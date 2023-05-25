namespace Ejercicio13Version1.Consola
{
    internal class Program
    {
        enum Operaciones
        {
            Suma=1,
            Resta,
            Multiplicacion,
            Division
        }
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
                                1-Sumar
                                2-Resta
                                3-Multiplicación
                                4-División");
                Console.Write("Ingrese selección:");
                var opcionSeleccionada = int.Parse(Console.ReadLine());
                if (ValidarOpcion(opcionSeleccionada))
                {
                    Operaciones operacionSeleccionada = (Operaciones)opcionSeleccionada;
                    resultado = RealizarOperacionSeleccionada(numero1, numero2, operacionSeleccionada);
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

                Console.WriteLine (ex.Message);
            }
        }

        private static int RealizarOperacionSeleccionada(int numero1, int numero2, Operaciones operacionSeleccionada)
        {
            
            switch (operacionSeleccionada)
            {
                case Operaciones.Suma:
                    return CalcularSuma(numero1, numero2);
                    
                case Operaciones.Resta:
                    return CalcularResta(numero1, numero2);
                  
                case Operaciones.Multiplicacion:
                    return CalcularProducto(numero1, numero2);
                   
                default:
                    return CalcularDivision(numero1, numero2);
                    
            }
            
        }

        private static int CalcularDivision(int numero1, int numero2) => numero1 / numero2;
        

        private static int CalcularProducto(int numero1, int numero2) => numero1 * numero2;

        private static int CalcularResta(int numero1, int numero2) => numero1 - numero2;
        

        private static int CalcularSuma(int numero1, int numero2) => numero1 + numero2;
        

        private static bool ValidarOpcion(int opcion) => opcion >= 1 && opcion <= 4;
        
    }
}