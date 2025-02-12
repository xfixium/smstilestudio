﻿// 
// SMS Tile Studio
// Copyright (C) 2022 xfixium | xfixium@yahoo.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using SMSTileStudio.Data;

namespace SMSTileStudio.Controls
{
    public partial class PaletteTilemapControl : UserControl
    {
        /// <summary>
        /// Events
        /// </summary>
        public event ColorShiftedHandler ColorShifted;
        public delegate void ColorShiftedHandler();
        public event SelectedColorChangedHandler SelectedColorChanged;
        public delegate void SelectedColorChangedHandler();

        /// <summary>
        /// Fields
        /// </summary>
        private int _index = 0;
        private bool _initialized = false;
        private bool _bgPaletteSelected = true;
        private ColorControl _selected = null;

        /// <summary>
        /// Properties
        /// </summary>
        public List<Color> BGPalette { get; private set; } = new List<Color>();
        public List<Color> SPRPalette { get; private set; } = new List<Color>();
        public List<Color> BGImport { get; private set; } = new List<Color>();
        public List<Color> SPRImport { get; private set; } = new List<Color>();

        /// <summary>
        /// Constructors
        /// </summary>
        public PaletteTilemapControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Menu item click
        /// </summary>
        private void mnuMain_Click(object sender, EventArgs e)
        {
            if (_selected == null || !(sender is ToolStripMenuItem menuItem))
                return;

            if (menuItem == mnuRemoveColor)
            {
                if (_bgPaletteSelected)
                    BGImport[_index] = Color.Transparent;
                else
                    SPRImport[_index] = Color.Transparent;
            }
            else if (menuItem == mnuMoveColor)
            {
                int index = GetAvailableIndex(_bgPaletteSelected);
                if (index == -1)
                {
                    MessageBox.Show("There are no available slots to move the color to.");
                    return;
                }

                Color color = _bgPaletteSelected ? BGImport[_index] : SPRImport[_index];
                if (_bgPaletteSelected)
                {
                    BGImport[_index] = Color.Transparent;
                    SPRImport[index] = color;
                }
                else
                {
                    SPRImport[_index] = Color.Transparent;
                    BGImport[index] = color;
                }
            }
            else if (menuItem == mnuCopyColor)
            {
                int index = GetAvailableIndex(_bgPaletteSelected);
                if (index == -1)
                {
                    MessageBox.Show("There are no available slots to copy the color to.");
                    return;
                }

                Color color = _bgPaletteSelected ? BGImport[_index] : SPRImport[_index];
                if (_bgPaletteSelected)
                    SPRImport[index] = color;
                else
                    BGImport[index] = color;
            }

            pnlColor_Click(null, GetEmptyMouseEvent());
            UpdateUI();
            ColorShifted?.Invoke();
        }

        /// <summary>
        /// Shift button click
        /// </summary>
        private void btnShift_Click(object sender, EventArgs e)
        {
            if (_selected == null || !(sender is Button button))
                return;

            int shift = 0;
            if (button == btnBgLeft && _index > 0)
                shift = -1;
            else if (button == btnBgRight && _index < 15)
                shift = 1;
            else if (button == btnSprLeft && _index > 0)
                shift = -1;
            else if (button == btnSprRight && _index < 15)
                shift = 1;

            if (shift == 0)
                return;

            int source = _index;
            Color sourceColor = _bgPaletteSelected ? BGImport[_index] : SPRImport[_index];
            _index += shift;
            Color targetColor = _bgPaletteSelected ? BGImport[_index] : SPRImport[_index];

            if (_bgPaletteSelected)
            {
                BGImport[source] = targetColor;
                BGImport[_index] = sourceColor;
            }
            else
            {
                SPRImport[source] = targetColor;
                SPRImport[_index] = sourceColor;
            }

            pnlColor_Click(Controls.Find("pnlColor" + (_bgPaletteSelected ? _index : _index + 32), true)[0], GetEmptyMouseEvent());
            UpdateUI();
            ColorShifted?.Invoke();
        }

        /// <summary>
        /// Color click
        /// </summary>
        private void pnlColor_Click(object sender, MouseEventArgs e)
        {
            if (_selected != null)
                _selected.Selected = false;

            if (sender == null)
            {
                _selected = null;
                _index = 0;
                return;
            }

            _selected = sender as ColorControl;
            _selected.Selected = true;
            _bgPaletteSelected = _selected.Parent == pnlBgImportPalette;
            _index = _selected.Index;
            SelectedColorChanged?.Invoke();

            if (_selected != null && e.Button == MouseButtons.Right)
                mnuMain.Show(Cursor.Position);
        }

