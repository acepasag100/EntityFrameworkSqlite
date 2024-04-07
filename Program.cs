using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkSqlite
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using(var database = new PersonContext())
            {
                /*var per = new Person()
                {
                    Name = "John"
                };
                database.Persons.Add(per);

                var pers = new List<Person>()
                {
                    new Person() {Name = "Vic"},
                    new Person() {Name = "Gordon"},
                    new Person() {Name = "Emz"}
                };
                database.AddRange(pers);
                database.Add(new Person()
                {
                    Name = "Jonalyn"
                });*/

                /*
                database.Add(new Table_Three()
                {
                    Name = "Ace"
                });*/

                /*var per = database.Persons.First<Person>(); // First Record
                 * per.Name = "Ace Pasag";
                 */

                //var per_Update = database.Persons.First(a => a.Id == 2);
                //per_Update.Name = "Jonalyn Opino";

                var per_Delete = database.Persons.First(a => a.Id == 6);
                database.Persons.Remove(per_Delete);

                database.SaveChanges();

                //for (int i = 0; )
            }

           // List Data

            Console.WriteLine("Done");
        }
    }
}

/* Note: Install the following NuGet Package
 * 1. Microsoft.EntityFrameworkCore.Sqlite
 * 2. Microsoft.EntityFrameworkCore.Tools
 */
