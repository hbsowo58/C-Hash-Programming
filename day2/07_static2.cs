using static System.Console;

// 핵심. static method

class Car
{
    private int speed = 0;
    private int color = 10;

    private static int cnt = 0;

    // static이 아니므로 -> 객체가 있어야 호출 가능한 메소드임
    // public int GetCount() { return cnt; };  

    // static method
    //      객체 없이 클래스로 접근 가능
    //      static field에만 접근 가능하고 instance field에는 당연히 접근 불가!!
    public static int GetCount() => cnt;

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


        Car c1 = new Car(50);
        Car c2 = new Car(80);
        Console.WriteLine($"{Car.GetCount()}");
    }
}