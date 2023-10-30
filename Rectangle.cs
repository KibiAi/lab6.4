using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._4
{
    class Rectangle : GraphicPrimitive
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Рисуємо прямокутник з точками ({X}, {Y}) з шириною {Width} та з висотою {Height}");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override void Scale(float factor)
        {
            Width = (int)(Width * factor);
            Height = (int)(Height * factor);
        }
    }
}
