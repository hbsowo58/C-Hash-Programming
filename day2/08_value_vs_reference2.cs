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
	public SPoint(int a, int b) { x = a; y = b;}	
}

// 핵심 : 아래 코드의 메모리 모양
class Program 
{
	public static void Main()
	{
		// class -> 참조 변수
		CPoint cp1 = new CPoint(1, 1);
		CPoint cp2 = cp1;				// 주소 복사 [참조]
		
		cp1.x = 2;                      // cp2.x도 2
        WriteLine($"{cp1.x} {cp2.x}"); 


		// struct -> 값 복사 변수
		SPoint sp1 = new SPoint(1, 1);
		SPoint sp2 = sp1;				// sp2와 sp1은 서로 다른 메모리를 각각 가짐

		sp1.x = 2;						
		WriteLine($"{sp1.x} {sp2.x}"); 
	}
}
