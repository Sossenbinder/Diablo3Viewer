using Diablo3Viewer.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diablo3Viewer
{
    public partial class MainForm : Form
    {
        MainFormController mainForm;

        public MainForm()
        {
            List<string> itemSource = new List<string> { "EU", "US", "KR", "TW" };
            InitializeComponent();

            this.regionBox.DataSource = itemSource;

            mainForm = new MainFormController(this.FormTabs);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            evalInput();
        }

        private void battletagTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                evalInput();
            }
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                evalInput();
            }
        }

        private void evalInput()
        {
            if (!this.nameTextBox.Text.Equals("") && !this.nameTextBox.Text.Equals(""))
            {
                ProfileData profile = new ProfileData();

                profile.name = this.nameTextBox.Text;
                profile.battleTag = this.battletagTextBox.Text;
                profile.region = this.regionBox.SelectedValue.ToString();
                Program.profile = profile;

                mainForm.validateProfile();
            }
            else
            {
                MessageBox.Show(
                    "Login data missing. Please fill all the required data fields.",
                    "Failed to login.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1
                );
            }
        }

    }
}
