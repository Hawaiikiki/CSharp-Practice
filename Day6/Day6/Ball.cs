using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Ball
    {
        private int size;
        private Color color;
        private int numThrown;
        public int Size { get; set; }
        public Color Color { get { return color; } set { color = value; } }

        public int NumThrown { get { return numThrown; } set { numThrown = value; } }

        public Ball(int size, Color color)
        {
            Size = size;
            if (size <= 0)
            {
                throw new ArgumentException("ball size should be greater than 0");
            }
            Color = color;
            NumThrown = 0;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size != 0)
            {
                NumThrown++;
            }
            else if (Size == 0)
            {
                Console.WriteLine("Cannot throw popped ball");
            }
            
        }

        public int CountThrow()
        {
            return numThrown;
        }

    }
}
