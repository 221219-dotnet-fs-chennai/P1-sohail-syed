using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AddressRepo :IRepo<addressdetails>
    {
        private readonly string connectionString;
        public AddressRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }



        public void Add(addressdetails addressdetails)
        {
            string query = @"insert into Sohail.address (contact,email,state,pincode,user_id)  values ( @Contact, @Email, @State, @Pincode,@User_id)";
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.AddWithValue("@Contact", addressdetails.contact);
            sqlCommand.Parameters.AddWithValue("@Email", addressdetails.email);
            sqlCommand.Parameters.AddWithValue("@State", addressdetails.state);
            sqlCommand.Parameters.AddWithValue("@Pincode",addressdetails .pincode);
            sqlCommand.Parameters.AddWithValue("@User_id", addressdetails.user_id);

            int rows = sqlCommand.ExecuteNonQuery();
            Console.WriteLine(rows + "row(s) added");
            /*            return companyDetails;
            */
        }


        public List<addressdetails> GetAllDetails()
        {
            List<addressdetails> addressdetails = new List<addressdetails>();
            // establish the connection
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "select contact,email,state,pincode,user_id from sohail.address";
            using SqlCommand command = new SqlCommand(query, con);
            // execute it
            using SqlDataReader reader = command.ExecuteReader();
            // process the output
            while (reader.Read())
            {
                addressdetails.Add(new addressdetails()
                {
                    contact = reader.GetString(0),
                    email= reader.GetString(1),
                    state = reader.GetString(2),
                    pincode = reader.GetString(3),
                    user_id = reader.GetInt32(4),

                });
            }
            return addressdetails;
        }

    }
}
