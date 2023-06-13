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
            var newItem = new Items { ItemName = "Dummy Item" };
            dummyEntities.Items.Add(newItem);
            dummyEntities.SaveChanges();
            var allItems = dummyEntities.Items.Select(x => x);
            dummyEntities.Students.Add(new Student { LastName = "Sinha1", FirstMidName = "Kr", EnrollmentDate = DateTime.Today });
            dummyEntities.SaveChanges();
        }
    }
}
