using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm
{
    class CBBItems
    {
        private int _Values;
        private string _Text;

        public int Values { get => _Values; set => _Values = value; }
        public string Text { get => _Text; set => _Text = value; }

        public override string ToString()
        {
            return Text;
        }
    }
}