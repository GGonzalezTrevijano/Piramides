using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saludos, ¿Que figura deseas construir: \n1) Piramide \n2) Faldon Derecho \n3) Faldon Izquierdo \n4) Piramide Invertida");
            Console.Write("\r\n");

            string dato = Console.ReadLine();
            int opcion = int.Parse(dato);
            
            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("Construyendo la Piramide...");

                        for (int i = 0; i < 7; i++) //Este for genera los asteriscos en Vertical
                        {                          
                            for (int e = 0; e < i; e++)  //Este for genera los asteriscos en Horizontal al usar solo Write
                            {                               
                                Console.Write("*", e);                                 
                            }
                                for (int d = i; d < i; d++) //Este for va sumadando * hasta que iguala la cantidad de i, que es 7.
                                {
                                    Console.WriteLine();
                                }                          
                            Console.WriteLine("*", i);
                        }
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("Construyendo el faldon derecho...");

                        for (int i = 0; i < 7; i++)
                        {
                            
                            for (int e = 0; e < i; e++)
                            {                               
                                Console.Write("*", e);                                                            
                            }
                                for (int d = i; d < i; d++)
                                {
                                 Console.WriteLine();
                                }

                            Console.WriteLine("*", i);                                                    
                        }

                    }
                    break;

                case 3:
                    {
                        int numAsteriscos = 1; //Variable
                        int numEspacios = 6; //Varible

                        for (int i = 0; i < 6; i++) //Te genera 6 lineas vacias en horizontal
                        {
                            string linea = ""; //Variable vacia

                            for (int k = 0; k < numEspacios; k++) //Te genera 5 espacios
                            {
                                linea = linea + " "; 
                            }

                            for (int j = 0; j < numAsteriscos; j++) //Te genera 1 linea y la convierte en asterisco
                            {
                                linea = linea + "*";
                            }

                            Console.Write(linea); 
                            Console.WriteLine();
                            numAsteriscos++;
                            numEspacios--;
                        }
                    }
                    break;

            }

            Console.Write("\r\n");

        }
    }
}
