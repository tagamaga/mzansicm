using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mzansi.Models
{
    public class Commission
    {
        public int CommissionID { get; set; }
        public int DonationID { get; set; }
        public int UserID { get; set; }
        public decimal CommissionAmount { get; set; }
        public DateTime CommissionDate { get; set; }
        
    }
}