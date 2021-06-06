#region Namespaces

using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using CrosshairPlus.Models;

#endregion

namespace CrosshairPlus.ControlPanels
{
    public partial class ProcessInformationPanel : UserControl
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ProcessInformationPanel" /> class.
        /// </summary>
        public ProcessInformationPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Loads the process information.
        /// </summary>
        /// <param name="processItem">The process item.</param>
        public void LoadProcessInformation(ProcessItem processItem)
        {
            if (processItem != null)
                try
                {
                    if (string.IsNullOrEmpty(processItem.Location))
                        B_Open.Enabled = false;
                    else
                        B_Open.Enabled = true;

                    TBPath.Text = processItem.Location;
                    TBPID.Text = processItem.ProcessId;
                    TBProcessName.Text = processItem.ProcessName;
                    TBWindowTitle.Text = processItem.WindowTitle;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
        }

        /// <summary>
        ///     Handles the Click event of the B_Open control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void B_Open_Click(object sender, EventArgs e)
        {
            var pathText = TBPath.Text;

            if (!string.IsNullOrEmpty(pathText) && File.Exists(pathText))
                Process.Start("explorer.exe", "/select, " + pathText);
            else
                Console.WriteLine(@"File does not exist.");
        }
    }
}