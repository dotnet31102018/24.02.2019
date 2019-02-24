using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _2402XMLSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Person p1 = new Person("Dannaa", "Shovevany");

            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Person));

            using (Stream file = new FileStream(@"c:\temp\xmlfile.xml", FileMode.Create)) // creating new file stream
            {
                myXmlSerializer.Serialize(file, p1);

            } //closing file stream
            */

            Person p2;

            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Person));

            using (Stream file = new FileStream(@"c:\temp\xmlfile.xml", FileMode.Open)) // creating new file stream
            {
                p2 = myXmlSerializer.Deserialize(file) as Person;

            } //closing file stream
            Console.WriteLine();
        }
    }
}