        /// <summary>
        /// Sets the palette control's color palette
        /// </summary>
        /// <param name="import">The imported colors to match against a palette</param>
        /// <param name="bgPalette">The background palette</param>
        /// <param name="sprPalette">The sprite palette</param>
        public void SetPalette(List<Color> import, List<Color> bgPalette, List<Color> sprPalette)
        {
            //List<Color> sprImport = new List<Color>();
            //if (import.Count > 16)
            //    sprImport.AddRange(import.GetRange(16, import.Count - 16));

            //BGImport = Match(new List<Color>(import.GetRange(0, import.Count > 16 ? 16 : import.Count).ToArray()), bgPalette);
            //SPRImport = Match(new List<Color>((sprImport.Count > 0 ? sprImport : import).ToArray()), sprPalette);

            MatchColors(import, bgPalette, sprPalette);
            BGPalette = new List<Color>(bgPalette.ToArray());
            SPRPalette = new List<Color>(sprPalette.ToArray());

            if (_selected != null)
            {
                _selected.Selected = false;
                _selected = null;
            }

            _initialized = true;
            UpdateUI();
        }

        /// <summary>
        /// Updates UI
        /// </summary>
        private void UpdateUI()
        {
            if (!_initialized)
                return;

            for (int i = 0; i < 16; i++)
                SetColorPanel(i, BGImport[i]);

            for (int j = 0; j < 16; j++)
                SetColorPanel(j + 16, BGPalette[j]);

            for (int k = 0; k < 16; k++)
                SetColorPanel(k + 32, SPRImport[k]);

            for (int l = 0; l < 16; l++)
                SetColorPanel(l + 48, SPRPalette[l]);
        }

        /// <summary>
        /// Matches import colors to palettes
        /// </summary>
        /// <param name="import">Import colors to match</param>
        /// <returns>A list of rearranged colors</returns>
        private void MatchColors(List<Color> import, List<Color> bgPalette, List<Color> sprPalette)
        {
            List<Color> bgMatches = new List<Color>();
            for (int i = 0; i < 16; i++)
                bgMatches.Add(Color.Transparent);

            List<Color> sprMatches = new List<Color>();
            for (int i = 0; i < 16; i++)
                sprMatches.Add(Color.Transparent);

            foreach (Color color in import)
            {
                for (int i = 0; i < bgPalette.Count; i++)
                {
                    if (bgPalette[i].ToArgb() == color.ToArgb())
                    {
                        bgMatches[i] = color;
                        break;
                    }
                }
            }

            foreach (Color color in import)
            {
                for (int i = 0; i < sprPalette.Count; i++)
                {
                    if (sprPalette[i].ToArgb() == color.ToArgb())
                    {
                        sprMatches[i] = color;
                        break;
                    }
                }
            }

            List<Color> unmatched = new List<Color>();
            foreach (Color color in import)
            {
                if (!unmatched.Contains(color) &&
                    bgMatches.Find(x => x.ToArgb() == color.ToArgb()) == Color.Empty && 
                    sprMatches.Find(x => x.ToArgb() == color.ToArgb()) == Color.Empty)
                    unmatched.Add(color);
            }

            foreach (Color color in unmatched)
            {
                for (int i = 0; i < 16; i++)
                {
                    if (bgMatches[i] == Color.Transparent)
                    {
                        bgMatches[i] = color;
                        break;
                    }
                    else if (sprMatches[i] == Color.Transparent)
                    {
                        sprMatches[i] = color;
                        break;
                    }
                }
            }

            BGImport = bgMatches;
            SPRImport = sprMatches;
        }

        /// <summary>
        /// Gets any open color index for the given palette
        /// </summary>
        /// <returns>Color index</returns>
        private int GetAvailableIndex(bool bgPalette)
        {
            for (int i = 0; i < (bgPalette ? SPRImport : BGImport).Count; i++)
                if ((bgPalette ? SPRImport : BGImport)[i].ToArgb() == Color.Transparent.ToArgb())
                    return i;

            return -1;
        }

        /// <summary>
        /// Sets the indexed color panel's color
        /// </summary>
        /// <param name="index">The color panel index</param>
        /// <param name="color">The backcolor to set</param>
        private void SetColorPanel(int index, Color color)
        {
            Control panel = (Controls.Find("pnlColor" + index, true)[0] as Panel);
            panel.BackColor = color;
            ttMain.SetToolTip(panel, panel.BackColor == Color.Transparent ? "" : GetTooltip(panel.BackColor));
        }

        /// <summary>
        /// Gets color tooltip
        /// </summary>
        /// <param name="col">The color to get string of</param>
        /// <returns>A color string</returns>
        private string GetTooltip(Color col)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("RGB: " + col.R + ", " + col.G + ", " + col.B);
            sb.AppendLine("RGB Hex: $" + col.R.ToString("X2") + col.G.ToString("X2") + col.B.ToString("X2"));
            //sb.AppendLine("SMS Hex: $" + Palette.GetColor(col).ToString("X2"));
            return sb.ToString();
        }

        /// <summary>
        /// Gets empty mouse event arguments
        /// </summary>
        /// <returns>Empty mouse event arguments</returns>
        private MouseEventArgs GetEmptyMouseEvent()
        {
            return new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0);
        }
    }
}
