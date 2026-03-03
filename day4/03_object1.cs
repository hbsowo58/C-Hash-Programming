
// 핵심. 모든 object의 기본 7가지 메소드

// 1. C# 의 거의 모든 타입은 자동으로 "Object" 클래스를 상속 받음
// 2. Object 클래스에는 7개의 메소드가 있음
// 3. 이 7개의 메소드는 C# 의 모든 종류의 변수와 리터럴 값에서 사용 가능
//      Window w = new Window() 에서 w 에도 7개의 메소드 있음.  

/*
class Object
{
    // 2개의 static method
    public static bool Equals(object? objA, object? objB) { ... };
    public static bool ReferenceEquals(object? objA, object? objB) { ...};

    // 2개의 non-virtual method
    public Type GetType() { ... };
    protected object MemberwiseClone() { ... };

    // 3개의 virtual method
    public virtual bool Equals(object? obj) { ... };
    public virtual int GetHashCode() { ... };
    public virtual string? ToString() { ... };
}
*/

class Car 
{
    
}

class Program
{
    public static void Main()
    {
        Car c = new Car();
        var s = c.ToString();   
    }

}
