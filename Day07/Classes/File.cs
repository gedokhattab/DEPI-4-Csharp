using Day07.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    internal class File : IReadable, IWritable
    {
        private string words;

        public string Read()
        {
            return words;
        }

        public void Write(string text)
        {
            words = text;
        }
    }
}
