using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mzansi.Models
{
    public class BankBranch
    {
        public int BankBranchID { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string BranchInfo { get; set; }

        public int BankID { get; set; }
        public virtual Bank Banks { get; set; }

        public int LocationID { get; set; }
        public virtual Location Locations { get; set; }

        public bool BranchActive { get; set; }
    }
}