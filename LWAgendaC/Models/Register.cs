using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LWAgendaC.Models
{
        public class Register
        {
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
            public string LastName { get; set; }
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }
            [Required, DataType(DataType.PhoneNumber)]
            public string Number { get; set; }
            public string NType { get; set; }
        }

}