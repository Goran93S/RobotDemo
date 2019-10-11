using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Puzzle
{
    class Toy:IMove
    {    
        public bool[,] table = new bool[5, 5];
        public int coordinate_X { get; set; }
        public int coordinate_Y { get; set; }
        public string Direction { get; set; }
        public int TargetCoordinateX { get; set; } 
        public int TargetCoordinateY { get; set; }

        public bool Fall = false;

        public int Interval = 1; //Interval or step of Toy
        public DateTime _Start { get; set; }
        public DateTime _Finish { get; set; }

        public Random random=new Random();

        public Toy(int coordinate_X,int coordinate_Y,string Direction)
        {
            this.coordinate_X = coordinate_X;
            this.coordinate_Y = coordinate_Y;
            this.Direction = Direction;
            
        }

        public Toy()
        {
            
        }            
        public void Place()
        {
            table[coordinate_X, coordinate_Y] = false; 
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (!(i == coordinate_X && j == coordinate_Y))
                        table[i, j] = true;                 
        } //Placing Toy on table
            
        public void Move()
        {
            if (Direction == "North")
            {
                if (coordinate_X - Interval_Move() >= 0)
                    coordinate_X -= Interval_Move();
                else
                    Fall = true;
            }
            if (Direction == "East")
            {
                if (coordinate_Y + Interval_Move() <= 4)
                    coordinate_Y += Interval_Move();
                else
                    Fall = true;
            }
            if (Direction == "South")
            {
                if (coordinate_X + Interval_Move() <= 4)
                    coordinate_X += Interval_Move();
                else
                    Fall = true;
            }
            if (Direction == "West")
            {
                if (coordinate_Y - Interval_Move() >= 0)
                    coordinate_Y -= Interval_Move();
                else
                    Fall = true;
            }
        }  //Making a move

        public void TurnLeft()
        {
            switch (Direction)
            {
                case "North": Direction = "West"; break;
                case "West": Direction = "South"; break;
                case "South": Direction = "East"; break;
                case "East": Direction = "North"; break;
            }
        }  //Turning left for 90 degres

        public void TurnRight()
        {
            switch (Direction)
            {
                case "North": Direction = "East"; break;
                case "East": Direction = "South"; break;
                case "South": Direction = "West"; break;
                case "West": Direction = "North"; break;
            }
        }  //Turning right for 90 degres

        public int Interval_Move()
        {
            return Interval;
        } //Returning interval

        public int GenerateRandomCoordinate(int min,int max)
        {                    
            return random.Next(min, max);
        } //Random coordinates for matching

        public bool CheckMatching()
        {
            if (coordinate_X == TargetCoordinateX && coordinate_Y == TargetCoordinateY)
                return true;
            else
                return false;
        }

        
    }
}