using System;
namespace MyProject.Classes
{
    public class Cell { 
        public int state {get; set;} 
        public int nextState {get; set;}  // why ? :first loop determine the future states based on the old states then set the new ones
        static int dimension {get; set;}

        public Cell(){
            state = 0 ;
            nextState = 0 ;
        }
        
        public void update(){
            state = nextState ;
        }
     }
}