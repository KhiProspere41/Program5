using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForensicEvidenceAnalyzer
{
    abstract class Analyzer
    {
        public string CaseName { get; set; }
        public abstract string CollectEvidence(char[,] grid);
    }
}