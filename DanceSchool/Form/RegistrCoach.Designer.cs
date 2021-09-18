
namespace DanceSchool
{
    partial class RegistrCoach
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
            this.backButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordBox1 = new System.Windows.Forms.TextBox();
            this.passwordLable = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.LoginLable = new System.Windows.Forms.Label();
            this.registrButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.aboutBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Silver;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.backButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(30, 21);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 44);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.aboutBox);
            this.panel1.Controls.Add(this.surnameBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.AboutLabel);
            this.panel1.Controls.Add(this.surnameLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.passwordBox1);
            this.panel1.Controls.Add(this.passwordLable);
            this.panel1.Controls.Add(this.loginBox);
            this.panel1.Controls.Add(this.LoginLable);
            this.panel1.Controls.Add(this.registrButton);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Location = new System.Drawing.Point(466, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 511);
            this.panel1.TabIndex = 9;
            // 
            // surnameBox
            // 
            this.surnameBox.BackColor = System.Drawing.Color.Silver;
            this.surnameBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnameBox.Location = new System.Drawing.Point(175, 284);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(161, 28);
            this.surnameBox.TabIndex = 12;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Silver;
            this.nameBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(175, 222);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(161, 28);
            this.nameBox.TabIndex = 11;
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AboutLabel.Location = new System.Drawing.Point(28, 335);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(83, 32);
            this.AboutLabel.TabIndex = 10;
            this.AboutLabel.Text = "About";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnameLabel.Location = new System.Drawing.Point(28, 279);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(113, 32);
            this.surnameLabel.TabIndex = 9;
            this.surnameLabel.Text = "Surname";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(28, 217);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(79, 32);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // passwordBox1
            // 
            this.passwordBox1.BackColor = System.Drawing.Color.Silver;
            this.passwordBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordBox1.Location = new System.Drawing.Point(175, 160);
            this.passwordBox1.Name = "passwordBox1";
            this.passwordBox1.PasswordChar = '*';
            this.passwordBox1.Size = new System.Drawing.Size(161, 28);
            this.passwordBox1.TabIndex = 6;
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
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.Silver;
            this.loginBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBox.Location = new System.Drawing.Point(175, 35);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(161, 28);
            this.loginBox.TabIndex = 0;
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
            // registrButton
            // 
            this.registrButton.BackColor = System.Drawing.Color.Silver;
            this.registrButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.registrButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrButton.Location = new System.Drawing.Point(88, 435);
            this.registrButton.Name = "registrButton";
            this.registrButton.Size = new System.Drawing.Size(183, 55);
            this.registrButton.TabIndex = 2;
            this.registrButton.Text = "Registration";
            this.registrButton.UseVisualStyleBackColor = false;
            this.registrButton.Click += new System.EventHandler(this.registrButton_Click);
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
            // aboutBox
            // 
            this.aboutBox.BackColor = System.Drawing.Color.Silver;
            this.aboutBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutBox.Location = new System.Drawing.Point(175, 340);
            this.aboutBox.Name = "aboutBox";
            this.aboutBox.Size = new System.Drawing.Size(161, 28);
            this.aboutBox.TabIndex = 13;
            // 
            // RegistrCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DanceSchool.Properties.Resources.photo_2019_11_15_13_32_40;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backButton);
            this.Name = "RegistrCoach";
            this.Text = "Creativity";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordBox1;
        private System.Windows.Forms.Label passwordLable;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Button registrButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox aboutBox;
    }
}