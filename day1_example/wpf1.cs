
// 핵심: 콘솔 프로젝트에서 WPF 사용법 알기 

// C# 언어의 장점
// => 강력한 문법 + 풍부한 라이브러리

// WPF(Windows Presentation Framework)
//      GUI 용 라이브러리
//      Direct-X 엔진을 사용한 강력하고 유연한 GUI 작성 가능

// < WPF 사용 방법 >
// 1. 프로젝트의 종류를 "WPF 응용프로그램"으로 선택해야함
//      하지만, 자동 생성되는 파일/코드가 너무 복잡함
//      입문자에게는 권하지 않음
//      실전 프로젝트에서 사용

// 2. 프로젝트 종류는 "콘솔 응용프로그램"으로 선택하고 프로젝트 설정 파일 2곳만 수정
//      프로젝트 이름을 클릭하면 나오는 xml 설정 파일 수정
//      학습 시에 적합

// System.windows.MessageBox 클래스를 사용하면 MessageBox를 나타낼 수 있음
using System.Windows;
MessageBox.Show("Hello", "caption");

