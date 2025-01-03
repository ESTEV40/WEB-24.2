using System;

namespace UescColcicAPI.Core
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; }
        public int Registration { get; set; }
        public string Course { get; set; }
        public string Bio { get; set; }

        public int? UserID_FK { get; set; }
        public User user { get; set;}
    }
}