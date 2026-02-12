class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bilmærke: ");
        string Bilmærke = Console.ReadLine();
        Console.WriteLine();
 
        Console.WriteLine("Hvilket brændstof bruger bilen?");
        string Brændstof =  Console.ReadLine();
        Console.WriteLine();
 
        Console.WriteLine("Hvor mange km kører den pr. liter? ");
        double Liter = double.Parse(Console.ReadLine());
        Console.WriteLine();
 
        Console.WriteLine("Hvor mange km har den kørt? ");
        double Kørt = double.Parse(Console.ReadLine());
        Console.WriteLine();
 
        Console.WriteLine("Afstand mellem adresser?: ");
        double Afstand = double.Parse(Console.ReadLine());
        Console.WriteLine();
 
        double nyKm = Kørt + Afstand;
        Console.WriteLine("Ny kilometerafstand: ");
        Console.WriteLine(nyKm + " Km");
        Console.WriteLine();

 
        double fuelPrice;
        if (Brændstof == "benzin")
        {
            fuelPrice = 13.49;
        }
        else
        {
            fuelPrice = 12.29;
        }
        double fuelNeeded = Afstand / Liter;
        double tripCost = fuelNeeded * fuelPrice;

        Console.WriteLine("Brændstof brugt: ");
        Console.WriteLine(fuelNeeded + " Liter ");
        Console.WriteLine();

        Console.WriteLine("Pris for turen: ");
        Console.WriteLine(tripCost + " Kr");
        Console.WriteLine();
 
        string brand1 = "Toyota";
        string model1 = "Corolla";
        int km1 = 156000;
        string brand2 = "Ford";
        string model2 = "Fiesta";
        int km2 = 112000;
        Console.WriteLine("Bilmærke".PadRight(15) + "| " + "Model".PadRight(15) + "| " + "Kilometertal");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine(brand1.PadRight(15) + "| " + model1.PadRight(15) + "| " + km1.ToString().PadLeft(10) + " km");
        Console.WriteLine(brand2.PadRight(15) + "| " + model2.PadRight(15) + "| " + km2.ToString().PadLeft(10) + " km");

 


    }
}