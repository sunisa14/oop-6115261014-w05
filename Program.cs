using System;

namespace oop_6115261014_w05
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b2 = new Building("001", "Building 1", "180", "30");
            Room r422 = new Room("422", "Room 422", "4", "4", "computer", b2);
            Subject S = new Subject("55555", "cpt", "5.1", "1", "1");
            Lecturer Sunisa = new Lecturer("Sunisa", "Lumsiri", "lecturer");
            Section cpt = new Section("15", "8.00", "12.00", r422, S, Sunisa);
            Console.WriteLine(r422.ToString());
            Console.WriteLine(cpt.ToString());
        }
    }
}