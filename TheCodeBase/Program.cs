using System;
using System.Collections.Generic;
using TheCodeBase;

class Program
{
    static void Main(string[] args)
    {
        // Plato boyutlarını kullanıcıdan istedim
        Console.WriteLine("Enter plateau size :");
        var plateauSize = Console.ReadLine().Split(' ');
        int plateauWidth = int.Parse(plateauSize[0]);
        int plateauHeight = int.Parse(plateauSize[1]);
        Plateau plateau = new Plateau(plateauWidth, plateauHeight);

        // Rover'ların listesini oluşturdum
        var rovers = new List<Rover>();

        while (true)
        {
            // Rover başlangıç pozisyonunu kullanıcıdan istedim
            Console.WriteLine("Enter rover position, or 'end' to finish :");
            var roverInput = Console.ReadLine();
            if (roverInput.ToLower() == "end") break;

            var roverParts = roverInput.Split(' ');
            int roverX = int.Parse(roverParts[0]);
            int roverY = int.Parse(roverParts[1]);
            char roverDirection = char.Parse(roverParts[2]);
            Rover rover = new Rover(roverX, roverY, roverDirection);
            rovers.Add(rover);

            // Rover hareket komutlarını kullanıcıdan istedim
            Console.WriteLine("Enter rover commands :");
            var commands = Console.ReadLine();

            // Rover'ı hareket ettirdim
            foreach (var command in commands)
            {
                switch (command)
                {
                    case 'L':
                        rover.TurnLeft();
                        break;
                    case 'R':
                        rover.TurnRight();
                        break;
                    case 'M':
                        rover.Move();
                        break;
                }
            }
        }

        // Sonuçları yazdırdım
        foreach (var r in rovers)
        {
            Console.WriteLine(r);
        }
    }
}
