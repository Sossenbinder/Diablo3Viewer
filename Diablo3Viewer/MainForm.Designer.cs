using System.Collections.Generic;
namespace Diablo3Viewer
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.FormTabs = new System.Windows.Forms.TabControl();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.battletagLabel = new System.Windows.Forms.Label();
            this.battletagTextBox = new System.Windows.Forms.TextBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.regionBox = new System.Windows.Forms.ComboBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormTabs
            // 
            this.FormTabs.Location = new System.Drawing.Point(0, 0);
            this.FormTabs.Name = "FormTabs";
            this.FormTabs.SelectedIndex = 0;
            this.FormTabs.Size = new System.Drawing.Size(536, 598);
            this.FormTabs.TabIndex = 0;
            this.FormTabs.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(38, 602);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(0, 605);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // battletagLabel
            // 
            this.battletagLabel.AutoSize = true;
            this.battletagLabel.Location = new System.Drawing.Point(140, 605);
            this.battletagLabel.Name = "battletagLabel";
            this.battletagLabel.Size = new System.Drawing.Size(52, 13);
            this.battletagLabel.TabIndex = 3;
            this.battletagLabel.Text = "Battletag:";
            // 
            // battletagTextBox
            // 
            this.battletagTextBox.Location = new System.Drawing.Point(194, 602);
            this.battletagTextBox.Name = "battletagTextBox";
            this.battletagTextBox.Size = new System.Drawing.Size(100, 20);
            this.battletagTextBox.TabIndex = 4;
            this.battletagTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.battletagTextBox_KeyPress);
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(296, 605);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(44, 13);
            this.regionLabel.TabIndex = 5;
            this.regionLabel.Text = "Region:";
            // 
            // regionBox
            // 
            this.regionBox.FormattingEnabled = true;
            this.regionBox.Location = new System.Drawing.Point(342, 601);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(57, 21);
            this.regionBox.TabIndex = 6;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(408, 599);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(121, 28);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 629);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.regionBox);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.battletagTextBox);
            this.Controls.Add(this.battletagLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.FormTabs);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl FormTabs;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label battletagLabel;
        private System.Windows.Forms.TextBox battletagTextBox;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.ComboBox regionBox;
        private System.Windows.Forms.Button loginButton;
    }
}

