using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class Operacoes
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            if(num1 > num2) { 
                return num1 - num2;
            }
            else
            {
                throw new ArgumentException("Segundo as regras de negócio desta empresa, esta calculadora não permite subtrair um número por outro maior ou igual.");
            }
        }
    }
}
