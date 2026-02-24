using static System.Console;

// 해결책1. 캐스팅

class Shape
{
    public int color;
}
class Rect : Shape
{
    public void Draw() { WriteLine("Draw Rect"); }  // 자식의 고유 멤버
}
class Circle : Shape
{
    public void Draw() { WriteLine("Draw Circle"); }
}
class Triangle : Shape
{
    public void Draw() { WriteLine("Draw Triangle"); }
}
class Program
{
    public static void Main()
    {
        // 만들어지는 모든 도형을 보관하기 위한 컬렉션
        List<Shape> s = new List<Shape>(); // 모든 도형을 보관할수 있다

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

                foreach (var e in s)
                    if (e is Rect)
                    {
                        Rect r = (Rect)e; // Shape을 Rect로 캐스팅
                    }
                    else if (e is Circle)
                    {
                        Circle r = (Circle)e;
                    }
                    r.Draw();
            }


        }
    }