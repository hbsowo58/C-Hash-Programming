
// 코드를 구분하는 논리적 단위
// C#: namespace
// Java: package

using Graphic;

namespace Graphic
{
    class Point
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public Point(int a, int b) => (X, Y) = (a, b);
        public override string ToString() => $"({X}, {Y})";
    }

    // namespace는 중첩될 수 있다.
    namespace Engine
    {
        class Card
        {
            public static void Test()
            {
                Console.WriteLine("Card Test")
            }
        }
    }
}


class Program
{
    static void Main()
    {
        Graphic.Point p1 = new Graphic.Point(1, 2);

        // Card 객체 만들어 보세요
        Graphic.Point c = new Graphic.Point();

        // Card 클래스의 static method Test() 호출해 보세요
        Graphic.Engine.Card.Test(); 
        // Graphic namespace 안에
        // Engine namespace 안에 
        // Card 클래스의 Test method 호출
        
    }
}
// C# 표준의 모든 클래스는 System이라는 namespace 안에 있음
// System: namespace 이름
// Console: 클래스 이름
// WriteLine() : static method
System.Console.WriteLine("aa");
// 코드만으로는 namespace인지 class 인지 구분이 불가
//      개발시 IDE의 lookup 기능으로 구분
