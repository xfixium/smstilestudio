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
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using SMSTileStudio.Data;

namespace SMSTileStudio.Controls
{
    public partial class PaletteControl : UserControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        public event SelectedColorChangedHandler SelectedColorChanged;
        public delegate void SelectedColorChangedHandler();
        private ColorControl _selected = null;
        private bool _readOnly = false;

        /// <summary>
        /// Properties
        /// </summary>
        public List<Color> Colors
        {
            get
            {
                List<Color> colors = new List<Color>();
                for (int i = 0; i < 16; i++)
                    colors.Add((Controls.Find("pnlColor" + i, true)[0] as Control).BackColor);

                return colors;
            }
        }
        public int SelectedIndex { get { return _selected == null ? -1 : _selected.Index; } }
        public Color SelectedColor { get { return _selected == null ? Color.White : _selected.BackColor; } }
        public bool ReadOnly { get { return _readOnly; } set { _readOnly = value; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public PaletteControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Color click
        /// </summary>
        private void pnlColor_Click(object sender, EventArgs e)
        {
            if (_readOnly)
                return;

            if (_selected != null)
                _selected.Selected = false;

            _selected = sender as ColorControl;
            _selected.Selected = true;
            SelectedColorChanged?.Invoke();
        }

        /// <summary>
        /// Select a color control by index
        /// </summary>
        /// <param name="index">Color index to select</param>
        public void SelectColor(int index)
        {
            foreach (var color in tpnlMain.Controls.OfType<ColorControl>())
                if (color.Index == index)
                    _selected = color;

            _selected.Selected = true;
        }

        /// <summary>
        /// Sets the palette control's color palette
        /// </summary>
        /// <param name="palette"></param>
        public void SetPalette(List<Color> palette)
        {
            if (_selected != null)
            {
                _selected.Selected = false;
                _selected = null;
            }

            if (palette == null)
            {
                palette = new List<Color>();
                for (int i = 0; i < 16; i++)
                    palette.Add(Color.Black);
            }

            if (palette.Count < 16)
                for (int i = palette.Count - 1; i < 16; i++)
                    palette.Add(Color.Black);

            for (int i = 0; i < 16; i++)
            {
                Control ctrl = (Controls.Find("pnlColor" + i, true)[0] as Panel);
                ctrl.BackColor = palette[i];
                ttMain.SetToolTip(ctrl, GetTooltip(ctrl.BackColor));
            }
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
    }
}
