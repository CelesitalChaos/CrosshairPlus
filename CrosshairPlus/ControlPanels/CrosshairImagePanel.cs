#region Namespaces

using System;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace CrosshairPlus.ControlPanels
{
    public partial class CrosshairImagePanel : UserControl
    {
        public CrosshairImagePanel()
        {
            InitializeComponent();
        }

        private void B_Open_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = @"Open Crosshair Image",
                Filter = @"Image Files|*.png;*.gif"
            };

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                TB_Path.Text = openFileDialog.FileName;
                PB_CrosshairImage.Image = Image.FromFile(TB_Path.Text);

                // Load image size
                NUD_Height.Value = PB_CrosshairImage.Image.Height;
                NUD_Width.Value = PB_CrosshairImage.Image.Width;
            }
        }
    }
}