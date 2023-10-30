using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._4
{
    class Triangle : GraphicPrimitive
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Рисуємо трикутник з точками ({X}, {Y})");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override void Scale(float factor)
        {
            SideA *= (int) factor;
            SideB *= (int) factor;
            SideC *= (int) factor;
        }
    }
}
