using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Representation_of_functions
{
    class TrigonometricFunctions : Operations
    {
        public override void SetValues(string line)
        {
            this.line = line;
            if (line.Substring(0, 1) == "-")
            {
                line = "0" + line;
            }
            if (line.Contains("(") && line.Contains(")"))
            {
                string[] part = line.Split(parentheses);
                if (part[0] == "sin" && part[2] == "")
                {
                    line = part[1];
                    CallOperations(line);
                    Sine(part[0]);
                }

                else if (part[0] == "cos" && part[2] == "")
                {
                    line = part[1];
                    CallOperations(line);
                    Cosine(part[0]);
                }
                else if (part[0] == "tan" && part[2] == "")
                {
                    line = part[1];
                    CallOperations(line);
                    Tangent(part[0]);
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
            else if (!line.Contains("(") && !line.Contains(")"))
            {
                missingParantheses = true;
            }
        }

        protected void Sine(string parts)
        {
            for (int i = 0; i < valuesX.Length; i++)
            {
                result = Math.Sin(valuesY[i]);
                valuesY[i] = result;
            }
        }
        protected void Cosine(string parts)
        {
            for (int i = 0; i < valuesX.Length; i++)
            {
                result = Math.Cos(valuesY[i]);
                valuesY[i] = result;
            }
        }
        protected void Tangent(string parts)
        {
            for (int i = 0; i < valuesX.Length; i++)
            {
                result = Math.Tan(valuesY[i]);
                valuesY[i] = result;
            }
        }
        protected void InverseSine(string[] parts)
        {
            //TO DO
        }
        protected void InverseCosine(string[] parts)
        {
            //TO DO
        }
        protected void InverseTangent(string[] parts)
        {
            //TO DO
        }
    }
}
