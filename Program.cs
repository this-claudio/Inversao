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
            Calcula.Somar(Criar.Complexo(real:3.0,imaginario:2.0),Criar.Complexo(angulo:0.5878,modulo:3.6,radiano:true));
            cout << "Programa encerrado" << endl;
           
            
      
        }
    }
}
