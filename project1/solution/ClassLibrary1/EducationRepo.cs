using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class EducationRepo : IRepo<educationdetails>
    {
        private readonly string connectionString;
        public EducationRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }



        public void Add(educationdetails educationdetails)
        {
            string query = @"insert into Sohail.education (user_id,university,passoutyear,grade)  values ( @User_id, @University, @Passoutyear, @Grade)";
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(query, con);

            sqlCommand.Parameters.AddWithValue("@grade", educationdetails.grade);
            sqlCommand.Parameters.AddWithValue("@passoutyear", educationdetails.passoutyear);
            sqlCommand.Parameters.AddWithValue("@university", educationdetails.university);
            sqlCommand.Parameters.AddWithValue("@user_id", educationdetails.user_id);

            int rows = sqlCommand.ExecuteNonQuery();
            Console.WriteLine(rows + "row(s) added");
            /*            return educationDetails;
            */
        }


        public List<educationdetails> GetAllDetails()
        {
            List<educationdetails> educationdetails = new List<educationdetails>();
            // establish the connection
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "select user_id,university,passoutyear,grade from sohail.education";
            using SqlCommand command = new SqlCommand(query, con);
            // execute it
            using SqlDataReader reader = command.ExecuteReader();
            // process the output
            while (reader.Read())
            {
                educationdetails.Add(new educationdetails()
                {

                    user_id = reader.GetInt32(0),
                    university = reader.GetString(1),
                    passoutyear = reader.GetString(2),
                    grade = reader.GetString(3),

                });
            }
            return educationdetails;
        
    }
    }

}

