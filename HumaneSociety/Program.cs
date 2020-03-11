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

            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            Employee employee = db.Employees.FirstOrDefault(a => a.EmployeeId == 1);
            Query.RunEmployeeQueries(employee, "read");
            //PointOfEntry.Run();

        }
    }
}
