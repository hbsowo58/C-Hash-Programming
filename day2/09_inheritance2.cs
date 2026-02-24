
// 핵심. C# 언어만의 특징2 (C++, java 와 다른) object
//      모든 타입은 자동으로 Object라는 클래스를 상속받는다!!!!!!



class Car   // class Car : Object 로, object의 field/method를 기본 상속받음 
{
}

class Program
{
    public static void Main()
    {
        Car c = new Car();

        // C#의 거의 모든 클래스는 ToString() 메소드가 있다.
        // => object가 제공하는 메소드는 다 알아야한다!!!
        string s = c.ToString(); // 타입 이름이 문자열로

        int n = 10;
        n.ToString();
        
    }
}