using static System.Console;

// 핵심. 기반 클래스의 메소드를 파생 클래스에서 override 해서 사용할 거라면 virtual method로 해야한다
// 그래야 Shape 참조변수로 호출해도, 자식 메소드가 호출됨!!
class Shape
{
    private int color = 0;

    // dynamin binding
    public virtual void Draw() { WriteLine("Draw Shape"); }
}



class Rect : Shape
{
    public override void Draw() { WriteLine("Draw Rect"); }
}

class Circle : Shape
{
    public override void Draw() { WriteLine("Draw Circle"); }
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

