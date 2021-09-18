
namespace DanceSchool
{
    partial class Subscription
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
            this.priceBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.discBox = new System.Windows.Forms.TextBox();
            this.aboutLBox = new System.Windows.Forms.Label();
            this.priceLBox = new System.Windows.Forms.Label();
            this.nameLBox = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nextBox = new System.Windows.Forms.PictureBox();
            this.prevBox = new System.Windows.Forms.PictureBox();
            this.createbutton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gainsboro;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.backButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 44);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.discBox);
            this.panel1.Controls.Add(this.aboutLBox);
            this.panel1.Controls.Add(this.priceLBox);
            this.panel1.Controls.Add(this.nameLBox);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(140, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 289);
            this.panel1.TabIndex = 14;
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.priceBox.Location = new System.Drawing.Point(358, 29);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(125, 27);
            this.priceBox.TabIndex = 24;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameBox.Location = new System.Drawing.Point(108, 29);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(125, 27);
            this.nameBox.TabIndex = 23;
            // 
            // discBox
            // 
            this.discBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.discBox.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.discBox.Location = new System.Drawing.Point(17, 97);
            this.discBox.Multiline = true;
            this.discBox.Name = "discBox";
            this.discBox.Size = new System.Drawing.Size(483, 166);
            this.discBox.TabIndex = 22;
            // 
            // aboutLBox
            // 
            this.aboutLBox.AutoSize = true;
            this.aboutLBox.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutLBox.Location = new System.Drawing.Point(17, 92);
            this.aboutLBox.Name = "aboutLBox";
            this.aboutLBox.Size = new System.Drawing.Size(85, 32);
            this.aboutLBox.TabIndex = 21;
            this.aboutLBox.Text = "Name:";
            // 
            // priceLBox
            // 
            this.priceLBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLBox.AutoSize = true;
            this.priceLBox.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLBox.Location = new System.Drawing.Point(358, 24);
            this.priceLBox.Name = "priceLBox";
            this.priceLBox.Size = new System.Drawing.Size(85, 32);
            this.priceLBox.TabIndex = 15;
            this.priceLBox.Text = "Name:";
            // 
            // nameLBox
            // 
            this.nameLBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLBox.AutoSize = true;
            this.nameLBox.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLBox.Location = new System.Drawing.Point(108, 24);
            this.nameLBox.Name = "nameLBox";
            this.nameLBox.Size = new System.Drawing.Size(85, 32);
            this.nameLBox.TabIndex = 19;
            this.nameLBox.Text = "Name:";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(278, 24);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(74, 32);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Price:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(17, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(85, 32);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name:";
            // 
            // nextBox
            // 
            this.nextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextBox.BackColor = System.Drawing.Color.Transparent;
            this.nextBox.BackgroundImage = global::DanceSchool.Properties.Resources._5fd8aef713bcf_Rsi0y;
            this.nextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextBox.Location = new System.Drawing.Point(618, 394);
            this.nextBox.Name = "nextBox";
            this.nextBox.Size = new System.Drawing.Size(44, 44);
            this.nextBox.TabIndex = 23;
            this.nextBox.TabStop = false;
            this.nextBox.Click += new System.EventHandler(this.nextBox_Click);
            // 
            // prevBox
            // 
            this.prevBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prevBox.BackColor = System.Drawing.Color.Transparent;
            this.prevBox.BackgroundImage = global::DanceSchool.Properties.Resources._5fd8aef713bcf;
            this.prevBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prevBox.Location = new System.Drawing.Point(140, 394);
            this.prevBox.Name = "prevBox";
            this.prevBox.Size = new System.Drawing.Size(44, 44);
            this.prevBox.TabIndex = 24;
            this.prevBox.TabStop = false;
            this.prevBox.Click += new System.EventHandler(this.prevBox_Click);
            // 
            // createbutton
            // 
            this.createbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createbutton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.createbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.createbutton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createbutton.Location = new System.Drawing.Point(427, 12);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(235, 44);
            this.createbutton.TabIndex = 25;
            this.createbutton.Text = "Create Subscription";
            this.createbutton.UseVisualStyleBackColor = false;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.deleteButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(140, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(235, 44);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Subscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DanceSchool.Properties.Resources.cooking;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.prevBox);
            this.Controls.Add(this.nextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backButton);
            this.DoubleBuffered = true;
            this.Name = "Subscription";
            this.Text = "Creativity";
            this.Load += new System.EventHandler(this.Subscription_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox discBox;
        private System.Windows.Forms.Label aboutLBox;
        private System.Windows.Forms.Label priceLBox;
        private System.Windows.Forms.Label nameLBox;
        private System.Windows.Forms.PictureBox nextBox;
        private System.Windows.Forms.PictureBox prevBox;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button deleteButton;
    }
}