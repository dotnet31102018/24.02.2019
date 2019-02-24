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
            
            Person p1 = new Person("Dannaa", "Shovevany");

            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Person));

            using (Stream file = new FileStream(@"c:\temp\xmlfile.xml", FileMode.Create)) // creating new file stream
            {
                myXmlSerializer.Serialize(file, p1);

            } //closing file stream
            

            Person p2;

            //XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Person));

            using (Stream file = new FileStream(@"c:\temp\xmlfile.xml", FileMode.Open)) // creating new file stream
            {
                p2 = myXmlSerializer.Deserialize(file) as Person;

            } //closing file stream

            /*
            // --------------------- Array
            Person[] pArray =
            {
                new Person("number 1", "the best!"),
                new Person("zehavi", "python"),
                new Person("bond", "java"),
                new Person("james", "c#")

            };

            XmlSerializer myXmlSerializerArray = new XmlSerializer(typeof(Person[]));

            using (Stream file = new FileStream(@"c:\temp\xmlarrayfile.xml", FileMode.Create)) // creating new file stream
            {
                myXmlSerializerArray.Serialize(file, pArray);

            } //closing file stream
            

            Person[] p2Array;

            using (Stream file = new FileStream(@"c:\temp\xmlarrayfile.xml", FileMode.Open)) // creating new file stream
            {
                p2Array = myXmlSerializerArray.Deserialize(file) as Person[];

            } //closing file stream

    */
            Console.WriteLine();
        }
    }
}

