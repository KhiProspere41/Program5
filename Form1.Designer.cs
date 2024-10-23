namespace ForensicEvidenceAnalyzer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.RadioButton rbPrintAnalyzer;
        private System.Windows.Forms.RadioButton rbDNAAnalyzer;
        private System.Windows.Forms.RadioButton rbBloodAnalyzer;
        private System.Windows.Forms.RadioButton rbFiberAnalyzer;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.rbPrintAnalyzer = new System.Windows.Forms.RadioButton();
            this.rbDNAAnalyzer = new System.Windows.Forms.RadioButton();
            this.rbBloodAnalyzer = new System.Windows.Forms.RadioButton();
            this.rbFiberAnalyzer = new System.Windows.Forms.RadioButton();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // File Name TextBox
            this.txtFileName.Location = new System.Drawing.Point(13, 13);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(320, 20);
            this.txtFileName.TabIndex = 0;

            // Select File Button
            this.btnSelectFile.Location = new System.Drawing.Point(340, 12);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);

            // PrintAnalyzer RadioButton
            this.rbPrintAnalyzer.AutoSize = true;
            this.rbPrintAnalyzer.Location = new System.Drawing.Point(13, 50);
            this.rbPrintAnalyzer.Name = "rbPrintAnalyzer";
            this.rbPrintAnalyzer.Size = new System.Drawing.Size(90, 17);
            this.rbPrintAnalyzer.TabIndex = 2;
            this.rbPrintAnalyzer.TabStop = true;
            this.rbPrintAnalyzer.Text = "Print Analyzer";
            this.rbPrintAnalyzer.UseVisualStyleBackColor = true;

            // DNAAnalyzer RadioButton
            this.rbDNAAnalyzer.AutoSize = true;
            this.rbDNAAnalyzer.Location = new System.Drawing.Point(13, 74);
            this.rbDNAAnalyzer.Name = "rbDNAAnalyzer";
            this.rbDNAAnalyzer.Size = new System.Drawing.Size(91, 17);
            this.rbDNAAnalyzer.TabIndex = 3;
            this.rbDNAAnalyzer.TabStop = true;
            this.rbDNAAnalyzer.Text = "DNA Analyzer";
            this.rbDNAAnalyzer.UseVisualStyleBackColor = true;

            // BloodAnalyzer RadioButton
            this.rbBloodAnalyzer.AutoSize = true;
            this.rbBloodAnalyzer.Location = new System.Drawing.Point(13, 98);
            this.rbBloodAnalyzer.Name = "rbBloodAnalyzer";
            this.rbBloodAnalyzer.Size = new System.Drawing.Size(96, 17);
            this.rbBloodAnalyzer.TabIndex = 4;
            this.rbBloodAnalyzer.TabStop = true;
            this.rbBloodAnalyzer.Text = "Blood Analyzer";
            this.rbBloodAnalyzer.UseVisualStyleBackColor = true;

            // FiberAnalyzer RadioButton
            this.rbFiberAnalyzer.AutoSize = true;
            this.rbFiberAnalyzer.Location = new System.Drawing.Point(13, 122);
            this.rbFiberAnalyzer.Name = "rbFiberAnalyzer";
            this.rbFiberAnalyzer.Size = new System.Drawing.Size(92, 17);
            this.rbFiberAnalyzer.TabIndex = 5;
            this.rbFiberAnalyzer.TabStop = true;
            this.rbFiberAnalyzer.Text = "Fiber Analyzer";
            this.rbFiberAnalyzer.UseVisualStyleBackColor = true;

            // Analyze Button
            this.btnAnalyze.Location = new System.Drawing.Point(13, 146);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 6;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);

            // Result Label
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(13, 182);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 211);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.rbFiberAnalyzer);
            this.Controls.Add(this.rbBloodAnalyzer);
            this.Controls.Add(this.rbDNAAnalyzer);
            this.Controls.Add(this.rbPrintAnalyzer);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtFileName);
            this.Name = "Form1";
            this.Text = "Forensic Evidence Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
