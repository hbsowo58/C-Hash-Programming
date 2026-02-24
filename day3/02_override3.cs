using static System.Console;

class Animal
{
    // 일반 메소드
    // C#의 기본 바인딩 정책인 static binding 사용
    // Cry1() 메소드 호출은 컴파일 시간에 참조변수의 타입으로 결정됨
    public void Cry1() { WriteLine("Animal Cry1"); }

    // virtual 가상 메소드
    // dynamic binding 정책
    // cry2() 호출 시, 컴파일 시간에 결정하지 않고 런타임에 실제 메모리를 확인해서 결정
    public virtual void Cry2() { WriteLine("Animal Cry2"); }
}

class Dog : Animal
{
    // 일반 메소드를 override할 때는 new 키워드 사용
    public new void Cry1() { WriteLine("Dog Cry1"); }

    // virtual method를 override 할 때는 overrid 키워드 사용
    public override void Cry2() { WriteLine("Dog Cry2"); }
}

class Program
{
    public static void Main()
    {
        Animal ad = new Dog();

        // 참조 변수의 타입은 animal
        // 실제 메모리의 객체 타입은 dog

        ad.Cry1();  // static binding -> Animal Cry
        // 컴파일 시간에 결정됨, 빠름
        ad.Cry2();  // dynamic binding -> Dog Cry
        // 런타임에 결정됨, 느림 
    }
}

// java는 모든 메소드가 dynamic binding
// 따라서, virtual 키워드가 없고 && 모두 C#의 vritual 처럼 동작한다