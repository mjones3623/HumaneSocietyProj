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
<<<<<<< HEAD
            //Admin admin = new Admin();

            //admin.LogIn();

            //PointOfEntry.Run();
=======
            //PointOfEntry.Run();
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            Employee employee = db.Employees.FirstOrDefault(a => a.EmployeeId == 1);
            Query.RunEmployeeQueries(employee, "read");
>>>>>>> 33947ef95e6ce33aa7c366fe8e534fa716510b79
        }
    }
}
