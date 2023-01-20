using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SkillRepo : IRepo<skills>
    {
        private readonly string connectionString;
        public SkillRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }



        public void Add(skills skills)
        {
            string query = @"insert into Sohail.skills ( skill_name,skill_profficency,user_id)  values ( @Skill_name, @Skill_profficency, @User_id)";
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.AddWithValue("@skill_name", skills.skill_name);
            sqlCommand.Parameters.AddWithValue("@skill_profficency", skills.skill_profficency);
            sqlCommand.Parameters.AddWithValue("@user_id", skills.user_id);
 
            int rows = sqlCommand.ExecuteNonQuery();
            Console.WriteLine(rows + "row(s) added");
            /*            return UserDetails;
            */
        }


        public List<skills> GetAllDetails()
        {
            List<skills> skills = new List<skills>();
            // establish the connection
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "select user_id, skill_name, skill_profficency from sohail.skills";
            using SqlCommand command = new SqlCommand(query, con);
            // execute it
            using SqlDataReader reader = command.ExecuteReader();
            // process the output
            while (reader.Read())
            {
                skills.Add(new skills()
                {
                    skill_name = reader.GetString(1),
                    skill_profficency = reader.GetString(2),
                    user_id = reader.GetInt32(0),

                    
                });
            }
            return skills;
        }
    }  
}
    

