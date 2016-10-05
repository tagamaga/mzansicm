using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mzansi.Models
{
    public class mcmUser
    {
        public int mcmUserID { get; set; }

        public int UserTypeID { get; set; }
        public virtual UserType UserTypes { get; set; }


        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        public string Cellphone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int RegionID { get; set; }
        public virtual Region Regions { get; set; }

        public int BankID { get; set; }
        public virtual Bank Banks { get; set; }

        public int BankBranchID { get; set; }
        public virtual IList<BankBranch> BankBranches { get; set; }

        public int ReferredByID { get; set; }
        public virtual IList<mcmUser> Users { get; set; }

        public bool UserActive { get; set; }

    }
}