using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mzansi.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }

        public int TownID { get; set; }
        public virtual Town Towns { get; set; }

        public bool LocationActive { get; set; }


    }
}