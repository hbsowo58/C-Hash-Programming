using static System.Console;

// Shape 객체가 Draw()를 쓰진 않을거지만, 모든 shape의 자식 클래스는 draw가 필요함
//=> Shape에도 draw가 있어야 Shape 참조변수로 Draw() 호출 가능

class Shape
{
    private int color = 0;

    public void Draw() { WriteLine("Draw Shape"); }
}



class Rect : Shape
{
    public void Draw() { WriteLine("Draw Rect"); }
}

class Circle : Shape
{
    public void Draw() { WriteLine("Draw Circle"); }
}

class Program
{
    public static void Main()
    {
        List<Shape> s = new List<Shape>();

        while (true)
        {
            int cmd = int.Parse(Console.ReadLine());

            if (cmd == 1)
            {
                s.Add(new Rect());
            }
            else if (cmd == 2)
            {
                s.Add(new Circle());
            }
            else if (cmd == 9)
            {
                // 이제 부모 참조변수로 draw()를 호출해도 오류가 안남
                // 하지만, static binding이므로 부모의 Draw가 호출됨 
                foreach (var e in s)
                {
                    e.Draw();
                }
            }
        }
    }
}

