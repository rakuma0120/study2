using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study2
{
    public  class TestBase
    {

        private executePro _execute;

        public TestBase(executePro execute)
        {
            _execute = execute;
        }

        public executePro Execute 
        { 
            get { return _execute; }
        }

        public virtual int Compare()
        {
            return Execute(1,2);
        }


        public delegate int executePro(int x, int y);


    }
}
