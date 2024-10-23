using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForensicEvidenceAnalyzer
{
    class BloodAnalyzer : DNAAnalyzer
    {
        public int BloodSamplesCollected { get; private set; }

        public override string CollectEvidence(char[,] grid)
        {
            BloodSamplesCollected = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 'B')
                    {
                        BloodSamplesCollected++;
                    }
                }
            }
            return $"Blood samples collected: {BloodSamplesCollected}";
        }
    }
}