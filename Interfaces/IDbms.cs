using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IDbms
    {
        public string SqlLanguage { get; set; }
        public string DbInstance { get; set; }
        public string QuerySchema { get; set; }
        public string LicenseKey { get; }
        public bool CreateDb(string name);
        public bool DeleteDb(string name);
    }
}
