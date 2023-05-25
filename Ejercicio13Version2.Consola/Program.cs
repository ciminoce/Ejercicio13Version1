namespace Ejercicio13Version2.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Operaciones Básicas");
                var resultado = 0;
                Console.Write("Ingrese un número:");
                var numero1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese otro número:");
                var numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine(@"Operaciones admitidas:
                                + - Sumar
                                -  -Resta
                                * - Multiplicación
                                / - División");
                Console.Write("Ingrese selección:");
                var opcionSeleccionada = Console.ReadLine();
                if (ValidarOpcion(opcionSeleccionada))
                {
                    switch (opcionSeleccionada)
                    {
                        case "+":
                            resultado = CalcularSuma(numero1, numero2);
                            break;
                        case "-":
                            resultado = CalcularResta(numero1, numero2);
                            break;
                        case "*":
                            resultado = CalcularProducto(numero1, numero2);
                            break;
                        default:
                            resultado = CalcularDivision(numero1, numero2);
                            break;
                    }
                    Console.WriteLine($"El resultado es {resultado}");
                }
                else
                {
                    Console.WriteLine("Opción seleccionada no válida");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Número ingresado de forma inválida");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número ingresado fuera del rango permitido");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static int CalcularDivision(int numero1, int numero2) => numero1 / numero2;

        private static int CalcularProducto(int numero1, int numero2) => numero1 * numero2;
        private static int CalcularResta(int numero1, int numero2) => numero1 - numero2;
        private static int CalcularSuma(int numero1, int numero2) => numero1 + numero2;
       private static bool ValidarOpcion(string opcion) => opcion =="+" || opcion=="-" || opcion=="*" || opcion=="/"  ;

    }

}