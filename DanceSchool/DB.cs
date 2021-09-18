using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DanceSchool
{
    public static class DB
    {
        public static string connectionString = "Server=WIN-IM65VJ5PFU6\\MYMSSQLSERVER;Database=School;Trusted_Connection=True;";

        public static int InsertLoging(int type, int userId, int log)
        {
            string sqlExpression = "InsertLoging";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter typeParam = new SqlParameter { ParameterName = "@usersId", Value = type };
                    command.Parameters.Add(typeParam);
                    SqlParameter userParam = new SqlParameter { ParameterName = "@userId", Value = userId };
                    command.Parameters.Add(userParam);
                    SqlParameter logParam = new SqlParameter { ParameterName = "@logId", Value = log };
                    command.Parameters.Add(logParam);
                    command.ExecuteScalar();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public static int SelectOneCoach(string name, string surname)
        {
            string sqlExpression = "SelectOneCoach";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter nameParam = new SqlParameter { ParameterName = "@name", Value = name };
                    command.Parameters.Add(nameParam);
                    SqlParameter surnameParam = new SqlParameter { ParameterName = "@surname", Value = surname };
                    command.Parameters.Add(surnameParam);
                    return (int)command.ExecuteScalar();
                }
                catch
                {
                    return -1;
                }
            }
        }

        public static List<CoachU> SelectOneCoachFullInformation(int id)
        {
            string sqlExpression = "SelectOneCoachFullInformation";
            List<CoachU> coaches = new List<CoachU>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter idParam = new SqlParameter { ParameterName = "@id", Value = id };
                    command.Parameters.Add(idParam);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CoachU coach = new CoachU();

                            coach.Login = (string)reader.GetValue(0);
                            coach.Password = (string)reader.GetValue(1);
                            coach.Name = (string)reader.GetValue(2);
                            coach.Surname = (string)reader.GetValue(3);
                            coach.About = (string)reader.GetValue(4);
                            coach.Picture = (string)reader.GetValue(5);
                            coach.Id = (int)reader.GetValue(6);

                            coaches.Add(coach);
                        }
                    }
                    return coaches;
                }
                catch
                {
                    return null;
                }
            }
        }
        public static int GoIn(int Type,string login, string password)
        {
            string sqlExpression = string.Empty;
            if (Type == 1)
            {
                sqlExpression = "SelectIdFromAdmin";
            }
            else if (Type == 2)
            {
                sqlExpression = "SelectIdFromCoach";
            }
            else if (Type == 3)
            {
                sqlExpression = "SelectIdFromDancer";
            }

            try
            {
                int res = -1;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter loginParam = new SqlParameter { ParameterName = "@login", Value = login };
                    command.Parameters.Add(loginParam);
                    SqlParameter passwordParam = new SqlParameter { ParameterName = "@password", Value = password };
                    command.Parameters.Add(passwordParam);
                    res = (int)command.ExecuteScalar();
                }
                return res;
            }
            catch
            {
                return -1;
            }
            
        }

        public static int CheckAdminLogin(string login)
        {
            string sqlExpression = "SelectIdFromAdminLogin";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter loginParam = new SqlParameter { ParameterName = "@login", Value = login };
                    command.Parameters.Add(loginParam);
                    return (int)command.ExecuteScalar();
                }
                catch
                {
                    return -1;
                }
            }
        }

        public static int CheckCoachLogin(string login)
        {
            string sqlExpression = "SelectIdFromCoachLogin";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter loginParam = new SqlParameter { ParameterName = "@login", Value = login };
                    command.Parameters.Add(loginParam);
                    return (int)command.ExecuteScalar();
                }
                catch
                {
                    return -1;
                }
            }
        }

        public static int CheckDancerLogin(string login)
        {
            string sqlExpression = "SelectIdFromDancerLogin";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter loginParam = new SqlParameter { ParameterName = "@login", Value = login };
                    command.Parameters.Add(loginParam);
                    return (int)command.ExecuteScalar();
                }
                catch
                {
                    return -1;
                }
            }
        }

        public static int InsertAdmin(string login, string password)
        {
            string sqlExpression = "InsertAdmin";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter loginParam = new SqlParameter { ParameterName = "@login", Value = login };
                    command.Parameters.Add(loginParam);
                    SqlParameter passwordParam = new SqlParameter { ParameterName = "@password", Value = password };
                    command.Parameters.Add(passwordParam);
                    command.ExecuteScalar();
                    return 1;
                }
            }
            catch 
            {
                return -1;
            }
        }
        public static int InsertCoach(string login, string password, string name, string surname, string about)
        {
            string sqlExpression = "InsertCoach";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter loginParam = new SqlParameter { ParameterName = "@login", Value = login };
                    command.Parameters.Add(loginParam);
                    SqlParameter passwordParam = new SqlParameter { ParameterName = "@password", Value = password };
                    command.Parameters.Add(passwordParam);
                    SqlParameter nameParam = new SqlParameter { ParameterName = "@name", Value = name };
                    command.Parameters.Add(nameParam);
                    SqlParameter surnameParam = new SqlParameter { ParameterName = "@surname", Value = surname };
                    command.Parameters.Add(surnameParam);
                    SqlParameter aboutParam = new SqlParameter { ParameterName = "@about", Value = about };
                    command.Parameters.Add(aboutParam);
                    command.ExecuteScalar();
                    return 1;
                }
            }
            catch
            {
                return -1;
            }
        }

        public static int InsertDancerTeam(string name, int coachid, int id)
        {
            try
            {
                string sqlExpression = "InsertDancerTeam";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter coachidParam = new SqlParameter { ParameterName = "@coachid", Value = coachid };
                    command.Parameters.Add(coachidParam);
                    SqlParameter idParam = new SqlParameter { ParameterName = "@id", Value = id };
                    command.Parameters.Add(idParam);
                    SqlParameter nameParam = new SqlParameter { ParameterName = "@name", Value = name };
                    command.Parameters.Add(nameParam);
                    command.ExecuteScalar();
                }
                return 1;
            }
            catch {

                return -1;
            }
        }

        public static int InsertScheduleDancer(int ids, int idd)
        {
            try
            {
                string sqlExpression = "InsertScheduleDancer";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter idsParam = new SqlParameter { ParameterName = "@ids", Value = ids };
                    command.Parameters.Add(idsParam);
                    SqlParameter iddParam = new SqlParameter { ParameterName = "@idd", Value = idd };
                    command.Parameters.Add(iddParam);
                    command.ExecuteScalar();
                }
                return 1;
            }
            catch
            {

                return -1;
            }
        }

        

        public static int DeleteSchedule(int id)
        {
            try
            {
                string sqlExpression = "DeleteSchedule";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter idParam = new SqlParameter { ParameterName = "@id", Value = id };
                    command.Parameters.Add(idParam);
                    command.ExecuteScalar();
                }
                return 1;
            }
            catch
            {

                return -1;
            }
        }

        public static int SelectIdFromTeams(int id, string name)
        {
            try
            {
                string sqlExpression = "SelectIdFromTeams";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter idParam = new SqlParameter { ParameterName = "@coachId", Value = id };
                    command.Parameters.Add(idParam);
                    SqlParameter nameParam = new SqlParameter { ParameterName = "@name", Value = name };
                    command.Parameters.Add(nameParam);
                    return (int)command.ExecuteScalar();
                }
            }
            catch
            {

                return -1;
            }
        }

        public static int InsertIntoSchedule(DateTime date, TimeSpan time, int coachId, int teamId)
        {
            try
            {
                string sqlExpression = "InsertIntoSchedule";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter dateParam = new SqlParameter { ParameterName = "@date", Value = date.Date };
                    command.Parameters.Add(dateParam);
                    SqlParameter timeParam = new SqlParameter { ParameterName = "@time", Value = time };
                    command.Parameters.Add(timeParam);
                    SqlParameter coachIdParam = new SqlParameter { ParameterName = "@coachId", Value = coachId };
                    command.Parameters.Add(coachIdParam);
                    SqlParameter teamIdParam = new SqlParameter { ParameterName = "@teamId", Value = teamId };
                    command.Parameters.Add(teamIdParam);
                    command.ExecuteScalar();
                    return 1;
                }
            }
            catch
            {

                return -1;
            }
        }
        public static int InsertDancer(string login, string password, string name, string surname)
        {
            string sqlExpression = "InsertDancer";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter loginParam = new SqlParameter { ParameterName = "@login", Value = login };
                    command.Parameters.Add(loginParam);
                    SqlParameter passwordParam = new SqlParameter { ParameterName = "@password", Value = password };
                    command.Parameters.Add(passwordParam);
                    SqlParameter nameParam = new SqlParameter { ParameterName = "@name", Value = name };
                    command.Parameters.Add(nameParam);
                    SqlParameter surnameParam = new SqlParameter { ParameterName = "@surname", Value = surname };
                    command.Parameters.Add(surnameParam);
                    command.ExecuteScalar();
                    return 1;
                }
            }
            catch
            {
                return -1;
            }
        }

        public static string SelectLogin(int type, int id)
        {
            string sqlExpression;
            if (type == 1) { sqlExpression = "SelectLoginFromAdmin"; }
            else if (type == 2) { sqlExpression = "SelectLoginFromCoach"; }
            else if (type == 3) { sqlExpression = "SelectLoginFromDancer"; }
            else { return string.Empty; }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter idParam = new SqlParameter { ParameterName = "@id", Value = id };
                    command.Parameters.Add(idParam);
                    return (string)command.ExecuteScalar();
                }
                catch
                {
                    return string.Empty;
                }
            }
        }

        public static object SelectAllFromUser(int type, int id)
        {
            string sqlExpression;
            if (type == 1) { sqlExpression = "SelectAllFromAdmin"; }
            else if (type == 2) { sqlExpression = "SelectAllFromCoach"; }
            else if (type == 3) { sqlExpression = "SelectAllFromDancer"; }
            else { return null; }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter idParam = new SqlParameter { ParameterName = "@id", Value = id };
                    command.Parameters.Add(idParam);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (type == 1)
                            {
                                Admin admin = new Admin(id);

                                admin.Login = (string)reader.GetValue(0);
                                admin.Password = (string)reader.GetValue(1);
                                return admin;
                            }
                            if (type == 2)
                            {
                                CoachU coach = new CoachU(id);

                                coach.Login = (string)reader.GetValue(0);
                                coach.Password = (string)reader.GetValue(1);
                                coach.Name = (string)reader.GetValue(2);
                                coach.Surname = (string)reader.GetValue(3);
                                coach.About = (string)reader.GetValue(4);
                                coach.Picture = (string)reader.GetValue(5);
                                return coach;
                            }
                            if (type == 3)
                            {
                                Dancer dancer = new Dancer(id);

                                dancer.Login = (string)reader.GetValue(0);
                                dancer.Password = (string)reader.GetValue(1);
                                dancer.Name = (string)reader.GetValue(2);
                                dancer.Surname = (string)reader.GetValue(3);
                                return dancer;
                            }
                        }
                    }
                    return null;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static int UpdateAdmin(int id, string login)
        {
            string sqlExpression = "UpdateAdmin";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter loginParam = new SqlParameter { ParameterName = "@login", Value = login };
                    command.Parameters.Add(loginParam);
                    SqlParameter idParam = new SqlParameter { ParameterName = "@id", Value = id };
                    command.Parameters.Add(idParam);
                    command.ExecuteScalar();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public static int UpdateDancer(int id, string login, string name, string surname)
        {
            string sqlExpression = "UpdateDancer";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter loginParam = new SqlParameter { ParameterName = "@login", Value = login };
                    command.Parameters.Add(loginParam);
                    SqlParameter nameParam = new SqlParameter { ParameterName = "@name", Value = name };
                    command.Parameters.Add(nameParam);
                    SqlParameter surnameParam = new SqlParameter { ParameterName = "@surname", Value = surname };
                    command.Parameters.Add(surnameParam);
                    SqlParameter idParam = new SqlParameter { ParameterName = "@id", Value = id };
                    command.Parameters.Add(idParam);
                    command.ExecuteScalar();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public static int UpdateCoach(int id, string login, string name, string surname, string about)
        {
            string sqlExpression = "UpdateCoach";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter loginParam = new SqlParameter { ParameterName = "@login", Value = login };
                    command.Parameters.Add(loginParam);
                    SqlParameter nameParam = new SqlParameter { ParameterName = "@name", Value = name };
                    command.Parameters.Add(nameParam);
                    SqlParameter surnameParam = new SqlParameter { ParameterName = "@surname", Value = surname };
                    command.Parameters.Add(surnameParam);
                    SqlParameter idParam = new SqlParameter { ParameterName = "@id", Value = id };
                    command.Parameters.Add(idParam);
                    SqlParameter aboutParam = new SqlParameter { ParameterName = "@about", Value = about };
                    command.Parameters.Add(aboutParam);
                    command.ExecuteScalar();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public static List<CoachU> SelectAllCoach()
        {
            string sqlExpression = "SelectAllCoach";
            List<CoachU> coaches = new List<CoachU>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CoachU coach = new CoachU();

                            coach.Login = (string)reader.GetValue(0);
                            coach.Password = (string)reader.GetValue(1);
                            coach.Name = (string)reader.GetValue(2);
                            coach.Surname = (string)reader.GetValue(3);
                            coach.About = (string)reader.GetValue(4);
                            coach.Picture = (string)reader.GetValue(5);
                            coach.Id = (int)reader.GetValue(6);

                            coaches.Add(coach);
                        }
                    }
                    return coaches;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static List<string> SelectNameFromTeam()
        {
            string sqlExpression = "SelectNameFromTeam";
            List<string> names = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            names.Add(reader.GetValue(0).ToString());
                        }
                    }
                    return names;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static List<List<string>> SelectNameSurnameFromCoach()
        {
            string sqlExpression = "SelectNameSurnameFromCoach";
            List<List<string>> names = new List<List<string>>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            List<string> name = new List<string>();
                            name.Add(reader.GetValue(0).ToString());
                            name.Add(reader.GetValue(1).ToString());

                            names.Add(name);
                        }
                    }
                    return names;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static List<List<string>> SelectSchedule(DateTime date)
        {
            string sqlExpression = "SelectSchedule";

            List<List<string>> schedules = new List<List<string>>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter dateParam = new SqlParameter { ParameterName = "@date", Value = date };
                    command.Parameters.Add(dateParam);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            List<string> schedule = new List<string>();
                            schedule.Add(reader.GetValue(4).ToString()); 
                            schedule.Add(reader.GetValue(2).ToString() + " " + reader.GetValue(3).ToString());
                            schedule.Add(reader.GetValue(0).ToString());
                            schedule.Add(reader.GetValue(1).ToString());
                            schedule.Add(reader.GetValue(5).ToString());
                            schedules.Add(schedule);
                        }
                    }
                    return schedules;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static List<List<string>> SelectAllRank()
        {
            string sqlExpression = "SelectAllRank";

            List<List<string>> ranks = new List<List<string>>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            List<string> rank = new List<string>();
                            rank.Add(reader.GetValue(0).ToString());
                            rank.Add(reader.GetValue(1).ToString());
                            rank.Add(reader.GetValue(2).ToString());
                            rank.Add(reader.GetValue(3).ToString());
                            rank.Add(reader.GetValue(4).ToString());
                            rank.Add(reader.GetValue(5).ToString());
                            rank.Add(reader.GetValue(6).ToString());
                            rank.Add(reader.GetValue(7).ToString());
                            ranks.Add(rank);
                        }
                    }
                    return ranks;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static List<SubscriptionModel> SelectAllSubscription()
        {
            string sqlExpression = "SelectAllSubscription";
            List<SubscriptionModel> subscriptions = new List<SubscriptionModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //try
                //{
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            SubscriptionModel subscription = new SubscriptionModel();

                            subscription.Id = (int)reader.GetValue(0);
                            subscription.Name = (string)reader.GetValue(1);
                            subscription.Price = (double)reader.GetValue(2);
                            subscription.Discription = (string)reader.GetValue(3);

                            subscriptions.Add(subscription);
                        }
                    }
                    return subscriptions;
                }
                /*catch
                {
                    return null;
                }*/
            }
        


        public static int InsertSubscription(string name, string prices, string discription)
        {
            string sqlExpression = "InsertSubscription";
            float.TryParse(prices, out float price);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter nameParam = new SqlParameter { ParameterName = "@name", Value = name };
                    command.Parameters.Add(nameParam);
                    SqlParameter priceParam = new SqlParameter { ParameterName = "@price", Value = price };
                    command.Parameters.Add(priceParam);
                    SqlParameter discriptionParam = new SqlParameter { ParameterName = "@discription", Value = discription };
                    command.Parameters.Add(discriptionParam);
                    command.ExecuteScalar();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public static int DeleteSubscription(string name)
        {
            string sqlExpression = "DeleteSubscription";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter nameParam = new SqlParameter { ParameterName = "@name", Value = name };
                    command.Parameters.Add(nameParam);
                    command.ExecuteScalar();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
        }


    }
}

