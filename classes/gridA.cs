using System;
using MyProject.Cell ;
using System.Collections.Generic;
namespace MyProject.Classes
{
    public class gridA : grid
    {
        public int max_state ;

        public gridA(int width, int height) : base(width, height)
        {
            max_state = 1;
        }

        public override void update()
        {
            \\TODO
        }
    } 
}