class Person
{
    private int age;

    // C# 에서는 expression bodied 를 많이 사용
    public int Age
    {
        get => age;
        set => age = value;  // if 등을 사용하려면 {} 로 구현
    }

}
class Program
{
    public static void Main()
    {
        // 인자가 한개인 생성자에 인자 10을 전달
        // 하지만, 인자가 한개인 생성자가 존재하지 않으면 error
        Person p = new Person(10);

        // property는 생성 시에 초기화도 가능
        //      {} 중괄호 내부에 property 
        Person p1 =new Person { Age = 10 };
        Person p2 = new Person { Age = 10, Name="AAA" };

    }
}