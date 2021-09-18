
namespace DanceSchool
{
    partial class beginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdminButton = new System.Windows.Forms.Button();
            this.dancerButton = new System.Windows.Forms.Button();
            this.coachButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminButton
            // 
            this.AdminButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminButton.BackColor = System.Drawing.Color.LightGray;
            this.AdminButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AdminButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminButton.Location = new System.Drawing.Point(608, 31);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(165, 52);
            this.AdminButton.TabIndex = 0;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // dancerButton
            // 
            this.dancerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dancerButton.BackColor = System.Drawing.Color.LightGray;
            this.dancerButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dancerButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dancerButton.Location = new System.Drawing.Point(608, 194);
            this.dancerButton.Name = "dancerButton";
            this.dancerButton.Size = new System.Drawing.Size(165, 52);
            this.dancerButton.TabIndex = 1;
            this.dancerButton.Text = "Dancer";
            this.dancerButton.UseVisualStyleBackColor = false;
            this.dancerButton.Click += new System.EventHandler(this.dancerButton_Click);
            // 
            // coachButton
            // 
            this.coachButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coachButton.BackColor = System.Drawing.Color.LightGray;
            this.coachButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.coachButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.coachButton.Location = new System.Drawing.Point(608, 111);
            this.coachButton.Name = "coachButton";
            this.coachButton.Size = new System.Drawing.Size(165, 52);
            this.coachButton.TabIndex = 2;
            this.coachButton.Text = "Coach";
            this.coachButton.UseVisualStyleBackColor = false;
            this.coachButton.Click += new System.EventHandler(this.coachButton_Click);
            // 
            // beginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DanceSchool.Properties.Resources.photo_2019_11_15_13_32_40;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 514);
            this.Controls.Add(this.coachButton);
            this.Controls.Add(this.dancerButton);
            this.Controls.Add(this.AdminButton);
            this.Name = "beginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creativity";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button dancerButton;
        private System.Windows.Forms.Button coachButton;
    }
}

