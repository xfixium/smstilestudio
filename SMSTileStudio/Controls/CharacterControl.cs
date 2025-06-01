// 
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
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using SMSTileStudio.Data;
using System.Runtime.InteropServices;

namespace SMSTileStudio.Controls
{
    public partial class CharacterControl : UserControl
    {
        /// <summary>
        /// Events
        /// </summary>
        public event CharacterMapChangedHandler CharacterMapChanged;
        public delegate void CharacterMapChangedHandler(List<CharacterSet> characterMap);

        /// <summary>
        /// Fields
        /// </summary>
        private List<CharacterSet> _characterMap = new List<CharacterSet>();

        /// <summary>
        /// Properties
        /// </summary>
        public List<CharacterSet> CharacterMap { get { return _characterMap; } set { _characterMap = value; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public CharacterControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Character changed
        /// </summary>
        private void Ctrl_CharacterChanged(CharacterItemControl sender)
        {
            if (_characterMap == null || _characterMap.Count == 0 || sender.Index >= _characterMap.Count)
                return;

            _characterMap[sender.Index] = new CharacterSet(sender.Character, sender.TileID);
            CharacterMapChanged?.Invoke(_characterMap.DeepClone());
        }

        /// <summary>
        /// Character move up
        /// </summary>
        private void Ctrl_CharacterMoveUp(CharacterItemControl sender)
        {
            var index = sender.Index;
            if (index - 1 < 0)
                return;

            var charset = _characterMap[index].DeepClone();
            _characterMap.RemoveAt(index);
            _characterMap.Insert(index - 1, charset);
            LoadData(_characterMap);
            SetItemFocus(index - 1);
            CharacterMapChanged?.Invoke(_characterMap.DeepClone());
        }

        /// <summary>
        /// Character move down
        /// </summary>
        private void Ctrl_CharacterMoveDown(CharacterItemControl sender)
        {
            var index = sender.Index;
            if (index + 1 >= _characterMap.Count)
                return;

            var charset = _characterMap[index].DeepClone();
            _characterMap.RemoveAt(index);
            _characterMap.Insert(index + 1, charset);
            LoadData(_characterMap);
            SetItemFocus(index + 1);
            CharacterMapChanged?.Invoke(_characterMap.DeepClone());
        }

        /// <summary>
        /// Character insert
        /// </summary>
        private void Ctrl_CharacterInsert(CharacterItemControl sender)
        {
            var index = sender.Index + 1;
            var charset = new CharacterSet('0', (byte)(sender.TileID + 1));
            _characterMap.Insert(sender.Index + 1, charset);
            LoadData(_characterMap);
            SetItemFocus(index);
            CharacterMapChanged?.Invoke(_characterMap.DeepClone());
        }

        /// <summary>
        /// Character remove
        /// </summary>
        private void Ctrl_CharacterRemove(CharacterItemControl sender)
        {
            var index = sender.Index;
            _characterMap.RemoveAt(sender.Index);
            RemoveCharacterItemControl(sender as CharacterItemControl);
            IndexControls();
            SetItemFocus(index);
            CharacterMapChanged?.Invoke(_characterMap.DeepClone());
        }

        /// <summary>
        /// Indexes item controls
        /// </summary>
        private void IndexControls()
        {
            var index = _characterMap.Count - 1;
            foreach (var ctrl in Controls)
                (ctrl as CharacterItemControl).Index = index--;
        }

        /// <summary>
        /// Reindexes charset tile ids
        /// </summary>
        public void Reindex()
        {
            var index = 0;
            foreach (var charSet in _characterMap)
                charSet.TileID = (byte)index++;

            LoadData(_characterMap);
            CharacterMapChanged?.Invoke(_characterMap.DeepClone());
        }

        /// <summary>
        /// Removes selected charsets
        /// </summary>
        public void RemoveSelected()
        {
            foreach (var ctrl in Controls.OfType<CharacterItemControl>())
                if (ctrl.Selected)
                    _characterMap.RemoveAll(x => x.TileID == ctrl.TileID);

            LoadData(_characterMap);
            CharacterMapChanged?.Invoke(_characterMap.DeepClone());
        }

        /// <summary>
        /// Sets item focus based on index
        /// </summary>
        private void SetItemFocus(int index)
        {
            foreach (var ctrl in Controls.OfType<CharacterItemControl>())
            {
                if (ctrl.Index == index)
                {
                    ctrl.SetFocus();
                    break;
                }
            }
        }

        /// <summary>
        /// Creates a character item control
        /// </summary>
        /// <returns></returns>
        private CharacterItemControl CreateItemControl(CharacterSet character)
        {
            var ctrl = new CharacterItemControl();
            ctrl.Character = character.Character;
            ctrl.TileID = character.TileID;
            ctrl.Dock = DockStyle.Top;
            ctrl.CharacterChanged += Ctrl_CharacterChanged;
            ctrl.CharacterMoveUp += Ctrl_CharacterMoveUp;
            ctrl.CharacterMoveDown += Ctrl_CharacterMoveDown;
            ctrl.CharacterInsert += Ctrl_CharacterInsert;
            ctrl.CharacterRemove += Ctrl_CharacterRemove;
            return ctrl;
        }

        /// <summary>
        /// Loads given character map data to UI
        /// </summary>
        /// <param name="characterMap"></param>
        public void LoadData(List<CharacterSet> characterMap)
        {
            Hide();
            foreach (var ctrl in Controls)
                if (ctrl is CharacterItemControl)
                    RemoveCharacterItemControl(ctrl as CharacterItemControl);

            Controls.Clear();
            _characterMap = characterMap;
            for (int i = _characterMap.Count - 1; i > -1; i--)
            {
                try
                {
                    var ctrl = CreateItemControl(_characterMap[i]);
                    ctrl.Index = i;
                    Controls.Add(ctrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Show();
        }

        /// <summary>
        /// Disposes of character item control events
        /// </summary>
        /// <param name="ctrl">Character item control to dispose</param>
        private void RemoveCharacterItemControl(CharacterItemControl ctrl)
        {
            // Unhook events, and dispose
            ctrl.CharacterChanged -= Ctrl_CharacterChanged;
            ctrl.CharacterMoveUp -= Ctrl_CharacterMoveUp;
            ctrl.CharacterMoveDown -= Ctrl_CharacterMoveDown;
            ctrl.CharacterInsert -= Ctrl_CharacterInsert;
            ctrl.CharacterRemove -= Ctrl_CharacterRemove;
            ctrl.Dispose();
        }
    }
}
