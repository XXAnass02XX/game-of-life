using MyProject.Classes;
using System;
using System.IO;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
            // Read the file contents
            string[] lines = File.ReadAllLines("examples/example1.txt");

            // Create the initial grid
            GridA grid = new GridA(lines[0].Length, lines.Length);
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    grid.grid[i][j].state = lines[i][j] == '1' ? 1 : 0;
                }
            }

            // Run the Game of Life simulation
            while (true)
            {
                grid.Update();
                PrintGrid(grid);
                System.Threading.Thread.Sleep(500); // Pause for 0.5 seconds
            }
        }

        static void PrintGrid(GridA grid)
        {
            Console.Clear();
            for (int i = 0; i < grid.grid.Count; i++)
            {
                for (int j = 0; j < grid.grid[i].Count; j++)
                {
                    Console.Write(grid.grid[i][j].state == 1 ? "1" : "0");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
