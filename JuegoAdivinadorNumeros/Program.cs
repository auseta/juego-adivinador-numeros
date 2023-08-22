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

            int numeroIngresado;

            do
            {

                Console.WriteLine("Ingresa un numero entre 0 y 100");

                Console.Write(">> ");

                try
                {
                    numeroIngresado = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex) when (ex.GetType() != typeof(FormatException))
                {
                    Console.WriteLine($"Ha ocurrido un error: has introducido datos incorrectos. Se tomara como valor ingresado al número 0");
                    numeroIngresado = 0;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Ha ocurrido un error. Has introducido texto. Se tomara como valor ingresado al número 0");
                    numeroIngresado = 0;
                }
                
                if (numeroIngresado > numeroRandom)
                {
                    Console.WriteLine("Muy alto! El número a adivinar es menor");
                    intentos++;
                }

                else if (numeroIngresado < numeroRandom)
                {
                    Console.WriteLine("Muy bajo! El número a adivinar es mayor");
                    intentos++;
                }

                else
                {
                    ganaste = true;
                    intentos++;
                }

            } while (!ganaste);

            Console.WriteLine($"Adivinaste! lograste adivinar el número {numeroRandom} en {intentos} intentos");

        }
    }
}