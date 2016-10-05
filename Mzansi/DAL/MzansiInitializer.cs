using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Mzansi.Models;

namespace Mzansi.DAL
{
    public class MzansiInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MzansiContext>
    {
        protected override void Seed(MzansiContext context)
        {

        }
    }
}