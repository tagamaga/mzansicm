﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mzansi.Models
{
    public class Bank
    {
        public int BankID { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankInfo { get; set; }
        public bool BankActive { get; set; }
    }
}