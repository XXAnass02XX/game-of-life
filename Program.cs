﻿using MyProject.Classes;
using System;
using System.IO;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
            // Read the file contents
            Console.WriteLine("which example you want to run , type just a number from 1 to 4 :");
            int nbr = int.Parse(Console.ReadLine());
            try
            {
                string[] lines = File.ReadAllLines($"examples/example{nbr}.txt");

            // Create the initial grid
                Console.WriteLine($"the lens are : {lines[0].Length} and {lines.Length}");
                GridA our_grid = new GridA(lines[0].Length, lines.Length);
                for (int i = 0; i < lines.Length; i++)
                {
                    for (int j = 0; j < lines[i].Length; j++)
                    {
                        try
                        {
                            our_grid.grid[i][j].state = lines[i][j] == '1' ? 1 : 0;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"An error occurred: {ex.Message}");
                            Console.WriteLine($"problem at :::: i: {i} , j : {j}");
                            return ;
                        }
                        
                    }
                }
                /* to see the created grid
                for (int i = 0; i < lines.Length; i++)
                {
                    for (int j = 0; j < lines[i].Length; j++)
                    {
                        Console.Write(our_grid.grid[i][j].state);
                    }
                    Console.Write("\n");
                }
                return ;*/
                // Run the Game of Life simulation
                int iter = 0;
                while (iter < 10)
                {
                    our_grid.Update();
                    PrintGrid(our_grid);
                    System.Threading.Thread.Sleep(500); // Pause for 0.5 seconds
                    iter ++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"an error occured : {ex}");
            }
        }

        static void PrintGrid(GridA our_grid)
        {
            Console.Clear();
            Console.WriteLine("state------");
            string square ;
            for (int i = 0; i < our_grid.grid.Count; i++)
            {
                for (int j = 0; j < our_grid.grid[i].Count; j++)
                {
                    square = our_grid.grid[i][j].state == 0 ? "█" : " " ; 
                    Console.Write(square);
                }
                Console.WriteLine();
            }
            /*Console.WriteLine("next_state-------");
            for (int i = 0; i < our_grid.grid.Count; i++)
            {
                for (int j = 0; j < our_grid.grid[i].Count; j++)
                {
                    Console.Write(our_grid.grid[i][j].nextState);
                }
                Console.WriteLine();
            }
            Console.WriteLine();*/
        }
    }