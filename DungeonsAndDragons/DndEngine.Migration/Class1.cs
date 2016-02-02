using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndEngine.Migration
{
    public class Class1
    {
        public void AddingFunction(int inParameter1, int inParameter2, out int outParameter)
        {
            int something = inParameter1 + inParameter2;
        }

        public void CallingFunction()
        {
            int thing1 = 10;
            int thing2 = 20;
            int result;

            AddingFunction(thing1, thing2, out result);
           
        }
    }
}
