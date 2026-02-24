using static System.Console;

class CPoint
{
	public int x;
	public int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	public int x;
	public int y;
	public SPoint(int a, int b) { x = a; y = b; }	
}

class Program 
{
	public static void Main()
	{
		CPoint cp1;			// HEAP에 객체는 만들지 않고, STACK에 참조변수만 만든 것 (x,y 없음)
		SPoint sp1;			// STACK에 값 변수, 그 자체로 인스턴스가 할당되긴 함. (x,y 있지만 초기화는 안되있음)
		SPoint sp2 = new SPoint(1, 1);   // STACK에 인스턴스 만들고 초기화까지 함! (x,y 있고 초기화도 되어서 값 할당도 되어있음)
		
		// 핵심 : 에러를 모두 찾으세요
		int a = cp1.x;	// ERROR - HEAP에 인스턴스가 없음
		cp1.x = 2;		// ERROR

		int b = sp1.x;  // ERROR - C#은 초기화 전에는 사용 불가
        sp1.x = 2;		// OK - 초기화(SET)는 가능
		int c = sp1.x;	// OK

		int d = sp2.x;	// OK
		sp2.x = 2;		// OK

	}
}
