using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Puzzle
{
    public interface IMove
    {
        void Move();
        void TurnLeft();
        void TurnRight();
        int Interval_Move();
    }
}