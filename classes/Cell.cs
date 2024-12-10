using System;
namespace MyProject.Classes
{
    public class A { 
        private bool isAlive = 0 ;
        private bool next_state = 0 ; // first loop determine the future states based on the old states then set the new ones
        static dimension ;

        public A(){}
        
        public int get
        /*public bool is_alive(){
            return isAlive;
        }

        public void switch_state(){
            isAlive = next_state;
        }

        public void kill(){
            next_state = 0;
        }

        public void revive(){
            next_state = 1;
        }*/

        public setDimension(int a){
            dimension = a ;
        }
     }
}