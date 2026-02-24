// inheritance (상속 )
//      class만 가능
//      struct는 불가
//      기존 타입을 그대로 가진 새로운 타입 선언 

// 부모 지칭 용어 : Base class, Super class, Parent class
// 자식 지칭 용어 : Derived class, Sub class, Child class


// 공통 특징은 person 클래스에 정의
class Person
{
    private string name;
    private int age;

    private string email;  // 여기에 추가하면 Person의 파생 클래스에 모두 추가됨
}
class Professor : Person
{
    private string major;
}
class Student : Person
{
    private string id;
}

class Program
{
    public static void Main()
    {
        Student s = new Student();

    }
}
