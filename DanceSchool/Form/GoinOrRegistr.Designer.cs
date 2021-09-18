
namespace DanceSchool
{
    partial class GoinOrRegistr
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
            this.GoinButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoinButton
            // 
            this.GoinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoinButton.BackColor = System.Drawing.Color.LightGray;
            this.GoinButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GoinButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GoinButton.Location = new System.Drawing.Point(601, 26);
            this.GoinButton.Name = "GoinButton";
            this.GoinButton.Size = new System.Drawing.Size(165, 52);
            this.GoinButton.TabIndex = 1;
            this.GoinButton.Text = "Go in";
            this.GoinButton.UseVisualStyleBackColor = false;
            this.GoinButton.Click += new System.EventHandler(this.GoinButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationButton.BackColor = System.Drawing.Color.LightGray;
            this.registrationButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.registrationButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrationButton.Location = new System.Drawing.Point(601, 102);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(165, 52);
            this.registrationButton.TabIndex = 2;
            this.registrationButton.Text = "Registration";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightGray;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.backButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 44);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // GoinOrRegistr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DanceSchool.Properties.Resources.photo_2019_11_15_13_32_40;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.GoinButton);
            this.Name = "GoinOrRegistr";
            this.Text = "Creativity";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoinButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button backButton;
    }
}