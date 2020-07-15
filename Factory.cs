using System;
using System.Collections.Generic;
using ComplexoDefinicao;

namespace ComplexoFactory
{
    

    public class Criar
    {
        ///<summary>Função que gera um numero complexo, cria um numero complexo</summary>
        ///<param name="real">recebe o valor da parte real</param>
        ///<param name="imaginario">recebe o valor da parte imaginaria</param>
        ///<param name="">recebe o valor do modulo</param>
        ///<param name="">recebe o valor do angulo</param>
        ///<param name="">true para radianos, false para graus</param>
        ///<return>retorna um objeto da classe complexo</return>
        static public Complexo Complexo(double real=0, double imaginario=0, double modulo=0, double angulo=0, bool radiano=false)
        {
            Complexo numero_complexo = new Complexo(real,imaginario,modulo,angulo,radiano);
            return numero_complexo;
        }
    }
}