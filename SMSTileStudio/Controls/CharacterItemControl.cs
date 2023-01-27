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
using System.Drawing;
using System.Windows.Forms;
using SMSTileStudio.Data;

namespace SMSTileStudio.Controls
{
    public partial class CharacterItemControl : UserControl
    {
        /// <summary>
        /// Events
        /// </summary>
        public event CharacterChangedHandler CharacterChanged;
        public delegate void CharacterChangedHandler(CharacterItemControl sender);
        public event CharacterMoveUpHandler CharacterMoveUp;
        public delegate void CharacterMoveUpHandler(CharacterItemControl sender);
        public event CharacterMoveDownHandler CharacterMoveDown;
        public delegate void CharacterMoveDownHandler(CharacterItemControl sender);
        public event CharacterInsertHandler CharacterInsert;
        public delegate void CharacterInsertHandler(CharacterItemControl sender);
        public event CharacterRemoveHandler CharacterRemove;
        public delegate void CharacterRemoveHandler(CharacterItemControl sender);

        /// <summary>
        /// Properties
        /// </summary>
        public CharacterSet CharacterSet { get; set; }
        public char Character { get { return txtCharacter.Text.Length <= 0 ? ' ' : txtCharacter.Text[0]; } set { CharacterSet.Character = value; txtCharacter.Text = value.ToString(); } }
        public byte TileID { get { return (byte)nudTileID.Value; } set { CharacterSet.TileID = value; nudTileID.Value = value; } }
        public bool Selected { get { return chkSelected.Checked; } }
        public int Index { get; set; }

        /// <summary>
        /// Constructors
        /// </summary>
        public CharacterItemControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hook wheel scroll event
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            nudTileID.MouseWheel += NudIndex_MouseWheel;
        }

        /// <summary>
        /// Disable wheel scrolling
        /// </summary>
        private void NudIndex_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        /// <summary>
        /// Menu option click
        /// </summary>
        private void mnuCharacterMap_Click(object sender, EventArgs e)
        {
            if (!(sender is ToolStripMenuItem menuItem))
                return;

            if (menuItem == mnuMoveUp)
                CharacterMoveUp?.Invoke(this);
            else if (menuItem == mnuMoveDown)
                CharacterMoveDown?.Invoke(this);
            else if (menuItem == mnuInsert)
                CharacterInsert?.Invoke(this);
            else if (menuItem == mnuRemove)
                CharacterRemove?.Invoke(this);
        }

        /// <summary>
        /// Button click
        /// </summary>
        private void btnCharacterMap_Click(object sender, EventArgs e)
        {
            // If data not loaded, if button is not sender, return
            if (!(sender is Button button))
                return;

            if (button == btnOptions)
            {
                mnuOptions.Show(btnOptions, new Point(0, btnOptions.Height));
                return;
            }
        }

        /// <summary>
        /// Character changed
        /// </summary>
        private void txtCharacter_TextChanged(object sender, EventArgs e)
        {
            CharacterChanged?.Invoke(this);
        }

        /// <summary>
        /// Tile Index changed
        /// </summary>
        private void nudIndex_ValueChanged(object sender, EventArgs e)
        {
            CharacterChanged?.Invoke(this);
        }

        /// <summary>
        /// Set control focus
        /// </summary>
        public void SetFocus()
        {
            txtCharacter.Focus();
        }
    }
}
