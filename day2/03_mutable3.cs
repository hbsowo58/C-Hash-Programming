

// 핵심. 객체는 참조변수지만, new로 생성하면 각자 고유의 메모리가 할당됨!! 이는 string에도 마찬가지로 적용된다. 

// heap의 string intern pool : string 객체 중 문자열 리터럴 그 자체가 존재 
string s1 = "AAA";      // String("AAA")의 주소 참조
string s2 = "AAA";      // 동일한 주소 참조 

// new로 생성하면 string intern pool에 저장하지 않고, 독립적인 인스턴스 메모리 할당
//      권장하진 않음 (메모리 낭비)
string s3 = new string("AAA");
string s4 = new string("AAA");


//immutable의 장점
// 1. 동일 데이타를 공유해서 메모리 절약
// 2. 여러개의 cpu가 동시접근해도 문제 없는, 즉 멀티코어에 최적화됨
// 3. 컴파일러가 다양한 방법으로 최적화 가능
// => stringbuilder는 성능이 나쁘고 동시 접근시 동기화 필요 


// 같은 메모리 주소를 공유하는지 확인하는 방법
Console.WriteLine($"{object.ReferenceEquals(s1, s2)}");  // true
Console.WriteLine($"{object.ReferenceEquals(s3, s4)}");  // false

// == 연산자는, 메모리랑 상관 없이, 같은 문자열인지만 확인
Console.WriteLine($"{s1==s3}");  // true


// 프로그래밍 철학: immutable한게 최고다 

// Rust: 모든 변수는 기본적으로 immutable
// let n = 10;
// n = 20 
// let mut n = 10; // 변경은 키워드 선언 필요