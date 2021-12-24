namespace Probability
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inputTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.probabilityDataGridView = new System.Windows.Forms.DataGridView();
            this.characterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findProbabilityButton = new System.Windows.Forms.Button();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.precisionPanel = new System.Windows.Forms.Panel();
            this.precisionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityDataGridView)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.precisionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precisionNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextRichTextBox
            // 
            this.inputTextRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextRichTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextRichTextBox.ForeColor = System.Drawing.Color.Crimson;
            this.inputTextRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.inputTextRichTextBox.Name = "inputTextRichTextBox";
            this.inputTextRichTextBox.Size = new System.Drawing.Size(369, 379);
            this.inputTextRichTextBox.TabIndex = 0;
            this.inputTextRichTextBox.Text = "";
            // 
            // probabilityDataGridView
            // 
            this.probabilityDataGridView.AllowUserToAddRows = false;
            this.probabilityDataGridView.AllowUserToDeleteRows = false;
            this.probabilityDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.probabilityDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.probabilityDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.probabilityDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.probabilityDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.probabilityDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.probabilityDataGridView.ColumnHeadersHeight = 30;
            this.probabilityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.probabilityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.characterColumn,
            this.probabilityColumn});
            this.probabilityDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.probabilityDataGridView.EnableHeadersVisualStyles = false;
            this.probabilityDataGridView.GridColor = System.Drawing.Color.White;
            this.probabilityDataGridView.Location = new System.Drawing.Point(45, 0);
            this.probabilityDataGridView.Name = "probabilityDataGridView";
            this.probabilityDataGridView.ReadOnly = true;
            this.probabilityDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.probabilityDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.probabilityDataGridView.RowHeadersWidth = 25;
            this.probabilityDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probabilityDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.probabilityDataGridView.RowTemplate.Height = 30;
            this.probabilityDataGridView.Size = new System.Drawing.Size(289, 296);
            this.probabilityDataGridView.TabIndex = 1;
            this.probabilityDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.probabilityDataGridView_MouseDown);
            // 
            // characterColumn
            // 
            this.characterColumn.HeaderText = "Char [X]";
            this.characterColumn.Name = "characterColumn";
            this.characterColumn.ReadOnly = true;
            this.characterColumn.Width = 96;
            // 
            // probabilityColumn
            // 
            this.probabilityColumn.HeaderText = "Prob. [P]";
            this.probabilityColumn.Name = "probabilityColumn";
            this.probabilityColumn.ReadOnly = true;
            this.probabilityColumn.Width = 96;
            // 
            // findProbabilityButton
            // 
            this.findProbabilityButton.BackColor = System.Drawing.Color.White;
            this.findProbabilityButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.findProbabilityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findProbabilityButton.ForeColor = System.Drawing.Color.Teal;
            this.findProbabilityButton.Location = new System.Drawing.Point(0, 0);
            this.findProbabilityButton.Name = "findProbabilityButton";
            this.findProbabilityButton.Size = new System.Drawing.Size(45, 379);
            this.findProbabilityButton.TabIndex = 0;
            this.findProbabilityButton.Text = ">>\r\n\r\nP\r\nr\r\no\r\nb\r\na\r\nb\r\ni\r\nl\r\ni\r\nt\r\ny\r\n\r\n>>";
            this.findProbabilityButton.UseVisualStyleBackColor = false;
            this.findProbabilityButton.Click += new System.EventHandler(this.findProbabilityButton_Click);
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.BackColor = System.Drawing.Color.White;
            this.saveToFileButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveToFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToFileButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.saveToFileButton.Location = new System.Drawing.Point(45, 338);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(289, 41);
            this.saveToFileButton.TabIndex = 2;
            this.saveToFileButton.Text = "Save To File...";
            this.saveToFileButton.UseVisualStyleBackColor = false;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.probabilityDataGridView);
            this.mainPanel.Controls.Add(this.precisionPanel);
            this.mainPanel.Controls.Add(this.saveToFileButton);
            this.mainPanel.Controls.Add(this.findProbabilityButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPanel.Location = new System.Drawing.Point(369, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(334, 379);
            this.mainPanel.TabIndex = 5;
            // 
            // precisionPanel
            // 
            this.precisionPanel.BackColor = System.Drawing.Color.White;
            this.precisionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.precisionPanel.Controls.Add(this.label1);
            this.precisionPanel.Controls.Add(this.precisionNumericUpDown);
            this.precisionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.precisionPanel.Location = new System.Drawing.Point(45, 296);
            this.precisionPanel.Name = "precisionPanel";
            this.precisionPanel.Size = new System.Drawing.Size(289, 42);
            this.precisionPanel.TabIndex = 3;
            // 
            // precisionNumericUpDown
            // 
            this.precisionNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precisionNumericUpDown.ForeColor = System.Drawing.Color.Teal;
            this.precisionNumericUpDown.Location = new System.Drawing.Point(157, 8);
            this.precisionNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.precisionNumericUpDown.Name = "precisionNumericUpDown";
            this.precisionNumericUpDown.Size = new System.Drawing.Size(56, 26);
            this.precisionNumericUpDown.TabIndex = 0;
            this.precisionNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.precisionNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(74, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Precision = ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 379);
            this.Controls.Add(this.inputTextRichTextBox);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Probability Finder";
            ((System.ComponentModel.ISupportInitialize)(this.probabilityDataGridView)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.precisionPanel.ResumeLayout(false);
            this.precisionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precisionNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputTextRichTextBox;
        private System.Windows.Forms.DataGridView probabilityDataGridView;
        private System.Windows.Forms.Button findProbabilityButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilityColumn;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel precisionPanel;
        private System.Windows.Forms.NumericUpDown precisionNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}

