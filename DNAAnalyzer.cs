using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForensicEvidenceAnalyzer
{
    class DNAAnalyzer : Analyzer
    {
        public int SamplesCollected { get; private set; }

        public override string CollectEvidence(char[,] grid)
        {
            SamplesCollected = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 'D' || grid[i, j] == 'H' || grid[i, j] == 'F')
                    {
                        SamplesCollected++;
                    }
                }
            }
            return $"Samples collected: {SamplesCollected}";
        }
    }
}
