internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Franco Saul Peruch Melgar");
        Console.WriteLine("IV Bachillerato C");
        Console.WriteLine("Clave: 29");
        int[] numerosEnteros = new int[8];
        int numeroMayor = 0;
        int posicionMayor = 0;

        for (int indice = 0; indice < 8; indice++)
        {
            Console.Write("Ingrese el número " + (indice + 1) + ": ");
            numerosEnteros[indice] = int.Parse(Console.ReadLine());

            if (indice == 0)
            {
                numeroMayor = numerosEnteros[indice];
                posicionMayor = indice + 1;
            }
            else if (numerosEnteros[indice] > numeroMayor)
            { 
                numeroMayor = numerosEnteros[indice];
                posicionMayor = indice + 1;
            }
        }

        Console.WriteLine("El número mayor es: " + numeroMayor);
        Console.WriteLine("Se encuentra en la posición: " + posicionMayor);

    }
}