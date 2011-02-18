/**    
 *    Fruk, transform a SAN to Graphviz Dot Language represention of it corresponding
 *    Markov Chain.
 *    Copyright (C) 2010  <Otávio Basso Gomes>
 *
 *    This program is free software: you can redistribute it and/or modify
 *    it under the terms of the GNU General Public License as published by
 *    the Free Software Foundation, either version 3 of the License, or
 *    (at your option) any later version.
 *
 *    This program is distributed in the hope that it will be useful,
 *    but WITHOUT ANY WARRANTY; without even the implied warranty of
 *    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *    GNU General Public License for more details.
 *
 *    You should have received a copy of the GNU General Public License
 *    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace Fruki
{
    partial class RunForm
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
            this.tbDotExe = new System.Windows.Forms.TextBox();
            this.tbAutonomus = new System.Windows.Forms.TextBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btFindDotExe = new System.Windows.Forms.Button();
            this.btFindAut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumStates = new System.Windows.Forms.TextBox();
            this.tbNumTransistions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbDotExe
            // 
            this.tbDotExe.Location = new System.Drawing.Point(94, 13);
            this.tbDotExe.Name = "tbDotExe";
            this.tbDotExe.Size = new System.Drawing.Size(411, 20);
            this.tbDotExe.TabIndex = 0;
            this.tbDotExe.Text = "C:\\Program Files (x86)\\Graphviz2.26.3\\bin\\dot.exe";
            // 
            // tbAutonomus
            // 
            this.tbAutonomus.Location = new System.Drawing.Point(94, 38);
            this.tbAutonomus.Name = "tbAutonomus";
            this.tbAutonomus.Size = new System.Drawing.Size(411, 20);
            this.tbAutonomus.TabIndex = 1;
            this.tbAutonomus.Text = "E:\\T2_v2.txt";
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(12, 75);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(75, 23);
            this.btGenerate.TabIndex = 2;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "dot.exe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Autonomus file:";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(430, 73);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btFindDotExe
            // 
            this.btFindDotExe.Location = new System.Drawing.Point(511, 10);
            this.btFindDotExe.Name = "btFindDotExe";
            this.btFindDotExe.Size = new System.Drawing.Size(75, 23);
            this.btFindDotExe.TabIndex = 6;
            this.btFindDotExe.Text = "Find...";
            this.btFindDotExe.UseVisualStyleBackColor = true;
            this.btFindDotExe.Click += new System.EventHandler(this.btFindDot_Click);
            // 
            // btFindAut
            // 
            this.btFindAut.Location = new System.Drawing.Point(511, 35);
            this.btFindAut.Name = "btFindAut";
            this.btFindAut.Size = new System.Drawing.Size(75, 23);
            this.btFindAut.TabIndex = 7;
            this.btFindAut.Text = "Find...";
            this.btFindAut.UseVisualStyleBackColor = true;
            this.btFindAut.Click += new System.EventHandler(this.btFindAut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of states:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of transitions:";
            // 
            // tbNumStates
            // 
            this.tbNumStates.Enabled = false;
            this.tbNumStates.Location = new System.Drawing.Point(132, 106);
            this.tbNumStates.Name = "tbNumStates";
            this.tbNumStates.Size = new System.Drawing.Size(48, 20);
            this.tbNumStates.TabIndex = 10;
            // 
            // tbNumTransistions
            // 
            this.tbNumTransistions.Enabled = false;
            this.tbNumTransistions.Location = new System.Drawing.Point(132, 134);
            this.tbNumTransistions.Name = "tbNumTransistions";
            this.tbNumTransistions.Size = new System.Drawing.Size(48, 20);
            this.tbNumTransistions.TabIndex = 11;
            // 
            // RunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 170);
            this.Controls.Add(this.tbNumTransistions);
            this.Controls.Add(this.tbNumStates);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btFindAut);
            this.Controls.Add(this.btFindDotExe);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.tbAutonomus);
            this.Controls.Add(this.tbDotExe);
            this.Name = "RunForm";
            this.Text = "Fruk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDotExe;
        private System.Windows.Forms.TextBox tbAutonomus;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btFindDotExe;
        private System.Windows.Forms.Button btFindAut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumStates;
        private System.Windows.Forms.TextBox tbNumTransistions;
    }
}

