using ClassLibrary1;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class SqlRepo : IRepo<User>

    {
        private readonly string connectionString;
        public SqlRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
       


        public void Add(User UserDetails)
        {
            string query = @"insert into Sohail.[User] (user_id, Firstname,Lastname,Age,Gender)  values (@user_id, @Firstname, @Lastname, @Age, @Gender)";
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.AddWithValue("@user_id", UserDetails.user_id);
            sqlCommand.Parameters.AddWithValue("@firstname",UserDetails.First_name);
            sqlCommand.Parameters.AddWithValue("@lastname", UserDetails.Last_name) ;
            sqlCommand.Parameters.AddWithValue("@age", UserDetails.Age);
            sqlCommand.Parameters.AddWithValue("@gender", UserDetails.Gender);
            int rows = sqlCommand.ExecuteNonQuery();
            Console.WriteLine(rows + "row(s) added");
/*            return UserDetails;
*/        }


        public List<User> GetAllDetails()
        {
            List<User> UserDetails = new List<User>();
            // establish the connection
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "select user_id, Firstname, Lastname, Age, Gender from sohail.[User]";
            using SqlCommand command = new SqlCommand(query, con);
            // execute it
            using SqlDataReader reader = command.ExecuteReader();
            // process the output
            while (reader.Read())
            {
                UserDetails.Add(new User()
                {
                    user_id = reader.GetInt32(0),
                    First_name = reader.GetString(1),
                    Last_name = reader.GetString(2),
                    Age = reader.GetInt32(3),
                    Gender = reader.GetString(4)
                }); 
            }
            return UserDetails;
        }
    }
}
