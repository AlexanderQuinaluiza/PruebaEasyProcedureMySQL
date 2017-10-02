using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedimientos_MySQL
{
    class Conexion
    {
        private static MySqlConnection connection;
        /// <summary>
        /// set o get MySqlConnection 
        /// </summary>
        public MySqlConnection Connection
        {
            get
            {
                return connection;
            }

            set
            {
                connection = value;
            }
        }
    }
}
