using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBox.Model
{
    class Note
    {
        private string _note;

        public Note(string note)
        {
            _note = note;
        }
        public override string ToString()
        {
            return _note;
        }
    }
}
