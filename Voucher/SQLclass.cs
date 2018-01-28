using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Voucher
{
    class SQLclass
    {
        public SQLclass(String server, String database) {
            this.server = server;
            this.database = database;
            SQLclass.connection = new SqlConnection("Server = " + server + "; Database = " + database + "; User Id = sa; Password = 12345;");
        }
        public String getserver() {
            return this.server;
        }
        public String getdatabase()
        {
            return this.database;
        }
        private String server;
        private String database;
        public static SqlConnection connection;
    }
}
