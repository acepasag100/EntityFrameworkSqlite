namespace EntityFrameworkSqlite
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using(var database = new PersonContext())
            {
                /*database.Add(new Person()
                {
                    Name = "Ace"
                });
                */
                database.Add(new Table_Three()
                {
                    Name = "Ace"
                });
                database.SaveChanges();
            }

            Console.WriteLine("Done");
        }
    }
}

/* Note: Install the following NuGet Package
 * 1. Microsoft.EntityFrameworkCore.Sqlite
 * 2. Microsoft.EntityFrameworkCore.Tools
 */
