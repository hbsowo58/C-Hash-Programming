using static System.Console;

// Triangle 추가해도 의존성을 해결했기 때문에 OCP 만족!!!! 
// 디자인을 잘 하면 !!!!!!!!!!!!! 결국 이런 유지보수와 확장성이 고려되고 최적화 되는 것!!!!!

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

class Triangle : Shape
{
    public override void Draw() { WriteLine("Draw Triangle"); }
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

                foreach (var e in s)
                {
                    e.Draw();           // 새로운 도형이 추가되어도 main 코드는 바뀌지 않는데 [OCP 만족]
                    // 이것이 다형성(Polymorphism)
                    // 도일한 한줄의 코드가 상황에 따라 다르게 동작하는것
                    //      여기서 상황은, 실제 메모리에 저장된 객체의 종류를 의미 
                    //      여기서 동작은 virtual method
                    // OCP를 만족하는 좋은 문법 
                }
            }
        }
    }
}

// 객체지향 언어의 3대 특징
// 캡슐화 : 필드를 private으로 보호해서 안전성 증가
// 상속: 공통의 특징을 기반 클래스에, 이 문법 때문에 List<Shape> 가능
// 다형성: e.Draw() 코드로 다양한 도형을 그릴 수 있음, OCP 만족하는 좋은 코드