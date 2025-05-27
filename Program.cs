// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b);*/
 Console.Write("Ingrese un número: ");
            string entrada = Console.ReadLine();

            // Verificar si es un número entero válido
            if (int.TryParse(entrada, out int numero))
            {
                if (numero > 0)
                {
                    // Convertimos el número a string
                    string numeroStr = numero.ToString();
                    string invertido = "";

                    // Invertimos el número manualmente
                    for (int i = numeroStr.Length - 1; i >= 0; i--)
                    {
                        invertido += numeroStr[i];
                    }

                    Console.WriteLine("Número invertido: " + invertido);
                }
                else
                {
                    Console.WriteLine("El número debe ser mayor a 0.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
            }