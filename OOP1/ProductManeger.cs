﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManeger
    {
        //encapsulation
        public void Add(Product product)//Methotdur:
        {
            Console.WriteLine(product.ProductName + " "+ "Eklendi.");
            
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName, product + "Güncelendi.");
            
        }

       

    }
}
