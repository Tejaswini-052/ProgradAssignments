using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GenericMethod
    {
        
            public void Display<T>(T msg)
            {
                Console.WriteLine(msg);
            }
        }
   }

