using static System.Console;


class Example
{
    // 파라미터에 디폴트값 사용가능
    // C++: 지원, 디폴트파라미터 라고 부름
    // C#: 지원, optinal 파라미터 라고 부름
    // python: 지원
    // Java, C, Rust: 모두 지원 안함
    public void M1(int a, int b = 0, int c = 0)
    {
    }
}

class Program
{
    public static void Main()
    {
        Example e = new Example();

        e.M1(1, 2, 3);
        e.M1(1, 2);
    }
}