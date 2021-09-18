
namespace DanceSchool
{
    partial class User
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.aboutLable = new System.Windows.Forms.Label();
            this.LoginLable = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.surnameBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.surnameLabel);
            this.panel1.Controls.Add(this.loginBox);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.aboutLable);
            this.panel1.Controls.Add(this.LoginLable);
            this.panel1.Controls.Add(this.changeButton);
            this.panel1.Location = new System.Drawing.Point(537, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 511);
            this.panel1.TabIndex = 11;
            // 
            // surnameBox
            // 
            this.surnameBox.BackColor = System.Drawing.Color.Silver;
            this.surnameBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnameBox.Location = new System.Drawing.Point(175, 154);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(199, 28);
            this.surnameBox.TabIndex = 18;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Silver;
            this.nameBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(175, 89);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(199, 28);
            this.nameBox.TabIndex = 19;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Silver;
            this.richTextBox1.Location = new System.Drawing.Point(175, 216);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(199, 193);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnameLabel.Location = new System.Drawing.Point(28, 154);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(113, 32);
            this.surnameLabel.TabIndex = 9;
            this.surnameLabel.Text = "Surname";
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.Silver;
            this.loginBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBox.Location = new System.Drawing.Point(175, 30);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(199, 28);
            this.loginBox.TabIndex = 17;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(28, 89);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(79, 32);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // aboutLable
            // 
            this.aboutLable.AutoSize = true;
            this.aboutLable.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutLable.Location = new System.Drawing.Point(28, 216);
            this.aboutLable.Name = "aboutLable";
            this.aboutLable.Size = new System.Drawing.Size(83, 32);
            this.aboutLable.TabIndex = 5;
            this.aboutLable.Text = "About";
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
            this.LoginLable.Click += new System.EventHandler(this.LoginLable_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Silver;
            this.changeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.changeButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeButton.Location = new System.Drawing.Point(28, 431);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(346, 55);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Silver;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.backButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(28, 26);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 44);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DanceSchool.Properties.Resources.photo_2019_11_15_13_32_40;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 568);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel1);
            this.Name = "User";
            this.Text = "Creativity";
            this.Load += new System.EventHandler(this.User_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label aboutLable;
        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox nameBox;
    }
}