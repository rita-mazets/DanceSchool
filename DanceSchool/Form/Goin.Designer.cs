
namespace DanceSchool
{
    partial class Goin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.AdminButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.LoginLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordLable = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.Silver;
            this.loginBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBox.Location = new System.Drawing.Point(175, 35);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(161, 28);
            this.loginBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.Silver;
            this.passwordBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordBox.Location = new System.Drawing.Point(175, 99);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(161, 28);
            this.passwordBox.TabIndex = 1;
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.Silver;
            this.AdminButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AdminButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminButton.Location = new System.Drawing.Point(90, 166);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(183, 55);
            this.AdminButton.TabIndex = 2;
            this.AdminButton.Text = "Go in";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.loginLabel.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(538, 316);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(0, 32);
            this.loginLabel.TabIndex = 3;
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginLable.Location = new System.Drawing.Point(28, 30);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(77, 32);
            this.LoginLable.TabIndex = 4;
            this.LoginLable.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.passwordLable);
            this.panel1.Controls.Add(this.loginBox);
            this.panel1.Controls.Add(this.LoginLable);
            this.panel1.Controls.Add(this.AdminButton);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Location = new System.Drawing.Point(396, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 247);
            this.panel1.TabIndex = 5;
            // 
            // passwordLable
            // 
            this.passwordLable.AutoSize = true;
            this.passwordLable.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLable.Location = new System.Drawing.Point(28, 95);
            this.passwordLable.Name = "passwordLable";
            this.passwordLable.Size = new System.Drawing.Size(118, 32);
            this.passwordLable.TabIndex = 5;
            this.passwordLable.Text = "Password";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Silver;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.backButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(27, 24);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 44);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Goin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DanceSchool.Properties.Resources.photo_2019_11_15_13_32_40;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginLabel);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Goin";
            this.Text = "Creativity";
            this.Load += new System.EventHandler(this.Goin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label passwordLable;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox passwordBox;
    }
}