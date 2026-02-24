using static System.Console;

class Shape
{
    private int color = 0;

    public virtual void Draw() { WriteLine("Draw Shape"); }

    // 복제 메소드 
    // 자신의 복사본을 만드는 가상 메소드는 널리 알려진 디자인 기술
    public virtual Shape Clone()
    {
        Shape s = new Shape();
        s.color = color;
        return s;
    }
}



class Rect : Shape
{
    public override void Draw() { WriteLine("Draw Rect"); }
    public override Shape Clone()
    {
        return new Rect();
    }
}

class Circle : Shape
{
    public override void Draw() { WriteLine("Draw Circle"); }
    public override Shape Clone()
    {
        return new Circle();
    }
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
            else if (cmd == 8)
            {
                Console.Write("복제할 도형의 번호를 입력해주세요: ");
                int k = int.Parse(Console.ReadLine());

                // k번쨰 도형의 복사본을 생성해서 s에 추가합니다. 
                // k번 도형은 어떤 타입일까?

                // 아래 처럼 했다면? ㅋ OCP 만족 못함 [나쁜 디자인]
                // 문법만 아는 개발자는 이렇게 했을 거임
                // 다지인을 아는 개발자는??
                //if (s[k] is Rect)
                //{
                //}
                //else if (s[k] is Circle)
                //{
                //}

                // k번째 도형이 어떤 타입인지 알 필요는 없고, k번쨰 도형에 clone을 요청하면 됨
                // 이것이 다형성
                //  자식 객체의 타입에 상관없이 의도대로 동작할 수 있는 코드
                //  Don't ask. Do it!
                s.Add(s[k].Clone());

            }
            else if (cmd == 9)
            {

                foreach (var e in s)
                {
                    e.Draw();
                }
            }
        }
    }
}
