

// 핵심. null 인지 조사하는 방법 

string s = null;
int?   n = null;

// null은 타입이면서 "존재하지 않는 값" 이기도 해서 
// ==
// is
// 모두 사용 가능
if ( s == null ) {}
if ( n == null ) {}

if ( s is null ) {}
if ( n is null ) {}
