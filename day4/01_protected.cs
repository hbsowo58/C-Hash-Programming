 
// 핵심. 접근지정자
// : 필드, 메소드, property 등에 대한 접근 가능 범위를 지정하는 키워드 
//      전통적인 접근지정자는 3가지 : private, public, protected 

// C++ : 3가지 지원
// Java : 3 + default 지원
//      private + default(같은 패키지 단위) + protected(같은 패키지 or 자식 클래스) + public
// C# : 3 + internal
//      private + protected + internal(같은 프로젝트 단위) + public
// 그 외 언어들도 3가지에 추가로 더 가진 경우가 있음

class Shape
{
    private int color = 0;          // 자신의 메소드만 접근 가능
    protected int color = 0;        // 자신의 메소드 + 자식의 메소드에서 접근 가능
    internal int color = 0;         // 프로젝트 단위 (같이 빌드되는 하나의 프로젝트 내라면 접근 가능)
    public int color = 0;           // 모든 위치(모든 클래스의 메소드)에서 접근 가능
    



    public void SetColor(int c)
    {
        color = c;
    }   
}

class Rect : Shape
{
    public void Draw()
    {
        int c = color;  // protected, interval, public 오류 안남
    }
}

class Program 
{     
    public static void Main()
    {
        Shape s = new Shape();
        s.color = 10; // public, interval 오류 안남
    }

}
