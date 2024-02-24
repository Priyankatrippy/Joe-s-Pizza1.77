using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsole15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectionManager electionManager = new ElectionManager();

            electionManager.StartElection();

            Console.WriteLine($"Winner: {electionManager.GetWinner()}");
        }
    }
}
    