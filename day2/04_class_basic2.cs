using static System.Console;

// 핵심. 생성자 

class Rect
{
    public int left = 0;
    public int top = 0;
    public int rigth = 0;
    public int bottom = 0;


    public int GetArea()
    {
        return (right - left) * (bottom - top);
    }

    // 생성자: 클래스 이름과 동일한 이름의 메소드로 객체를 생성할 떄 호출한다.
    public Rect(int left, int top, int rigth, int bottom)
    {
        this.left=left;
        this.top=top;
        this.rigth=rigth;
        this.bottom=bottom;
    }
    // 위 코드는 아래 코드와 동일
    public Rect(int left, int top, int rigth, int bottom) 
        => (this.left, this.top, this.rigth, this.bottom) =(left,top,rigth,bottom);
  
    public Rect() => (left,top,rigth,bottom)=(0,0,0,0);
}

class Program
{
    public static void Main()
    {
        // 객체를 생성할 때는 new 사용
        Rect rc1 = new Rect(1, 1, 10, 10);

        // 사용자 정의 생성자가 존재하므로, 인자가 없는 생성자를 따로 정의해야함
        Rect rc2 = new Rect();

        int ret = rc.GetArea();

        Console.WriteLine($"{ret}");
    }
}