using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Representation_of_functions
{
    public class Operations
    {
        protected string line;
        protected string[] parts;
        protected double[] valuesX = new double[150];
        protected double[] valuesY = new double[150];
        private double n1 = 0;
        private double n2 = 0;
        private double n3 = 0;
        protected double result = 0;
        protected bool change = false;
        private bool exit = false;
        protected char[] parentheses = { '(', ')' };
        protected bool missingParantheses = false;
        protected bool table = false;

        public virtual void SetValues(string line)
        {
            this.line = line;
            if (line.Substring(0, 1) == "-")
            {
                line = "0" + line;
            }
            if (line.Contains("(") && line.Contains(")"))
            {
                string[] part = line.Split(parentheses);
                if (part[0] == "" && part[2] == "")
                {
                    line = part[1];
                    CallOperations(line);
                }

                else
                {
                    part = line.Split('(');
                    if (part.Length == 2 && part[0] != "")
                    {
                        string parte1 = part[0];
                        line = part[1];
                        part = line.Split(')');
                        /*if (part.Length == 1)
                        {
                        }*/
                        line = part[0];
                        if (!line.Contains("x"))
                        {
                            change = true;
                        }
                        CallOperations(line);
                        change = false;
                        table = true;
                        line = parte1 + "0";
                        CallOperations(line);
                    }
                    else if (part.Length == 2 && part[0] == "")
                    {
                        line = part[1];
                        part = line.Split(')');
                        string parte1 = part[1];
                        line = part[0];
                        if (!line.Contains("x"))
                        {
                            change = true;
                        }
                        CallOperations(line);
                        change = false;
                        table = true;
                        line = "0" + parte1;
                        CallOperations(line);
                    }
                }
            }

            else if (line.Contains("(") && !line.Contains(")"))
            {
                missingParantheses = true;
            }
            else if (!line.Contains("(") && line.Contains(")"))
            {
                missingParantheses = true;
            }
            else
            {
                CallOperations(line);
            }
        }

        protected void CallOperations(string line)
        {
            string[] nums;
            if (line.Contains("*"))
            {
                nums = line.Split('*');
                parts = new string[nums.Length];
                for (int data = 0; data < nums.Length; data++)
                {
                    parts[data] = nums[data];
                }
                Multiply(parts);
            }
            else if (line.Contains("/"))
            {
                nums = line.Split('/');
                parts = new string[nums.Length];
                for (int data = 0; data < nums.Length; data++)
                {
                    parts[data] = nums[data];
                }
                Divide(parts);
            }
            else if (line.Contains("+"))
            {
                nums = line.Split('+');
                parts = new string[nums.Length];
                for (int data = 0; data < nums.Length; data++)
                {
                    parts[data] = nums[data];
                }
                Add(parts);
            }
            else if (line.Contains("-"))
            {
                nums = line.Split('-');
                parts = new string[nums.Length];
                for (int data = 0; data < nums.Length; data++)
                {
                    parts[data] = nums[data];
                }
                Subtract(parts);
            }
            else
            {
                for (int i = 0; i < 150; i++)
                {
                    valuesX[i] = (i - 50) / 10;
                    valuesY[i] = Convert.ToDouble(line);
                }
            }
        }
        public bool GetMissParentheses()
        {
            return missingParantheses;
        }
        public double[] GetValuesX()
        {
            return valuesX;
        }

        public double[] GetValuesY()
        {
            return valuesY;
        }

        protected void Add(string[] parts)
        {
            if (parts.Length == 3)
            {
                if (parts[0].Trim() == "x" && parts[1].Trim() != "x" && parts[2].Trim() != "x")
                {
                    n2 = Convert.ToDouble(parts[1].Trim());
                    n3 = Convert.ToDouble(parts[2].Trim());
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            result = xTemp + n2 + n3;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
                else if (parts[1].Trim() == "x" && parts[0].Trim() != "x" && parts[2].Trim() != "x")
                {
                    n1 = Convert.ToDouble(parts[0].Trim());
                    n3 = Convert.ToDouble(parts[2].Trim());
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            result = xTemp + n1 + n3;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
                else if (parts[2].Trim() == "x" && parts[0].Trim() != "x" && parts[1].Trim() != "x")
                {
                    n1 = Convert.ToDouble(parts[0].Trim());
                    n2 = Convert.ToDouble(parts[1].Trim());
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            result = xTemp + n1 + n2;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
                else
                {

                    n1 = Convert.ToDouble(parts[0].Trim());
                    n2 = Convert.ToDouble(parts[1].Trim());
                    n3 = Convert.ToDouble(parts[2].Trim());
                    result = n1 + n2 + n3;
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
            }
            else
            {
                try
                {
                    n1 = Convert.ToDouble(parts[0].Trim());
                }
                catch
                {
                    for (int i = 0; i < parts.Length; i++)
                    {
                        if (parts[i].Contains("/"))
                        {
                            string[] nums = parts[i].Split('/');
                            double temp1;
                            if (i == 0)
                                temp1 = Convert.ToDouble(parts[i + 1].Trim());
                            else
                                temp1 = Convert.ToDouble(parts[i - 1].Trim());
                            double temp2 = Convert.ToDouble(nums[0].Trim());
                            double tempResult = temp1 + temp2;
                            parts[i] = Convert.ToString(tempResult);
                            parts[i + 1] = nums[1];
                            Divide(parts);
                            change = true;
                        }
                        else if (parts[i].Contains("*"))
                        {
                            string[] nums = parts[i].Split('*');
                            double temp1;
                            if (i == 0)
                                temp1 = Convert.ToDouble(parts[i + 1].Trim());
                            else
                                temp1 = Convert.ToDouble(parts[i - 1].Trim());
                            double temp2 = Convert.ToDouble(nums[0].Trim());
                            double tempResult = temp1 + temp2;
                            parts[i] = Convert.ToString(tempResult);
                            parts[i + 1] = nums[1];
                            Multiply(parts);
                            change = true;
                        }
                        else if (parts[i].IndexOf("-", 1) >= 0)
                        {
                            string[] nums = parts[i].Split('-');
                            double temp1;
                            if (i == 0)
                                temp1 = Convert.ToDouble(parts[i + 1].Trim());
                            else
                                temp1 = Convert.ToDouble(parts[i - 1].Trim());
                            double temp2 = Convert.ToDouble(nums[0].Trim());
                            double tempResult = temp1 + temp2;
                            parts[i] = Convert.ToString(tempResult);
                            parts[i + 1] = nums[1];
                            Subtract(parts);
                            change = true;
                        }
                    }
                }
                if (parts[0].Trim() == "x")
                {
                    n2 = Convert.ToDouble(parts[1].Trim());
                    // draw graphic
                    for (int x = 0; x < 150; x++)
                    {
                        double xTemp = (x - 50.0) / 10.0;
                        valuesX[x] = xTemp;
                        valuesY[x] = xTemp + n2;
                    }
                }
                else if (parts[1].Trim() == "x")
                {
                    n1 = Convert.ToDouble(parts[0].Trim());
                    // draw graphic
                    for (int x = 0; x < 150; x++)
                    {
                        double xTemp = (x - 50.0) / 10.0;
                        valuesX[x] = xTemp;
                        valuesY[x] = xTemp + n1;
                    }
                }
                else if (table)
                {
                    for (int x = 0; x < 150; x++)
                    {
                        valuesY[x] += n1;
                    }
                }
                else
                {
                    n1 = Convert.ToDouble(parts[0].Trim());
                    n2 = Convert.ToDouble(parts[1].Trim());
                    result = n1 + n2;
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
            }
        }

        protected void Subtract(string[] parts)
        {
            //string[] nums = line.Split('-');
            if (parts.Length == 3)
            {
                if (parts[0].Trim() == "x" && parts[1].Trim() != "x" && parts[2].Trim() != "x")
                {
                    n2 = Convert.ToDouble(parts[1].Trim());
                    n3 = Convert.ToDouble(parts[2].Trim());
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            result = xTemp - n2 - n3;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
                else if (parts[1].Trim() == "x" && parts[0].Trim() != "x" && parts[2].Trim() != "x")
                {
                    n1 = Convert.ToDouble(parts[0].Trim());
                    n3 = Convert.ToDouble(parts[2].Trim());
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            result = n1 - xTemp - n3;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
                else if (parts[2].Trim() == "x" && parts[0].Trim() != "x" && parts[1].Trim() != "x")
                {
                    n1 = Convert.ToDouble(parts[0].Trim());
                    n2 = Convert.ToDouble(parts[1].Trim());
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            result = n1 - n2 - xTemp;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
                else
                {

                    n1 = Convert.ToDouble(parts[0].Trim());
                    n2 = Convert.ToDouble(parts[1].Trim());
                    n3 = Convert.ToDouble(parts[2].Trim());
                    result = n1 - n2 - n3;
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i].Contains("/"))
                    {
                        string[] nums = parts[i].Split('/');
                        double temp1;
                        if (i == 0)
                            temp1 = Convert.ToDouble(parts[i + 1].Trim());
                        else
                            temp1 = Convert.ToDouble(parts[i - 1].Trim());
                        double temp2 = Convert.ToDouble(nums[0].Trim());
                        double tempResult = temp1 - temp2;
                        parts[i] = Convert.ToString(tempResult);
                        parts[i + 1] = nums[1];
                        Divide(parts);
                        change = true;
                    }
                    else if (parts[i].Contains("*"))
                    {
                        string[] nums = parts[i].Split('*');
                        double temp1;
                        if (i == 0)
                            temp1 = Convert.ToDouble(parts[i + 1].Trim());
                        else
                            temp1 = Convert.ToDouble(parts[i - 1].Trim());
                        double temp2 = Convert.ToDouble(nums[0].Trim());
                        double tempResult = temp1 - temp2;
                        parts[i] = Convert.ToString(tempResult);
                        parts[i + 1] = nums[1];
                        Multiply(parts);
                        change = true;
                    }
                    else if (parts[i].Contains("+"))
                    {
                        string[] nums = parts[i].Split('+');
                        double temp1;
                        if (i == 0)
                            temp1 = Convert.ToDouble(parts[i + 1].Trim());
                        else
                            temp1 = Convert.ToDouble(parts[i - 1].Trim());
                        double temp2 = Convert.ToDouble(nums[0].Trim());
                        double tempResult = temp1 - temp2;
                        parts[i] = Convert.ToString(tempResult);
                        parts[i + 1] = nums[1];
                        Add(parts);
                        change = true;
                    }
                }
                if (parts[0].Trim() == "x")
                {
                    n2 = Convert.ToDouble(parts[1].Trim());
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            result = xTemp - n2;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
                else if (parts[1].Trim() == "x")
                {
                    n1 = Convert.ToDouble(parts[0].Trim());
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            result = n1 - xTemp;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
                else
                {
                    n1 = Convert.ToDouble(parts[0].Trim());
                    n2 = Convert.ToDouble(parts[1].Trim());
                    result = n1 - n2;
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
            }
        }

        protected void Multiply(string[] parts)
        {
            //string[] nums = line.Split('*');
            if (parts.Length == 3)
            {
                if (parts[0].Trim() == "x" && parts[1].Trim() != "x" && parts[2].Trim() != "x")
                {
                    n2 = Convert.ToDouble(parts[1].Trim());
                    n3 = Convert.ToDouble(parts[2].Trim());
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            valuesX[x] = xTemp;
                            valuesY[x] = xTemp * n2 * n3;
                        }
                    }
                }
                else if (parts[1].Trim() == "x" && parts[0].Trim() != "x" && parts[2].Trim() != "x")
                {
                    n1 = Convert.ToDouble(parts[0].Trim());
                    n3 = Convert.ToDouble(parts[2].Trim());
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            valuesX[x] = xTemp;
                            valuesY[x] = xTemp * n1 * n3;
                        }
                    }
                }
                else if (parts[2].Trim() == "x" && parts[0].Trim() != "x" && parts[1].Trim() != "x")
                {
                    n1 = Convert.ToDouble(parts[0].Trim());
                    n2 = Convert.ToDouble(parts[1].Trim());
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            valuesX[x] = xTemp;
                            valuesY[x] = xTemp * n1 * n2;
                        }
                    }
                }
                else
                {

                    n1 = Convert.ToDouble(parts[0].Trim());
                    n2 = Convert.ToDouble(parts[1].Trim());
                    n3 = Convert.ToDouble(parts[2].Trim());
                    result = n1 * n2 * n3;
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i] == "x" && !exit)
                    {
                        double temp1;
                        //double temp2;
                        double tempResult = 0;
                        string[] nums;
                        change = true;
                        if (parts.Contains("x"))
                        {
                            if (parts[i].Contains("+"))
                            {
                                nums = parts[i].Split('+');
                                change = true;
                                if (i == 0)
                                    temp1 = Convert.ToDouble(parts[i + 1].Trim());
                                else
                                    temp1 = Convert.ToDouble(parts[i - 1].Trim());
                                for (int x = 0; x < 150; x++)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    tempResult = xTemp * temp1;
                                    if (i == 0)
                                    {
                                        parts[i] = Convert.ToString(tempResult);
                                        parts[i + 1] = nums[0];
                                    }
                                    else
                                    {
                                        parts[i - 1] = Convert.ToString(tempResult);
                                        parts[i] = nums[1];
                                    }
                                    Add(parts);
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                            else
                            {
                                if (i < parts.Length - 1)
                                {
                                    nums = parts[i + 1].Split('+');
                                }
                                else
                                {
                                    nums = parts[i].Split('+');
                                }
                                if (i == 0)
                                    temp1 = Convert.ToDouble(nums[i].Trim());
                                else
                                    temp1 = Convert.ToDouble(nums[i - 1].Trim());

                                for (int x = 0; x < 150; x++)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    tempResult = xTemp * temp1;
                                    if (i == 0)
                                    {
                                        parts[i] = Convert.ToString(tempResult);
                                        parts[i + 1] = nums[1];
                                    }
                                    else
                                    {
                                        parts[i - 1] = Convert.ToString(tempResult);
                                        parts[i] = nums[1];
                                    }
                                    Add(parts);
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                        }
                        else if (parts.Contains("/"))
                        {
                            if (parts[i].Contains("/"))
                            {
                                nums = parts[i].Split('/');
                                change = true;
                                if (i == 0)
                                    temp1 = Convert.ToDouble(parts[i + 1].Trim());
                                else
                                    temp1 = Convert.ToDouble(parts[i - 1].Trim());
                                for (int x = 0; x < 150; x++)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    tempResult = xTemp * temp1;
                                    if (i == 0)
                                    {
                                        parts[i] = Convert.ToString(tempResult);
                                        parts[i + 1] = nums[0];
                                    }
                                    else
                                    {
                                        parts[i - 1] = Convert.ToString(tempResult);
                                        parts[i] = nums[1];
                                    }
                                    Divide(parts);
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                            else
                            {
                                if (i < parts.Length - 1)
                                {
                                    nums = parts[i + 1].Split('/');
                                }
                                else
                                {
                                    nums = parts[i].Split('/');
                                }
                                if (i == 0)
                                    temp1 = Convert.ToDouble(nums[i].Trim());
                                else
                                    temp1 = Convert.ToDouble(nums[i - 1].Trim());

                                for (int x = 0; x < 150; x++)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    tempResult = xTemp * temp1;
                                    if (i == 0)
                                    {
                                        parts[i] = Convert.ToString(tempResult);
                                        parts[i + 1] = nums[1];
                                    }
                                    else
                                    {
                                        parts[i - 1] = Convert.ToString(tempResult);
                                        parts[i] = nums[1];
                                    }
                                    Add(parts);
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                        }
                        else if (parts.Contains("-"))
                        {
                            if (parts[i].Contains("-"))
                            {
                                nums = parts[i].Split('-');
                                change = true;
                                if (i == 0)
                                    temp1 = Convert.ToDouble(parts[i + 1].Trim());
                                else
                                    temp1 = Convert.ToDouble(parts[i - 1].Trim());
                                for (int x = 0; x < 150; x++)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    tempResult = xTemp * temp1;
                                    if (i == 0)
                                    {
                                        parts[i] = Convert.ToString(tempResult);
                                        parts[i + 1] = nums[0];
                                    }
                                    else
                                    {
                                        parts[i - 1] = Convert.ToString(tempResult);
                                        parts[i] = nums[1];
                                    }
                                    Subtract(parts);
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                            else
                            {
                                if (i < parts.Length - 1)
                                {
                                    nums = parts[i + 1].Split('-');
                                }
                                else
                                {
                                    nums = parts[i].Split('+');
                                }
                                if (i == 0)
                                    temp1 = Convert.ToDouble(nums[i].Trim());
                                else
                                    temp1 = Convert.ToDouble(nums[i - 1].Trim());

                                for (int x = 0; x < 150; x++)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    tempResult = xTemp * temp1;
                                    if (i == 0)
                                    {
                                        parts[i] = Convert.ToString(tempResult);
                                        parts[i + 1] = nums[1];
                                    }
                                    else
                                    {
                                        parts[i - 1] = Convert.ToString(tempResult);
                                        parts[i] = nums[1];
                                    }
                                    Subtract(parts);
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                        }


                        //5*x
                    }
                    else
                    {
                        if (parts[i].Contains("/"))
                        {

                            double temp1;
                            double temp2;
                            double tempResult = 0;
                            string[] nums = parts[i].Split('/');
                            change = true;
                            if (parts[i].Contains("x"))
                            {
                                if (i == 0)
                                    temp1 = Convert.ToDouble(parts[i + 1].Trim());
                                else
                                    temp1 = Convert.ToDouble(parts[i - 1].Trim());
                                for (int x = 0; x < 150; x++)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    tempResult = xTemp * temp1;
                                    if (i == 0)
                                    {
                                        parts[i] = Convert.ToString(tempResult);
                                        parts[i + 1] = nums[0];
                                    }
                                    else
                                    {
                                        parts[i - 1] = Convert.ToString(tempResult);
                                        parts[i] = nums[1];
                                    }
                                    Divide(parts);
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                            else if (parts[i + 1].Contains("x"))
                            {
                                if (i == 0)
                                    temp1 = Convert.ToDouble(nums[i + 1].Trim());
                                else
                                    temp1 = Convert.ToDouble(parts[i - 1].Trim());
                                for (int x = 0; x < 150; x++)
                                {
                                    Divide(nums);
                                    double xTemp = (x - 50.0) / 10.0;
                                    tempResult = xTemp * temp1;

                                    valuesX[x] = xTemp;
                                    valuesY[x] = tempResult;
                                }
                            }
                            else
                            {
                                if (i == 0)
                                    temp1 = Convert.ToDouble(nums[i + 1].Trim());
                                else
                                    temp1 = Convert.ToDouble(parts[i - 1].Trim());
                                temp2 = Convert.ToDouble(nums[0].Trim());
                                tempResult = temp1 * temp2;

                                if (i == 0)
                                {
                                    parts[i] = Convert.ToString(tempResult);
                                    parts[i + 1] = nums[1];
                                }
                                else
                                {
                                    parts[i - 1] = Convert.ToString(tempResult);
                                    parts[i] = nums[1];
                                }
                                Divide(parts);
                                for (int x = 0; x < 150; x++)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    result = xTemp * n1;
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                            change = true;
                            exit = true;
                        }
                        else if (parts[i].Contains("+"))
                        {
                            double temp1;
                            double temp2;
                            double tempResult = 0;
                            string[] nums = parts[i].Split('+');
                            change = true;
                            if (parts[i].Contains("x"))
                            {
                                if (i == 0)
                                    temp1 = Convert.ToDouble(parts[i + 1].Trim());
                                else
                                    temp1 = Convert.ToDouble(parts[i - 1].Trim());
                                for (int x = 0; x < 150; x++)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    tempResult = xTemp * temp1;
                                    if (i == 0)
                                    {
                                        parts[i] = Convert.ToString(tempResult);
                                        parts[i + 1] = nums[0];
                                    }
                                    else
                                    {
                                        parts[i - 1] = Convert.ToString(tempResult);
                                        parts[i] = nums[1];
                                    }
                                    Add(parts);
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                            else if (parts[i + 1].Contains("x"))
                            {
                                if (i == 0)
                                    temp1 = Convert.ToDouble(nums[i + 1].Trim());
                                else
                                    temp1 = Convert.ToDouble(parts[i - 1].Trim());
                                for (int x = 0; x < 150; x++)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    tempResult = xTemp * temp1;
                                    if (i == 0)
                                    {
                                        parts[i] = Convert.ToString(tempResult);
                                        parts[i + 1] = nums[0];
                                    }
                                    else
                                    {
                                        parts[i - 1] = Convert.ToString(tempResult);
                                        parts[i] = nums[1];
                                    }
                                    Add(parts);
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                            else
                            {
                                if (i == 0)
                                    temp1 = Convert.ToDouble(parts[i + 1].Trim());
                                else
                                    temp1 = Convert.ToDouble(parts[i - 1].Trim());
                                temp2 = Convert.ToDouble(nums[0].Trim());
                                tempResult = temp1 * temp2;

                                if (i == 0)
                                {
                                    parts[i] = Convert.ToString(tempResult);
                                    parts[i + 1] = nums[1];
                                }
                                else
                                {
                                    parts[i - 1] = Convert.ToString(tempResult);
                                    parts[i] = nums[1];
                                }
                                Add(parts);
                                for (int x = 0; x < 150; x++)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    result = xTemp * n1;
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                            change = true;
                            exit = true;
                        }
                        else if (parts[i].Contains("-"))
                        {
                            double temp1;
                            double temp2;
                            double tempResult = 0;
                            string[] nums = parts[i].Split('-');
                            change = true;
                            if (parts[i].Contains("x"))
                            {
                                if (i == 0)
                                    temp1 = Convert.ToDouble(parts[i + 1].Trim());
                                else
                                    temp1 = Convert.ToDouble(parts[i - 1].Trim());
                                for (int x = 0; x < 150; x++)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    tempResult = xTemp * temp1;
                                    if (i == 0)
                                    {
                                        parts[i] = Convert.ToString(tempResult);
                                        parts[i + 1] = nums[0];
                                    }
                                    else
                                    {
                                        parts[i - 1] = Convert.ToString(tempResult);
                                        parts[i] = nums[1];
                                    }
                                    Subtract(parts);
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                            else if (parts[i + 1].Contains("x"))
                            {
                                if (i == 0)
                                    temp1 = Convert.ToDouble(nums[i + 1].Trim());
                                else
                                    temp1 = Convert.ToDouble(parts[i - 1].Trim());
                                for (int x = 0; x < 150; x++)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    tempResult = xTemp * temp1;
                                    if (i == 0)
                                    {
                                        parts[i] = Convert.ToString(tempResult);
                                        parts[i + 1] = nums[0];
                                    }
                                    else
                                    {
                                        parts[i - 1] = Convert.ToString(tempResult);
                                        parts[i] = nums[1];
                                    }
                                    Subtract(parts);
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                            else
                            {
                                if (i == 0)
                                    temp1 = Convert.ToDouble(parts[i + 1].Trim());
                                else
                                    temp1 = Convert.ToDouble(parts[i - 1].Trim());
                                temp2 = Convert.ToDouble(nums[0].Trim());
                                tempResult = temp1 * temp2;

                                if (i == 0)
                                {
                                    parts[i] = Convert.ToString(tempResult);
                                    parts[i + 1] = nums[1];
                                }
                                else
                                {
                                    parts[i - 1] = Convert.ToString(tempResult);
                                    parts[i] = nums[1];
                                }
                                Subtract(parts);
                                for (int x = 0; x < 150; x++)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    result = xTemp * n1;
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                            change = true;
                            exit = true;
                        }
                    }
                }
                if (parts[0].Trim() == "x" && !exit)
                {
                    n2 = Convert.ToDouble(parts[1].Trim());
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            result = xTemp * n2;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
                else if (parts[1].Trim() == "x" && !exit)
                {
                    n1 = Convert.ToDouble(parts[0].Trim());
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            result = xTemp * n1;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
                else if (!exit)
                {
                    n1 = Convert.ToDouble(parts[0].Trim());
                    n2 = Convert.ToDouble(parts[1].Trim());
                    result = n1 * n2;
                    // draw graphic
                    if (!change)
                    {
                        for (int x = 0; x < 150; x++)
                        {
                            double xTemp = (x - 50.0) / 10.0;
                            valuesX[x] = xTemp;
                            valuesY[x] = result;
                        }
                    }
                }
            }
        }

        protected void Divide(string[] parts)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                try
                {
                    n1 = Convert.ToDouble(parts[0].Trim());
                }
                catch
                {
                    if (parts[i].Contains("x"))
                    {
                        double temp1;
                        //double temp2;
                        double tempResult = 0;
                        string[] nums;
                        change = true;
                        if (parts[i].Contains("+"))
                        {
                            nums = parts[i].Split('+');
                            change = true;
                            if (i == 0)
                                temp1 = Convert.ToDouble(parts[i + 1].Trim());
                            else
                                temp1 = Convert.ToDouble(parts[i - 1].Trim());
                            for (int x = 0; x < 150; x += 5)
                            {
                                double xTemp = (x - 50.0) / 10.0;
                                tempResult = xTemp / temp1;
                                if (i == 0)
                                {
                                    parts[i] = Convert.ToString(tempResult);
                                    parts[i + 1] = nums[0];
                                }
                                else
                                {
                                    parts[i - 1] = Convert.ToString(tempResult);
                                    parts[i] = nums[1];
                                }
                                Add(parts);
                                valuesX[x] = xTemp;
                                valuesY[x] = result;
                            }
                        }
                        else
                        {
                            if (i < parts.Length - 1)
                            {
                                nums = parts[i + 1].Split('+');
                            }
                            else
                            {
                                nums = parts[i].Split('+');
                            }
                            if (i == 0)
                                temp1 = Convert.ToDouble(nums[i].Trim());
                            else
                                temp1 = Convert.ToDouble(nums[i - 1].Trim());

                            for (int x = 0; x < 150; x += 5)
                            {
                                double xTemp = (x - 50.0) / 10.0;
                                tempResult = xTemp / temp1;

                                if (i == 0)
                                {
                                    parts[i] = Convert.ToString(tempResult);
                                    parts[i + 1] = nums[1];
                                }
                                else
                                {
                                    parts[i - 1] = Convert.ToString(tempResult);
                                    parts[i] = nums[1];
                                }
                                Add(parts);
                                valuesX[x] = xTemp;
                                valuesY[x] = result;
                            }
                        }
                    }
                    if (parts[i].Contains("*"))
                    {
                        string[] nums = parts[i].Split('*');
                        double temp1;
                        if (i == 0)
                            temp1 = Convert.ToDouble(parts[i + 1].Trim());
                        else
                            temp1 = Convert.ToDouble(parts[i - 1].Trim());
                        double temp2 = Convert.ToDouble(nums[0].Trim());

                        double tempResult = temp1 / temp2;
                        parts[i] = Convert.ToString(tempResult);
                        parts[i + 1] = nums[1];
                        change = true;
                        Multiply(parts);
                    }
                    else if (parts[i].Contains("+"))
                    {
                        if (parts[i].Contains("+"))
                        {
                            double temp1;
                            double temp2;
                            double tempResult = 0;
                            string[] nums = parts[i].Split('+');
                            change = true;
                            if (parts[i].Contains("x"))
                            {
                                if (i == 0)
                                    temp1 = Convert.ToDouble(parts[i + 1].Trim());
                                else
                                    temp1 = Convert.ToDouble(parts[i - 1].Trim());
                                for (int x = 0; x < 150; x += 5)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    tempResult = xTemp / temp1;
                                    if (i == 0)
                                    {
                                        parts[i] = Convert.ToString(tempResult);
                                        parts[i + 1] = nums[0];
                                    }
                                    else
                                    {
                                        parts[i - 1] = Convert.ToString(tempResult);
                                        parts[i] = nums[1];
                                    }
                                    Add(parts);
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                            else if (parts[i + 1].Contains("x"))
                            {
                                if (i == 0)
                                    temp1 = Convert.ToDouble(nums[i + 1].Trim());
                                else
                                    temp1 = Convert.ToDouble(parts[i - 1].Trim());
                                for (int x = 0; x < 150; x += 5)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    if (xTemp != 0)
                                    {
                                        tempResult = temp1 / xTemp;
                                        if (i == 0)
                                        {
                                            parts[i] = Convert.ToString(tempResult);
                                            parts[i + 1] = nums[0];
                                        }
                                        else
                                        {
                                            parts[i - 1] = Convert.ToString(tempResult);
                                            parts[i] = nums[1];
                                        }
                                        Add(parts);
                                        valuesX[x] = xTemp;
                                        valuesY[x] = result;
                                    }
                                }
                            }
                            else
                            {
                                if (i == 0)
                                    temp1 = Convert.ToDouble(parts[i + 1].Trim());
                                else
                                    temp1 = Convert.ToDouble(parts[i - 1].Trim());
                                temp2 = Convert.ToDouble(nums[0].Trim());
                                tempResult = temp1 / temp2;

                                if (i == 0)
                                {
                                    parts[i] = Convert.ToString(tempResult);
                                    parts[i + 1] = nums[1];
                                }
                                else
                                {
                                    parts[i - 1] = Convert.ToString(tempResult);
                                    parts[i] = nums[1];
                                }
                                Add(parts);
                                for (int x = 0; x < 150; x += 5)
                                {
                                    double xTemp = (x - 50.0) / 10.0;
                                    result = xTemp / n1;
                                    valuesX[x] = xTemp;
                                    valuesY[x] = result;
                                }
                            }
                            change = true;
                            exit = true;
                        }
                    }
                    else if (parts[i].IndexOf("-", 1) >= 0)
                    {
                        string[] nums = parts[i].Split('-');
                        double temp1;
                        if (i == 0)
                            temp1 = Convert.ToDouble(parts[i + 1].Trim());
                        else
                            temp1 = Convert.ToDouble(parts[i - 1].Trim());
                        double temp2 = Convert.ToDouble(nums[0].Trim());
                        double tempResult = temp1 - temp2;
                        parts[i] = Convert.ToString(tempResult);
                        parts[i + 1] = nums[1];
                        Subtract(parts);
                        change = true;
                    }
                }
            }
            if (parts[0].Trim() == "x" && parts[1].Trim() != "0")
            {
                // draw graphic
                n2 = Convert.ToDouble(parts[1].Trim());
                if (!change)
                {
                    for (int x = 0; x < 150; x += 5)
                    {
                        double xTemp = (x - 50.0) / 10.0;
                        result = xTemp / n2;
                        valuesX[x] = xTemp;
                        valuesY[x] = result;
                    }
                }
            }
            else if (parts[1].Trim() == "x")
            {
                // draw graphic
                n1 = Convert.ToDouble(parts[0].Trim());
                if (!change)
                {
                    for (int x = 0; x < 150; x += 5)
                    {
                        double xTemp = (x - 50.0) / 10.0;
                        result = n1 / xTemp;
                        valuesX[x] = xTemp;
                        valuesY[x] = result;
                    }
                }

            }
            else
            {
                n1 = Convert.ToDouble(parts[0].Trim());
                n2 = Convert.ToDouble(parts[1].Trim());
                result = n1 / n2;
                // draw graphic
                if (!change)
                {
                    for (int x = 0; x < 150; x += 5)
                    {
                        double xTemp = (x - 50.0) / 10.0;
                        valuesX[x] = xTemp;
                        valuesY[x] = result;
                    }
                }
            }
        }

        protected void Pow(string[] parts)
        {
            //TO DO
        }
        protected void Root(string[] parts)
        {
            //TO DO
        }
        protected void Logarithm(string[] parts)
        {
            //TO DO
        }

    }
}
