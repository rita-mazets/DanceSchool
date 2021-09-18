using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanceSchool
{
    public partial class Schedule : Form
    {
        public int Type { get; }
        public int IdU { get; }
        public Schedule(int type, int id, Size size)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Size = size;
            Type = type;
            IdU = id;

        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            if (Type != 3)
            {
                joinButton.Visible = false;
                joinButton.Enabled = false;
                List<List<string>> fullnames = DB.SelectNameSurnameFromCoach();
                List<string> teams = DB.SelectNameFromTeam();
                List<string> names = new List<string>();
                List<string> surnames = new List<string>();
                foreach (var fullname in fullnames)
                {
                    names.Add(fullname[0]);
                    surnames.Add(fullname[1]);
                }

                AutoCompleteStringCollection source = new AutoCompleteStringCollection();
                source.AddRange(teams.ToArray());
                teamBox.AutoCompleteCustomSource = source;
                teamBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                teamBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

                AutoCompleteStringCollection source1 = new AutoCompleteStringCollection();
                source1.AddRange(names.ToArray());
                nameBox.AutoCompleteCustomSource = source1;
                nameBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                nameBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

                AutoCompleteStringCollection source2 = new AutoCompleteStringCollection();
                source2.AddRange(surnames.ToArray());
                surnameBox.AutoCompleteCustomSource = source2;
                surnameBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                surnameBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            if (Type == 3)
            {
                addButton.Enabled = false;
                addButton.Visible = false;
                DeleteButton.Enabled = false;
                DeleteButton.Visible = false;
                teamnamelabel.Visible = false;
                coachnameLabel.Visible = false;
                surnameLabel.Visible = false;
                timeLabel.Visible = false;
                teamBox.Visible = false;
                nameBox.Visible = false;
                surnameBox.Visible = false;
                timeBox.Visible = false;
            }

            DateTime date = monthCalendar1.SelectionStart;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            SchoolMain school = new SchoolMain(Type, IdU, this.Size);
            FormAction.Open(this, school);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<List<string>> schedule = new List<List<string>>();
            DateTime date = monthCalendar1.SelectionStart;
            schedule = DB.SelectSchedule(date);
            if (schedule == null)
            {
                MessageBox.Show("There are no classes on this day");
                DB.InsertLoging(Type, IdU, 46);
                return;
            }
            DB.InsertLoging(Type, IdU, 45);
            for (int i = 0; i < schedule.Count; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = schedule[i][j];
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.ClearSelection();
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                int result = DB.InsertScheduleDancer(id, IdU);
                if(result != -1) DB.InsertLoging(Type, IdU, 47);
                else DB.InsertLoging(Type, IdU, 48);
            }
            catch
            {
                return;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teamBox.Text) || string.IsNullOrEmpty(nameBox.Text)
                ||  string.IsNullOrEmpty(surnameBox.Text) || string.IsNullOrEmpty(timeBox.Text))
            {
                dataGridView1.ClearSelection();
                MessageBox.Show("Введите данные в поля и укажите дату");
            }
            DateTime date = monthCalendar1.SelectionStart;
            
            TimeSpan time = Convert.ToDateTime(timeBox.Text).TimeOfDay;
            string name = nameBox.Text, surname = surnameBox.Text;
            string team = teamBox.Text;
            int idCoach = DB.SelectOneCoach(name, surname);
            int idTeam = DB.SelectIdFromTeams(idCoach, team);
            int res = DB.InsertIntoSchedule(date, time, idCoach, idTeam);
            if (res == 1)
            {
                MessageBox.Show("Success!");
                DB.InsertLoging(Type, IdU, 51);
            }
            else
            {
                MessageBox.Show("Error!");
                DB.InsertLoging(Type, IdU, 52);
            }


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            int res = DB.DeleteSchedule(id);
            if (res == 1)
            {
                MessageBox.Show("Success!");
                DB.InsertLoging(Type, IdU, 49);
            }
            else
            {
                MessageBox.Show("Error!");
                DB.InsertLoging(Type, IdU, 50);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            int res = DB.DeleteSchedule(id);
            if (res == 1) MessageBox.Show("Success!");
            else MessageBox.Show("Error!");
        }

    
    }
}
