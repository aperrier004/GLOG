using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exporteur
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple program demonstrating how to use NHibernate to create the DB schema

            Console.WriteLine("Exporting DB schema... ");

            Configuration cfg = new Configuration();
            cfg.Configure();
            // Update database according to mapping files and DB credentials
            new SchemaExport(cfg).Execute(true, true, false);

            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
