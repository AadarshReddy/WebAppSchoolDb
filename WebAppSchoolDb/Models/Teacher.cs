using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppSchoolDb.Models
{
    [Table("Teacher")]
    public class Teacher
    {
        [Key]
        public int TId { get; set; }

        public string TName { get; set; }

        public string Tsubject { get; set; }

    }
}