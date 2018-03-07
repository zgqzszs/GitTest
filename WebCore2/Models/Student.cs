using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebCore2.Models
{
    public class Student
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Range(1, 100)]
        public string Age { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        public void Aafaf()
        {
            
        }
    }
}
