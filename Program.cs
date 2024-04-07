using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

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

                //var per_Delete = database.Persons.First(a => a.Id == 6);
                //database.Persons.Remove(per_Delete);

                //database.SaveChanges();

                //var table_person = database.Persons.First();
                //Console.WriteLine(table_person.Id + "-" + table_person.Name);
                /*
                List<string> names = new List<string>() 
                {
                    "Janine Jacobs",
                    "Verna Ramos", 
                    "Noreen Bowers",
                    "Darell Phelps",
                    "Harold Wolfe",
                    "Octavio Merritt",
                    "Brent Frank",
                    "Morgan Colon",
                    "Greg Haas",
                    "Isabella Carney",
                    "Jennie Sellers",
                    "Clyde Floyd",
                    "Mayra Austin",
                    "Mallory Guerrero",
                    "Estela Fowler",
                    "Omer Francis",
                    "Stefanie Hopkins",
                    "Reuben Clark",
                    "Jana Mcpherson",
                    "Chris Humphrey",
                    "Nadia Huber",
                    "Justin Pittman",
                    "Barry Espinoza",
                    "Angeline Keys",
                    "Fred Johns",
                    "Jacklyn Boone",
                    "Tad Garcia",
                    "Wayne Roman",
                    "Philip Robinson",
                    "Chase Pugh",
                    "Truman Gaines",
                    "Roslyn Christensen",
                    "Michele Miles",
                    "Minnie Estes",
                    "Marguerite Cruz",
                    "Marianne Everett",
                    "Irma Ruiz",
                    "Arden Dunn",
                    "Herschel Bass",
                    "Shelley Soto",
                    "Augusta Bird",
                    "Diann Schroeder",
                    "Roxanne Roberts",
                    "Dante Logan",
                    "Lenora Shepard",
                    "Kellie Kline",
                    "Lyman Caldwell",
                    "Humberto French",
                    "Perry Prince",
                    "Enrique Oneal"
                };

                foreach(var item in names)
                {
                    database.Add(new Person()
                    {
                        Name = item
                    });
                }
                database.SaveChanges();
                */

                //Search function
                //var search = database.Persons.Where(a => a.Id == 3);

                //var search = database.Persons.Find(70);
                //Console.WriteLine($"{search.Id}-{search.Name}");

                /*var search = database.Persons.ToList();
                //var search = database.Persons;
                foreach (var item in search)
                {
                    Console.WriteLine($"{item.Id}-{item.Name}");
                }*/

                //var search = database.Persons.OrderBy(x => x.Name);
                //var search = database.Persons.OrderByDescending(x => x.Name);


                var search = database.Persons.Where(x => EF.Functions.Like(x.Name, "%el%")).ToList();
                foreach (var item in search)
                {
                    Console.WriteLine($"{item.Id}-{item.Name}");
                }
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

//https://www.learnentityframeworkcore.com/dbset/querying-data