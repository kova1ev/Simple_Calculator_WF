using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttoMultip = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonAdding = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonSing = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonResultat = new System.Windows.Forms.Button();
            this.HistoryBox = new System.Windows.Forms.TextBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PercentHelp = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Controls.Add(this.buttonClear);
            this.flowLayoutPanel1.Controls.Add(this.buttonDivide);
            this.flowLayoutPanel1.Controls.Add(this.buttoMultip);
            this.flowLayoutPanel1.Controls.Add(this.buttonDelete);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.buttonSubtract);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.buttonAdding);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.buttonPercent);
            this.flowLayoutPanel1.Controls.Add(this.buttonSing);
            this.flowLayoutPanel1.Controls.Add(this.button0);
            this.flowLayoutPanel1.Controls.Add(this.buttonDot);
            this.flowLayoutPanel1.Controls.Add(this.buttonResultat);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.PercentHelp.SetToolTip(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
            // 
            // buttonClear
            // 
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonClear.Name = "buttonClear";
            this.PercentHelp.SetToolTip(this.buttonClear, resources.GetString("buttonClear.ToolTip"));
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDivide
            // 
            resources.ApplyResources(this.buttonDivide, "buttonDivide");
            this.buttonDivide.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDivide.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDivide.Name = "buttonDivide";
            this.PercentHelp.SetToolTip(this.buttonDivide, resources.GetString("buttonDivide.ToolTip"));
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttoMultip
            // 
            resources.ApplyResources(this.buttoMultip, "buttoMultip");
            this.buttoMultip.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttoMultip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoMultip.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttoMultip.Name = "buttoMultip";
            this.PercentHelp.SetToolTip(this.buttoMultip, resources.GetString("buttoMultip.ToolTip"));
            this.buttoMultip.UseVisualStyleBackColor = false;
            this.buttoMultip.Click += new System.EventHandler(this.buttoMultip_Click);
            // 
            // buttonDelete
            // 
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDelete.Name = "buttonDelete";
            this.PercentHelp.SetToolTip(this.buttonDelete, resources.GetString("buttonDelete.ToolTip"));
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button7.Name = "button7";
            this.PercentHelp.SetToolTip(this.button7, resources.GetString("button7.ToolTip"));
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button8.Name = "button8";
            this.PercentHelp.SetToolTip(this.button8, resources.GetString("button8.ToolTip"));
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.BackColor = System.Drawing.Color.Gray;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button9.Name = "button9";
            this.PercentHelp.SetToolTip(this.button9, resources.GetString("button9.ToolTip"));
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonSubtract
            // 
            resources.ApplyResources(this.buttonSubtract, "buttonSubtract");
            this.buttonSubtract.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSubtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubtract.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSubtract.Name = "buttonSubtract";
            this.PercentHelp.SetToolTip(this.buttonSubtract, resources.GetString("buttonSubtract.ToolTip"));
            this.buttonSubtract.UseVisualStyleBackColor = false;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.Name = "button4";
            this.PercentHelp.SetToolTip(this.button4, resources.GetString("button4.ToolTip"));
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button5.Name = "button5";
            this.PercentHelp.SetToolTip(this.button5, resources.GetString("button5.ToolTip"));
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button6.Name = "button6";
            this.PercentHelp.SetToolTip(this.button6, resources.GetString("button6.ToolTip"));
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonAdding
            // 
            resources.ApplyResources(this.buttonAdding, "buttonAdding");
            this.buttonAdding.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonAdding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdding.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonAdding.Name = "buttonAdding";
            this.PercentHelp.SetToolTip(this.buttonAdding, resources.GetString("buttonAdding.ToolTip"));
            this.buttonAdding.UseVisualStyleBackColor = false;
            this.buttonAdding.Click += new System.EventHandler(this.buttonAdding_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.Name = "button1";
            this.button1.Tag = "1";
            this.PercentHelp.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.Name = "button2";
            this.PercentHelp.SetToolTip(this.button2, resources.GetString("button2.ToolTip"));
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.Name = "button3";
            this.PercentHelp.SetToolTip(this.button3, resources.GetString("button3.ToolTip"));
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonPercent
            // 
            resources.ApplyResources(this.buttonPercent, "buttonPercent");
            this.buttonPercent.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonPercent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPercent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonPercent.Name = "buttonPercent";
            this.PercentHelp.SetToolTip(this.buttonPercent, resources.GetString("buttonPercent.ToolTip"));
            this.buttonPercent.UseVisualStyleBackColor = false;
            this.buttonPercent.Click += new System.EventHandler(this.buttonPercent_Click);
            this.buttonPercent.MouseEnter += new System.EventHandler(this.buttonPercent_MouseEnter);
            // 
            // buttonSing
            // 
            resources.ApplyResources(this.buttonSing, "buttonSing");
            this.buttonSing.BackColor = System.Drawing.Color.Gray;
            this.buttonSing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSing.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonSing.Name = "buttonSing";
            this.PercentHelp.SetToolTip(this.buttonSing, resources.GetString("buttonSing.ToolTip"));
            this.buttonSing.UseVisualStyleBackColor = false;
            this.buttonSing.Click += new System.EventHandler(this.buttonSing_Click);
            // 
            // button0
            // 
            resources.ApplyResources(this.button0, "button0");
            this.button0.BackColor = System.Drawing.Color.Gray;
            this.button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button0.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button0.Name = "button0";
            this.PercentHelp.SetToolTip(this.button0, resources.GetString("button0.ToolTip"));
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDot
            // 
            resources.ApplyResources(this.buttonDot, "buttonDot");
            this.buttonDot.BackColor = System.Drawing.Color.Gray;
            this.buttonDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDot.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDot.Name = "buttonDot";
            this.PercentHelp.SetToolTip(this.buttonDot, resources.GetString("buttonDot.ToolTip"));
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonResultat
            // 
            resources.ApplyResources(this.buttonResultat, "buttonResultat");
            this.buttonResultat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonResultat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResultat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonResultat.Name = "buttonResultat";
            this.PercentHelp.SetToolTip(this.buttonResultat, resources.GetString("buttonResultat.ToolTip"));
            this.buttonResultat.UseVisualStyleBackColor = false;
            this.buttonResultat.Click += new System.EventHandler(this.buttonResultat_Click);
            // 
            // HistoryBox
            // 
            resources.ApplyResources(this.HistoryBox, "HistoryBox");
            this.HistoryBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HistoryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoryBox.CausesValidation = false;
            this.HistoryBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.ReadOnly = true;
            this.PercentHelp.SetToolTip(this.HistoryBox, resources.GetString("HistoryBox.ToolTip"));
            // 
            // MainLabel
            // 
            resources.ApplyResources(this.MainLabel, "MainLabel");
            this.MainLabel.Name = "MainLabel";
            this.PercentHelp.SetToolTip(this.MainLabel, resources.GetString("MainLabel.ToolTip"));
            this.MainLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainLabel_MouseClick);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.MainLabel);
            this.panel1.Controls.Add(this.HistoryBox);
            this.panel1.Name = "panel1";
            this.PercentHelp.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // PercentHelp
            // 
            this.PercentHelp.AutomaticDelay = 1500;
            this.PercentHelp.AutoPopDelay = 15000;
            this.PercentHelp.InitialDelay = 1500;
            this.PercentHelp.ReshowDelay = 1500;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.PercentHelp.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonClear;
        private Button buttonDivide;
        private Button buttoMultip;
        private Button buttonDelete;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonSubtract;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button buttonAdding;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonPercent;
        private Button buttonSing;
        private Button button0;
        private Button buttonDot;
        private Button buttonResultat;
        private TextBox HistoryBox;
        private Label MainLabel;
        private Panel panel1;
        private ToolTip PercentHelp;
    }
}

