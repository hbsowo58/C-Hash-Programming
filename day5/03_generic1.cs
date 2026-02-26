
// 핵심. 메소드의 제네릭 문법 


class Program
{
    // 각 타입별로 오버로딩으로 만드는건 불편함
    /* 
    public static void Swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }
    public static void Swap(ref double a, ref double b)
    {
        double tmp = a;
        a = b;
        b = tmp;
    }
    */

    // 구현은 동일하며 단지, 타입만 다른 여러개의 함수가 필요할 때
    // 직접 여러 오버로딩 함수 작성❌
    // 함수의 틀 만들 ⭕
    // C++ : 틀이라는 관점을 강조해서 template 용어 사용
    // C#, Java, Rust : 모든 타입에 동작한다를 강조해서 일반화(genetic) 용어 사용

    public static void Swap<T>(ref T a, ref T b)
    {
        T tmp = a;
        a = b;
        b = tmp;
    }

    public static void Main()
    {
        int n1 = 10, n2 = 20;
        double d1 = 1.1, d2 = 2.3;

        //Swap(ref n1, ref n2); 

        Swap<int>(ref n1, ref n2);
        // 컴파일러가 하는 일
        // 1. 틀을 이용해서 Swap(ref int, ref int) 함수를 생성
        // 2. 이 코드는 "call Swap(ref n1, ref n2" 역할
        // 즉, 타입별 함수는 더이상 개발자가 만드는 것이 아니라, 컴파일러가 만드는 것!

        Swap<double>(ref d1, ref d2);

        // generic 함수를 사용하는 두가지 방법
        // sol1. 타입 인자를 명시적으로 전달 - 위 코드
        // sol2. 타입 인자 생략 -> 함수 일자로 컴파일러가 추론
        //      일반적인 방법
        Swap(ref n1, ref n2); // n1,n2를 보고 컴파일러가 int를 추론할 것임
    }
}