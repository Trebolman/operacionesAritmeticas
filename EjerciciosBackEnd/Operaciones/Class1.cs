// Creado por Daniel I. Cabana
// iTrebolSoft
// 21/10/2018

using System;

namespace op
{
    public class OperacionesAritmeticas
    {
        public Int32 Suma (Int32 num1, Int32 num2){
            return num1 + num2;
        }
        public Int32 Restar(Int32 num1, Int32 num2){
            return num1 - num2;
        }
        public Int32 Multiplicar(Int32 num1, Int32 num2){
            return num1 * num2;
        }
        public Int32 Division(Int32 num1, Int32 num2){
            return num1 / num2;
        }
        public double Potencia(double num1, double pot)
        {
            return Math.Pow(num1,pot);
        }
        public double Raiz(Int32 num1)
        {
            return Math.Sqrt(num1);
        }
    }
}
