using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCS.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }

    public class Client
    {
        public void Add(string nazwa, string imie, string nazwisko, int pesel)
        {
            using (var db = new AccountContext())
            {

                var q = (from n in db.People select n).ToList();
                db.Accounts.Add(new Account
                {
                    Name = nazwa,
                    People = new List<Person>
                    {
                        new Person
                        {
                            FirstName = imie,
                            LastName = nazwisko,
                            PESEL = pesel
                        },
                    }
                });

                db.SaveChanges();
            }
        }

        public void Show(string nazwisko, int pesel)
        {
            using (var db = new AccountContext())
            {
                var q = (from n in db.People where n.PESEL == pesel && n.LastName == nazwisko select n).ToList();

                foreach (var item in q)
                {
                    Console.WriteLine("{0}-{1} {2} {3}", item.Id, item.FirstName, item.LastName, item.PESEL);
                }
            }
        }
    }

}
