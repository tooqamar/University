using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.ViewModel
{
    public class VMStockByTile
    {
        public long id { set; get; }
        public string itemname { set; get; }
        public string itemcode { set; get; }

        public decimal inqty { set; get; }
        public decimal outqty { set; get; }
        public decimal balance { set; get; }
      

    }
}
