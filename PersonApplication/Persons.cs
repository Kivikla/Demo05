using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Persons
    {
        // persons collection stores person objects
        private List<Person> persons;

        public Persons()
        {
            persons = new List<Person>();
        }

        /// <summary>
        /// Add person to collection
        /// </summary>
        /// <param name="person">person to add</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public Person GetPerson(int index)
        {
            if (index < persons.Count) return persons.ElementAt(index);
            else return null;
        }

        public Person FindPerson(string SocialSecurityNumber)
        {
            foreach(Person person in persons)
            {
                // compare two strings
                if (SocialSecurityNumber.Equals(person.SocialSecurityNumber))
                {
                    return person;
                }
            }
            return null; // person with search socialsec... not found in collection
        }

        public void PrintData()
        {
            foreach(Person person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
