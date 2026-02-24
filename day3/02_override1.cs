using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}
class Dog : Animal
{
    // 메소드 오버라이딩: 부모 클래스에 정의된 메서드를 자식에서 재정의 
    //      아마 함수 시그니쳐가 완전히 동일해야할거임

    // new 키워드: override임을 컴파일러에게 확인시켜줌 (override 기능?)
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Program
{
    public static void Main()
    {
        Animal a = new Animal();
        Dog d = new Dog();

        a.Cry();    // animal cry
        d.Cry();    // dog cry

        //----------------------------------
        Animal ad = d;


        ad.Cry(); // ?
    }
}
