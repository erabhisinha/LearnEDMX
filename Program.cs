using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyEntities dummyEntities = new DummyEntities();
            dummyEntities.Students.Add(new Student { LastName="Sinha", FirstMidName = "Kr", EnrollmentDate = DateTime.Today});
            dummyEntities.SaveChanges();
        }
    }
}
