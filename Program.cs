using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certamen1
{
     class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0, b = 0, c = 0;
                int mayor = 0, menor = 0;
                int con = 0;
                while (con < 3)
                {
                    
                    try
                    {
                        Console.WriteLine("INGRESE 3 NUMEROS QUE SEA MAYOR A 0");
                        Console.WriteLine("ingrese un numero");
                        a = int.Parse(Console.ReadLine());
                        if (a >= 1)
                        {
                            mayor = a;
                            menor = a;
                            con++;
                        }
                        else
                        {
                            Console.WriteLine("solo numeros mayor a cero");
                        }
                   
                        Console.WriteLine("ingrese un numero");
                        b = int.Parse(Console.ReadLine());
                        if (b >= 1)
                        {
                            if (b <= a)
                            {
                                menor = b;
                            }
                            else
                            {
                                mayor = b;
                            }
                            con++;
                        }
                        else
                        {
                            Console.WriteLine("solo numeros mayor a cero");
                        }
                   
                        Console.WriteLine("ingrese un numero");
                        c = int.Parse(Console.ReadLine());
                        if (c >= 1)
                        {
                            if (c <= b && c <=a)
                            {
                                menor = c;
                            }
                            else
                            {
                                if (c>=b && c >=a)
                                {
                                    mayor = c;
                                }
                                
                            }
                            con++;
                        }
                        else
                        {
                            Console.WriteLine("solo numeros mayor a cero");
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("solo numero");
                        a = 0; b = 0; c = 0;
                        mayor = 0;
                         menor = 0;
                         con = 0;
                    }
                    
                    

                } 
            
            Console.WriteLine("numero mayor " + mayor);
            Console.WriteLine("numero menor " + menor);

            Console.WriteLine("DIFERENCIAS EN NUMEROS");
            int dif = c - a;
            if (dif < 0)
            {
                dif = dif * -1;
            }
            Console.WriteLine("la diferencia entre " + c + " y " + a + " es " + dif);
            int dif1 = b - a;
            if (dif1 < 0)
            {
                dif1 = dif1 * -1;
            }
            Console.WriteLine("la diferencia entre " + b + " y " + a + " es " + dif1);
            int dif2 = b - c;
            if (dif2 < 0)
            {
                dif2 = dif2 * -1;
            }
            Console.WriteLine("la diferencia entre " + b + " y " + c + " es " + dif2);

            Console.WriteLine("NUMEROS PARES A AL C");
            if ((a % 2) == 0)
            {
                if (a < c) {
                    for (int i = a; i <= c; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else {
                a = a + 1;
                for (int i = a; i <= c; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
            if (a > c)
            {
                Console.WriteLine("C es mayor que A no hay numeros que mostar");
            }
            Console.WriteLine("NUMEROS IMPARES DE C AL A");
            if ((c % 2) == 0)
            {
                c = c + 1;
                    for (int i = c; i <= a; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
            }
            else
            {
                for (int i = c; i <= a; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
            if (c > a)
            {
                Console.WriteLine("A es mayor que C no hay numeros que mostar");
            }
            Console.WriteLine("MES SEGUN LA DIFERENCIA ENTRE C Y A");
            int cas = dif ;
            switch (cas) { 
                case 1:
                    cas = 1;
                    Console.WriteLine("enero");
                    break;
                case 2:
                    cas = 2;
                    Console.WriteLine("febrero");
                    break;
                case 3:
                    cas = 3;
                    Console.WriteLine("marzo");
                    break;
                case 4:
                    cas = 4;
                    Console.WriteLine("abril");
                    break;
                case 5:
                    cas = 5;
                    Console.WriteLine("mayo");
                    break;
                case 6:
                    cas = 6;
                    Console.WriteLine("junio");
                    break;
                case 7:
                    cas = 7;
                    Console.WriteLine("julio");
                    break;
                case 8:
                    cas = 8;
                    Console.WriteLine("agosto");
                    break;
                case 9:
                    cas = 9;
                    Console.WriteLine("septiembre");
                    break;
                case 10:
                    cas = 10;
                    Console.WriteLine("octubre");
                    break;
                case 11:
                    cas = 11;
                    Console.WriteLine("noviembre");
                    break;
                case 12:
                    cas = 12;
                    Console.WriteLine("diciembre");
                    break;
            }
            Console.WriteLine("DIA DE LA SEMANA SEGUN LA DIFERENCIA ENTRE B Y A");
            int dia = dif1;
            switch (dia)
            {
                case 1:
                    dia = 1;
                    Console.WriteLine("lunes");
                    break;
                case 2:
                    dia = 2;
                    Console.WriteLine("martes");
                    break;
                case 3:
                    dia = 3;
                    Console.WriteLine("miercoles");
                    break;
                case 4:
                    dia = 4;
                    Console.WriteLine("jueves");
                    break;
                case 5:
                    dia = 5;
                    Console.WriteLine("viernes");
                    break;
                case 6:
                    dia = 6;
                    Console.WriteLine("sabado");
                    break;
                case 7:
                    dia = 7;
                    Console.WriteLine("domingo");
                    break;
              
            }


            }
            catch (Exception)
            {
                Console.WriteLine("ERROR Oprima enter");
            }





            Console.ReadKey();
        }

    }
}
