using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class Pathfinding
    {
        private string[] _grid;

        public string[] Grid {
            get { return _grid; }
            set { _grid = value; }
        }
        
        public Pathfinding(string grid)
        {
            int line = 0;

            this._grid = new string[grid.Split('\n').Length];
            foreach (var item in grid.Split('\n')){
                this._grid[line] = item;
                line++;
            }
        }
    }

}
