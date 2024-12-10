using System;
using MyProject.Cell ;
using System.Collections.Generic;
namespace MyProject.Classes
{
    public abstract class grid
    {
        private width { get; set; };
        private height { get; set; };
        private List<List<Cell>> grid { get; set; }; //= new List<List<Cell>>();

        public grid(int width, int height){
            width = 0;
            height = 0;
            grid = new List<List<Cell>>();

            for(int i = 0; i < height; i++){
                for (int j = 0; j < width ; j++ ){
                    grid[i][j] = new Cell(); //TODO error : grid isnt initialized !!
                }
            }
        }

        public abstract void update();

    }


}