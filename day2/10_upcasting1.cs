
// upcasting : 객체지향에서 가장 중요한 개념 중 하나

class Animal
{
    public int Age { get; set; } = 0;
}

class Dog : Animal
{
    public int Color { get; set; } = 0;
}

class Cat : Animal
{
    public int Speed {  get; set; } = 0;
}

class Program
{
    public static void Main()
    {
        Dog r1 = new Dog(); // ok

        int r2 = new Dog(); // error

        // 부모 참조변수에 자식 객체를 참조할(가리킬) 수 있다.
        Animal r3 = new Dog(); // ?

    }
}


// 핵심2. 컴파일러는 컴파일 시간에 r3가 가리키는 객체의 정확한 타입을 알 수 없음
//      단지, 참조 변수의 타입을 따를 뿐 

// 힙 영역에 저장되는, 객체의 타입은 런타임에 결정됨 
// 아래는 그 예시
// if(사용자 입력값 == 1) r3 = new Animal();



// 핵심3. 컴파일러는 r3가 Animal 타입인 것만 알기에, r3의 Animal 부분만 접근 가능하고, 자식 부분은 접근 불가(error)
r3.Age = 10; // ok
r3.Color = 10; // error - 메모리에는 분명 있지만 접근 불가능

//      이유: 멤버(필드, 메소드) 접근이 유효 한지를 확인하는 시점 때문임
//      C++, C#, Java : 컴파일 시간에 확인(static type check)
//      Python        : 런타임에 확인(dynamic type check)  -> 실행 하다가 프로그램 중지됨


// 핵심4. 고유 멤버에 접근하려면 캐스팅해야함
((Dog)r3).Color = 10; // ok
//      단 이경우에, r3가 가리키는 곳이 반드시 Dog인지 개발자가 확신해야 함!
//      아니면 runtime error 발생


// 핵심5. Dog라는 확신이 없으면 is 연산자로 type을 확인하면 됨
if(r3 is Dog)
{
    Dog d = (Dog)r3;        // 타입 캐스팅해서 Dog 참조변수에 할당
    d.Color = 10;           // dog 타입변수로 접근해야 오류가 없읍
}