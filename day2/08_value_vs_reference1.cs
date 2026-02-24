using static System.Console;

// 핵심 : value type vs reference type

// reference type : class, interface 문법으로 만든 타입
//		모든 필드는 heap에 생성
//		stack에는 참조변수 생성(주소를 저장)


// value type : struct, enum 등의 문법으로 만든 타입
//		모든 필드는 stack에 생성
//		(java에서 enum은 객체(참조변수)지만 C#은 값 타입)

// C#, Java, Swift, kotlin 동일
// 모든 변수가 reference인 언어

// 권장
// 크기가 작은 타입 선언 -> struct
//		크기가 큰 타입을 stack에 선언하면 stack overflow 나기 쉬움!!
//		예시) point, date
// 크기가 크고 라이브러리도 많이 쓰는 무거운 타입 선언 -> class
//		예시) People(이름, 나이, 등등)

class CPoint
{
	private int x;
	private int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	private int x;
	private int y;
	public SPoint(int a, int b) { x = a; y = b;}	
}
class Program 
{
	public static void Main()
	{
		// 객체를 생성하는 코드는 완전히 동일하지만,
		// 메모리 구조는 다르다!!
		CPoint cp = new CPoint(0, 0);
		SPoint sp = new SPoint(0, 0);	
	}
}
