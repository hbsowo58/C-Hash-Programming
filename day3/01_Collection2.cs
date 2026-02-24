// 핵심. 단축표기법

class Program
{
    public static void Main()
    {
        List<int> s1 = new List<int>(); // 정확한 표기법
        List<int> s2 = new();           // 단축 표기법

        // C#은 컴파일러에 의한 타입 추론이 강력하므로 단축 표기법 추천

        Point pt1 = new Point(1, 1);
        Point pt2 = new(1, 1);      // 이렇게 단축표기해도 된다
    }
}
