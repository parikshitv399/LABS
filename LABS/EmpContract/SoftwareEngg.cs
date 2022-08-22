﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpContract
{
    internal class SoftwareEngg : IEmpContract
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpDes { get; set; }
        public void WorkHours()
        {
            Console.WriteLine($"\nThe fixed work hours for [{EmpName} - {EmpID}] are 8 hours excluding 1 hour lunch\n");
        }
        public void NoProjectDisclosure()
        {
            Console.WriteLine($"\nThe employee's Designation is {EmpDes}. Therefore, they are supposed to dissolve the shares of organizations who are currently clients of KPMG. However, they don't need to register their investments on platform.\n");
        }
        public void WearIDTag()
        {
            Console.WriteLine("\nWearing the issued ID is important!\n");
        }
    }
}
