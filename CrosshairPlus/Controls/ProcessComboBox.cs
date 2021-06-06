#region Namespaces

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using CrosshairPlus.Models;

#endregion

namespace CrosshairPlus.Controls
{
    /// <summary>
    ///     The Process ComboBox.
    /// </summary>
    public class ProcessComboBox : ComboBox
    {
        /// <summary>
        ///     The Process ComboBox.
        /// </summary>
        public ProcessComboBox()
        {
            ProcessItems = new List<ProcessItem>();
            DrawItem += ProcessComboBox_DrawItem;
            ImagesVisible = true;
            DrawMode = DrawMode.OwnerDrawVariable;
            DropDownStyle = ComboBoxStyle.DropDownList;
            ImageListSmall = new ImageList {ImageSize = new Size(32, 32)};

            RefreshProcesses();
        }

        public ImageList ImageListSmall { get; }

        public Process SelectedProcess { get; private set; }

        public ProcessItem SelectedProcessItem => ProcessItems[SelectedIndex];

        public List<ProcessItem> ProcessItems { get; }

        public bool ImagesVisible { get; set; }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);

            if (SelectedIndex != 0) SelectedProcess = ProcessItems[SelectedIndex].Process;
        }

        /// <summary>
        ///     Draws overridden items.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void ProcessComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            //Draw background of the item e.DrawBackground(); 
            if (e.Index != -1)
            {
                // selected item 
                var comboboxItem = Items[e.Index];

                //Draw the image in combo box using its bound and ItemHeight 
                if (ImagesVisible)
                {
                    if (!ImageListSmall.Images.Empty)
                    {
                        var img = ImageListSmall.Images[e.Index.ToString()];
                        if (img != null) e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y, ItemHeight, ItemHeight);
                    }

                    // We need to draw the item as string because we made draw mode to owner variable
                    e.Graphics.DrawString(comboboxItem.ToString(), Font, Brushes.Black,
                        new RectangleF(e.Bounds.X + ItemHeight, e.Bounds.Y, DropDownWidth, ItemHeight));
                }
                else
                {
                    e.Graphics.DrawString(comboboxItem.ToString(), Font, Brushes.Black,
                        new RectangleF(e.Bounds.X, e.Bounds.Y, DropDownWidth, ItemHeight));
                }
            }

            //draw rectangle over the item selected 
            e.DrawFocusRectangle();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            RefreshProcesses();
        }

        /// <summary>
        ///     Refreshes the processes.
        /// </summary>
        public void RefreshProcesses()
        {
            Items.Clear();
            ImageListSmall.Images.Clear();
            ProcessItems.Clear();

            try
            {
                var index = 0;
                foreach (var process in Process.GetProcesses())
                {
                    if (string.IsNullOrEmpty(process.MainWindowTitle)) continue;

                    // Add process to list
                    var item = new ProcessItem(process);

                    Items.Add(item.Process.MainWindowTitle);
                    ProcessItems.Add(item);
                    ImageListSmall.Images.Add(index.ToString(), item.Icon);

                    index++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if (Items.Count > 0) SelectedIndex = 0;
        }
    }
}