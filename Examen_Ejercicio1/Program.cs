namespace Examen_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número entre 1 y 15: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int numero) && numero >= 1 && numero <= 15)
            {
                string valorEnLetras = ObtenerValoresEnLetras(numero);
                Console.WriteLine($"El número {numero} en letras es: {valorEnLetras}");
            }
            else
            {
                Console.WriteLine("El número ingresado no está en el rango válido.");
            }
        }

        static string ObtenerValoresEnLetras(int numero)
        {
            switch (numero)
            {
                case 1: return "UNO";
                case 2: return "DOS";
                case 3: return "TRES";
                case 4: return "CUATRO";
                case 5: return "CINCO";
                case 6: return "SEIS";
                case 7: return "SIETE";
                case 8: return "OCHO";
                case 9: return "NUEVE";
                case 10: return "DIEZ";
                case 11: return "ONCE";
                case 12: return "DOCE";
                case 13: return "TRECE";
                case 14: return "CATORCE";
                case 15: return "QUINCE";
                default: return "Número fuera de rango";
            }
        }

    }
}
