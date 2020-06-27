using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Charts
{
    interface IFunctionTree
    {
        string FunctionNameTree
        {
            get;
        }

        double ValueTree(double x);
        event emptyFunctionTree FunctionChangedTree;

    }
    public delegate void emptyFunctionTree();

}
