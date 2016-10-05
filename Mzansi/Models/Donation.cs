using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mzansi.Models
{
    public class Donation
    {
        public int DonationID { get; set; }

        public int UserID { get; set; }
        public virtual mcmUser Users { get; set; }

        public DateTime DonationDate { get; set; }
        public decimal DonationAmount { get; set; }
        public int DonationPeriod { get; set; }
        public decimal InterestRate { get; set; }
        public decimal DonationInterest { get; set; }
        public decimal DonationAtMaturity { get; set; }

        public bool DonationAssigned { get; set; }
        public int DonationAssignedBy { get; set; }
        public DateTime DonationAssignedDate { get; set; }
        public int DonationAssignedTo { get; set; }
        public bool DonationCancelled { get; set; }
        public int DonationCancelledBy { get; set; }
        public DateTime DonationCancelledDate { get; set; }
        public bool DonationPaid { get; set; }
        public string DonationPoPFilename { get; set; }
        public DateTime DonationPaidDate { get; set; }
        public bool DonationConfirmed { get; set; }
        public int DonationConfirmedBy { get; set; }
        public DateTime DonationConfirmedDate { get; set; }
        public bool DonationDisputed { get; set; }
        public int DonationDisputedBy { get; set; }
        public DateTime DonationDisputedDate { get; set; }
        public bool DonationDeclined { get; set; }
        public int DonationDeclinedBy { get; set; }
        public DateTime DonationDeclinedDate { get; set; }
    }
}