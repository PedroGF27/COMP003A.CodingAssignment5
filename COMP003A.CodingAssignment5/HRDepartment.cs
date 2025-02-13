using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.CodingAssignment5
{
    internal class HRDepartment : Department
    {
        public override void GetDepartmentDetails()
        {
            Console.WriteLine("Handles employee relations and recruitment.");
        }
    }
}
