#region Namespaces

using System;
using System.Windows.Forms;
using CrosshairPlus.Models;

#endregion

namespace CrosshairPlus.ControlPanels
{
    public partial class CrosshairOptionsPanel : UserControl
    {
        public CrosshairOptionsPanel()
        {
            InitializeComponent();

            // Add data to combo boxes
            CB_RenderModes.DataSource = Enum.GetValues(typeof(RenderMode));
            CB_Hotkey.DataSource = Enum.GetValues(typeof(Keys));

            // Default
            CB_Hotkey.Text = @"Ins";
        }

        private void CrosshairOptionsPanel_Load(object sender, EventArgs e)
        {
        }
    }
}