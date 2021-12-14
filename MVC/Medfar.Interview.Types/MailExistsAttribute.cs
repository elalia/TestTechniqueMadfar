using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;

namespace Medfar.Interview.Types
{
    public class MailExistsAttribute : ValidationAttribute
    {
        private static string _connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MEDFAR_DEV_INTERVIEW;User id=sa;Password=AliaEts;Integrated Security=True";
        private static SqlConnection _dbConnection;
        public override bool IsValid(object value)
        {            
            List<string> mail = new List<string>();           
            mail = GetAllMail();
            if (mail.FirstOrDefault(m => m == (string)value) == null)
                return true;
            else
                return false;
        }

        private List<string> GetAllMail()
        {
            _dbConnection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand("SELECT email FROM Users", _dbConnection);

            _dbConnection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<string> emails = new List<string>();           
            while (reader.Read())
            {
                emails.Add(reader["email"].ToString());
            }
            return emails;
        }
    }
}