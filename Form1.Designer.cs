namespace doancuoiki
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
            this.components = new System.ComponentModel.Container();
            this.txtInfixExpression = new System.Windows.Forms.TextBox();
            this.btnStartPause = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlExpression = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlStack = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlOutput = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFinalExpression = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radInfix2Prefix = new System.Windows.Forms.RadioButton();
            this.radInfix2Postfix = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bsTreePanel1 = new WindowsFormsApplication2.BSTreePanel();
            this.lblResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInfixExpression
            // 
            this.txtInfixExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfixExpression.Location = new System.Drawing.Point(145, 22);
            this.txtInfixExpression.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfixExpression.Name = "txtInfixExpression";
            this.txtInfixExpression.Size = new System.Drawing.Size(615, 22);
            this.txtInfixExpression.TabIndex = 0;
            this.txtInfixExpression.Text = "(10/2-2)*(7+5)";
            // 
            // btnStartPause
            // 
            this.btnStartPause.BackColor = System.Drawing.Color.MistyRose;
            this.btnStartPause.Location = new System.Drawing.Point(650, 5);
            this.btnStartPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(99, 27);
            this.btnStartPause.TabIndex = 1;
            this.btnStartPause.Text = "Start";
            this.btnStartPause.UseVisualStyleBackColor = false;
            this.btnStartPause.Click += new System.EventHandler(this.btnStartPause_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 318);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(952, 246);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Token";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stack";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Output";
            this.columnHeader3.Width = 150;
            // 
            // pnlExpression
            // 
            this.pnlExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlExpression.AutoScroll = true;
            this.pnlExpression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExpression.Location = new System.Drawing.Point(21, 31);
            this.pnlExpression.Margin = new System.Windows.Forms.Padding(4);
            this.pnlExpression.Name = "pnlExpression";
            this.pnlExpression.Size = new System.Drawing.Size(938, 39);
            this.pnlExpression.TabIndex = 3;
            this.pnlExpression.WrapContents = false;
            // 
            // pnlStack
            // 
            this.pnlStack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStack.AutoScroll = true;
            this.pnlStack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStack.Location = new System.Drawing.Point(21, 98);
            this.pnlStack.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStack.Name = "pnlStack";
            this.pnlStack.Size = new System.Drawing.Size(938, 39);
            this.pnlStack.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlOutput
            // 
            this.pnlOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOutput.AutoScroll = true;
            this.pnlOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOutput.Location = new System.Drawing.Point(21, 165);
            this.pnlOutput.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOutput.Name = "pnlOutput";
            this.pnlOutput.Size = new System.Drawing.Size(938, 39);
            this.pnlOutput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Final Expression ";
            // 
            // txtFinalExpression
            // 
            this.txtFinalExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinalExpression.BackColor = System.Drawing.Color.LightCyan;
            this.txtFinalExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalExpression.ForeColor = System.Drawing.Color.Maroon;
            this.txtFinalExpression.Location = new System.Drawing.Point(155, 274);
            this.txtFinalExpression.Margin = new System.Windows.Forms.Padding(4);
            this.txtFinalExpression.Name = "txtFinalExpression";
            this.txtFinalExpression.Size = new System.Drawing.Size(669, 22);
            this.txtFinalExpression.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Infix Expression:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Infix Expression (formatted): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stack:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Output:";
            // 
            // radInfix2Prefix
            // 
            this.radInfix2Prefix.AutoSize = true;
            this.radInfix2Prefix.BackColor = System.Drawing.Color.PaleTurquoise;
            this.radInfix2Prefix.Location = new System.Drawing.Point(412, 12);
            this.radInfix2Prefix.Margin = new System.Windows.Forms.Padding(4);
            this.radInfix2Prefix.Name = "radInfix2Prefix";
            this.radInfix2Prefix.Size = new System.Drawing.Size(97, 20);
            this.radInfix2Prefix.TabIndex = 11;
            this.radInfix2Prefix.Text = "Infix to Prefix";
            this.radInfix2Prefix.UseVisualStyleBackColor = false;
            this.radInfix2Prefix.CheckedChanged += new System.EventHandler(this.radInfix2Prefix_CheckedChanged);
            // 
            // radInfix2Postfix
            // 
            this.radInfix2Postfix.AutoSize = true;
            this.radInfix2Postfix.BackColor = System.Drawing.Color.PaleTurquoise;
            this.radInfix2Postfix.Checked = true;
            this.radInfix2Postfix.Location = new System.Drawing.Point(174, 12);
            this.radInfix2Postfix.Margin = new System.Windows.Forms.Padding(4);
            this.radInfix2Postfix.Name = "radInfix2Postfix";
            this.radInfix2Postfix.Size = new System.Drawing.Size(103, 20);
            this.radInfix2Postfix.TabIndex = 11;
            this.radInfix2Postfix.TabStop = true;
            this.radInfix2Postfix.Text = "Infix to Postfix";
            this.radInfix2Postfix.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pnlOutput);
            this.panel1.Controls.Add(this.pnlStack);
            this.panel1.Controls.Add(this.pnlExpression);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(15, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1328, 222);
            this.panel1.TabIndex = 12;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 28);
            this.linkLabel1.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 91);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(993, 613);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radInfix2Prefix);
            this.tabPage1.Controls.Add(this.txtFinalExpression);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnStartPause);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.radInfix2Postfix);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(985, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Expression Converter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bsTreePanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(985, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Expression Tree";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bsTreePanel1
            // 
            this.bsTreePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bsTreePanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bsTreePanel1.InfixExpression = null;
            this.bsTreePanel1.Location = new System.Drawing.Point(12, 7);
            this.bsTreePanel1.Margin = new System.Windows.Forms.Padding(5);
            this.bsTreePanel1.Name = "bsTreePanel1";
            this.bsTreePanel1.Size = new System.Drawing.Size(961, 598);
            this.bsTreePanel1.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(141, 59);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(14, 16);
            this.lblResult.TabIndex = 18;
            this.lblResult.Text = "_";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1017, 727);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInfixExpression);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "doancuoiki ExpressionTree";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfixExpression;
        private System.Windows.Forms.Button btnStartPause;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.FlowLayoutPanel pnlExpression;
        private System.Windows.Forms.FlowLayoutPanel pnlStack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel pnlOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFinalExpression;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radInfix2Prefix;
        private System.Windows.Forms.RadioButton radInfix2Postfix;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private WindowsFormsApplication2.BSTreePanel bsTreePanel1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label8;
    }
}

