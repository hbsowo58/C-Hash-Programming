using static System.Console;

// #1. construction
int a = 1, b = 2, c = 3;
var t1 = (a, b, c);


// #2. deconstruction
// 아래 코드는 t1이라는 tuple 의 값을 각각, x, y, z 에 담은것
int x, y, z;
x = t1.Item1;
y = t1.Item2;
z = t1.Item3;
// 위 코드는 아래와 같음
(x, y, z) = t1;


// #3. 아래 2줄의 차이점은 ?
// 1. t2라는 튜플을 만들고, 각 요소의 이름이 a1,a2,a3
(int a1, int a2, int a3) t2 = (1, 2, 3); 
// 2. 왼쪽을 deconstruction해서 앞쪽 변수에 각각 담기
(int b1, int b2, int b3) = (4, 5, 6); 

