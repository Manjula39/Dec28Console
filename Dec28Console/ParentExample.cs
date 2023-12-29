using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dec28Console
{
    public class ParentExample
    {
        public void Building() { Console.WriteLine("all classes of same project or another will able to access public member  "); }
        protected void LicPolicy() { Console.WriteLine("all classes of same project will able to access protected member"); }
        private void Education() { Console.WriteLine("never accessible outside the class"); }
    }
    public class child1 : ParentExample
    {
        static void Main(string[] args)
        {
            child1 c1 = new child1();
            c1.Building();
            c1.LicPolicy();
            ParentExample pe = new ParentExample();
            pe.Building();
        }
    }
    class Testing
    {
        static void Main(string[] args)
        {
            // child , parent instance,please check again
        }
    }
}
