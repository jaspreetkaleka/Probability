using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Probability
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<string> _saveToFileData;

        private void findProbabilityButton_Click(object sender, EventArgs e)
        {
            var charFrequency = new Hashtable();

            foreach (var c in inputTextRichTextBox.Text)
            {
                if (charFrequency[c] != null)
                {
                    charFrequency[c] = (int) charFrequency[c] + 1;
                }
                else
                {
                    charFrequency[c] = 1;
                }
            }

            double totalChars = inputTextRichTextBox.TextLength;

            probabilityDataGridView.Rows.Clear();
            _saveToFileData = new List<string>();
            var en = charFrequency.GetEnumerator();
            char ch;
            double charFreq;
            while (en.MoveNext())
            {
                if (en.Key == null)
                {
                    continue;
                }

                charFreq =  (int) en.Value / totalChars;
                ch = (char) en.Key;

                if (ch == '\n')
                {
                    _saveToFileData.Add("NL" + charFreq.ToString("N" + precisionNumericUpDown.Value));
                    probabilityDataGridView.Rows.Add("NL", charFreq.ToString("N" + precisionNumericUpDown.Value));
                }
                else
                {
                    _saveToFileData.Add(ch + charFreq.ToString("N" + precisionNumericUpDown.Value));
                    probabilityDataGridView.Rows.Add(ch, charFreq.ToString("N" + precisionNumericUpDown.Value));
                }
            }
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "txt",
                Filter = @"Text Files|*.txt",
                OverwritePrompt = true,
                RestoreDirectory = true
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(sfd.FileName, _saveToFileData.ToArray());
            }
        }

        private void probabilityDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && DataGridView.ModifierKeys == Keys.Alt)
            {
                var info = probabilityDataGridView.HitTest(e.X, e.Y);
                if (info.RowIndex >= 0)
                {
                    var data = new List<string>();
                    foreach (DataGridViewRow r in probabilityDataGridView.SelectedRows)
                    {
                        data.Add(r.Cells[0].Value + r.Cells[1].Value.ToString());
                    }

                    if (data.Count != 0)
                    {
                        probabilityDataGridView.DoDragDrop(data.ToArray(), DragDropEffects.Copy);
                    }
                }
            }
        }
    }
}