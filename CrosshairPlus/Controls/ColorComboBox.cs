#region Namespaces

using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

#endregion

namespace CrosshairPlus.Controls
{
    /// <summary>
    ///     The Color ComboBox.
    /// </summary>
    public class ColorComboBox : ComboBox
    {
        /// <summary>
        ///     The Color ComboBox.
        /// </summary>
        public ColorComboBox()
        {
            DrawItem += ColorComboBox_DrawItem;
            ColorVisible = true;
            DrawMode = DrawMode.OwnerDrawVariable;
            DropDownStyle = ComboBoxStyle.DropDownList;

            RefreshColors();
        }


        /// <summary>
        ///     Gets or sets a value indicating whether [color visible].
        /// </summary>
        /// <value>
        ///     <c>true</c> if [color visible]; otherwise, <c>false</c>.
        /// </value>
        public bool ColorVisible { get; set; }


        /// <summary>
        ///     Draws overridden items.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void ColorComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            //Draw background of the item e.DrawBackground(); 
            if (e.Index != -1)
            {
                // selected item 
                var comboboxItem = ((ComboBox) sender).Items[e.Index].ToString();

                //Draw the image in combo box using its bound and ItemHeight 
                if (ColorVisible)
                {
                    var c = Color.FromName(comboboxItem ?? string.Empty);
                    Brush b = new SolidBrush(c);
                    e.Graphics.FillRectangle(b, e.Bounds.X, e.Bounds.Y, ItemHeight - 2, ItemHeight - 2);


                    // We need to draw the item as string because we made draw mode to owner variable
                    e.Graphics.DrawString(comboboxItem, Font, Brushes.Black,
                        new RectangleF(e.Bounds.X + ItemHeight, e.Bounds.Y, DropDownWidth, ItemHeight));
                }
                else
                {
                    e.Graphics.DrawString(comboboxItem, Font, Brushes.Black,
                        new RectangleF(e.Bounds.X, e.Bounds.Y, DropDownWidth, ItemHeight));
                }
            }

            //draw rectangle over the item selected 
            e.DrawFocusRectangle();
        }

        /// <summary>
        ///     Refreshes the colors.
        /// </summary>
        public void RefreshColors()
        {
            Items.Clear();

            try
            {
                var colorType = typeof(Color);
                var propInfoList = colorType.GetProperties(BindingFlags.Static |
                                                           BindingFlags.DeclaredOnly | BindingFlags.Public);
                foreach (var c in propInfoList) Items.Add(c.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if (Items.Count > 0) SelectedIndex = 0;
        }
    }
}