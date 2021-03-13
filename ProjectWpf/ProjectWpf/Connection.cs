using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;


namespace ProjectWpf
{
    class Connection
    {
        private Connection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
       /* public DBConnect()
        {
            Initialize();
        }*/

        //Initialize values
        private void Initialize()
        {
            server = "192.168.20.98:3306";
            database = "nielsbaptist_trivialPursuit";
            uid = "nielsbaptist";
            password = "W2IUJDXgU52w";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

/*            connection = new SqlConnection(connectionString);
*/        }

    }
}
