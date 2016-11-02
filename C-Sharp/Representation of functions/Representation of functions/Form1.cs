/*
 * 0.01 - 13 May - Creation of the text box and implement analysis of function and represent
 * 0.02 - 23 May - Implementation when more than two values and the two operations
 * 0.03 - 24 May - Implementation when more than two values with one X and the two operations only multiply with sum 
 *                  and the priority order to perform, multiplication and division They have done before addition and subtraction
 * 0.04 - 25 May - Fix memory and attempt to implement when two numerical values, X and operations are add, subtract, multiply and divide 
 * 0.05 - 27 May - The program make multiplies with add
 * 0.06 - 30 May - Friendly program, implemnt menu File and its contents. Adds value table
 * 0.07 - 31 May - The program make multiplies with divide and multiplies with Subtrack
 * 0.08 - 1 June - Load and save in file, and first version to make divisions with sums
 * 0.09 - 2 June - Second version to make divisions with sums (i.e. 1+5/x). And the read file functions are stored in a queue and 
 *                  will dequeue, when there are no more functions to represent the user is notified.
 * 0.10 - 6 June - First version of establish the order of priority when the function has parentheses, inside the parentheses is done first
 *                  and then the rest of the operations 
 * 0.11 - 7 June - Third version to make divisions with sums (1+x/5, x/5+1).
 * 0.12 - 8 June - Implements of Trigonometric functions sine, cosine, tangent.
 * 0.13 - 9 June - Fix Trigonometric functions sine, cosine, tangent, and box of values X
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Representation_of_functions
{
    public partial class Form1 : Form
    {
        private Queue functionQueue = new Queue();
        private Operations operations = new Operations();
        private TrigonometricFunctions trigonometric = new TrigonometricFunctions();
        private bool tablevalues = false;
        private bool show = false;
        private static double[] y;
        private static double[] x;
        public Form1()
        {
            InitializeComponent();
            tbResult.Hide();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void chart1_Click(object sender, EventArgs e)
        {

        }

        public void tbFunction_TextChanged(object sender, EventArgs e)
        {

        }

        public void btExecute_Click(object sender, EventArgs e)
        {
            tbResult.Hide();
            string line;
            bool load = true;
            show = false;
            // Clean chart
            chart1.Series["Series1"].Points.Clear();
            try
            {
                if (functionQueue.Count != 0)
                {
                    line = (string)functionQueue.Dequeue();
                    tbFunction.Text = line;
                    load = functionQueue.Count == 0 ? false : true;
                }

                else
                {
                    line = tbFunction.Text;
                }

                if (line.Contains("sin") || line.Contains("cos") || line.Contains("tan"))
                {
                    trigonometric.SetValues(line);
                    x = trigonometric.GetValuesX();
                    y = trigonometric.GetValuesY();
                }
                else
                {
                    operations.SetValues(line);
                    x = operations.GetValuesX();
                    y = operations.GetValuesY();
                }
                if (!operations.GetMissParentheses())
                {
                    if (tablevalues)
                    {
                        //tbx_tablevalues.Text = Math.Round(x[0], 2) + "  " + Math.Round(y[0], 2) + "\n";
                        string tableValues = "";
                        for (int i = 0; i < x.Length; i+=10)
                        {
                            string tempX = x[i].ToString("###0.00");
                            string tempY = y[i].ToString("###0.00");
                            tableValues += tempX + "  " + tempY + " \n";
                        }
                        tbx_tablevalues.Text = tableValues;
                    }
                    for (int i = 0; i < x.Length; i++)
                    {
                        chart1.Series["Series1"].Points.AddXY(x[i], y[i]);
                    }


                    chart1.Series["Series1"].ChartType = SeriesChartType.Point;

                    chart1.Series["Series1"].Color = Color.Red;
                }
                else
                {
                    MessageBox.Show("Missing parentheses");
                }

                if (!load)
                {
                    MessageBox.Show("Not exists more functions");
                }
            }
            // catch Convert
            catch (FormatException)
            {
                tbResult.Show();
                tbResult.Text = "Error! Invalid number";
            }
            catch (Exception)
            {
                tbResult.Show();
                tbResult.Text = "Error!";
            }
        }

        private void mn_File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mn_File_Help_Guide_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adittion: X + Y\nSubtraction: X - Y\nDivision: X / Y\n"
                + "Multiplication: X * Y\nLogarithms (log)\nSquare roots: (function) ^ (1 / 2)\n"
                + "Generic roots: (function) ^ (1 / index))\nSine: sin(funtion)\nCosine: cos(function)\n"
                + "Tangent: tan(function)","Nomenclature Command"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void mn_File_Help_Functionality_Click(object sender, EventArgs e)
        {
            MessageBox.Show("With this application you can represent functions."
                + "It is only valid for any function with any of these operators: "
                + "addition, subtraction, division, multiplication, root, exponential "
                + "and root. View the command guie.", "Functionality", MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }


        private void grBox_tablevalues_Enter(object sender, EventArgs e)
        {

        }

        private void chck_tablevalues_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (!check.Checked)
            {
                tablevalues = false;
                this.grBox_tablevalues.Visible = false;
            }
            else
            {
                tablevalues = true;
                this.grBox_tablevalues.Visible = true;
                FillTableValues();
            }
        }

        private void FillTableValues()
        {
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application to represent  functions by Jose Muñoz"
                , "About", MessageBoxButtons.OK  , MessageBoxIcon.Information);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (File.Exists("function.rof"))
            {
                try
                {
                    StreamWriter myFile = File.AppendText("function.rof");
                    if (tbFunction.Text != "")
                    {
                        myFile.WriteLine(tbFunction.Text);
                        myFile.WriteLine("###");
                    }
                    else
                        tbResult.Text = "There isn't function to save";
                    myFile.Close();
                    MessageBox.Show("The function has been saved");
                }
                catch (PathTooLongException)
                {
                    tbResult.Text = "Error! Too long";
                }
                catch (IOException exc)
                {
                    tbResult.Text = "Input/output error " + exc.Message;
                }
                catch (Exception exp)
                {
                    tbResult.Text = exp.Message;
                }
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists("function.rof"))
            {
                try
                {
                    StreamReader myFile = File.OpenText("function.rof");
                    string line;
                    do
                    {
                        line = myFile.ReadLine();
                        if (line != null)
                        {
                            if (!line.Contains("<") && !line.Contains("#"))
                                functionQueue.Enqueue(line);
                        }
                    } while (line != null);
                    myFile.Close();
                    MessageBox.Show("File loaded");
                }
                catch (PathTooLongException)
                {
                    tbResult.Text = "Error! Too long";
                }
                catch (IOException exc)
                {
                    tbResult.Text = "Input/output error " + exc.Message;
                }
                catch (Exception exp)
                {
                    tbResult.Text = exp.Message;
                }
            }
        }

        private void tbx_tablevalues_TextChanged(object sender, EventArgs e)
        {

        }
        


        /* private void btSave_Click(object sender, EventArgs e)
         {

         }

         private void btLoad_Click(object sender, EventArgs e)
         {

         }*/
    }
}
