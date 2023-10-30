using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._4
{
    class Circle : GraphicPrimitive
    {
        public int Radius { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Рисуємо круг на точках ({X}, {Y}) з радіусом {Radius}");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override void Scale(float factor)
        {
            Radius = (int)(Radius * factor);
        }
    }
}
