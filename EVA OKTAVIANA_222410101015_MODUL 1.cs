using System;

class Processor
{
    public string merk;
    public string tipe;

    public Processor(string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }
}

class Intel : Processor
{
    public Intel(string merk, string tipe) : base("INTEL", tipe)
    {

    }
}

class CoreI3 : Intel
{
    public CoreI3(string merk, string tipe) : base(merk, "Core I3")
    {

    }
}

class CoreI5 : Intel
{
    public CoreI5(string merk, string tipe) : base(merk, "CoreI5")
    {

    }
}

class CoreI7 : Intel
{
    public CoreI7(string merk, string tipe) : base(merk, "CoreI7")
    {

    }
}

class AMD : Processor
{
    public AMD(string merk, string tipe) : base("AMD", tipe)
    {

    }

}

class Ryzen : AMD
{
    public Ryzen(string merk, string tipe) : base(merk, "RAYZEN")
    {

    }
}

class Athlon : AMD
{
    public Athlon(string merk, string tipe) : base(merk, "ATHLON")
    {

    }
}

class Vga
{
    public string merk;

    public Vga(string merk)
    {
        this.merk = merk;
    }
}

class Nvidia : Vga
{
    public Nvidia(string merk) : base("Nvidia")
    {

    }
}

class AmD : Vga //kenapa AMD ditulis dengan kapital yang berbeda? karena sebelumnya constructor tersebut sudah dipakai
{
    public AmD(string merk) : base("AMD")
    {

    }
}

class Laptop
{
    public string merk;
    public string tipe;
    public Vga Vga;
    public Processor Processor;

    public Laptop(string merk, string tipe, Vga Vga, Processor Processor)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.Vga = Vga;
        this.Processor = Processor;
    }

    public void LaptopDiNyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} telah berhasil dinyalakan");
    }
    public void LaptopDiMatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}

class ASUS : Laptop
{
    public ASUS(string merk, string tipe, Vga Vga, Processor Processor) : base("ASUS", tipe, Vga, Processor)
    {

    }
}
class ROG : ASUS
{
    public ROG(string merk, string tipe, Vga Vga, Processor Processor) : base(merk, "ROG", Vga, Processor)
    {
    }
}

class Vivobook : ASUS
{
    public Vivobook(string merk, string tipe, Vga Vga, Processor Processor) : base(merk, "VIVOBOOK", Vga, Processor)
    {

    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}
class ACER : Laptop
{
    public ACER(string merk, string tipe, Vga Vga, Processor Processor) : base("ACER", tipe, Vga, Processor)
    {

    }
}

class Swift : ACER
{
    public Swift(string merk, string tipe, Vga Vga, Processor Processor) : base(merk, "SWIFT", Vga, Processor)
    {

    }
}
class Predator : ACER
{
    public Predator(string merk, string tipe, Vga Vga, Processor Processor) : base(merk, "PREDATOR", Vga, Processor)
    {

    }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop dengan {merk} {tipe} sedang memainkan game");

    }
}
class LENOVO : Laptop
{
    public LENOVO(string merk, string tipe, Vga Vga, Processor Processor) : base("LENOVO", tipe, Vga, Processor)
    {

    }
}
class Legion : LENOVO
{
    public Legion(string merk, string tipe, Vga Vga, Processor Processor) : base(merk, "LEGION", Vga, Processor)
    {

    }
}
class IdeaPad : LENOVO
{
    public IdeaPad(string merk, string tipe, Vga Vga, Processor Processor) : base(merk, "IdeaPad", Vga, Processor)
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Processor processor1 = new Processor("Intel", "CoreI5");
        Processor processor2 = new Processor("Intel", "Ryzen");
        Processor processor3 = new Processor("Intel", "CoreI7");

        Vga vga1 = new Vga("MDA");
        Vga vga2 = new Vga("Nvidia");

        Laptop laptop1 = new Vivobook("ASUS", "Vivobook", vga2,processor1);

        //Console.WriteLine("SOAL NOMOR 2");
        //laptop1.Ngoding();

        //Console.WriteLine("SOAL NOMOR 3");
        //Console.WriteLine(laptop1.Vga.merk);
        //Console.WriteLine(laptop1.Processor.merk);
        //Console.WriteLine(laptop1.Processor.tipe);



        Laptop laptop2 = new IdeaPad("LENOVO", "IdeaPad", vga1, processor2);
        
         //Console.WriteLine($"SOAL NOMOR 1");
         //laptop2.LaptopDiNyalakan();
         //laptop2.LaptopDiMatikan();

        
        Predator predator = new Predator("ACER", "Predator", vga1, processor3);
        //Console.WriteLine("SOAL NOMOR 4");
        //predator.BermainGame();
        
        ACER acer = new Predator("ACER", "Predator", vga1, processor1);
        //Console.WriteLine("SOAL NOMOR 5");
        //acer.BermainGame();
        
    }
}

