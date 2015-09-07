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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.battletagLabel = new System.Windows.Forms.Label();
            this.battletagTextBox = new System.Windows.Forms.TextBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.regionBox = new System.Windows.Forms.ComboBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.FormTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTabs
            // 
            this.FormTabs.Controls.Add(this.tabPage1);
            this.FormTabs.Controls.Add(this.tabPage2);
            this.FormTabs.Location = new System.Drawing.Point(0, 0);
            this.FormTabs.Name = "FormTabs";
            this.FormTabs.SelectedIndex = 0;
            this.FormTabs.Size = new System.Drawing.Size(567, 598);
            this.FormTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(42, 602);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(4, 605);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // battletagLabel
            // 
            this.battletagLabel.AutoSize = true;
            this.battletagLabel.Location = new System.Drawing.Point(148, 605);
            this.battletagLabel.Name = "battletagLabel";
            this.battletagLabel.Size = new System.Drawing.Size(52, 13);
            this.battletagLabel.TabIndex = 3;
            this.battletagLabel.Text = "Battletag:";
            // 
            // battletagTextBox
            // 
            this.battletagTextBox.Location = new System.Drawing.Point(206, 602);
            this.battletagTextBox.Name = "battletagTextBox";
            this.battletagTextBox.Size = new System.Drawing.Size(100, 20);
            this.battletagTextBox.TabIndex = 4;
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(312, 605);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(44, 13);
            this.regionLabel.TabIndex = 5;
            this.regionLabel.Text = "Region:";
            // 
            // regionBox
            // 
            this.regionBox.FormattingEnabled = true;
            this.regionBox.Location = new System.Drawing.Point(362, 601);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(57, 21);
            this.regionBox.TabIndex = 6;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(439, 599);
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
            this.ClientSize = new System.Drawing.Size(564, 629);
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
            this.FormTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl FormTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label battletagLabel;
        private System.Windows.Forms.TextBox battletagTextBox;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.ComboBox regionBox;
        private System.Windows.Forms.Button loginButton;
    }
}

