using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LoginRepo : IRepo<logindetails>
    {

        private readonly string connectionString;
        public LoginRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(logindetails Logindetails)
        {

            string query = @"insert into sohail.login_details (loginid,password,Email)  values (@loginid,@password,@Email)";
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.AddWithValue("@loginid", Logindetails.loginid);
            sqlCommand.Parameters.AddWithValue("@password", Logindetails.password);
            sqlCommand.Parameters.AddWithValue("@Email", Logindetails.Email);
            int rows = sqlCommand.ExecuteNonQuery();
            Console.WriteLine(rows + "row(s) added");
        }

        public List<logindetails> GetAllDetails()
        {
            List<logindetails> Logindetails = new List<logindetails>();
            // establish the connection
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "select loginid,password,Email from sohail.login_details";
            using SqlCommand command = new SqlCommand(query, con);
            // execute it
            using SqlDataReader reader = command.ExecuteReader();
            // process the output
            while (reader.Read())
            {
                Logindetails.Add(new logindetails()
                {
                    loginid = reader.GetInt32(0),
                    password = reader.GetString(1),
                    Email = reader.GetString(2),
                });
            }
            return Logindetails;
        }
    }
}
