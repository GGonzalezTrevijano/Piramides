using System;

namespace Piramide
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Saludos, ¿Que figura deseas construir?: \n1) Piramide \n2) Faldon Derecho \n3) Faldon Izquierdo \n4) Piramide Invertida");
            Console.Write("\r\n");

            string dato = Console.ReadLine();
            int opcion = int.Parse(dato);
            
            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("Construyendo la Piramide...");
                        int espacios = 8;

                        for (int i = 0; i < 8; i++) //Genera un espacio en horizontal
                        {
              
                            Console.WriteLine("", i); 

                            for (int f = 0; f < espacios ; f++) //Genera un espacio de 7 huecos, luego va decreciendo con "espacios--"
                            {
                                    Console.Write(" ", f);   
                            }

                            for (int e = 0; e < i; e++) //Genera un la piramide incrementandose de 1 en 1
                            {
                                Console.Write("*", e);
                                
                            }
                            espacios--;

                            for (int s = 1; s < i; s++) //Genera la piramide que se incrementa a partir del 2 asterisco del lado anterior
                            {
                                Console.Write("*", s);                              
                            }
                        }
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("Construyendo el faldon derecho...");

                        for (int i = 0; i < 7; i++) //Te genera 7 numeros
                        {
                            
                            for (int e = 0; e < i; e++) // Te genera 6 numeros
                            {                               
                                Console.Write("*", e); //Te cambia los 6 numeros por asteriscos                   
                            }                            
                            Console.WriteLine("*", i);  //Cambia los numeros del primer for por Asteriscos 
                        }
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Construyendo el faldon izquierdo...");

                        int numAsteriscos = 1; // Variable
                        int numEspacios = 6; // Varible

                        for (int i = 0; i < 6; i++) // Te genera 6 lineas vacias
                        {
                            string linea = ""; // Variable vacia

                            for (int k = 0; k < numEspacios; k++) // Te genera 5 espacios que se van incremendanto de uno en uno
                            {
                                linea = linea + " "; // Te genera espacios en la variable linea
                            }

                            for (int j = 0; j < numAsteriscos; j++) // Te genera los asteriscos incrementandose de uno en uno
                            {
                                linea = linea + "*";    // Te añade asteriscos a la variable linea
                            }

                            Console.Write(linea);  // Te pinta los datos de los for
                            Console.WriteLine();    //Deja un espacio entre los asteriscos
                            numAsteriscos++;    //  Incrementa el número de asteriscos gradualmente
                            numEspacios--;  //  Reduce el númro de espacios gradualmente
                        }
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("Construyendo la Piramide inversa...");

                        for (int i = 0; i < 7; i++)
                        {

                            Console.WriteLine("", i);

                            for (int f = 0; f < i; f++) 
                            {
                                Console.Write(" ", f);
                            }

                            for (int e = 7; e > i; e--) 
                            {
                                Console.Write("*", e);
                            }

                            for (int s = 6; s > i; s--) 
                            {
                                Console.Write("*", s);
                            }
                        }
                    }
                    break;
            }
            Console.Write("\r\n");
        }
    }
}
