using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}
class Dog : Animal
{
    public void Cry() { WriteLine("2. Dog Cry"); }
}

class Program
{
    public static void Main()
    {
        Animal a=new Animal();
        Dog d = new Dog();

        Animal ad = d;

        // 다형성(upcasting)된 변수는 어떤 메서드를 호출할까?
        // 참조 타입은 부모, 실제 객체는 자식 
        // 실제 메모리의 객체는 자식이므로 자식 메소드 호출
        // C#, C++, Rust        : Animal 것 부름
        // Java, Python, Swift : Dog것 부름
        ad.Cry(); // ?
    }
}

// 2가지 Funtion(Method) Binding 개념 (104p)

// 1. static binding: 컴파일 시간에 컴파일러가 호출할 함수를 결정
//      [핵심] 컴파일시간에는 실제 메모리에 저장된 타입을 알 수 없다!!
//      [핵심2] 참조 변수의 타입만 알 수 있음 
//      따라서 컴파일러는 부모메서드르 호출
//      [장점] 빠름 
//      [단점] 논리적이지 않음
//      C++,C#의 기본 바인딩 정책 

// 2. dynamic binding: 런타임에 컴파일러가 호출할 함수를 결정
//      컴파일 시간에는 ad가 가리키는 메모리를 조사하는 중간언어 코드를 만들어 두고, 실행시간에 메모리를 조사해서 호출을 결정
//      실제 메모리에 Dog 객체가 있다면 자식의 메소드를 호출 
//      [장단점] 느리지만 논리적임
//      Java, Python, Kotlin, Swift 등 대부분의 객체지향 언어의 기본 바인딩 기법
//      C/C++의 virtual method