class Triangulo2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("App Triangulo - 18A");
        double lado1, lado2, lado3;
        // string ladoMayor;  - esto no hace falta
        Console.WriteLine("Introduzca un lado");
        lado1 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el segundo lado");
        lado2 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el último lado");
        lado3 = Double.Parse(Console.ReadLine());

        if (compareSides(lado1, lado2) & compareSides(lado2, lado3))
        {
            Console.WriteLine("El triángulo es equilatero");
        }

        if (!compareSides(lado1, lado2))
        {
            Console.WriteLine("no son equilateros");
            Console.WriteLine("el lado mayor es: " + BiggestSide(lado1, lado2, lado3));
        }

        if (!compareSides(lado1, lado3))
        {
            Console.WriteLine("no son equilateros");
            Console.WriteLine("el lado mayor es: " + BiggestSide(lado1, lado2, lado3));
        }


    }

    public static Boolean compareSides(double a, double b)
    {
        return a == b;
    }

    public static String BiggestSide(double side1, double side2, double side3)
    {
        String biggestSize = "lado 3";
        if ((side1 > side2) && (side1 > side3))
            return biggestSize = "lado 1";
        if ((side2 > side3))
            return biggestSize = "lado2";
        return biggestSize;
    }
}
   