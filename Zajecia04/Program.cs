using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajecia04.Model;

namespace Zajecia04
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                db.Database.Log = Console.WriteLine;

                var q = (from n in db.People select n).ToList();

                foreach (var item in q)
                {
                    Console.WriteLine("{0}, {1}", item.FirstName,
                        (item is Student) ? (item as Student).CardNumber : (item as Teacher).Degree.ToString());
                }
               db.Schools.Add(new School { 
                    Name = "ATH",
                    People = new List<Person> {
                        new Teacher{
                            FirstName = "Antoni",
                            LastName = "Kowalski",
                            Degree = eDegree.Msc
                        },
                        new Teacher{
                            FirstName = "Mariola",
                            LastName = "Nowak",
                            Degree = eDegree.Doctor
                        },
                        new Student {
                            FirstName = "Dawid",
                            LastName = "Nowak",
                            CardNumber = "123456"
                        },
                        new Student {
                            FirstName = "Jan",
                            LastName = "Kowal",
                            CardNumber = "23456"
                        
                        }
                    }
                });

                db.SaveChanges();
            }
        }
    }
}
