using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomControllerSample.Extension
{
    public class AutoControllerDbContext
    {
        public string ConnectionString { get; set; }
        public Type ContextType { get; set; }
    }

    //private bool IsConnectionStringInConfiguration(string connectionStringName)
    //{
    //    var connectionStringSetting = ConfigurationManager.ConnectionStrings[connectionStringName];

    //    return connectionStringSetting != null;
    //}
}
