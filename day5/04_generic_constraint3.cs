class List<T> where T : struct    // T 는 value type 이어야 한다.
{	
}

class Program 
{
	public static void Main()
	{
		List<int>    c1 = new List<int>();		// ok
		List<string> c2 = new List<string>();	// error

		Nullable<int> n = null;
	}	
}



/*
class C1<T> where T : struct           {} // value 타입만 된다
class C2<T> where T : class            {} // reference 타입만 된다
class C3<T> where T : class?           {} // null 가능하다
class C4<T> where T : notnull          {} // null 불가능 타입
class C5<T> where T : unmanaged        {}

class C6<T> where T : new()        // 디폴트 생성자(인자없는 생성자)가 있어야 된다
{
	public void Foo()
	{
		T a = new T(); // 제약이 없으면 안됨
	}

}


// class C7<T> where T : base_class_name  {} // 해당 클래스를 상속받아야한다
// class C8<T> where T : base_class_name? {}
// class C9<T> where T : interface_name   {} // 해당 인터페이스를 상속받아야한다
// class C10<T> where T : interface_name?  {}


class C11<T> where T : class, IComparable<T>  // 여러개도 가능
{ 
}

// 각 타입에 대해 나눠서도 가능
class C12<T, U> where T : struct  
			    where U : class
{ 
}
*/