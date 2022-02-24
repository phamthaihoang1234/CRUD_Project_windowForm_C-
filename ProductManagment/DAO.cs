using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagment
{
    internal class DAO
    {
        public SqlConnection connect = null;
        public SqlCommand command = null;
        public SqlDataReader reader = null;
        public string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",true,true)
                .Build();
            return config["ConnectionStrings:ProductDB"];
        }
    }
}
