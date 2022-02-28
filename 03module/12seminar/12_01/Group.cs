using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _12_01
{
    [Serializable]
    public class Group
    {
        [JsonInclude]
        public string GroupName { get; set; }
        [JsonInclude]
        public List<Student> Students { get; set; } = new List<Student>();
        public Group(string groupName, List<Student> students)
        {
            GroupName = groupName;
            Students = students;
        }
        public Group() { }
        public override string ToString()
        {
            string res = "";
            foreach (var student in Students)
                res += GroupName + " " + student.SurName + " " + student.CourseNumber + "\n";
            return res;
        }
    }
}
