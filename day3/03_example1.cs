using static System.Console;

// 파워 포인트 같은 프로그램을 객체지향 프로그램으로 설계해 봅시다.

// 1. 모든 타입을 클래스로 만든 후 사용하기
// 2. 모든 도형은 공통의 특징이 있음 -> 공통 부모인 Shape 만들기
//      공통 도형이 있으면, 한개의 컬랙션(List)에 보관할 수 있음
//      서로 다른 자식 클래스 끼리는 하나의 컬랙션에 저장 불가 

class Shape
{
    public int color;
}
class Rect : Shape
{
    // left,top,right,bottom, 생성자 등은 생략하고 virtual에 집중

    public void Draw() { WriteLine("Draw Rect"); }
}
class Circle : Shape
{
    // left,top,right,bottom, 생성자 등은 생략하고 virtual에 집중

    public void Draw() { WriteLine("Draw Circle"); }
}
class Program
{
    public static void Main()
    {
        
        // List<Rect> s = new List<Rect>(); // Rect 만 보관 가능

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
        }
    }