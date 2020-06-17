using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Lab2Progra
{
    public class Operac
    {
        public static double multip(double n1) {
            return n1 * 2;
        }

        public static void escribirBitacora(string txtAlmacenado)
        {
            using (StreamWriter objStrem = new StreamWriter(@"C:\Operaciones\Resultado.txt", true))
            {
                objStrem.WriteLine(txtAlmacenado);
                objStrem.Flush(); //File save
            }
           
        }
    }
}