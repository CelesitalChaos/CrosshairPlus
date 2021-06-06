#region Namespaces

using System.Windows.Forms;

#endregion

namespace CrosshairPlus.ControlPanels
{
    public partial class CrosshairInformationPanel : UserControl
    {
        public CrosshairInformationPanel()
        {
            InitializeComponent();

            // Default
            CCB_Center.Text = @"Red";
            CCB_Line.Text = @"Orange";
        }
    }
}