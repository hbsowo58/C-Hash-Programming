class Person
{
    // 1. 필드를 만들기
    private int age;

    // 2. age에 대한 property 작성
    //      필드의 대문자로 만드는게 관례
    public int Age
    {
        get => age;
        set => age = value;
    }

    // 위와 같이 property의 기본형(추가적인 로직이 없음)은 아래처럼 한 줄로 표현 가능
    //      1. 필드도 자동으로 생성됨(int age 불필요)
    //      2. Age Property의 set/get 기능 자동 추가 
    public int Age { get; set; } = 0;
}