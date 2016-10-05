using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mzansi.Models
{
    public class Town
    {
        public int TownID { get; set; }
        public string TownCode { get; set; }
        public string TownName { get; set; }
        public string PostalCode { get; set; }

        public int CityID { get; set; }
        public virtual City Cities { get; set; }

        public bool TownActive { get; set; }
    }
}