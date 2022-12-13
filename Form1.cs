using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancuoiki
{
    public partial class Form1 : Form
    {
        

        const int CONTROL_SIZE = 30;
        bool _isInProcess = false;
        bool _isInfix2Prefix = true;

        public Form1()
        {
            InitializeComponent();

            this.Text = Application.ProductName + " " + Application.ProductVersion;

        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtInfixExpression.Text.Trim()))
                return;

            if (!timer1.Enabled)
            {
                if (!_isInProcess)
                {
                    string infix = txtInfixExpression.Text;
                    Y2Expression.FormatExpression(ref infix);

                    IEnumerable<string> enumer;
                    if (_isInfix2Prefix)
                    {
                        infix = infix.Replace("(", "#");
                        infix = infix.Replace(")", "(");
                        infix = infix.Replace("#", ")");

                        enumer = infix.Split(' ').Reverse();

                    }
                    else
                        enumer = infix.Split(' ');

                    foreach (string s in enumer)
                    {
                        Label lbl = new Label();
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Text = s;
                        lbl.BackgroundImageLayout = ImageLayout.Stretch;

                        lbl.Width = CONTROL_SIZE;
                        lbl.Height = CONTROL_SIZE;

                        pnlExpression.Controls.Add(lbl);
                    }
                    listView1.Items.Clear();
                    txtFinalExpression.Clear();

                }
                btnStartPause.Text = "Pause";
            }
            else
            {
                if (_isInProcess)
                    btnStartPause.Text = "Resume";
                else
                    btnStartPause.Text = "Start";
            }
            _isInProcess = true;
            timer1.Enabled = !timer1.Enabled;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!_isInProcess)
                return;
            pnlExpression.Controls.Clear();
            pnlOutput.Controls.Clear();
            pnlStack.Controls.Clear();


            btnStartPause.Text = "Start";
            _isInProcess = false;
            timer1.Stop();

        }

        private void ProcessPostfix(Control ctl)
        {
            if (Y2Expression.IsOperand(ctl.Text))
                Output(ctl);
            else if (ctl.Text == "(")
                PushStack(ctl);
            else if (ctl.Text == ")")
            {
                Control x = PopStack();
                while (x.Text != "(")
                {
                    Output(x);
                    x = PopStack();
                }
            }
            else // operator
            {
                while (pnlStack.Controls.Count > 0 &&
                    Y2Expression.GetPriority(ctl.Text) <= Y2Expression.GetPriority(PeekStack().Text))
                    Output(PopStack());
                PushStack(ctl);
            }

        }

        Control PeekStack()
        {
            return pnlStack.Controls[pnlStack.Controls.Count - 1];
        }
        Control PopStack()
        {
            Control ctl = pnlStack.Controls[pnlStack.Controls.Count - 1];
            pnlStack.Controls.Remove(ctl);

            return ctl;
        }
        void PushStack(Control ctl)
        {
            pnlStack.Controls.Add(ctl);

            if (pnlStack.Controls.Count > 1)
                pnlStack.BackColor = Color.White;
        }
        void Output(Control ctl)
        {
            pnlOutput.Controls.Add(ctl);

            if (pnlOutput.Controls.Count > 1)
                pnlOutput.BackColor = Color.White;
        }

        void AddToListView(Control ctl)
        {
            string s = String.Empty;
            if (ctl != null)
                s = ctl.Text;
            ListViewItem item = listView1.Items.Add(s);
            StringBuilder str = new StringBuilder();

            // stack
            foreach (Control c in pnlStack.Controls)
                str.Append(c.Text).Append(" ");

            s = str.ToString().Trim();
            if (s == String.Empty)
                s = "{Empty}";

            item.SubItems.Add(s);

            // output
            str = new StringBuilder();
            foreach (Control c in pnlOutput.Controls)
                str.Append(c.Text).Append(" ");

            s = str.ToString().Trim();
            if (s == String.Empty)
                s = "{Empty}";
            item.SubItems.Add(s);

            if (listView1.Items.Count > 1)
                listView1.Items[listView1.Items.Count - 2].Selected = false;

            item.Selected = true;

            listView1.TopItem = item;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            StepForward();
        }

        private void radInfix2Prefix_CheckedChanged(object sender, EventArgs e)
        {
            // Ko cho phép đổi nếu đang In Process
            if (!_isInProcess)
                _isInfix2Prefix = radInfix2Prefix.Checked;

            radInfix2Prefix.Checked = _isInfix2Prefix;
            radInfix2Postfix.Checked = !_isInfix2Prefix;
        }

        
        private void btnStepForward_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                btnStartPause_Click(null, null);
                btnStartPause.Text = "Resume";
                timer1.Stop();
                StepForward();
            }


        }

        private void StepForward()
        {
            try
            {
                if (pnlExpression.Controls.Count > 0)
                {
                    Control ctl = pnlExpression.Controls[0];
                    ctl.BackColor=Color.SkyBlue;

                    pnlExpression.Controls.Remove(ctl);
                    if (_isInfix2Prefix)
                        ProcessPostfix(ctl);
                    else
                        ProcessPostfix(ctl);

                    AddToListView(ctl);
                }
                else if (pnlStack.Controls.Count > 0)
                {
                    Control ctl = PopStack();
                    Output(ctl);

                    // last 
                    if (pnlExpression.Controls.Count == 0 && pnlStack.Controls.Count == 0)
                        AddToListView(null);
                }
                else if (pnlOutput.Controls.Count > 0) // final expression
                {
                    int index = 0;
                    if (_isInfix2Prefix)
                        index = pnlOutput.Controls.Count - 1;

                    if (pnlOutput.Controls.Count > 1)
                        pnlOutput.BackColor = Color.White;

                    Control ctl = pnlOutput.Controls[index];

                    txtFinalExpression.Text += ctl.Text + " ";
                    pnlOutput.Controls.Remove(ctl);

                    ctl.Dispose();
                }
                else
                {
                    btnReset_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btnGo_Click(object sender, EventArgs e)
        {
            
            bsTreePanel1.InfixExpression = txtInfixExpression.Text;
            if (tabControl1.SelectedIndex == 0)
                btnStartPause_Click(null, null);
            Console.WriteLine(Y2Expression.Infix2Prefix(txtInfixExpression.Text));

            try
            {
                if (_isInfix2Prefix)
                    lblResult.Text = Y2Expression.EvaluatePrefix(Y2Expression.Infix2Prefix(txtInfixExpression.Text)).ToString();
                else
                    lblResult.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(txtInfixExpression.Text)).ToString();
            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                btnGo_Click(null, null);

        }

    }


}


