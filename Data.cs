using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oimo
{
    public class OutData
    {
        public string? token { get; set; }
        public string account_number { get; set; }
        public string? refill_date_time { get; set; }
        public double? amount { get; set; }
        public string action { get; set; }

        public IEnumerator GetEnumerator() => this.GetEnumerator();
    }

    public class GetData
    {
        public bool success { get; set; }
        public string message { get; set; }
    }

   
}
