
namespace DanceSchool
{
    partial class SchoolMain
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
            this.coachButton = new System.Windows.Forms.Button();
            this.TeamButton = new System.Windows.Forms.Button();
            this.subscriptionButton = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coachButton
            // 
            this.coachButton.BackColor = System.Drawing.Color.Silver;
            this.coachButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.coachButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.coachButton.Location = new System.Drawing.Point(27, 91);
            this.coachButton.Name = "coachButton";
            this.coachButton.Size = new System.Drawing.Size(200, 70);
            this.coachButton.TabIndex = 3;
            this.coachButton.Text = "Coach";
            this.coachButton.UseVisualStyleBackColor = false;
            this.coachButton.Click += new System.EventHandler(this.coachButton_Click);
            // 
            // TeamButton
            // 
            this.TeamButton.BackColor = System.Drawing.Color.Silver;
            this.TeamButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.TeamButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TeamButton.Location = new System.Drawing.Point(27, 167);
            this.TeamButton.Name = "TeamButton";
            this.TeamButton.Size = new System.Drawing.Size(200, 70);
            this.TeamButton.TabIndex = 4;
            this.TeamButton.Text = "Team";
            this.TeamButton.UseVisualStyleBackColor = false;
            this.TeamButton.Click += new System.EventHandler(this.TeamButton_Click);
            // 
            // subscriptionButton
            // 
            this.subscriptionButton.BackColor = System.Drawing.Color.Silver;
            this.subscriptionButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.subscriptionButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subscriptionButton.Location = new System.Drawing.Point(27, 319);
            this.subscriptionButton.Name = "subscriptionButton";
            this.subscriptionButton.Size = new System.Drawing.Size(200, 70);
            this.subscriptionButton.TabIndex = 6;
            this.subscriptionButton.Text = "Subscription";
            this.subscriptionButton.UseVisualStyleBackColor = false;
            this.subscriptionButton.Click += new System.EventHandler(this.subscriptionButton_Click);
            // 
            // scheduleButton
            // 
            this.scheduleButton.BackColor = System.Drawing.Color.Silver;
            this.scheduleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.scheduleButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scheduleButton.Location = new System.Drawing.Point(27, 243);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(200, 70);
            this.scheduleButton.TabIndex = 7;
            this.scheduleButton.Text = "Schedule";
            this.scheduleButton.UseVisualStyleBackColor = false;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DanceSchool.Properties.Resources._1614529503_193_p_golova_na_belom_fone_237;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(166, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(606, -163);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 20);
            this.nameLabel.TabIndex = 9;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(27, 25);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(78, 32);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.scheduleButton);
            this.panel1.Controls.Add(this.coachButton);
            this.panel1.Controls.Add(this.subscriptionButton);
            this.panel1.Controls.Add(this.TeamButton);
            this.panel1.Location = new System.Drawing.Point(575, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 507);
            this.panel1.TabIndex = 11;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Silver;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.backButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 44);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SchoolMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DanceSchool.Properties.Resources.photo_2019_11_15_13_32_40;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 530);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameLabel);
            this.Name = "SchoolMain";
            this.Text = "Creativity";
            this.Load += new System.EventHandler(this.SchoolMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button coachButton;
        private System.Windows.Forms.Button TeamButton;
        private System.Windows.Forms.Button subscriptionButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
    }
}