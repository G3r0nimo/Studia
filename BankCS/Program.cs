using BankCS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCS
{



    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Witaj w uberaplikacji bankowej");
            Console.WriteLine("Wybierz dzialanie: 1 - utworz konto, 2 - sprawdz konto");
            var x = Console.ReadKey();
            var xn = Convert.ToInt32(x);
            switch (xn)
            {
                case 1:
                    {
                        Console.WriteLine("TEXT");
                        
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("X");
                        break; 
                    }

                default:
                    Console.WriteLine("Niepoprawna opcja");
                    break;
            }


            using (var db = new AccountContext())
            {
              //  db.Database.Log = Console.WriteLine;

                var q = (from n in db.People select n).ToList();

                foreach (var item in q)
                {
                 /*   Console.WriteLine("{0}, {1}", item.FirstName,
                        (item is Person) ? (item as Person).CardNumber : (item as Teacher).Degree.ToString());
               */
                  }
                db.Accounts.Add(new Account
                {
                    Name = "8975",
                    People = new List<Person> {
                        new Person{
                            FirstName = "Antoni",
                            LastName = "Kowalski",
                            PESEL = 12345
                        },
                       
                      /*  new Account {
                            FirstName = "Jan",
                            LastName = "Kowal",
                            CardNumber = "23456"

                        } */
                    }
                });

                db.SaveChanges();
            }
        }
    }
}
