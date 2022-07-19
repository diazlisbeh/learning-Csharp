using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataBase
{
    public class DB{
        protected SqlConnection _connetion;
        private string _connectionsstring;

        public DB(string server, string db,string user, string password){
            _connectionsstring = $"Data Source={server}; Initial Catalog={db}; User={user}; password={password}";
        }

        public void Connect(){
            _connetion = new SqlConnection(_connectionsstring);
            _connetion.Open();
        }
        public void Close(){
           if(_connetion != null && _connetion.State == System.Data.ConnectionState.Open)
           _connetion.Close();
        }
    }
}