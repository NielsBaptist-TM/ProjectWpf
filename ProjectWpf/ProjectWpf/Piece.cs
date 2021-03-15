using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWpf
{
    class Piece
    {
        private string _name;
        private ConsoleColor _colour;

        public Piece(string name, ConsoleColor colour)
        {
            _name = name;
            _colour = colour;
        }

        public string name  
        {
            get { return name; } 
            set { name = value; } 
        }
        public ConsoleColor colour
        {
            get { return colour; }
            set { colour = value; }
        }
    }
}
