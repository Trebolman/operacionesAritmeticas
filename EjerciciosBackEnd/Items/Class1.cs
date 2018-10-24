using System;

namespace Items
{
    public class Ejercicios
    {
        public string EsPrimo (Int32 num)
        {
            int numVerif = 0, i;
            for( i = 1 ; i < (num + 1); i++)
            {
                if (num % i == 0)
                {
                    numVerif++;
                }
            }
            if (numVerif != 2) {
                /*Console.WriteLine("No es primo");*/
                return "No es primo";
            }
            else {
                //Console.WriteLine("Si es primo");
                return "Si es primo";
            }
        }

        public string EsPar(int num)
        {
            if (num % 2 == 0) { return "Es un numero par"; }
            else return "Es un numero impar";
        }

        public string QueDiaEs(int num)
        {
            string [] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            return $"{dias[num - 1]}";
        }

        public string QueMesEs(int num)
        {
            string[] dias = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return $"{dias[num - 1]}";
        }

        public int[] OrdenarNumeros(int[] array)
        {
            
            Array.Sort(array);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    int val1 = array[i];

            //}
            return array;
        }

        public string esPositivo(int num)
        {
            if (num >= 0) return "positivo";
            else return "negativo";
        }

        public string esVocal(string letra)
        {
            letra = letra.ToLower();
            if ((letra == "a") || (letra == "e") || (letra == "i") || (letra == "o") || (letra == "u"))
            {
                return "Es una vocal";
            }
            else return "No es una vocal";
        }

        //public int[] ordenar(int[] dato)
        //{

        //}
    }
}
