using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    class Retrieval
    {
        public static int role;

        private static string user_name = null, pass_word = null;
        private static bool checklogin;

        public static int User_ID
        {
            get;
            private set;
        }

        public static string Emp_First_Name
        {
            get;
            private set;
        }

        public static string Emp_Last_Name
        {
            get;
            private set;
        }

        public static Boolean getUserDetails(string username, string password)
        {
            try
            {
                string Query = "get_user_login_details_pos;";
                MySqlCommand cmd = new MySqlCommand(Query, Conn.ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataReader sda = cmd.ExecuteReader();

                if (sda.HasRows)
                {
                    checklogin = true;
                    while (sda.Read())
                    {
                        User_ID = Convert.ToInt32(sda["ID"].ToString());
                        Emp_First_Name = sda["First Name"].ToString();
                        Emp_Last_Name = sda["Last Name"].ToString();
                        user_name = sda["Username"].ToString();
                        pass_word = sda["Password"].ToString();
                        role = Convert.ToInt32(sda["Role"].ToString());
                    }
                }
                else
                {
                    checklogin = false;
                    if (username != null && password != null)
                    {
                        if (user_name != username && pass_word == password)
                        {
                            alert aa=new alert("Error!","Invalid Username.","error");
                            aa.ShowDialog();
                        }
                        else if (user_name == username && pass_word != password)
                        {
                            alert aa = new alert("Error!", "Invalid Password.", "error");
                            aa.ShowDialog();

                        }
                        else if (user_name != username && pass_word != password)
                        {
                            alert aa = new alert("Error!", "Invalid User Name And Password.", "error");
                            aa.ShowDialog();
                        }
                    }
                }

                if (Conn.ConnectionString.State == ConnectionState.Open)
                {
                    Conn.ConnectionString.Close();
                }
            }
            catch (Exception ex)
            {
                if (Conn.ConnectionString.State == ConnectionState.Open)
                {
                    Conn.ConnectionString.Close();
                }

                MessageBox.Show("Enable to Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return checklogin;
        }

    }
}
