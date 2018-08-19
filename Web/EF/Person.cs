﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreInheritance.EF
{
    public abstract class Person
    {
        [Key]
        public int Id { get; set; }

        public int Type { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public int Age { get; set; }
    }

    [NotMapped]
    public class Student : Person
    {
        [MaxLength(50)]
        public string PersonalEmail { get; set; }
    }

    [NotMapped]
    public class Instructor : Person
    {
        [MaxLength(50)]
        public string BusinessEmail { get; set; }
    }
}