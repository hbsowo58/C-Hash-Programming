using static System.Console;

// 핵심. ToString() 메소드: 객체의 상태를 문자열로 반환하는 object의 virtual 메소드 

// ToString() 메소드
//      기본 구현은 "타입 이름" 반환
//      디버깅 등에서 객체의 상태를 문자열로 반환 하는 용도로 사용하는 메소드
//      보통 클래스 만드는 사람이 override 해서 자신의 상태를 반환하도록 변경

class Object
{
	public virtual String ToString()
	{
		// 자신의 타입을 조사해서 문자열로 반환하는 코드 
		// return "내타입의이름"
        //      string, Int32 등


	    // virtual method - 3개
	    //      기본 구현을 사용해도 되지만, 
	    //      클래스 설계자가 다시 만들어도 된다!

	    // non-virtual
	    //      다시 만들지 말고, 제공해주는 기능을 사용해라
	}
}

class Point
{
    private int x = 0;
    private int y = 0;

    public Point(int a, int b) => (x, y) = (a, b);

    // 사용자 재정의 
    //      자신의 상태를 문자열로 만들어서 반환
    public override string ToString()
    {

        string s = $"x={x}, y={y}"; // $ 연산자로 문자열 생성
        return s;
    }
}

class Program
{
    public static void Main()
    {
        Point p = new Point(1, 2);

        // 객체 p의 상태(x, y) 를 화면에 출력해 보고 싶다
        //      이런 용도로 사용하라고 Object 제공하는 메소드가 "ToString()"
        //      객체의 상태를 "문자열"로 반환하는 의미를 가진 메소드

        string s = p.ToString();
        WriteLine(s);
    }
}