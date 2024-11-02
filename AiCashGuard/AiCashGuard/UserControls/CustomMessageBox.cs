using System;
using System.Windows.Forms;

namespace AiCashGuard.UserControls
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }
        public CustomMessageBox(string popupType, string message, string popupTitle, string btnText, bool showCancelButton)
        {
            InitializeComponent();
            textMessage.Text = message;
            SetPopupIcon(popupType);
            title.Text = popupTitle;
            Btn_Text.Text = btnText;
            Cancel_Panel.Visible = showCancelButton; // Hide or show Cancel based on need
        }

        public static DialogResult Show(string popupType, string message, string title, string btnText, bool showCancelButton = true)
        {
            using (CustomMessageBox customMessageBox = new CustomMessageBox(popupType, message, title, btnText, showCancelButton))
            {
                return customMessageBox.ShowDialog(); // Show as modal dialog
            }
        }

        private void Btn_Text_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SetPopupIcon(string iconType)
        {
            switch (iconType)
            {
                case "Success":
                    this.popupIcon.Image = Properties.Resources.success;
                    this.popupIcon.InitialImage = Properties.Resources.success;
                    break;
                case "Error":
                    this.popupIcon.Image = Properties.Resources.Error;
                    this.popupIcon.InitialImage = Properties.Resources.Error;
                    break;
                case "Question":
                    this.popupIcon.Image = Properties.Resources.Info;
                    this.popupIcon.InitialImage = Properties.Resources.Info;
                    break;
                default:
                    this.popupIcon.Image = Properties.Resources.Info;
                    this.popupIcon.InitialImage = Properties.Resources.Info;
                    break;
            }
        }
    }
}
