using System;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using datahandle;
namespace trainer
{
    public class SignUpPage

    {

        Regex regemail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        Regex regpass = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$");
        SqlHandle sq = new SqlHandle();
        Logging lg = new Logging();





        private string firstname;
        private string lastname;
        private string emailid;
        private string password;
        private int phoneno;



        public string FirstName
        {
            set
            {
                firstname = value;
            }
            get
            {
                return firstname;
            }

        }

        public string LastName
        {
            set
            {
                lastname = value;
            }

            get
            {
                return lastname;
            }
        }

        public string EmailId
        {
            set
            {
                //if (regemail.IsMatch(value))
                //{
                //    emailid = value;
                //}
                if (regemail.IsMatch(value))
                {

                    emailid = value;

                }
                else
                {
                    Console.WriteLine("Enter a valid mail");
                }
                //else
                //{
                //    Console.WriteLine("Enter a valid email id");
                //}
            }

            get
            {
                return emailid;
            }

        }

        public string Password
        {
            set
            {
                if (regpass.IsMatch(value))
                {
                    password = value;

                }
                else
                {


                    Console.WriteLine("1.Password must contain min 8 letter \n2.Must contain min 1 capital letter \n3.Must contain atleast 1 small letter");
                    Console.WriteLine("");
                }
            }
            get
            {
                return password;
            }

        }

        public int PhoneNo
        {
            set
            {
                phoneno = value;
            }
            get
            {
                return phoneno;
            }
        }




        public void SignUpPageSubmission()
        {
            try
            {
                int reader = sq.SqlQueryWriter($"INSERT into sohail.[user](first_name,last_name,email_id,[password],phone_no) VALUES('{this.firstname}','{this.lastname}','{this.emailid}','{this.password}','{this.phoneno}');");
                //Console.WriteLine(reader);
            }
            catch (Exception e)
            {
                Console.WriteLine("Some error occured during signup");
                lg.ErrorWriter(e);

            }
            //while (reader.Read())
            //{

            //    Console.WriteLine(reader.GetInt32(0));

            //}

        }
    }

}


