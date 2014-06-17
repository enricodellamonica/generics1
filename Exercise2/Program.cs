using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {

            GenericList<int> gl= new GenericList<int>(1,1);
            
            Console.WriteLine(gl.compare());
            Console.ReadLine();
        }
        }
    }
