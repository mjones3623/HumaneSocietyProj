using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run Employee Query Test
            //HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            //Employee employee = db.Employees.FirstOrDefault(a => a.EmployeeId == 1);
            //Query.RunEmployeeQueries(employee, "read");


            //Run Add Animal Test
            //HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            //Animal animal = db.Animals.FirstOrDefault(a => a.EmployeeId == 1);
            //Query.AddAnimal(animal);

            //Query.GetAnimalByID(1);
            //Query.GetRoom(5);
           
            //.csv file import
            var animals = Query.ProcessCSV("animals.csv");
            foreach (var animal in animals)
            {

                Query.AddAnimal(animal);

            }

            //PointOfEntry.Run();

        }

       
        
        
    }
}
