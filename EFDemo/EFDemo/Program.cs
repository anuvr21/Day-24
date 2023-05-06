using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Insert Data
           /* using (var context = new Assignment2Entities())
            {
                var std = new Client_Master()
                {
                    ClientNo= "C00002",
                    Name = "Bill",
                    Address1 = "123 street",
                    Address2="abc street",
                    City="Kochi",
                    State="Kerala",
                    BalDue=40000,
                    Phone_No=9876543210
                };
                context.Client_Master.Add(std); 
                context.SaveChanges();
            }

            //Update Data
            using (var context = new Assignment2Entities())
            {
                var std = context.Client_Master.First<Client_Master>();
                std.Name = "Steve";
                context.SaveChanges();
            }

            //Update data in a particular row
            using (var ctx = new Assignment2Entities())
            {
                var student = ctx.Client_Master
                                .Where(s => s.Name == "Bill")
                                .FirstOrDefault<Client_Master>();
            } */

            //Deleting Data
            using (var context = new Assignment2Entities())
            {
                var std = context.Client_Master.First<Client_Master>();
                context.Client_Master.Remove(std);

                context.SaveChanges();
            }
        }
    }
}
