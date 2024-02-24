using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsole15
{
     class Candidate
    {
         
        public string Name { get; }
        public int Votes { get; set; }

        public Candidate(string name)
        {
            Name = name;
            Votes = 0;
        }
    }
}

