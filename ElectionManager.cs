using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsole15
{
 class ElectionManager
    {
 
        private List<Candidate> candidates;

        public ElectionManager()
        {
            candidates = new List<Candidate>();
        }

        public void AddCandidate(string name)
        {
            candidates.Add(new Candidate(name));
        }

        public void StartElection()
        {
            Console.WriteLine("Welcome to the Election!");
            Console.WriteLine("Enter the names of the candidates (one per line), then press enter twice to start the election:");

            string candidateName;
            while (!string.IsNullOrWhiteSpace(candidateName = Console.ReadLine()))
            {
                AddCandidate(candidateName);
            }

            ConductVoting();
        }

        private void ConductVoting()
        {
            Console.WriteLine("Voting started!");

            string vote;
            while (!string.IsNullOrWhiteSpace(vote = Console.ReadLine()))
            {
                int candidateIndex = int.Parse(vote) - 1;
                if (candidateIndex >= 0 && candidateIndex < candidates.Count)
                {
                    candidates[candidateIndex].Votes++;
                }
                else
                {
                    Console.WriteLine("Invalid candidate number.");
                }
            }
        }

        public string GetWinner()
        {
            Candidate winner = candidates[0];
            foreach (Candidate candidate in candidates)
            {
                if (candidate.Votes > winner.Votes)
                {
                    winner = candidate;
                }
            }
            return winner.Name;
        }
    }
}

    

