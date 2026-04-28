//C#
internal class Program
{
    private static void Main(string[] args)
    {
        int cajonesOcupado = 0;
        const int capacidadTotal = 10;
        string opcion = "";

        Console.WriteLine("===CONTROL DE ACCESO AL CENTRO COMERCIAL====");

        do
        {
            Console.WriteLine("\nESTADO: {0} ocupados | {1} disponibles",
                cajonesOcupado, capacidadTotal-cajonesOcupado);
            Console.WriteLine("¿Ingresar nuevo vehículo? (S/N)");
            opcion= Console.ReadLine().ToUpper();

            if (opcion=="S")
            {
                cajonesOcupado++;//CajonesOcupados=CajonesOcupado+1
                Console.WriteLine(">>>Acceso Consedido, Levantando Barrera...");
            }
            else if (opcion!="N")
            {
                Console.WriteLine(">>>Opción inválida, Use 'S' para si o la 'n' para no...");
            }
        }
        while (opcion!="N" && cajonesOcupado<capacidadTotal);

        if (cajonesOcupado>=capacidadTotal)
        {
            Console.WriteLine("\n***************************************************************");
            Console.WriteLine("ALERTAA!!!, CUPO COMPLETADO, BARRERA BLOQUEADA");
            Console.WriteLine("\n***************************************************************");
        }

        Console.WriteLine("\nApagando el sistema del control");
        Console.WriteLine("\nPresione una tecla para continuar");
        Console.ReadKey();

    }
}
