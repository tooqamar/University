using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Viewmodel.Account
{
    public class TrialBalanceViewModel
    {
        public string AccountID { get; set; }
        public string AccountTitle { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? ClosingBalance { get; set; }
    }
}
