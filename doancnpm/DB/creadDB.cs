using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using codefirt;
using doancnpm;
using doancnpm.DB;

namespace codefirt
{
    public class creadDB : CreateDatabaseIfNotExists<Model2>
    {
        protected override void Seed(Model2 context)
        {
        }

    }
}