using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;


namespace doancnpm
{
    public class creadDB : CreateDatabaseIfNotExists<Model4>
    {
        protected override void Seed(Model4 context)
        {
         
        }

    }
}