﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
        public class GenericClass<T>
        {
            public GenericClass(T msg)
            {
                Console.WriteLine(msg);
            }
        }
        
    }

