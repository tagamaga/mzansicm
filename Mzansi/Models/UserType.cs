using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mzansi.Models
{
    public class UserType
    {
        public int UserTypeID { get; set; }
        public string UserTypeCode { get; set; }
        public string UserTypeName { get; set; }
        public string UserTypeInfo { get; set; }
        public bool UserTypeActive { get; set; }
    }
}