using static System.Console;

class Rect
{
    // 타입을 표현하기 위한 상태
    // C#, Java, Rust -> Field
    // C++ -> 멤버 변수
    public int left = 0;
    public int top = 0;
    public int rigth = 0;
    public int bottom = 0;


    // C#, Java, Rust -> method
    // C++ -> 멤버 함수
    public int GetArea()
    {
        return (right - left) * (bottom - top);
    }

}

class Program
{
    public static void Main()
    {
        // 객체를 생성할 때는 new 사용
        Rect rc = new Rect();
        rc.left = 1;
        rc.top = 1;
        rc.rigth = 10;
        rc.bottom = 10;

        int ret = rc.GetArea();

        Console.WriteLine($"{ret}"); 
    }
}