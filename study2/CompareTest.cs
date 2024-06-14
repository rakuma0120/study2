using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study2
{
    public class CompareTest : Test
    {
        public  readonly CompareTest test1 = new CompareTest(
            delegate (int x, int y) { return x + y; }
            );

        public readonly CompareTest test2 = new CompareTest(
            "testFiled"
            );

        public CompareTest(executePro execute) : base(execute)
        {
        }

        public CompareTest(string fieldName) :base(fieldName)
        {
        }
    }
}
