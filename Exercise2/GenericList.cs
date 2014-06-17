using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class GenericList<T> 
    {
        private T First;
        private T Second;


        public  GenericList(T x, T y)
        {
            this.First = x;
            this.Second = y;

        }

        public bool compare() {
            if (First.Equals(Second))
            {
                return true;
            }
        else
            {
                return false;
            }
            }
        }
    }
