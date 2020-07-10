using System;
using System.Collections.Generic;

namespace ComplexoDefinicao
{
    public interface IComplexo
    {
        public void SetRetangular(double r, double i); // atribui valores retangulares a um objeto complexo
        public void SetPolar(double a, double m, bool rad);// atribui valores polares a um objeto complexo
        public void GetRetangular();
        public void GetPolar();
    }
    public class Complexo:IComplexo
    {
        public double _real, _imag, _modulo, _angulo;

        public Complexo(double r, double i, double m, double a, bool rad)
        {
            if(m != 0 && a != 0)SetPolar(m,a,rad);
            else if (r != 0 && i != 0)SetRetangular(r, i);
            else Console.WriteLine("Voce tem que passar algum parametro!");
        }
        public void SetRetangular(double r, double i) // atribui valores retangulares a um objeto complexo
        {
            this._real = r; // atribui o valor da parte real
            this._imag = i; // atribui o valor da parte imaginaria
            this._modulo = Math.Sqrt(Math.Pow(r,2)+Math.Pow(i,2));
            this._angulo = (Math.Atan(i/r))*57.29;  // calcula o angulo e converte de radianos para graus (180/pi)
            if(r<0)_angulo = 180 + _angulo; // ajusta o quadrante
            
            Console.WriteLine("Numero Criado:\n"+"Retangular: "+r+" +("+i+"i)\n"
            + "Polar(Graus): "+this._modulo+ " <"+this._angulo+" °\n");
        }
        public void SetPolar(double m , double a , bool rad)// atribui valores polares a um objeto complexo
        {
            this._angulo = a;

            if(rad == true){
                _angulo *= 57.29;
            }
            
            this._modulo = m;
            this._real = Math.Cos(_angulo/57.29)*m; // calcula a parte real resultante
            this._imag = Math.Sin(_angulo/57.29)*m; //calcula a parte imaginaria resultante
            
            Console.WriteLine("Numero Criado:\n"+"Retangular: "+this._real+" +("+this._imag+"i)\n"
            + "Polar(Graus): "+this._modulo+ " <"+this._angulo+" °\n");
        }
        public void GetRetangular()
        {
            Console.WriteLine("Retangular: "+this._real+" +("+this._imag+"i)\n");
        }
        public void GetPolar()
        {
            Console.WriteLine("Polar(Graus): "+this._modulo+ " <"+this._angulo+" °\n");
        }
    }
}