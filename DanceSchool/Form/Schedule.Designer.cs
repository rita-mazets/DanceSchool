
using System.Windows.Forms;

namespace DanceSchool
{
    partial class Schedule
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.chooseButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.joinButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDancer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamnamelabel = new System.Windows.Forms.Label();
            this.teamBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.coachnameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightGray;
            this.backButton.BackgroundImage = global::DanceSchool.Properties.Resources._5fd8aef713bcf_Rsi0y;
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
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(762, 72);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            // 
            // chooseButton
            // 
            this.chooseButton.BackColor = System.Drawing.Color.LightGray;
            this.chooseButton.BackgroundImage = global::DanceSchool.Properties.Resources._5fd8aef713bcf_Rsi0y;
            this.chooseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chooseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.chooseButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chooseButton.Location = new System.Drawing.Point(762, 291);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(192, 44);
            this.chooseButton.TabIndex = 17;
            this.chooseButton.Text = "Choose";
            this.chooseButton.UseVisualStyleBackColor = false;
            this.chooseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.coach,
            this.time,
            this.countDancer,
            this.Idd});
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(706, 360);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // joinButton
            // 
            this.joinButton.BackColor = System.Drawing.Color.LightGray;
            this.joinButton.BackgroundImage = global::DanceSchool.Properties.Resources._5fd8aef713bcf_Rsi0y;
            this.joinButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.joinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.joinButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.joinButton.Location = new System.Drawing.Point(762, 355);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(192, 44);
            this.joinButton.TabIndex = 19;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = false;
            this.joinButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightGray;
            this.addButton.BackgroundImage = global::DanceSchool.Properties.Resources._5fd8aef713bcf_Rsi0y;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.addButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(762, 576);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 44);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.LightGray;
            this.DeleteButton.BackgroundImage = global::DanceSchool.Properties.Resources._5fd8aef713bcf_Rsi0y;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.DeleteButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(861, 576);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(93, 44);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 175;
            // 
            // coach
            // 
            this.coach.HeaderText = "Coach";
            this.coach.MinimumWidth = 6;
            this.coach.Name = "coach";
            this.coach.ReadOnly = true;
            this.coach.Width = 175;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 175;
            // 
            // countDancer
            // 
            this.countDancer.HeaderText = "Count dancer";
            this.countDancer.MinimumWidth = 6;
            this.countDancer.Name = "countDancer";
            this.countDancer.ReadOnly = true;
            this.countDancer.Width = 175;
            // 
            // Idd
            // 
            this.Idd.HeaderText = "Idd";
            this.Idd.MinimumWidth = 6;
            this.Idd.Name = "Idd";
            this.Idd.Width = 125;
            // 
            // teamnamelabel
            // 
            this.teamnamelabel.AutoSize = true;
            this.teamnamelabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.teamnamelabel.Location = new System.Drawing.Point(12, 536);
            this.teamnamelabel.Name = "teamnamelabel";
            this.teamnamelabel.Size = new System.Drawing.Size(127, 27);
            this.teamnamelabel.TabIndex = 23;
            this.teamnamelabel.Text = "Teams name";
            // 
            // teamBox
            // 
            this.teamBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.teamBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.teamBox.Location = new System.Drawing.Point(12, 586);
            this.teamBox.Name = "teamBox";
            this.teamBox.Size = new System.Drawing.Size(146, 28);
            this.teamBox.TabIndex = 28;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(188, 586);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(146, 28);
            this.nameBox.TabIndex = 29;
            // 
            // surnameBox
            // 
            this.surnameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.surnameBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnameBox.Location = new System.Drawing.Point(364, 586);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(146, 28);
            this.surnameBox.TabIndex = 30;
            // 
            // coachnameLabel
            // 
            this.coachnameLabel.AutoSize = true;
            this.coachnameLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.coachnameLabel.Location = new System.Drawing.Point(188, 536);
            this.coachnameLabel.Name = "coachnameLabel";
            this.coachnameLabel.Size = new System.Drawing.Size(123, 27);
            this.coachnameLabel.TabIndex = 31;
            this.coachnameLabel.Text = "Coach name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnameLabel.Location = new System.Drawing.Point(364, 536);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(94, 27);
            this.surnameLabel.TabIndex = 32;
            this.surnameLabel.Text = "Surname";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(545, 536);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(60, 27);
            this.timeLabel.TabIndex = 33;
            this.timeLabel.Text = "Time";
            // 
            // timeBox
            // 
            this.timeBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.timeBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeBox.Location = new System.Drawing.Point(545, 586);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(146, 28);
            this.timeBox.TabIndex = 34;
            this.timeBox.Text = "17:00:00";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DanceSchool.Properties.Resources.cooking1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.coachnameLabel);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.teamBox);
            this.Controls.Add(this.teamnamelabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.backButton);
            this.DoubleBuffered = true;
            this.Name = m;
            this.Text = "Creativity";
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button joinButton;
        private DataGridViewTextBoxColumn kl;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn fes;
        private Button addButton;
        private Button DeleteButton;
        private DataGridViewTextBoxColumn m;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn coach;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn countDancer;
        private DataGridViewTextBoxColumn Idd;
        private Label teamnamelabel;
        private TextBox teamBox;
        private TextBox nameBox;
        private TextBox surnameBox;
        private Label coachnameLabel;
        private Label surnameLabel;
        private Label timeLabel;
        private TextBox timeBox;
    }
}