using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpContract
{
    internal interface IEmpContract
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpDes { get; set; }
        public void WorkHours();
        public void NoProjectDisclosure();
        public void WearIDTag();
    }
}
