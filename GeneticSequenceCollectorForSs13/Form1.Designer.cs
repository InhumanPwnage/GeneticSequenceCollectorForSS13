namespace GeneticSequenceCollectorForSs13
{
    partial class Form1
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
            this.btnExtract = new System.Windows.Forms.Button();
            this.rchInputSequences = new System.Windows.Forms.RichTextBox();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpCurrentCatalogue = new System.Windows.Forms.GroupBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.rchCurrentCatalogue = new System.Windows.Forms.RichTextBox();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchInput = new System.Windows.Forms.Label();
            this.numSequence = new System.Windows.Forms.NumericUpDown();
            this.grpInput.SuspendLayout();
            this.grpCurrentCatalogue.SuspendLayout();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSequence)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(553, 254);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 0;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // rchInputSequences
            // 
            this.rchInputSequences.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchInputSequences.Location = new System.Drawing.Point(6, 19);
            this.rchInputSequences.Name = "rchInputSequences";
            this.rchInputSequences.Size = new System.Drawing.Size(622, 233);
            this.rchInputSequences.TabIndex = 1;
            this.rchInputSequences.Text = "";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.rchInputSequences);
            this.grpInput.Controls.Add(this.btnExtract);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(634, 283);
            this.grpInput.TabIndex = 2;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input Sequences";
            this.grpInput.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpCurrentCatalogue
            // 
            this.grpCurrentCatalogue.Controls.Add(this.rchCurrentCatalogue);
            this.grpCurrentCatalogue.Location = new System.Drawing.Point(12, 301);
            this.grpCurrentCatalogue.Name = "grpCurrentCatalogue";
            this.grpCurrentCatalogue.Size = new System.Drawing.Size(177, 136);
            this.grpCurrentCatalogue.TabIndex = 3;
            this.grpCurrentCatalogue.TabStop = false;
            this.grpCurrentCatalogue.Text = "Currently Catalogued";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.numSequence);
            this.grpOptions.Controls.Add(this.lblSearchInput);
            this.grpOptions.Controls.Add(this.btnSearch);
            this.grpOptions.Controls.Add(this.label2);
            this.grpOptions.Controls.Add(this.lblSearch);
            this.grpOptions.Controls.Add(this.txtSequence);
            this.grpOptions.Location = new System.Drawing.Point(195, 301);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(445, 136);
            this.grpOptions.TabIndex = 4;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // rchCurrentCatalogue
            // 
            this.rchCurrentCatalogue.Location = new System.Drawing.Point(6, 19);
            this.rchCurrentCatalogue.Name = "rchCurrentCatalogue";
            this.rchCurrentCatalogue.ReadOnly = true;
            this.rchCurrentCatalogue.Size = new System.Drawing.Size(165, 111);
            this.rchCurrentCatalogue.TabIndex = 0;
            this.rchCurrentCatalogue.Text = "";
            // 
            // txtSequence
            // 
            this.txtSequence.Location = new System.Drawing.Point(6, 74);
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.ReadOnly = true;
            this.txtSequence.Size = new System.Drawing.Size(433, 20);
            this.txtSequence.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(96, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search Sequence:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sequence:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(168, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchInput
            // 
            this.lblSearchInput.AutoSize = true;
            this.lblSearchInput.Location = new System.Drawing.Point(64, 58);
            this.lblSearchInput.Name = "lblSearchInput";
            this.lblSearchInput.Size = new System.Drawing.Size(0, 13);
            this.lblSearchInput.TabIndex = 5;
            // 
            // numSequence
            // 
            this.numSequence.Location = new System.Drawing.Point(105, 20);
            this.numSequence.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSequence.Name = "numSequence";
            this.numSequence.Size = new System.Drawing.Size(57, 20);
            this.numSequence.TabIndex = 6;
            this.numSequence.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 449);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpCurrentCatalogue);
            this.Controls.Add(this.grpInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SS13 Genetic Sequencer Collector";
            this.grpInput.ResumeLayout(false);
            this.grpCurrentCatalogue.ResumeLayout(false);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSequence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.RichTextBox rchInputSequences;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpCurrentCatalogue;
        private System.Windows.Forms.RichTextBox rchCurrentCatalogue;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label lblSearchInput;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSequence;
        private System.Windows.Forms.NumericUpDown numSequence;
    }
}

