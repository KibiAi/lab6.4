using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._4
{
    class Group : GraphicPrimitive
    {
        private List<GraphicPrimitive> children = new List<GraphicPrimitive>();

        public void Add(GraphicPrimitive child)
        {
            children.Add(child);
        }

        public override void Draw()
        {
            Console.WriteLine($"Рисуємо у группі ({X}, {Y})");
            foreach (var child in children)
            {
                child.Draw();
            }
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
            foreach (var child in children)
            {
                child.Move(x, y);
            }
        }

        public override void Scale(float factor)
        {
            foreach (var child in children)
            {
                child.Scale(factor);
            }
        }
    }
}
