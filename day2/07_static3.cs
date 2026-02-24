using static System.Console;

// 프로그램에서는 날짜를 많이 사용한다.
// Date 타입을 먼저 만들어보자

class Date
{
    // 1. 필드는 캡슐화를 위해 private로 보호
    private int year;
    private int month;   // 1~12만 유효
    private int day;     // 1~31만 유효

    // 2. getter/setter 제공 (property)
    public int Year
    {
        get => year;
        set => year=value;
    }
    public int Month
    {
        get => month;
        set { 
            if (value > 0 && value < 13) 
                month = value;
            else 
                throw new Exception("bad argument");   // 예외처리 
        }
    }
    public int Day
    {
        get => day;
        set { if(value>0&&value<32)day=value; }
    }

    // 3. 생성자로 필드 초기화
    public Date(int year, int month, int day) 
        =>(this.year, this.month, this.day) =(year, month,day);
}

class Program
{
    public static void Main()
    {
        Date d1=new Date(2025,2,23);
        Console.WriteLine(d1);
    }
}