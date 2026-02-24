using static System.Console;

// 핵심. static field

// static: 모든 객체지향 언어의 핵심
// instance field
// static field

// 자동차를 관리하는 프로그램에서 자동차의 총 생산 개수를 알고 싶음
// sol1. 모든 객체는 만들 때 생성자가 호출되므로, cnt 필드를 생성자에서 ++ 하자

class Car 
{
    private int speed = 0;
    private int color = 10;

    // public int cnt = 0;  이렇게 하면 객체별로 메모리에 각각 할당 

    // static을 사용하면 모든 객체가 공유
    //      1. Car 객체가 없어도 메모리에 존재
    //      2. 프로그램 실행 시에 정적 메모리에 생성되고 -> 종료될 때 메모리 해제
    //      3. 객체 생성 시, 개별 객체 메모리에는 존재하지 않음

    public static int cnt=0;  

    public Car(int s)
    {
        speed = s;
        ++cnt;
    }
}

class Program
{
    public static void Main()
    {

        // Car 객체가 없더라도 static field는 메모리에 존재.
        // 접근제어자가 public 이라면, Car.cnt로 언제든 접근 가능
        Console.WriteLine($"{Car.cnt}");

        Car c1 = new Car(50);
        Car c2 = new Car(80);
        Console.WriteLine($"{Car.cnt}");
    }
}