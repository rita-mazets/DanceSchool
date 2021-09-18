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
    public partial class Subscription : Form
    {
        public int Type { get; }
        public int Id { get; }
        private int index = 0;

        List<SubscriptionModel> subscriptions;
        public Subscription(int type, int id, Size size)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Size = size;
            Type = type;
            Id = id;
            subscriptions = new List<SubscriptionModel>();
        }

        private void Subscription_Load(object sender, EventArgs e)
        {
            subscriptions = DB.SelectAllSubscription();
            if (subscriptions is null) DB.InsertLoging(Type, Id, 37);
            else DB.InsertLoging(Type, Id, 36);
            SetParam();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            SchoolMain school = new SchoolMain(Type, Id, this.Size);
            FormAction.Open(this, school);
        }

        private void nextBox_Click(object sender, EventArgs e)
        {
            if (index == subscriptions.Count - 1) index = 0;
            else index++;
            SetParam();
        }

        private void SetParam()
        {
            if (subscriptions.Count == 0) return;
            if (Type == 1)
            {
                nameLBox.Visible = false;
                priceLBox.Visible = false;

                nameBox.Text = subscriptions[index].Name;
                priceBox.Text = subscriptions[index].Price.ToString();
                discBox.Text = subscriptions[index].Discription;
            }
            else
            {
                nameBox.Visible = false;
                priceBox.Visible = false;
                createbutton.Visible = false;
                createbutton.Enabled = false;
                deleteButton.Visible = false;
                deleteButton.Enabled = false;

                nameLBox.Text = subscriptions[index].Name;
                priceLBox.Text = subscriptions[index].Price.ToString();
                discBox.Text = subscriptions[index].Discription;
            }
        }

        private void prevBox_Click(object sender, EventArgs e)
        {
            if (index == 0) index = subscriptions.Count - 1;
            else index--;
            SetParam();
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            int result = DB.InsertSubscription(nameBox.Text, priceBox.Text, discBox.Text);
            if (result == 1)
            {
                MessageBox.Show("Success!");
                DB.InsertLoging(Type, Id, 38);
            }
            else
            {
                MessageBox.Show("The entry was not added", "Error!");
                DB.InsertLoging(Type, Id, 39);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int result = DB.DeleteSubscription(nameBox.Text);
            if (result == 1)
            {
                MessageBox.Show("Success!");
                DB.InsertLoging(Type, Id, 40);
            }
            else
            {
                MessageBox.Show("The entry was not  deleted", "Error!");
                DB.InsertLoging(Type, Id, 41);
            }
        }
    }
}