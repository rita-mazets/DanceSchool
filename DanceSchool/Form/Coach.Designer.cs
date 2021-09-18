
namespace DanceSchool
{
    partial class Coach
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginLable = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.prevBox = new System.Windows.Forms.PictureBox();
            this.nextBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.aboutBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(246, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 344);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.BackColor = System.Drawing.Color.Transparent;
            this.LoginLable.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginLable.Location = new System.Drawing.Point(246, 81);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(53, 23);
            this.LoginLable.TabIndex = 5;
            this.LoginLable.Text = "Login";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(246, 29);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(79, 32);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // prevBox
            // 
            this.prevBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prevBox.BackColor = System.Drawing.Color.Transparent;
            this.prevBox.BackgroundImage = global::DanceSchool.Properties.Resources._5fd8aef713bcf;
            this.prevBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prevBox.Location = new System.Drawing.Point(246, 504);
            this.prevBox.Name = "prevBox";
            this.prevBox.Size = new System.Drawing.Size(44, 44);
            this.prevBox.TabIndex = 10;
            this.prevBox.TabStop = false;
            this.prevBox.Click += new System.EventHandler(this.prevBox_Click);
            // 
            // nextBox
            // 
            this.nextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextBox.BackColor = System.Drawing.Color.Transparent;
            this.nextBox.BackgroundImage = global::DanceSchool.Properties.Resources._5fd8aef713bcf_Rsi0y;
            this.nextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextBox.Location = new System.Drawing.Point(679, 504);
            this.nextBox.Name = "nextBox";
            this.nextBox.Size = new System.Drawing.Size(44, 44);
            this.nextBox.TabIndex = 11;
            this.nextBox.TabStop = false;
            this.nextBox.Click += new System.EventHandler(this.nextBox_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gainsboro;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.backButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(24, 24);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 44);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // aboutBox
            // 
            this.aboutBox.BackColor = System.Drawing.Color.Gainsboro;
            this.aboutBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutBox.Location = new System.Drawing.Point(24, 154);
            this.aboutBox.Name = "aboutBox";
            this.aboutBox.Size = new System.Drawing.Size(194, 344);
            this.aboutBox.TabIndex = 14;
            this.aboutBox.Text = "";
            // 
            // Coach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DanceSchool.Properties.Resources.cooking;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.aboutBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextBox);
            this.Controls.Add(this.prevBox);
            this.Controls.Add(this.LoginLable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nameLabel);
            this.DoubleBuffered = true;
            this.Name = "Coach";
            this.Text = "Coach";
            this.Load += new System.EventHandler(this.Coach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox prevBox;
        private System.Windows.Forms.PictureBox nextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.RichTextBox aboutBox;
    }
}