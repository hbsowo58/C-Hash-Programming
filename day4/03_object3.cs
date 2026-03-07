// 03_object3.cs

// 현재 Rect 클래스 계층도
// Rect   -> Shape -> Object
// Circle -> Shape -> Object

// Object 역활 : 모든 C# 타입의 공통 기능을 제공 (GetType() 등의 타입 조사 기능)
// Shape  역활 : 도형으로서 가져야 하는 공통의 특징(Draw(), GetArea())
// Rect   역활 : 사각형 자체의 특징(left, top, right, bottom)

// 객체지향 언어를 잘하려면
//      1. 일단 문법 을 정확히 이해하고
//      2. 라이브러리가 왜 "계층별로 설계" 되는지,
//      3. 각 계층의 역활은 뭔지 이해할 수 있어야 한다!

abstract class Shape
{
    public abstract void Draw();
}

class Rect : Shape
{
    public override void Draw() { }
}
class Circle : Shape
{
    public override void Draw() { }
}

class Program
{
    public static void Main()
    {
        List<Rect> s = new List<Rect>(); // Rect 만 보관 가능

        // 모든 도형을 같이 보관하려면??

        // 1. Object 타입으로 보관
        List<object> s1 = new List<object>();
        //      단점 1. Object 안에는 Draw() 가 없어서 Object 타입으로는 Draw 메소드 호출안됨 (object는 draw의 인터페이스가 아님)
        //          호출하려면 다운캐스팅 필요하고, 복잡해짐
        //      단점 2. int, double 도 보관 가능.

        // 2. shape 타입으로 보관
        List<Shape> s2 = new List<Shape>();  
        //      장점 1. 모든 도형의 공통의 특징을 Shape 타입으로 모두 사용가능 
        //      장점 2: int, double 등은 보관 안돼서 안전함 (실수 방지)

    }



    public static void PrintHierachy(object obj)
    {
        Type t = obj.GetType();

        while (true)
        {
            Console.Write("{0} ->", t.Name);

            if (t.Name == "Object") break;

            t = t.BaseType;
        }

        Console.WriteLine(""); // 개행
    }
}