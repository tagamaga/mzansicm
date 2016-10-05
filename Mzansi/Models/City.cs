using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mzansi.Models
{
    public class City
    {
        public int CityID { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }

        public int RegionID { get; set; }
        public virtual Region Regions { get; set; }

        public bool CityActive { get; set; }
    }
}