﻿namespace CoViD.GUI.Forms
{
	partial class Infection
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Infection));
			this.txtXMax = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtYVMax = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblVmax2 = new System.Windows.Forms.Label();
			this.txtYAMax = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.udAntibodiesDecay = new CoViD.GUI.UC.UpDown();
			this.udAntibodiesGrowth = new CoViD.GUI.UC.UpDown();
			this.udVirusesGrowth = new CoViD.GUI.UC.UpDown();
			this.udVirusesN = new CoViD.GUI.UC.UpDown();
			this.btnNewEvolution = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ledSusceptibles = new CoViD.GUI.UC.Led();
			this.xy1 = new CoViD.GUI.XY();
			this.xy2 = new CoViD.GUI.XY();
			this.led1 = new CoViD.GUI.UC.Led();
			this.led2 = new CoViD.GUI.UC.Led();
			this.led3 = new CoViD.GUI.UC.Led();
			this.led4 = new CoViD.GUI.UC.Led();
			this.led5 = new CoViD.GUI.UC.Led();
			this.led6 = new CoViD.GUI.UC.Led();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtXMax
			// 
			this.txtXMax.Location = new System.Drawing.Point(995, 92);
			this.txtXMax.Name = "txtXMax";
			this.txtXMax.Size = new System.Drawing.Size(69, 20);
			this.txtXMax.TabIndex = 7;
			this.txtXMax.Text = "1,500";
			this.txtXMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(957, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "x Max";
			// 
			// txtYVMax
			// 
			this.txtYVMax.Location = new System.Drawing.Point(60, 93);
			this.txtYVMax.Name = "txtYVMax";
			this.txtYVMax.Size = new System.Drawing.Size(96, 20);
			this.txtYVMax.TabIndex = 11;
			this.txtYVMax.Text = "1,000,000,000";
			this.txtYVMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "y Max";
			// 
			// lblVmax2
			// 
			this.lblVmax2.Location = new System.Drawing.Point(1010, 71);
			this.lblVmax2.Name = "lblVmax2";
			this.lblVmax2.Size = new System.Drawing.Size(50, 13);
			this.lblVmax2.TabIndex = 28;
			this.lblVmax2.Text = "label7";
			this.lblVmax2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblVmax2.Visible = false;
			// 
			// txtYAMax
			// 
			this.txtYAMax.Location = new System.Drawing.Point(60, 468);
			this.txtYAMax.Name = "txtYAMax";
			this.txtYAMax.Size = new System.Drawing.Size(96, 20);
			this.txtYAMax.TabIndex = 59;
			this.txtYAMax.Text = "150,000,000";
			this.txtYAMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(24, 470);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(35, 13);
			this.label11.TabIndex = 58;
			this.label11.Text = "y Max";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.udAntibodiesDecay);
			this.panel1.Controls.Add(this.udAntibodiesGrowth);
			this.panel1.Controls.Add(this.udVirusesGrowth);
			this.panel1.Controls.Add(this.udVirusesN);
			this.panel1.Controls.Add(this.btnNewEvolution);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1084, 68);
			this.panel1.TabIndex = 60;
			// 
			// udAntibodiesDecay
			// 
			this.udAntibodiesDecay.Caption = "Antibodies unities number decay percent.";
			this.udAntibodiesDecay.Decimals = ((sbyte)(2));
			this.udAntibodiesDecay.Location = new System.Drawing.Point(828, 16);
			this.udAntibodiesDecay.MaximumSize = new System.Drawing.Size(335, 45);
			this.udAntibodiesDecay.MinimumSize = new System.Drawing.Size(162, 45);
			this.udAntibodiesDecay.Name = "udAntibodiesDecay";
			this.udAntibodiesDecay.Size = new System.Drawing.Size(221, 45);
			this.udAntibodiesDecay.TabIndex = 65;
			this.udAntibodiesDecay.Value = 0;
			this.udAntibodiesDecay.Click += new System.EventHandler(this.ud_Click);
			// 
			// udAntibodiesGrowth
			// 
			this.udAntibodiesGrowth.Caption = "Antibodies unities number growth percent.";
			this.udAntibodiesGrowth.Decimals = ((sbyte)(2));
			this.udAntibodiesGrowth.Location = new System.Drawing.Point(590, 16);
			this.udAntibodiesGrowth.MaximumSize = new System.Drawing.Size(335, 45);
			this.udAntibodiesGrowth.MinimumSize = new System.Drawing.Size(162, 45);
			this.udAntibodiesGrowth.Name = "udAntibodiesGrowth";
			this.udAntibodiesGrowth.Size = new System.Drawing.Size(216, 45);
			this.udAntibodiesGrowth.TabIndex = 64;
			this.udAntibodiesGrowth.Value = 0;
			this.udAntibodiesGrowth.Click += new System.EventHandler(this.ud_Click);
			// 
			// udVirusesGrowth
			// 
			this.udVirusesGrowth.Caption = "Viruses unities number growth percent.";
			this.udVirusesGrowth.Decimals = ((sbyte)(2));
			this.udVirusesGrowth.Location = new System.Drawing.Point(368, 16);
			this.udVirusesGrowth.MaximumSize = new System.Drawing.Size(335, 45);
			this.udVirusesGrowth.MinimumSize = new System.Drawing.Size(162, 45);
			this.udVirusesGrowth.Name = "udVirusesGrowth";
			this.udVirusesGrowth.Size = new System.Drawing.Size(209, 45);
			this.udVirusesGrowth.TabIndex = 63;
			this.udVirusesGrowth.Value = 0;
			this.udVirusesGrowth.Click += new System.EventHandler(this.ud_Click);
			// 
			// udVirusesN
			// 
			this.udVirusesN.Caption = "Viruses unities entered each tick.";
			this.udVirusesN.Decimals = ((sbyte)(0));
			this.udVirusesN.Location = new System.Drawing.Point(155, 16);
			this.udVirusesN.MaximumSize = new System.Drawing.Size(335, 45);
			this.udVirusesN.MinimumSize = new System.Drawing.Size(162, 45);
			this.udVirusesN.Name = "udVirusesN";
			this.udVirusesN.Size = new System.Drawing.Size(200, 45);
			this.udVirusesN.TabIndex = 61;
			this.udVirusesN.Value = 1000;
			this.udVirusesN.Click += new System.EventHandler(this.ud_Click);
			// 
			// btnNewEvolution
			// 
			this.btnNewEvolution.Location = new System.Drawing.Point(20, 34);
			this.btnNewEvolution.Name = "btnNewEvolution";
			this.btnNewEvolution.Size = new System.Drawing.Size(125, 22);
			this.btnNewEvolution.TabIndex = 52;
			this.btnNewEvolution.Text = "New";
			this.btnNewEvolution.UseVisualStyleBackColor = true;
			this.btnNewEvolution.Click += new System.EventHandler(this.btnNewEvolution_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(431, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 65;
			this.label1.Text = "label1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(927, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 13);
			this.label4.TabIndex = 69;
			this.label4.Text = "Peak of infection:";
			this.label4.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(1057, 71);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(15, 13);
			this.label5.TabIndex = 70;
			this.label5.Text = "%";
			this.label5.Visible = false;
			// 
			// ledSusceptibles
			// 
			this.ledSusceptibles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ledSusceptibles.Location = new System.Drawing.Point(168, 91);
			this.ledSusceptibles.MaximumSize = new System.Drawing.Size(381, 22);
			this.ledSusceptibles.MinimumSize = new System.Drawing.Size(22, 22);
			this.ledSusceptibles.Name = "ledSusceptibles";
			this.ledSusceptibles.Size = new System.Drawing.Size(97, 22);
			this.ledSusceptibles.State = CoViD.CL.Person.States.Susceptible;
			this.ledSusceptibles.TabIndex = 71;
			// 
			// xy1
			// 
			this.xy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.xy1.Location = new System.Drawing.Point(20, 114);
			this.xy1.Name = "xy1";
			this.xy1.Size = new System.Drawing.Size(1045, 341);
			this.xy1.TabIndex = 29;
			// 
			// xy2
			// 
			this.xy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.xy2.Location = new System.Drawing.Point(20, 490);
			this.xy2.Name = "xy2";
			this.xy2.Size = new System.Drawing.Size(1045, 346);
			this.xy2.TabIndex = 30;
			// 
			// led1
			// 
			this.led1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.led1.Location = new System.Drawing.Point(319, 91);
			this.led1.MaximumSize = new System.Drawing.Size(381, 22);
			this.led1.MinimumSize = new System.Drawing.Size(22, 22);
			this.led1.Name = "led1";
			this.led1.Size = new System.Drawing.Size(92, 22);
			this.led1.State = CoViD.CL.Person.States.Latency;
			this.led1.TabIndex = 72;
			// 
			// led2
			// 
			this.led2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.led2.Location = new System.Drawing.Point(412, 91);
			this.led2.MaximumSize = new System.Drawing.Size(381, 22);
			this.led2.MinimumSize = new System.Drawing.Size(22, 22);
			this.led2.Name = "led2";
			this.led2.Size = new System.Drawing.Size(53, 22);
			this.led2.State = CoViD.CL.Person.States.Ill;
			this.led2.TabIndex = 73;
			// 
			// led3
			// 
			this.led3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.led3.Location = new System.Drawing.Point(466, 91);
			this.led3.MaximumSize = new System.Drawing.Size(381, 22);
			this.led3.MinimumSize = new System.Drawing.Size(22, 22);
			this.led3.Name = "led3";
			this.led3.Size = new System.Drawing.Size(77, 22);
			this.led3.State = CoViD.CL.Person.States.Severe;
			this.led3.TabIndex = 74;
			// 
			// led4
			// 
			this.led4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.led4.Location = new System.Drawing.Point(542, 91);
			this.led4.MaximumSize = new System.Drawing.Size(381, 22);
			this.led4.MinimumSize = new System.Drawing.Size(22, 22);
			this.led4.Name = "led4";
			this.led4.Size = new System.Drawing.Size(111, 22);
			this.led4.State = CoViD.CL.Person.States.Convalescent;
			this.led4.TabIndex = 75;
			// 
			// led5
			// 
			this.led5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.led5.Location = new System.Drawing.Point(721, 91);
			this.led5.MaximumSize = new System.Drawing.Size(381, 22);
			this.led5.MinimumSize = new System.Drawing.Size(22, 22);
			this.led5.Name = "led5";
			this.led5.Size = new System.Drawing.Size(71, 22);
			this.led5.State = CoViD.CL.Person.States.Dead;
			this.led5.TabIndex = 76;
			// 
			// led6
			// 
			this.led6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.led6.Location = new System.Drawing.Point(792, 91);
			this.led6.MaximumSize = new System.Drawing.Size(381, 22);
			this.led6.MinimumSize = new System.Drawing.Size(22, 22);
			this.led6.Name = "led6";
			this.led6.Size = new System.Drawing.Size(84, 22);
			this.led6.State = CoViD.CL.Person.States.Immune;
			this.led6.TabIndex = 77;
			// 
			// Infection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1084, 845);
			this.Controls.Add(this.led6);
			this.Controls.Add(this.led5);
			this.Controls.Add(this.led4);
			this.Controls.Add(this.led3);
			this.Controls.Add(this.led2);
			this.Controls.Add(this.led1);
			this.Controls.Add(this.ledSusceptibles);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtXMax);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtYVMax);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblVmax2);
			this.Controls.Add(this.xy1);
			this.Controls.Add(this.xy2);
			this.Controls.Add(this.txtYAMax);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Infection";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Infection evolution";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Disease_FormClosing);
			this.Load += new System.EventHandler(this.Disease_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtXMax;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtYVMax;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblVmax2;
		private XY xy1;
		private XY xy2;
		private System.Windows.Forms.TextBox txtYAMax;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnNewEvolution;
		private System.Windows.Forms.Label label1;
		private UC.UpDown udVirusesN;
		private UC.UpDown udAntibodiesDecay;
		private UC.UpDown udAntibodiesGrowth;
		private UC.UpDown udVirusesGrowth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private UC.Led ledSusceptibles;
		private UC.Led led1;
		private UC.Led led2;
		private UC.Led led3;
		private UC.Led led4;
		private UC.Led led5;
		private UC.Led led6;
	}
}