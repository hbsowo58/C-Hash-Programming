
// 핵심. property
//      안전성도 높고, 가독성도 좋은 방법

class Person1
{
    private int age;

    // Property 문법
    //      C++/Java에는 없고 C#에만 있는 고유 특징
    //      getter/setter를 편리하게 만들고 사용하는 문법 
    //      만들 때는 함수처럼, 사용할 때는 필드로
    public int Age
    {
        get { return age; }
        set { if (value>0)
                age = value; }
    }
}




class Program
{
    public static void Main()
    {
        Person1 person1 = new Person1();

        // property는 필드처럼 접근
        person1.Age = 10;       // set 부분을 호출 -> 오른쪽이 value
        int n = person1.Age;    // get 부분을 호출 
    }
}
