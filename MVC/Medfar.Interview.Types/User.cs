using System;
using System.ComponentModel.DataAnnotations;


namespace Medfar.Interview.Types
{
    public class User
    {
        public Guid id { get; set; }
        
        [Required] public string first_name{ get; set; }
        [Required] public string last_name { get; set; }

        [EmailAddress][MailExists] public string email { get; set; }
        public DateTime date_created{ get; set; }

    }
}
