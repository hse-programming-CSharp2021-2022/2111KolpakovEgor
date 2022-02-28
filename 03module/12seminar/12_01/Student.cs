using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _12_01
{
    [Serializable]
    public class Student
    {
        [JsonInclude]
        public string SurName { get; set; }
        [JsonInclude]
        public int CourseNumber { get; set; }
        
        public Student(string surName, int courseNumber)
        {
            SurName = surName;
            CourseNumber = courseNumber;
        }
        public Student() { }
    }
}
