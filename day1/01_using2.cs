
// 현재 파일 뿐만 아니라, 프로젝트 내부의 모든 소스코드에서도 생략 가능
// 대신 이 파일을 빌드에 포함시켜야 함
global using System;
global using static System.Console;

using System; // 현재 파일만 적용됨


// System은 사실 기본적으로 global 처리되어있긴 함
//      => C# 10.0부터 obj/debug/net.10/globalUsing.g.cs 파일 자동 생성
//      여기에 global using System이 존재
//      컴파일 시에 같이 컴파일됨