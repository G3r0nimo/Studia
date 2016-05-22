using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajecia3.Model;
using System.Data.Entity;


namespace Zajecia03
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory",
                AppDomain.CurrentDomain.BaseDirectory);


            using (var db = new CompanyContext())
            {

                db.Database.Log = Console.WriteLine;
                //db.Database.Log=n=>Console.WriteLine(n);
                db.Configuration.LazyLoadingEnabled = false;

                var query = (from n in db.TeamMembers.Include(n => n.Team) select n).ToList();
                foreach (var member in query)
                {
                    Console.WriteLine("Member Name {0} m Team: {1} ", member.FirstName, member.Team.Name);
                }

                string firstName = db.TeamMembers.First().FirstName;
                Console.WriteLine(firstName);

                db.Team.Add(new Team
                {
                    Name = "ATH",
                    TeamMembers = new List<TeamMember>
                   {
                        new TeamMember {FirstName="Jan", MemberType=eMemberType.Programmer },
                        new TeamMember {FirstName="Maria", MemberType=eMemberType.ProjectOwner }
                   }
                });
                db.Team.Add(new Team
                {
                    Name = "Eksperci",
                    TeamMembers = new List<TeamMember>
                 {
                        new TeamMember {FirstName="Zbyszek",MemberType=eMemberType.ProjectOwner },
                       new TeamMember {FirstName="Adam",MemberType=eMemberType.ScrumMaster }

                   }
                });
                db.SaveChanges();
            }
        }
    }
}