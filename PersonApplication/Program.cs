using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Persons (collecion)
            Persons myFriends = new Persons();

            // create a few Person objects
            Person person1 = new Person
            {
                Firstname = "Kirsi",
                Lastname = "Mainio",
                SocialSecurityNumber = "123123-123"
            };
            Person person2 = new Person
            {
                Firstname = "Matti",
                Lastname = "Huuso",
                SocialSecurityNumber = "321321-321"
            };
            Person person3 = new Person
            {
                Firstname = "Teppo",
                Lastname = "Taistelija",
                SocialSecurityNumber = "121212-121"
            };

            // add Person objecs to Persons (myFriends)
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // get one person
            Person person4 = myFriends.GetPerson(10);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            } else
            {
                Console.WriteLine("There is no person at that position!");
            }

            // print collction
            myFriends.PrintData();

            // find person
            string SocialSecurityNumber = "123123-123";
            Console.WriteLine("Find person with Socialsec.. :" + SocialSecurityNumber);
            Person person5 = myFriends.FindPerson(SocialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            } else
            {
                Console.WriteLine("Can't find person with that Socialsec..");
            }
        }
    }
}
