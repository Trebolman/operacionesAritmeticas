/* Elaborado por Daniel I. Cabana
 * trebolman@gmail.com
 * 997589397
 * 
 * */

using System;
using Items;
using op;
namespace EjerciciosBackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu:
            Ejercicios obj = new Ejercicios();
            int salir = 1;
            Console.WriteLine("Ingrese el numero del ejercicio a realizar");
            Console.WriteLine("1) Indicar si un numero es primo o no.");
            Console.WriteLine("2) Indicar si un numero es par o impar");
            Console.WriteLine("3) Ingrese un numero y devuelva el dia correspondiente");
            Console.WriteLine("4) Ingrese un numero y devuelva el mes correspondiente");
            Console.WriteLine("5) Ingrese un numeros y devuelve el arreglo ordenadamente");
            Console.WriteLine("6) Ingrese un numero y devuelva si es positivo o negativo");
            Console.WriteLine("7) Ingrese una letra e identifique si es una vocal");
            Console.WriteLine("8) Ingrese 10 numeros y arrojar el mayor y el menor");
            Console.WriteLine("9) Identificar si el tercer numero es la suma de los dos primeros");
            Console.WriteLine("10) Calculadora");
            Console.WriteLine("11) Aplicacion para calcular el aumento de salario de un trabajador");

            int eleccion = Int32.Parse(Console.ReadLine());
            switch (eleccion)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("Indicar si un numero es primo o no.");
                        Console.WriteLine("Ingrese numero: (1 a 5)");
                        int numero = Int32.Parse(Console.ReadLine());

                        Console.WriteLine($"¿El numero {numero} es primo? : {obj.EsPrimo(numero)}");
                        Console.WriteLine("¿Probar otro numero ? Si=1/No=2");
                        salir = Int32.Parse(Console.ReadLine());
                        if (salir == 2) { break; }
                        Console.Clear();
                    }
                    while (salir == 1);
                    break;
                    
                case 2:
                    do
                    {
                        Console.WriteLine("Indicar si un numero es par o impar");
                        Console.WriteLine("Ingrese numero:");
                        int numero = Int32.Parse(Console.ReadLine());

                        Console.WriteLine($"¿El numero {numero} es par o impar? : {obj.EsPar(numero)}");
                        Console.WriteLine("¿Probar otro numero ? Si=1/No=2");
                        salir = Int32.Parse(Console.ReadLine());
                        if (salir == 2) { break; }
                        Console.Clear();
                    }
                    while (salir == 1);
                    break;
                case 3:
                    do
                    {
                        Console.WriteLine("Ingrese un numero y devuelva el dia correspondiente");
                        Console.WriteLine("Ingrese numero:");
                        int numero = Int32.Parse(Console.ReadLine());
                        if((numero > 0)&&(numero < 8))
                        {
                            Console.WriteLine($"El numero {numero} corresponde al dia de: {obj.QueDiaEs(numero)}");
                            Console.WriteLine("¿Probar otro numero ? Si=1/No=2");
                            salir = Int32.Parse(Console.ReadLine());
                            if (salir == 2) { break; }
                            Console.Clear();
                        }  
                    }
                    while (salir == 1);
                    break;
                case 4:
                    do
                    {
                        Console.WriteLine("Ingrese un numero y devuelva el mes correspondiente");
                        Console.WriteLine("Ingrese numero:");
                        int numero = Int32.Parse(Console.ReadLine());
                        if ((numero > 0) && (numero < 8))
                        {
                            Console.WriteLine($"El numero {numero} corresponde al mes de: {obj.QueMesEs(numero)}");
                            Console.WriteLine("¿Probar otro numero ? Si=1/No=2");
                            salir = Int32.Parse(Console.ReadLine());
                            if (salir == 2) { break; }
                            Console.Clear();
                        }      
                    }
                    while (salir == 1);
                    break;
                case 5:
                    do
                    {
                        int[] arr1 = new int[3];
                        Console.WriteLine("Ingrese un numeros y devuelve el arreglo ordenadamente");
                        Console.WriteLine("Ingrese numero 1:");
                        int num1 = Int32.Parse(Console.ReadLine());
                        arr1[0] = num1;

                        Console.WriteLine("Ingrese numero 2:");
                        int num2 = Int32.Parse(Console.ReadLine());
                        arr1[1] = num2;

                        Console.WriteLine("Ingrese numero 3:");
                        int num3 = Int32.Parse(Console.ReadLine());
                        arr1[2] = num3;

                        foreach (var item in arr1)
                        {
                            Console.WriteLine($"El arreglo ingresado fue: {item.ToString()}");
                        }

                        Array.Sort(arr1);
                        foreach (var item in arr1)
                        {
                            Console.WriteLine($"El arreglo ordenado es: {item.ToString()}");
                        }
                        Console.WriteLine("¿Probar otro numero ? Si=1/No=2/Menu=3");
                        salir = Int32.Parse(Console.ReadLine());
                        if (salir == 2) { break; }
                        Console.Clear();
                    }
                    while (salir == 1);
                    break;
                case 6:
                    do
                    {
                        Console.WriteLine("Ingrese un numero y devuelva si es positivo o negativo");
                        Console.WriteLine("Ingrese numero:");
                        int numero = Int32.Parse(Console.ReadLine());

                        Console.WriteLine($"El numero {numero} es: {obj.esPositivo(numero)}");
                        Console.WriteLine("¿Probar otro numero ? Si=1/No=2");
                        salir = Int32.Parse(Console.ReadLine());
                        if (salir == 2) { break; }
                        Console.Clear();
                    }
                    while (salir == 1);
                    break;
                case 7:
                    do
                    {
                        Console.WriteLine("Ingrese una letra e identifique si es una vocal");
                        Console.WriteLine("Ingrese letra:");
                        string letra = Console.ReadLine();

                        Console.WriteLine($"La letra {letra} es: {obj.esVocal(letra)}");
                        Console.WriteLine("¿Probar otro numero ? Si=1/No=2");
                        salir = Int32.Parse(Console.ReadLine());
                        if (salir == 2) { break; }
                        Console.Clear();
                    }
                    while (salir == 1);
                    break;
                case 8:
                    do
                    {
                        int[] arr2 = new int[10];
                        Console.WriteLine("Ingrese 10 numeros y arrojar el mayor y el menor");
                        for(int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"Ingrese el numero {i + 1}: ");
                            arr2[i] = Int32.Parse(Console.ReadLine());
                        }
                        Array.Sort(arr2);

                        Console.WriteLine($"El mayor numero es: {arr2[9]}");
                        Console.WriteLine($"El menor numero es: {arr2[0]}");
                        Console.WriteLine("¿Probar otro numero ? Si=1/No=2");
                        salir = Int32.Parse(Console.ReadLine());
                        if (salir == 2) { break; }
                        Console.Clear();
                    }
                    while (salir == 1);
                    break;
                case 9:
                    do
                    {
                        Console.WriteLine("Identificar si el tercer numero es la suma de los dos primeros");
                        int[] arr3 = new int[3];
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"Ingrese el numero {i + 1}: ");
                            arr3[i] = Int32.Parse(Console.ReadLine());
                        }
                        if(arr3[2] == (arr3[0] + arr3[1]))
                        {
                            Console.WriteLine("El tercer numero si es la suma de los dos primeros");
                        }
                        else { Console.WriteLine("No es suma de los dos primeros"); }

                        Console.WriteLine("¿Probar otro numero ? Si=1/No=2");
                        salir = Int32.Parse(Console.ReadLine());
                        if (salir == 2) { break; }
                        Console.Clear();
                    }
                    while (salir == 1);
                    break;
                case 10:
                    do
                    {
                        OperacionesAritmeticas calculadora = new OperacionesAritmeticas();
                        Console.WriteLine("Elija opción:");
                        Console.WriteLine("1) Sumar");
                        Console.WriteLine("2) Restar");
                        Console.WriteLine("3) Multiplicar");
                        Console.WriteLine("4) Dividir");
                        Console.WriteLine("5) Potencia");
                        Console.WriteLine("6) Raiz cuadrada");

                        int choice = Int32.Parse(Console.ReadLine());

                        int num1, num2;

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Ingrese el primer numero: ");
                                num1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el segundo numero: ");
                                num2 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine($"La suma de {num1} + {num2} es: {calculadora.Suma(num1, num2)}");
                                break;
                            case 2:
                                Console.WriteLine("Ingrese el primer numero: ");
                                num1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el segundo numero: ");
                                num2 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine($"La Resta de {num1} + {num2} es: {calculadora.Restar(num1, num2)}");
                                break;
                            case 3:
                                Console.WriteLine("Ingrese el factor 1: ");
                                num1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el factor 2: ");
                                num2 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine($"La Multiplicacion de {num1} + {num2} es: {calculadora.Multiplicar(num1, num2)}");
                                break;
                            case 4:
                                Console.WriteLine("Ingrese el divisor: ");
                                num1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el dividendo: ");
                                num2 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine($"La Division de {num1} + {num2} es: {calculadora.Division(num1, num2)}");
                                break;
                            case 5:
                                Console.WriteLine("Ingrese la base: ");
                                num1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese la potencia: ");
                                num2 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine($"La Potencia de {num1} elevado a {num2} es: {calculadora.Potencia(num1, num2)}");
                                break;
                            case 6:
                                Console.WriteLine("Ingrese el numero: ");
                                num1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine($"La Raiz Cuadrada de {num1} es: {calculadora.Raiz(num1)}");
                                break;
                        }

                        Console.WriteLine("¿Probar otro numero ? Si=1/No=2");
                        salir = Int32.Parse(Console.ReadLine());
                        if (salir == 2) { break; }
                        Console.Clear();
                    }
                    while (salir == 1);
                    break;
                case 11:
                    do
                    {
                        Console.WriteLine("Aplicacion para calcular el aumento de salario");
                        Console.WriteLine("Ingrese numero de años de trabajo del asalariado:");
                        int anios = Int32.Parse(Console.ReadLine());
                        double sueldo = 50000;
                        double aumento = 0;
                        if((anios > 10)) { aumento = 0.1; }
                        if((anios < 10)&&(anios > 5)) { aumento = 0.07; }
                        if((anios >= 5) && (anios >= 3)) { aumento = 0.05; }
                        if((anios < 3)) { aumento = 0.03; }

                        sueldo = sueldo + sueldo * aumento;
                        Console.WriteLine($"El aumento fue de {aumento} y el sueldo anual será {sueldo}");

                        Console.WriteLine("¿Probar otro numero ? Si=1/No=2");
                        salir = Int32.Parse(Console.ReadLine());
                        if (salir == 2) {  break; }
                        Console.Clear();
                    }
                    while (salir == 1);
                    break;
                case 12:
                    Console.WriteLine("Ingrese numeros a ordenar");
                    int numeros = Int32.Parse(Console.ReadLine());
                    int[] arreglo = new int[numeros];
                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        Console.WriteLine($"Ingrese el numero {i + 1}: ");
                        arreglo[i] = Int32.Parse(Console.ReadLine());
                    }
                    arreglo = obj.OrdenarNumeros(arreglo);
                    foreach (var item in arreglo)
                    {
                        Console.WriteLine($"El arreglo ordenado es: {item.ToString()}");
                    }
                    break;

                default:
                    Console.WriteLine("Ingrese valor entre 1 y 11");
                    break;
            }
            goto Menu;
        }
    }
}
