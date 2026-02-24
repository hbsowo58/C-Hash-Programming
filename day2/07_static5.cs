using static System.Console;



class Date
{
    // 강의에서는 간단히 하기 위해 auto property 사용
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }

    public Date(int year, int month, int day)
        => (Year, Month, Day) = (year, month, day);

    // 날짜 관련 메소드를 만들려면, 먼저 월별 날짜수를 정의해둬야함
    private static int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public static int HowManyDays(int month)
    {
        return days[month];
    }

    public Date Tomorrow()
    {
        Date tmp = new(Year, Month, Day + 1);
        return tmp;
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine(Date.HowManyDays(5));

        // 내일 날짜 구하기
        Date today = new Date(2025, 2, 23);
        Date tomorrow = today.Tomorrow();
    }
}