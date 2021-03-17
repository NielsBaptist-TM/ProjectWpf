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
        private List<Piece> _pieces;
        public Player(string name, string colour, int turns)
        {
            _name = name;
            _colour = colour;
            _turns = turns;
            _pieces = new List<Piece>();
        }

        public void insert()
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=r0793266.database.windows.net; Initial Catalog = SQLDBWPF; Persist Security Info = True; User ID = admin2ITF; Password = Password2ITF");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlConnection;
            cmd.CommandText = "insert into Players values('" + name + "','" + colour + "')";
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
        public List<Piece> pieces
        {
            get { return _pieces; }
            set { _pieces = value; }
        }
    }
}
