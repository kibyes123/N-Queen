namespace EightQueensGA
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPop = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGen = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCrosProb = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMutProb = new System.Windows.Forms.NumericUpDown();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.colSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.board1 = new EightQueensGA.Board();
            ((System.ComponentModel.ISupportInitialize)(this.txtPop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCrosProb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMutProb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.Color.Maroon;
            this.btnStart.Location = new System.Drawing.Point(18, 453);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(340, 24);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Solve";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Population Size";
            // 
            // txtPop
            // 
            this.txtPop.Location = new System.Drawing.Point(218, 6);
            this.txtPop.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPop.Name = "txtPop";
            this.txtPop.Size = new System.Drawing.Size(120, 20);
            this.txtPop.TabIndex = 2;
            this.txtPop.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Generations";
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(218, 32);
            this.txtGen.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(120, 20);
            this.txtGen.TabIndex = 2;
            this.txtGen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Crossover Probability";
            // 
            // txtCrosProb
            // 
            this.txtCrosProb.DecimalPlaces = 2;
            this.txtCrosProb.Location = new System.Drawing.Point(218, 58);
            this.txtCrosProb.Name = "txtCrosProb";
            this.txtCrosProb.Size = new System.Drawing.Size(120, 20);
            this.txtCrosProb.TabIndex = 2;
            this.txtCrosProb.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mutation Probability";
            // 
            // txtMutProb
            // 
            this.txtMutProb.DecimalPlaces = 2;
            this.txtMutProb.Location = new System.Drawing.Point(218, 84);
            this.txtMutProb.Name = "txtMutProb";
            this.txtMutProb.Size = new System.Drawing.Size(120, 20);
            this.txtMutProb.TabIndex = 2;
            this.txtMutProb.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // dgResults
            // 
            this.dgResults.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSol,
            this.ColFit});
            this.dgResults.Location = new System.Drawing.Point(18, 110);
            this.dgResults.Name = "dgResults";
            this.dgResults.RowHeadersVisible = false;
            this.dgResults.Size = new System.Drawing.Size(310, 297);
            this.dgResults.TabIndex = 3;
            // 
            // colSol
            // 
            this.colSol.FillWeight = 235F;
            this.colSol.HeaderText = "Solution";
            this.colSol.Name = "colSol";
            this.colSol.Width = 235;
            // 
            // ColFit
            // 
            this.ColFit.FillWeight = 50F;
            this.ColFit.HeaderText = "Fitness";
            this.ColFit.Name = "ColFit";
            this.ColFit.Width = 50;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 439);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(346, 413);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hill Climbing";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(137, 8);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Max. number of restarts:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Back Tracking";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(119, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "No options to specify";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgResults);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtPop);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtGen);
            this.tabPage1.Controls.Add(this.txtMutProb);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtCrosProb);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genetic Algorithm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "No. of Restarts:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "0";
            // 
            // board1
            // 
            this.board1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.board1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board1.Location = new System.Drawing.Point(375, 12);
            this.board1.Name = "board1";
            this.board1.Size = new System.Drawing.Size(467, 465);
            this.board1.TabIndex = 4;
            this.board1.Load += new System.EventHandler(this.board1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 501);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.board1);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(870, 540);
            this.MinimumSize = new System.Drawing.Size(870, 540);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8-Qeens Problem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCrosProb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMutProb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtPop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtGen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtCrosProb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtMutProb;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFit;
        private Board board1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

