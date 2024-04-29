namespace Calculadora;

class Program
{
    static void Main(string[] args)
    {
        Vista();
    }
    static void Vista()
    {
        bool cont = true;
        string? simbolo = "";
        float res = 0;
        var o1 = new Operacion();
        do
        {
            Console.WriteLine("Ingresar el numero");
            o1.Number = (float) Convert.ToDouble(Console.ReadLine());
            o1.AddNumber(o1.Number);
            if(cont)
            {
                cont = false;
                continue;
            }
            Console.WriteLine("Ingresar el simbolo (=)");
            simbolo = Console.ReadLine();
            if(simbolo == "=")
            {
                
                o1.Sumar(out res);
                o1.Estado = false;
            }
        }
        while (o1.Estado);
        Console.WriteLine($"el resultado de la operacion es {res}");
    }
}
