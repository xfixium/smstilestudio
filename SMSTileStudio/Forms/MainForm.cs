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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json;
using SMSTileStudio.Data;

namespace SMSTileStudio.Forms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Constructors
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open project button click
        /// </summary>
        private void mnuOpenProject_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog form = new OpenFileDialog())
                {
                    form.Filter = "SMS Tile Studio Project File (.tssms)|*.tssms";
                    form.Title = "Open Project";
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        App.Project = JsonConvert.DeserializeObject<Project>(File.ReadAllText(form.FileName));
                        if (App.Project.Palettes.Any(x => x.ID < -1))
                            App.Project.Palettes.RemoveRange(0, 2);

                        foreach (var tilemap in App.Project.Tilemaps)
                            if (tilemap.Tiles != null && tilemap.Tiles.Count > 0 && tilemap.FrameCount <= 0)
                                tilemap.Frames.Add(new TilemapFrame(tilemap.Columns, tilemap.Rows, tilemap.Tiles));

                        LoadData();
                        Text = "SMS Tile Studio - " + form.SafeFileName;
                    }
                }
            }
            catch
            {
                throw new Exception("There was an issue loading the project file. Please try again.");
            }
        }

        /// <summary>
        /// Save project menu click
        /// </summary>
        private void mnuSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog form = new SaveFileDialog())
                {
                    form.Filter = "SMS Tile Studio Project File (.tssms)|*.tssms";
                    form.Title = "Save Project";
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        App.Project.Version = Assembly.GetExecutingAssembly().GetName().Version;
                        File.WriteAllText(form.FileName, JsonConvert.SerializeObject(App.Project, Formatting.Indented));
                    }
                }
            }
            catch
            {
                throw new Exception("There was an issue saving the project file. Please try again.");
            }
        }

        /// <summary>
        /// Exit application button click
        /// </summary>
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// About button click
        /// </summary>
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            using (AboutForm dialog = new AboutForm())
            {
                dialog.ShowDialog();
            }
        }

        /// <summary>
        /// Load asset data
        /// </summary>
        private void LoadData()
        {
            pnlPalettes.LoadData(true);
            pnlTilemaps.LoadData(true);
            pnlMetaSprites.LoadData(true);
            pnlDialogs.LoadData(true);
            pnlDataEntries.LoadData(true);
            pnlEntities.LoadData(true);
        }

        /// <summary>
        /// Palettes changed
        /// </summary>
        private void pnlPalette_AssetsChanged()
        {
            pnlTilemaps.LoadData(false);
            pnlMetaSprites.LoadData(false);
        }
    }
}
