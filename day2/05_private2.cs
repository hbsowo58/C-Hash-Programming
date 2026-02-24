using static System.Console;

// 핵심. 객체지향 언어의 3대 특징: 캡슐화, 상속, 다형성

// 1. 캡슐화(encapsulation)
//      필드의 접근 제어자를 private으로 설정하여 외부로부터 객체의 안전성 확보
//      필드는 getMethod/setMethod를 통해서만 접근(변경) 가능
//      get/set 메소드의 접근제어자는 public이 관례


class Bike
{
    private int gear = 0;

    // 타입 안전성 확보
    // 값이 유효한지 확인한 후 상태를 변경 => 필드는 항상 안전한 상태를 유지 가능
    public void SetGear(int gear)
    {
        if (gear > 1 && gear <= 20)
            this.gear = gear;
    }
}

class Program
{
    public static void Main()
    {
        Bike b = new Bike();

        // private이 필요한 경우
        // 사용자가 기어를 음수 등의 잘못된 값으로 설정할 가능성 존재 (타입 안전성 낮음)
        //b.gear = -10; 

        // 상태에 간접 접근!
        b.SetGear(-10);     // 잘못된 값이므로 무시됨
        b.SetGear(10);      // ok
    }
}


