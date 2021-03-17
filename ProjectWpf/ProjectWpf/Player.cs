using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.IO;

namespace ProjectWpf
{
    class Player
    {
        private string _name;
        private string _colour;
        private int _turns;
        public Player(string name, string colour, int turns)
        {
            _name = name;
            _colour = colour;
            _turns = turns;
            insert(name, colour);
        }

        public void insert(string name, string colour)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=r0793266.database.windows.net; Initial Catalog = SQLDBWPF; Persist Security Info = True; User ID = admin2ITF; Password = Password2ITF");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlConnection;
            cmd.CommandText = "insert into Players (name, colour, active, turns) " +
                "values('" + name + "','" + colour + "','" + 1 + "','" + 0 + "')";
            SqlConnection.Open();
            cmd.ExecuteNonQuery();
            SqlConnection.Close();
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string colour
        {
            get { return _colour; }
            set { _colour = value; }
        }
        public int turns
        {
            get { return _turns; }
            set { _turns = value; }
        }
    }
}
