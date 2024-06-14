using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study2
{
    public class Test : TestBase
    {

        private string _fieldName;

        public Test(executePro execute) : base(execute)
        {
        }

        public Test(string fieldName) : base((executePro)null)
        {
            _fieldName = fieldName;
        }



        public string FieldName 
        { 
            get { return _fieldName; }
        }


        public override int Compare()
        {
            if(FieldName != "")
            {
                return 1;
            }
            else
            {
                return base.Compare();
            }
            
        }
    }
}
