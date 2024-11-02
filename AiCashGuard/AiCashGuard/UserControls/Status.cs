using System;
using System.Drawing;
using System.Windows.Forms;

namespace AiCashGuard.UserControls
{
    public class Status
    {
        private Panel statusPanel;
        private Label statusLabel;

        public Status(Panel panel, Label label)
        {
            statusPanel = panel;
            statusLabel = label;
        }

        public void AttachToPictureBox(PictureBox pictureBox)
        {
            pictureBox.Click += OnQrCodeClick; 
        }

        private void OnQrCodeClick(object sender, EventArgs e)
        {
            bool isScanSuccessful = PromptForStatus();

            if (isScanSuccessful)
            {
                statusPanel.BackColor = Color.LightGreen;
                statusLabel.Text = "Scan Successful";
            }
            else
            {
                statusPanel.BackColor = Color.Red;
                statusLabel.Text = "Scan Failed"; 
            }

            CenterLabelInPanel(statusLabel, statusPanel); // Ensure to call the correct centering method
        }

        private bool PromptForStatus()
        {
            Random random = new Random();
            return random.Next(2) == 0; 
        }

        private void CenterLabelInPanel(Label label, Panel panel)
        {
            label.TextAlign = ContentAlignment.BottomCenter;
            label.AutoSize = true; 
            label.Location = new Point((panel.Width - label.Width) / 2, panel.Height - label.Height - 10); 
        }

      

    }
}
