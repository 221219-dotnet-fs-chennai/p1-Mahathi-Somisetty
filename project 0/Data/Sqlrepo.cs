﻿using System;
using Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Design;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;

namespace Trainer
{
    public class Sqlrepo : IRepo
    {
        private readonly string? connectionstring = $@"server=LAPTOP-S7D0E4KP;Database=trainee;Trusted_Connection=True;";
        private string connection;

        public Sqlrepo(string connection)
        {
            this.connection = connection;
        }

        /*public Sqlrepo(string connectionstring)
{
   this.connectionstring = connectionstring;
}*/

        public Details Add(Details details)
        {
            using SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();

            string query = @"insert into TraineeDetails(FullName, EmailId, Gender, Age, PhoneNumber, Password) values ( @FullName, @EmailId, @Gender, @Age, @PhoneNumber, @Password)";
            
            SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@TraineeId", TraineeId);
            command.Parameters.AddWithValue("@FullName", details.FullName);
            command.Parameters.AddWithValue("@EmailId", details.EmailId);
            command.Parameters.AddWithValue("@Gender", details.Gender);
            command.Parameters.AddWithValue("@Age", details.Age);
            command.Parameters.AddWithValue("@PhoneNumber", details.Phonenumber);
            command.Parameters.AddWithValue("@Password", details.Password);

            command.ExecuteNonQuery();

            string query1 = @"insert into EducationalDetails(HQualification, YearOfPassing, Stream) values ( @HQualification, @YearOfPassing, @Stream)";

            SqlCommand command1 = new SqlCommand(query1, connection);
            //command1.Parameters.AddWithValue("@TraineeId ", TraineeId);
            command1.Parameters.AddWithValue("@HQualification", details.HighestQualification);
            command1.Parameters.AddWithValue("@YearOfPassing", details.PassingYear);
            command1.Parameters.AddWithValue("@Stream", details.Stream);

            command1.ExecuteNonQuery();

            string query2 = @"insert into CompanyDetails( Company_Name, ProjectName, Position, Experience) values ( @Company_Name, @ProjectName, @Position, @Experience)";

            SqlCommand command2 = new SqlCommand(query2, connection);
           // command2.Parameters.AddWithValue("@TraineeId", TraineeId);
            command2.Parameters.AddWithValue("@company_Name", details.CompanyName);
            command2.Parameters.AddWithValue("@ProjectName", details.ProjectName);
            command2.Parameters.AddWithValue("@Position", details.Position);
            command2.Parameters.AddWithValue("@Experience", details.Experience);
            command2.ExecuteNonQuery();

            string query3 = @"insert into Skills(Skill_name, Skill_Type, Expertise) values ( @Skill_name, @Skill_Type, @Expertise)";

            SqlCommand command3 = new SqlCommand(query3, connection);
            //command3.Parameters.AddWithValue("@TraineeId", TraineeId);
            command3.Parameters.AddWithValue("@Skill_Name", details.SkillName);
            command3.Parameters.AddWithValue("@Skill_Type", details.SkillType);
            command3.Parameters.AddWithValue("@Expertise", details.Expertise);
            command3.ExecuteNonQuery();

            Console.WriteLine("one Row Added Successfully");
            Console.ReadLine();

            return details;
        }

       /* public bool Login(string email)
        {
            throw new NotImplementedException();
        }
*/
        public bool Login(string email)
        {
            string query1 = $@"select EmailId from TraineeDetails where EmailId='{email}';";
            using SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand command1 = new SqlCommand(query1, con);

            SqlDataReader reader = command1.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                Console.Write("Enter your password: ");
                string? password = Console.ReadLine();
                string query = $@"select Password from TraineeDetails where Password='{password}';";
                SqlCommand command2 = new SqlCommand(query, con);
                using SqlDataReader read1 = command2.ExecuteReader();
                if (read1.Read())
                {
                    Console.WriteLine("successfull login");
                    return true;
                }

                else
                {
                    Console.WriteLine("wrong PAssword");
                    read1.Close();
                    return false;

                }

            }     
                
             else
              {
                    Console.WriteLine("No Email Registered With This");
                    reader.Close();
                    return false;
              }
               
            
            
        }
        public Details Get(string email)
        {
            Details details = new Details();
            using SqlConnection connect = new SqlConnection(connection);
            connect.Open();

            string query = $@" select TraineeId from TraineeDetails where EmailId = '{email}'; ";
            SqlCommand command = new SqlCommand(query, connect);
            int TrainId = Convert.ToInt32(command.ExecuteScalar());
            string query4 = $@" select * from TraineeDetails  where Traineeid = '{TrainId}'; ";
            SqlCommand command0 = new SqlCommand(query4, connect);
            string query5 = $@"select * from Skills where TraineeId = '{TrainId}';";
            SqlCommand command1 = new SqlCommand(query5, connect);
            string query6 = $@"select *from EducationalDetails where TraineeId = '{TrainId}';";
            SqlCommand command2 = new SqlCommand(query6, connect);
            string query7 = $@"select 8from CompanyDetails where TraineeId = '{TrainId}';";
            SqlCommand command3 = new SqlCommand(query7, connect);
            command.ExecuteNonQuery();
            command1.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            command3.ExecuteNonQuery();


            return details; 
            //throw new NotImplementedException();
        }

        public void Tupdate(string TableName, string ColumnName, string Newvalue , string email)
        {
            using SqlConnection connect = new SqlConnection(connection);
            connect.Open();
            string query = $@" select TraineeId from TraineeDetails where EmailId = '{email}'; ";
            SqlCommand command = new SqlCommand(query, connect);
            int TrainId = Convert.ToInt32(command.ExecuteScalar());
            Console.WriteLine(TrainId);
            string query1 = $@" update {TableName} set  {ColumnName} = '{Newvalue}' where  TraineeId='{TrainId}'";
            SqlCommand command1 = new SqlCommand(query1, connect);
            command1.ExecuteNonQuery();

            Console.WriteLine("Details Updated Successfully");
            
        }
        public void TDelete( string TableName, string ColumnName, string email)
        {
            using SqlConnection connect = new SqlConnection(connection);
            connect.Open();
            string query = $@" select TraineeId from TraineeDetails where EmailId = '{email}'; ";
            SqlCommand command = new SqlCommand(query, connect);
            int TrainId = Convert.ToInt32(command.ExecuteScalar());
            Console.WriteLine(TrainId);
            string query1 = $@" Delete from {TableName} set {ColumnName}= 'Null'  where  TraineeId='{TrainId}';";
            SqlCommand command1 = new SqlCommand(query, connect); 

            Console.WriteLine("Details Updated Successfully");

        }
    }
}

        
                
            
            
                


