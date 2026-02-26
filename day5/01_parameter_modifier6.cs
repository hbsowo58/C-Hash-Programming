using static System.Console;

class CPoint
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;
}
struct SPoint
{
    public int X { get; set; }
    public int Y { get; set; }
}



class Program
{
    // 참조(reference) 타입은 ref를 사용하지 않아도 참조로 받음
    public static void F1(CPoint pt)
    {
        pt.X = 10;  // main의 cp가 가리키는 객체 변경
        pt.Y = 20;
    }

    // 구조체는 값(value) 타입 
    public static void F2(SPoint pt)
    {
        pt.X = 10;
        pt.Y = 20;
    }
    public static void Main()
    {
        CPoint cp = new CPoint { X = 0, Y = 0 };
        SPoint sp = new SPoint { X = 0, Y = 0 };

        // 구조체는 값 복사라서 변화 없음
        F2(sp);
        Console.WriteLine("{sp.x}, {sp.y}");

        // 객체는 참조 타입이라서 변함
        F1(cp);
        Console.WriteLine("{cp.x}, {cp.y}");
    }
}