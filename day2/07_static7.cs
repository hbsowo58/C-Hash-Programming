// 다음 코드에서 에러를 모두 찾으세요
class Car
{
    // 객체를 생성하면 각 객체별로 하나씩 메모리에 할당되는 field
    private int speed = 0;
    
    // 객체가 없어도 메모리에 존재하고 모든 객체가 공유하는 field
    private static int cnt = 0;  

    public static void F1()
    {
        speed = 10; // error : static method는 instance field가 존재하지 않음
        cnt = 10;   // ok
    }
    public void F2()
    {
        speed = 10; // ok
        cnt = 10;   // ok
    }
}
class Program
{
    public static void Main()
    {
    }
}