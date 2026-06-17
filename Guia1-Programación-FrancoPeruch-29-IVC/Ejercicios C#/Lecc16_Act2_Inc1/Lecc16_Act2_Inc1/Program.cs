internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Franco Saul Peruch Melgar");
        Console.WriteLine("IV Bachillerato C");
        Console.WriteLine("Clave: 29");
        int[] edadesPersonas = new int[7];
        int cantidadMayoresEdad = 0;

        for (int indice = 0; indice < 7; indice++)
        {
            Console.Write("Ingrese la edad de la persona " + (indice + 1) + ": ");
            edadesPersonas[indice] = int.Parse(Console.ReadLine());

            if (edadesPersonas[indice] >= 18)
            {
                cantidadMayoresEdad++;
            }
        }
        Console.WriteLine("Cantidad de personas mayores de edad: " + cantidadMayoresEdad);
    }
}