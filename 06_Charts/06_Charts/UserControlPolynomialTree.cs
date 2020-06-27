using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Charts
{
    public partial class UserControlPolynomialTree : UserControl, IFunctionTree
    {
        public UserControlPolynomialTree()
        {
            InitializeComponent();
            
            groupBox.Text = FunctionNameTree;

        }

        public string FunctionNameTree
        {
            get
            {
                return string.Format("f(x) = {0}*x^ {1} + {2}*x + {3} ", numericUpDownA.Value, numericUpDownStopien.Value, numericUpDownB.Value,numericUpDownC.Value);
            }
        }
        public event emptyFunctionTree FunctionChangedTree;

        public double ValueTree(double x)
        {
            return (double)(numericUpDownA.Value) * Math.Pow(x,(double)numericUpDownStopien.Value) + (double)(numericUpDownB.Value) * x + (double)(numericUpDownC.Value);
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            groupBox.Text = FunctionNameTree;
            if (FunctionChangedTree != null)
            {
                FunctionChangedTree();
            }
        }
    }
}
