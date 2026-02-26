
// 규모가 큰 프로젝트를 작업하면 "이름 충돌" 가능성이 있다
//      예를 들어, 내가만든 클래스 이름과 다른 개발자가 만든 클래스 이름이 겹칠수 있음

// => namespace 문법으로 논리적 단위 분리

using Graphic;
// namespace 명시를 생략해주는 편의 문법
// Graphic 내부 요소들을 "Graphic"이라는 namespace 명시 없이도 사용 가능
// C#,C++: 해당 문법을 파일 맨 위에 정의해야됨(함수 내부도 불가)
namespace Graphic
{
    class Point
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public Point(int a, int b) => (X, Y) = (a, b);
        public override string ToString() => $"({X}, {Y})";
    }
}
namespace Graphic3D
{
    class Point
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public int Z { get; set; } = 0;
        public Point(int a, int b, int c) => (X, Y,Z) = (a, b, c);
        public override string ToString() => $"({X}, {Y})";
    }
}
// 라이브러리를 사용할 때, namespace 단위로 접근하듯이
// namespace 정의를 사용자 정의 라이브러리로 생각해도 쉽다


class Program
{
    static void Main()
    {
        Graphic.Point p1 = new Graphic.Point(1, 2);
        Graphic3D.Point p2 = new Graphic3D.Point(1, 2, 3);

        Console.WriteLine(p1.ToString());
        Console.WriteLine(p2.ToString());

        Point p3 = new Point(1, 2);
        Console.WriteLine(p2.ToString());
    }
}