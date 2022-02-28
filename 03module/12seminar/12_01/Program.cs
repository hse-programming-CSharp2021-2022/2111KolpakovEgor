using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace _12_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Ivanov", 1));
            students.Add(new Student("Petrov", 3));
            students.Add(new Student("Sidorov", 4));
            students.Add(new Student("Sobolev", 2));

            Group studentGroup = new Group("БПИ2111", students);

            BinaryFormatter binFormatter = new BinaryFormatter();

            using(FileStream fileStream = new FileStream ("student.txt", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(fileStream, studentGroup);
            }

            using (FileStream fileStream = new FileStream("student.txt", FileMode.OpenOrCreate))
            {
                Group group = (Group)binFormatter.Deserialize(fileStream);
                Console.WriteLine(group);
            }


            XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(Group));

            using (FileStream file = new FileStream("groupXML.txt", FileMode.OpenOrCreate))
            {
                xmlSerializer2.Serialize(file, studentGroup);
            }

            using (FileStream file = new FileStream("groupXML.txt", FileMode.OpenOrCreate))
            {
                Group group = (Group)xmlSerializer2.Deserialize(file);
                Console.WriteLine(group);
            }

            string json = JsonSerializer.Serialize(studentGroup);

            using (FileStream file = new FileStream("groupJSON.txt", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync(file, studentGroup);
            }
            using (FileStream file = new FileStream("groupJSON.txt", FileMode.OpenOrCreate))
            {
                var personFile = JsonSerializer.DeserializeAsync<Group>(file);
                Console.WriteLine(personFile);
            }
        }
    }
}
