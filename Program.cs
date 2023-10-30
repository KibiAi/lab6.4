using lab6._4;

class Program
{
    static void Main()
    {
        GraphicsEditor editor = new GraphicsEditor();

        Circle circle = new Circle { X = 10, Y = 35, Radius = 10 };
        Rectangle rectangle = new Rectangle { X = 25, Y = 40, Width = 10, Height = 15 };
        Triangle triangle = new Triangle { X = 50, Y = 70 };

        Group group = new Group { X = 70, Y = 80 };
        group.Add(circle);
        group.Add(rectangle);

        editor.AddPrimitive(circle);
        editor.AddPrimitive(rectangle);
        editor.AddPrimitive(triangle);
        editor.AddPrimitive(group);

        editor.DrawAll();

        Console.WriteLine("Рухаємо все...");
        editor.MoveAll(5, 5);
        editor.DrawAll();

        Console.WriteLine("Масштубуємо все...");
        editor.ScaleAll(1.5f);
        editor.DrawAll();
    }
}