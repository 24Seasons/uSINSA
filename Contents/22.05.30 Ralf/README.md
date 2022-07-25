# 인터프리터

## **컴파일러**

`C` `C++` `Pascal` `Delphi` `Modula` `COBOL` `Fortran`

특정 프로그래밍 언어로 쓰여있는 문서를 다른 프로그래밍 언어로 옮기는 언어 번역 프로그램

사람이 알아볼 수 있는 언어(고급 언어)를 기계가 이해하기 쉬운 언어(저급언어)로 번역한다고 생각하면 된다.

## **인터프리터**

`Javascript`  `PHP` `Python` `LISP` `Perl`

컴파일러와 비슷하지만 고레벨 언어를 중간 코드로 변환하고 이를 각 행마다 실행한다.

### **JIT 컴파일러**

`C#` `Java`

(Just-in-time)컴파일러와 인터프리터의 결합

오늘 처음봄. 공부가 필요

핵심은 중간언어(고급과 저급의 중간)로 번역한다는것 이로인해 인터프리터에 비해 실행속도가 빠르고 컴파일러에 비해 덜 번거로워지는듯 하다. 가장 큰 장점은 중간언어로 만들기때문에 운영체제에 독립적이라는것. JVM을 상상하면 쉽다.

컴파일러와 인터프리터의 차이

컴파일러는 소스코드를 전부 기계어로 번역하여 실행파일을 따로 만들어서 실행한다. 인터프리터는 소스코드를 한줄씩 읽으면서 그때그때 실행한다. 때문에 컴파일러는 실행속도가 빠르고 실행 전 번역 단계에서 오류를 검증할 수 있다. 또한 인터프리터는 컴파일 단계가 없이 고급 프로그램을 즉시 실행할수 있기때문에 코드를 수정하고 바로바로 확인할 수 있다는 장점이 있다.

## 인터프리터의 구성

### Tokenizer

특수문자(;,*,+,-,=….), 키워드(for,if,break…)등을 기준으로 스크립트를 여러개의 의미있는 토큰으로 자른다.



### Lexer

토큰의 형태를 기반으로 각 토큰에 의미를 부여한다.

Tokenizer와 Lexer 를 합쳐서 Lexical analyze 라고 한다.

### Parser

Lexical analyze 되어있는 데이터를 노드 구조로 배열한다. 대부분의 컴파일러와 인터프리터에서는 AST 자료구조를 사용한다.

### AST 자료구조

추상 구문 트리(Abstract syntax tree) 각 노드들(토큰이 변환된것)이 가지는 자료구조를 의미

![Untitled](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/a4f33826-ba0a-461b-a1b2-4b8a7d5e8d24/Untitled.png)

### Evaluator

Parsing된 자료구조를 바탕으로 실제 코드를 실행한다.

### 예시

**소스코드** : string st = “Hello World”;

**Tokenizer** : string/st/=/”Hello World”/;

**Lexer** : {자료형 : identifier,값 : st}, {자료형: string, 값 : “Hello World”}

**Parser** : identifier st의 자식노드 Value로 {자료형: string, 값 : “Hello World”}를 배치한다

**Evaluator** : 변수 st에 값 “Hello World”를 할당