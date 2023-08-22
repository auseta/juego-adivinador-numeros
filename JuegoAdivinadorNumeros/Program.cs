namespace JuegoAdivinadorNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numeroRandom = random.Next(0, 100);

            bool ganaste = false;

            int intentos = 0;

            do
            {

                Console.WriteLine("Ingresa un numero entre 0 y 100");

                Console.Write(">> ");

                string numero = Console.ReadLine();

                try
                {
                    int numeroIngresado = Int32.Parse(numero);

                    if (numeroIngresado > numeroRandom)
                    {
                        Console.WriteLine("Muy alto! El numero a adivinar es menor");
                        intentos++;
                    }

                    else if (numeroIngresado < numeroRandom)
                    {
                        Console.WriteLine("Muy bajo! El numero a adivinar es mayor");
                        intentos++;
                    }

                    else
                    {
                        ganaste = true;
                        intentos++;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ha ocurrido un error: { ex.Message }");   
                }

            } while (!ganaste);

            Console.WriteLine($"Adivinaste! lograste adivinar el numero {numeroRandom} en {intentos} intentos");

        }
    }
}