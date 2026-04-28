//C#
internal class Program
{
    private static void Main(string[] args)
    {
        const int TOTAL_SELLOS = 8;
        Console.WriteLine("----BIENVENIDOS A LA BARBERÍA DON ZEA----");
        for (int i = 1; i <=TOTAL_SELLOS ; i++)
        {
            Console.WriteLine("\nSello actual {0} de {1},i,TOTAL_SELLOS");
            Console.WriteLine("Presione cualquier tecla para registrar esta visita");
            Console.ReadKey();

            Console.WriteLine(">>Sellos #{0} registrado correctamente...");

        }
        Console.WriteLine("\n****************************************************");
        Console.WriteLine("¡CUPONERA COMPLETA!");
        Console.WriteLine("Orozco, has ganado tu corte de cabello gratis!!!!");
        Console.WriteLine("\n****************************************************");
        Console.WriteLine("\nPresione una tecla para cerrar...");
        Console.ReadKey();
    }
}
