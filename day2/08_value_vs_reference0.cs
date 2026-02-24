// 프로그램에서 사용되는 메모리의 종류
// TEXT MEMORY
// DATA MEMORY

// DATA MEM은 아래 3가지로 나눠짐
// static storage : 
// stack : 지역변수
//      크기가 작고(1MB 제한), 수명이 짧음(LIFO), 빠름    -> 크기가 작고, 생성/파괴가 자주 발생하면 적합
// heap  : 객체 
//      크기가 크고(1GB 제한), 수명이 김, 느림           -> 크기가 크고, 한번 만든 후에 오래 사용하면 적합



// stack vs heap 

// C/C++   : 타입사용자가 stack 을 사용할지 heap 을 사용할지 결정
//      개발자에게 메모리 지정 권한까지 부여
//      (new/malloc으로 메모리를 할당할 경우에는 heap)

// C#/Java/Swift : 타입설계자가 stack 을 사용할지 heap 을 사용할지 결정
//      class: heap에 할당
//      struct: stack에 할당