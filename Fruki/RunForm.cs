using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Fruki
{
    public partial class RunForm : Form
    {
        delegate void Message();

        public RunForm()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tbDotExe.Text))
            {
                MessageBox.Show(this, "File not found", "Please select the graphviz dot.exe executable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(tbAutonomus.Text))
            {
                MessageBox.Show(this, "File not found", "Please select an existing autonomus file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            WorkProgressDialog dialog = new WorkProgressDialog("Generating..", "Generating Markov Chain", new WorkProgressDialog.WorkProcedure(
                delegate()
                {
                    try
                    {
                        SANLoader sloader = new SANLoader();
                        SAN san = sloader.ParseFile(tbAutonomus.Text);

                        string output = ExtractOutputFilename();
                        string dotOuput = output + ".dot";
                        string imgOutput = output + ".png";

                        using (StreamWriter stream = new StreamWriter(new FileStream(dotOuput, FileMode.Create)))
                        {
                            Tuple<int, int> info = san.GenerateDotVis(stream);
                            Invoke(new Message(delegate()
                            {
                                tbNumStates.Text = Convert.ToString(info.Item1);
                                tbNumTransistions.Text = Convert.ToString(info.Item2);
                            }));
                        }

                        ProcessStartInfo dotProcess = new ProcessStartInfo();
                        dotProcess.FileName = tbDotExe.Text;
                        dotProcess.Arguments = dotOuput + " -Tpng -o " + imgOutput;
                        dotProcess.CreateNoWindow = true;
                        dotProcess.UseShellExecute = false;
                        
                        using (Process proc = Process.Start(dotProcess))
                        {
                            proc.WaitForExit();
                            
                        }

                        if (File.Exists(imgOutput))
                        {
                            Process.Start(imgOutput);
                        }                        
                    }
                    catch (Antlr.Runtime.RecognitionException recEx)
                    {                     
                        Invoke(new Message(delegate()
                        {
                            MessageBox.Show(this, "Parser error", recEx.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }));        
                    }
                    catch (Exception ex)
                    {
                        Invoke(new Message(delegate()
                        {
                            MessageBox.Show(this, "Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        })); 
                    }
                }));

            dialog.Run(this);
        }

        private string ExtractOutputFilename()
        {
            string output;
            int period = tbAutonomus.Text.IndexOf('.');
            if ( period < 0 )
            {
                output = tbAutonomus.Text;
            }
            else
            {
                output = tbAutonomus.Text.Substring(0, period);
            }

            return output;
        }

        private void btFindDot_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "dot.exe|dot.exe";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbDotExe.Text = ofd.FileName;
            }            
        }

        private void btFindAut_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbAutonomus.Text = ofd.FileName;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
