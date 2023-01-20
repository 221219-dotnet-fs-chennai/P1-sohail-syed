using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CompanyRepo : IRepo<companydetails>
    {
        private readonly string connectionString;
        public CompanyRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }



        public void Add(companydetails companydetails)
        {
            string query = @"insert into Sohail.company (company_id,company_name,startyear,endyear,user_id)  values ( @Company_id, @Company_name, @Startyear, @Endyear,@User_id)";
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.AddWithValue("@company_id", companydetails.company_id);
            sqlCommand.Parameters.AddWithValue("@company_name", companydetails.company_name);
            sqlCommand.Parameters.AddWithValue("@startyear", companydetails.startyear);
            sqlCommand.Parameters.AddWithValue("@endyear", companydetails.endyear);
            sqlCommand.Parameters.AddWithValue("@user_id", companydetails.user_id);

            int rows = sqlCommand.ExecuteNonQuery();
            Console.WriteLine(rows + "row(s) added");
            /*            return companyDetails;
            */
        }


        public List<companydetails> GetAllDetails()
        {
            List<companydetails> companydetails = new List<companydetails>();
            // establish the connection
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "select company_id,company_name,startyear,endyear,user_id from sohail.company";
            using SqlCommand command = new SqlCommand(query, con);
            // execute it
            using SqlDataReader reader = command.ExecuteReader();
            // process the output
            while (reader.Read())
            {
               companydetails .Add(new companydetails()
                {
                    company_id = reader.GetInt32(0),
                    company_name = reader.GetString(1),
                    startyear = reader.GetString(2),
                    endyear= reader.GetString(3),
                    user_id = reader.GetInt32(4),

                });
            }
            return companydetails;
        }
    }
}
    
