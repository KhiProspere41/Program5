using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ForensicEvidenceAnalyzer
{
    public partial class Form1 : Form
    {
        private char[,] grid;
        private Analyzer analyzer;

        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the button to select a file
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.FileName;
                    LoadGridFromFile(openFileDialog.FileName);
                }
            }
        }

        // Load the grid data from the file into a 2D array
        private void LoadGridFromFile(string fileName)
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                int rows = lines.Length;
                int cols = lines[0].Length;
                grid = new char[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        grid[i, j] = lines[i][j];
                    }
                }

                MessageBox.Show("File loaded successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}", "Error");
            }
        }

        // Event handler for analyzing evidence based on selected type
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (grid == null)
            {
                MessageBox.Show("Please select a file first.", "Error");
                return;
            }

            if (rbPrintAnalyzer.Checked)
            {
                analyzer = new PrintAnalyzer();
            }
            else if (rbDNAAnalyzer.Checked)
            {
                analyzer = new DNAAnalyzer();
            }
            else if (rbBloodAnalyzer.Checked)
            {
                analyzer = new BloodAnalyzer();
            }
            else if (rbFiberAnalyzer.Checked)
            {
                analyzer = new FiberAnalyzer();
            }

            if (analyzer != null)
            {
                analyzer.CaseName = Path.GetFileName(txtFileName.Text);
                string result = analyzer.CollectEvidence(grid);
                lblResult.Text = result;
            }
        }
    }
}