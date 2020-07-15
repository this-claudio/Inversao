using System;
using ComplexoDefinicao;


namespace ComplexoCalcula
{
    
    public class Calcula
    {
        ///<summary>Função que soma dois objetos complexos</summary>
        ///<param name="num1">recebe o valor do primeiro numero(objeto) complexo</param>
        ///<param name="num2">recebe o valor do segundo numero(objeto) complexo</param>
        static public void Somar(Complexo num1, Complexo num2)
        {
            double resul_real = num1._real + num2._real; // calcula a parte real resultante
            double resul_imag = num1._imag + num2._imag; //calcula a parte imaginaria resultante
            double resul_angulo = (Math.Atan(resul_imag/resul_real))*57.29; // calcula o angulo e  converte de radianos para graus
            if(resul_real<0)resul_angulo = 180 + resul_angulo; // ajusta o quadrante
            double resul_modulo = Math.Sqrt(Math.Pow(resul_real,2)+Math.Pow(resul_imag,2));// calcula o modulo usando regra de pitagoras
            Console.WriteLine("Numero Somado:\n"+"Retangular: "+resul_real+" +("+resul_imag+"i)\n"
            + "Polar(Graus): "+resul_modulo+ " <"+resul_angulo+" °\n");
        }
       
        public void Subtrair(){
                //implementação
        }
        public void Multiplicar(){
            //implementação
        }
        public void Dividir(){
            //implementação
        }
        

    }
}