using Medfar.Interview.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medfar.Interview.Web.Models
{
    public class ExampleViewModel: User
    {        

    public ExampleViewModel()
        {
            Users = new List<User>();

        }       
        public List<User> Users { get; set; }
        


    }
}