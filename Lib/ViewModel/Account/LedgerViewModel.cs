using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Viewmodel.Account
{
    public class LedgerViewModel
    {
        public int ID { get; set; }
        public int? serial { get; set; }
        public string Hash { get; set; }
        public string VoucherID { get; set; }
        public string VoucherType { get; set; }
        public string AccountID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Narration { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<decimal> Balance { get; set; }
        //////////////////////
    //    public DAL.tblLevel4 Account { get; set; }
    }
}
