// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b);
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
            }*/


int opcion;  
do  
{
    
    Console.WriteLine("\nCalculadora básica");
    Console.WriteLine("------------------");
    Console.WriteLine("¿Qué operación desea realizar?");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. División");
    Console.WriteLine("5. Salir");
    Console.Write("Opción: ");

    string opcionInput = Console.ReadLine();  // lee lo ingresado por el usuario como texto

    //  convierte la entrada a entero. Si falla o no está entre 1 y 5, muestra error y repite
    if (!int.TryParse(opcionInput, out opcion) || opcion < 1 || opcion > 5)
    {
        Console.WriteLine("Opción inválida. Debe ingresar un número entre 1 y 5.");
        continue;  // vuelve al inicio del bucle
    }

    // Si elige la opción 5, sale del programa
    if (opcion == 5)
    {
        Console.WriteLine("Saliendo del programa...");
        break;  //termina 
    }

   
    Console.Write("Ingrese el primer número: ");
    if (!double.TryParse(Console.ReadLine(), out double num1))  // valida si es double
    {
        Console.WriteLine("Entrada inválida. Debe ingresar un número válido.");
        continue;  // Si no es válido, volver al menú
    }
    Console.Write("Ingrese el segundo número: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))  
    {
        Console.WriteLine("Entrada inválida. Debe ingresar un número válido.");
        continue; 
    }

    switch (opcion)
    {
        case 1:
            Console.WriteLine($"El resultado de {num1} + {num2} es: {num1 + num2}");
            break;

        case 2:
            Console.WriteLine($"El resultado de {num1} - {num2} es: {num1 - num2}");
            break;

        case 3:
            Console.WriteLine($"El resultado de {num1} * {num2} es: {num1 * num2}");
            break;

        case 4:
            if (num2 == 0)  // Verificar si el divisor es cero
                Console.WriteLine("Error: No se puede dividir por cero.");
            else
                Console.WriteLine($"El resultado de {num1} / {num2} es: {num1 / num2}");
            break;
    }

    // Espera que el usuario presione una tecla para volver al menú
    Console.WriteLine("\nPresione una tecla para volver al menú...");
    Console.ReadKey();  // Espera que presione una tecla
    Console.Clear();    // Limpia la consola 

} while (true);  // Repetir hasta que se use 'break'
