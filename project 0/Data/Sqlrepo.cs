using System;
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
        private readonly string? connectionstring;
        public Sqlrepo(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }
        public Details Add(Details details)
        {
            using SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();

            string query = @"insert into TraineeDetails(FullName, EmailId, Gender, Age, PhoneNumber) values (@FullName, @EmailId, @Gender, @Age, @PhoneNumber)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FullName", details.FullName);
            command.Parameters.AddWithValue("@EmailId", details.EmailId);
            command.Parameters.AddWithValue("@Gender", details.Gender);
            command.Parameters.AddWithValue("@Age", details.Age);
            command.Parameters.AddWithValue("@PhoneNumber", details.Phonenumber);
            command.ExecuteNonQuery();

            string query1 = @"insert into Educationaldetails(HQualification, yearOfPassing, Percentage, Stream, UG) values (@HQualification, @YearofPassing, @Percentage, @Stream, @UG)";

            SqlCommand command1 = new SqlCommand(query1, connection);
            command1.Parameters.AddWithValue("@HQualification", details.HighestQualification);
            command1.Parameters.AddWithValue("YearOfPassing", details.PassingYear);
            command1.Parameters.AddWithValue("Percentage", details.Percentage);
            command1.Parameters.AddWithValue("Stream", details.Stream);

            command1.ExecuteNonQuery();

            string query2 = @"insert into Companydeatails(CompanyName, ProjectName, Position, Experience) values (@CompanyName, @ProjectName, @Position, @Experience)";

            SqlCommand command2 = new SqlCommand(query2, connection);
            command2.Parameters.AddWithValue("@companyName", details.CompanyName);
            command2.Parameters.AddWithValue("@ProjectName", details.ProjectName);
            command2.Parameters.AddWithValue("@Position", details.Position);
            command2.Parameters.AddWithValue("@Experience", details.Experience);
            command2.ExecuteNonQuery();

            string query3 = @"insert into Skills(SkillName, SkillType, Expertise) values (@SkillName, @SkillType, @Expertise)";

            SqlCommand command3 = new SqlCommand(query3, connection);
            command3.Parameters.AddWithValue("@SkillName", details.SkillName);
            command3.Parameters.AddWithValue("@SkillType", details.SkillType);
            command3.Parameters.AddWithValue("@Expertise", details.Expertise);
            command3.ExecuteNonQuery();

            Console.WriteLine("All the Rows Added Successfully");
            Console.ReadLine();

            return details;
        }
        public void DeleteTrainer(string EMail)
        {
            throw new NotImplementedException();
        }

        public Details GetAllTrainer(string email)
        {
            Details detail = new Details();
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            List<Details> details = new List<Details>();

            try
            {
                string query4 = @"Select TraineeDetails.TraineeId, TraineeDetails.FullName, TraineeDetails.EmailId, TraineeDetails.Gender,TraineeDetails.Age, TraineeDetails.PhoneNumber,
                         EducationalDetails.EducationId, EducationalDetails.HQualification, EducationalDetails.YearOfPassing, EducationalDetails.Percentage, EducationalDetails.Stream, 
                          Skills.SkillId, Skills.SkillType, Skills.Expertise
                           Companydeatails.CompanyId, Companydeatails.CompanyName, Companydeatails.ProjectName, Companydeatails.Position, Companydeatails.Experience From TrainerDetails
                            join EducationalDetails on TrainerDetails.TrainerId = EducationalDetails.EducationId
                                   join Skills on EducationalDetails.EducationId = Skills.SkillID
                                   join company on Skills.SkillID = CompanyId where TraineeDetails.Email = email;";

                SqlCommand command = new SqlCommand(query4, con);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    details.Add(new Details()
                    {
                        TraineeId = reader.GetInt32(0),
                        FullName = reader.GetString(1),
                        EmailId = reader.GetString(2),
                        Gender = reader.GetString(3),
                        Age = reader.GetString(4),
                        Phonenumber = reader.GetString(5),
                        EducationalId = reader.GetInt32(6),
                        HighestQualification = reader.GetString(7),
                        PassingYear = reader.GetString(8),
                        Percentage = reader.GetString(9),
                        Stream = reader.GetString(10),
                        SkillId = reader.GetInt32(11),
                        SkillName = reader.GetString(12),
                        SkillType = reader.GetString(13),
                        Expertise = reader.GetString(14),
                        CompanyId = reader.GetInt32(15),
                        CompanyName = reader.GetString(16),
                        ProjectName = reader.GetString(17),
                        Experience = reader.GetString(18),
                    });
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                System.Console.WriteLine(ex.Message);
                throw;
            }
            return detail;
        }
        public List<Details> GetAllTrainersDisconnected()
        {
            List<Details> details = new List<Details>();

            SqlConnection con = new SqlConnection(connectionstring);

            string query5 = @"select TraineeDetails.TraineeId, TraineeDetails.FullName, TraineeDetails.EmailId, TraineeDetails.Gender, TraineeDetails.Age, TraineeDetails.PhoneNumber,
                            EducationalDetails.EducationId, EducationalDetails.HQualification, EducationalDetails.YearOfPassing, EducationalDetails.Percentage, EducationalDetails.Stream,
                            Skills.SkillId, Skills.SkillName, Skill.Type, Skills.Expertise
                            Companydeatails.CompanyId, Companydeatails.CompanyName, Companydeatails.ProjectName, Companydeatails.Position, Companydeatails.Experience From TrainerDetails
                             join EducationalDetails.EducationId = Skills.SkillID
                             joinCompany on Skills.SkillID = CompanyId;";
            SqlDataAdapter adapter = new SqlDataAdapter(query5, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            DataTable dtTrainer = ds.Tables[0];

            foreach (DataRow row in dtTrainer.Rows)
            {
                details.Add(new Details()
                {
                    FullName = (string)row["Name"],
                    EmailId = (string)row["EmailID"],
                    Gender = (string)row["Gender"],
                    Age = (string)row["Age"],
                    Phonenumber = (string)row["Phonenumber"],
                    HighestQualification = (string)row["HighighestQualification"],
                    PassingYear = (string)row["PassingYear"],
                    Percentage = (string)row["Percentage"],
                    Stream = (string)row["Stream"],
                    SkillName = (string)row["SkillName"],
                    SkillType = (string)row["SkillType"],
                    Expertise = (string)row["Expertise"],
                    CompanyName = (string)row["CompanyName"],
                    ProjectName = (string)row["ProjectName"],
                    Experience = (string)row["Experience"],
                });
            }
            return details;
        }
        public bool login(string Email)
        {
            string query6 = $"select Email from TraineDetails where Email='{Email}';";
            using SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand command1 = new SqlCommand(query6, con);

            SqlDataReader reader = command1.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                Console.Write("Enter your password: ");
                string? password = System.Console.ReadLine();
                string query7 = $"select Email from Trainer where Password='{password}';";
                SqlCommand command2 = new SqlCommand(query7, con);
                using SqlDataReader read1 = command2.ExecuteReader();
                if (read1.Read())
                {
                    Console.WriteLine("Login Successfully");
                    Console.ReadLine();
                    return true;
                }
                else
                {
                    Console.WriteLine("Wrong Password");
                    read1.Close();
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Data Not found");
                Console.ReadLine();
                return false;
            }
        }
    }
}

        
                
            
            
                


