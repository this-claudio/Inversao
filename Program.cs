using System;
using System.Collections.Generic;
using ComplexoCalcula;
using ComplexoFactory;

namespace Inversao
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcula.Somar(Criar.Complexo(real:3.0,imaginario:2.0),Criar.Complexo(angulo:1.5707,modulo:3.6,radiano:true));
            Calcula.Somar(Criar.Complexo(imaginario:2.0),Criar.Complexo(angulo:45.00,modulo:3.6,radiano:false));  
      
        }
    }
}
