using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForensicEvidenceAnalyzer
{
    class FiberAnalyzer : Analyzer
    {
        public int FiberSamplesCollected { get; private set; }

        public override string CollectEvidence(char[,] grid)
        {
            FiberSamplesCollected = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 'F')
                    {
                        FiberSamplesCollected++;
                    }
                }
            }
            return $"Fiber samples collected: {FiberSamplesCollected}";
        }
    }
}