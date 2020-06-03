using System;

namespace FindObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Lamp lamp = new Lamp(160, false, 2, "brown");
            Console.WriteLine(lamp.turnTheLightOnAndOff());
            Bed bed = new Bed("black",2,3);
            Console.WriteLine(bed.ChangeBlanketCount(1)); 
            Console.WriteLine(bed.description());
            Chair chair = new Chair("white", "wood", "flowery");
            Console.WriteLine(chair.changeColor("black"));
            Console.WriteLine(chair.description());
            PC pc = new PC(1, "small", true, "black");
            Console.WriteLine(pc.changeCaseSize("big"));
            Console.WriteLine(pc.description());
            Cup cup = new Cup("white and purple", false, "large");
            Console.WriteLine(cup.pourSomeTea());
            Console.WriteLine(cup.description());
        }
    }
}
