namespace C__textbook_Unit_2
{
    internal class Program
    {
        /*
            변수 : 데이터를 메모리에 잠시 보관해 놓고 사용할 수 있는 임시 저장 공간이 필요
            변수 선언 : 데이터 형식 변수 이름 문장의 끝
                        int      number    ;
            데이터 형식      설명
            int             정수형 데이터 더 큰 정수는 long사용
            srting          문자열 데이터
            bool            논리형 데이터
            double          실수형 데이터
            object          C#에서 사용하는 모든 데이터
            
            변수 명명법
            1. 변수의 첫 글자는 문자로 지정, 숫자로 시작X
            2. 공백 포함x 255자 이하
            3. 영어 한글 한자 사용가능 _ 사용가능 기타 특수기호X
            4. 변수는 대소문자 구분, 일반적으로 소문자 사용

            리터럴 : 변수에 저장하는 값, 값 자체를 가지지 않는 널(null)도 있음

            상수 : 변수를 선언할 때 앞에 const 키워드를 붙이면 변수는 상수가 됨
                  한 번 상수로 선언된 변수는 값 변환X , 반드시 선언과 동시에 초기화
            
            Console.ReadLine() : 콘솔에서 한 줄을 입력받습니다. enter키 누를 때까지 대기
            Console.Read() : 콘솔에서 한 문자를 정수로 입력받습니다.
            Console.ReadKey() : 콘솔에서 다음 문자나 사용자가 누른 기능 키를 가져옵니다.

            암시적 형 변환 : 작은 형식에서 큰 형식에 저장할 때는 데이터가 손실되지 않아 그대로 담을 수 있음
            ex) int number1 = 1234;
                long number2 = number1;

            명시적 형 변환 : 큰 형식에서 작은 형식에 저장할 때는 데이터가 손실될 수 있기 때문에 명시적 형변환을 해야함(캐스팅 이라고도 함)
            ex) long number1 = 1234;
                int number2 = (int)number1;

            
            
            

            메서드                설명
            convert.ToString()   다른 데이터 형식을 문자열로 변환
            convert.ToInt32()    다른 데이터 형식을 정수형으로 변환    -> int.Parse()메서드로 대체가능
            convert.ToDouble()   다른 데이터 형식을 실수형으로 변환    -> double.Parse() 메서드로 대체가능
            convert.ToChar()     다른 데이터 형식을 문자형으로 변환

            int.TryParse(), double.TryParse() 같은 메서드로 더 안전하게 데이터 변환가능

            GetType() 메서드로 데이터 형식 확인
            
            이진수 다루기
            Convert.ToString(숫자,2).PadLeft(8,'0');
                                       -> PadLeft()메서드를 이용해서 8칸 기준으로 앞부분은 0으로 채움
            이진수 리터널 : 0b 0B 접두사 붙이기
            ex) byte b1 = 0b0010;
                byte b2 = 0B1100;

            var 키워드 : var로 선언된 변수는 저장으로 형식추론해서 변환 (형식 추론이라함), 선언과 동시에 초기화   

            문자열 연결 연산자 : + 로 문자열 끼리 연결
            ex) 123 + "123" -> 123123
                123 + 123 -> 산술연산자로 돼서 246
                "123" - 456 -> X 문자열 연산자는 오직 + 만 가능

            sizeof 연산자 : 단항 연산자로 데이터 형식 자체의 크기를 구함
            ex) sizeof(int)

            연산자 우선순위
            
            항목        연산자             우선순위(높음)
            괄호연산자   ()
            증감연산자   ++ --
            산술연산자   -(음수)
                       *,/
                       %
                       +,-
            연결연산자   +
            관계연산자   ==,!=,<,>,<=,>=
            논리연산자   !(NOT)
                       &&(AND)
                       ||(OR)

            제어문 : 프로그램 실행 순서를 제어하거나 프로그램 내용을 반복하는 작업 등을 처리할 때 사용하는 구문으로 조건문과 반복문으로 구분
            
            제어문     설명                                              종류

            순차문     프로그램이 작성된 순서대로 실행되는 구문

            조건문     조건의 참 또는 거짓에 따라 서로 다른 명령문을 실행할 수  if문(조건 하나 비교), else문(조건 분기), switch문(다양한 조건)
            (선택문)   있는 구조
            
            반복문     특정 명령문을 지정된 수만큼 반복해서 실행할 때나 조건식이 for문(구간 반복), do문(선행반복), while문(조건 반복),foreach문(배열 반복)
                      참일 동안 반복시킬때 사용

            기타      break문 : 반복문이나 switch문을 빠져나올 때 사용
                     continue문 : 반복문에서 조건에 따라 특정 명령문을 건너뛰고 다음 반복으로 넘어갈 때 사용
                     goto문 : 프로그램 실행 순서를 임의로 이동시킬 때 사용

            Parse 와 TryParse 메서드 의 차이점
            
            특성        Parse 메서드                 TryParse 메서드
            변환값      변환된 데이터 타입의 값         변환 성공 여부(bool)
            오류 처리   예외 발생                     예외 발생 X
            사용 예      int.Parse("123")           int.TryParse("123", out int result)
            안정성      안정성 낮음                   안정성 높음

            for(초기식;조건식;증감식)
            {
                실행문;
            }

            while(조건식)
            {
                조건식이 참일 때까지 실행할 문장들...
            }

            do
            {
                실행문;
            }while(조건식);
            do while문은 무조건 한 번은 실행문이 실행

            foreach(데이터형식 변수 in 컬렉션형식)
            {
                문장; // 변수에 들어 있는 값을 사용하는 문장이 온다.
            }

            goto문 
            레이블:
            goto 레이블;

            이름 하나로 데이터 여러 개를 담을 수 있는 그릇을 컬렉션이라고 함. 배열(array), 리스트(list), 사전(dictionary)등이 있음.

            배열 ex)
            var array = new string[] { "Array", "List", "Dictionary" };
            foreach(var arr in array) { Console.WriteLine(arr); }

            리스트 ex)
            var list = new List<string> { "Array", "List", "Dictionary" };
            foreach(var item in list) { Console.WriteLine(item); }

            사전 ex)
            var dictionary = new Dictionary<int,string>{ { 0,"Array" } , { 1,"List" } , { 2,"Dictionary" } };
            foreach(var pair in dictionary)
            {
                Console.WriteLine($"{pair.key} - {pair.value}");
            }
            
            배열 : 이름 하나로 데이터 여러 개를 저장하는 데이터 구조
            ●배열은 요소들의 순서 있는 집합, 각 요소는 인덱스로 접근할 수 있으며, 인덱스는 0부터 시작.
            ●배열 하나에는 데이터 형식 하나만 보관할 수 있음
            

            
            
                









            

            















         */
        static void Main(string[] args)
        {
            //const int Max = 100;
            //Console.WriteLine(Max);

            //Console.Write("이름을 입력하세요 : ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"안녕하세요. 당신의 이름은 {name} 입니다.");

            //long l = long.MaxValue;
            //Console.WriteLine($"l의 값 : {l}");
            //int i = (int)l;     -> int 형식 변수의 크기를 벗어나면 잘못된 데이터가 저장될 수 있음
            //Console.WriteLine($"i의 값 : {i}");

            //double d = 12.34;
            //int i = 1234;

            //d = i;  //  큰 그릇에 작은 그릇의 값을 저장
            //Console.WriteLine("암시적 형식 변환 = " + d);

            //d = 12.34;
            //i = (int)d; //  () 사용: 정수형 데이터만 저장됨
            //Console.WriteLine("명시적 형식변환 = " + i);

            //string s = "";
            //s = Convert.ToString(d);
            //Console.WriteLine("형식 변환 = " + s);

            //int i = 1234;
            //string s = "안녕하세요";
            //char c = 'A';
            //double d = 3.14;
            //object o = new object();    //  개체 : 개체를 생성하는 구문

            //Console.WriteLine(i.GetType());
            //Console.WriteLine(s.GetType());
            //Console.WriteLine(c.GetType());
            //Console.WriteLine(d.GetType());
            //Console.WriteLine(o.GetType());

            //Console.Write("정수를 입력하세요 : ");
            //string input = Console.ReadLine();
            //int number = Convert.ToInt32(input);
            //Console.WriteLine($"{number} : {number.GetType()}");

            //byte x = 10;

            //Console.WriteLine($"십진수 : {x} = 이진수 : {Convert.ToString(x,2).PadLeft(8,'0')}");
            //Console.WriteLine(Convert.ToInt32("1010",8));

            //Console.WriteLine("아무키나 누르세요 : ");
            //ConsoleKeyInfo cki = Console.ReadKey(true); //true 쓰면 누른 키 문자를 콘솔에 표시하지 말라는 뜻
            //Console.WriteLine("키 : {0}",cki.Key);
            //Console.WriteLine("문자 : {0}", cki.KeyChar);
            //Console.WriteLine("보조키 : {0}", cki.Modifiers);
            //Console.WriteLine();

            //if (int.TryParse("안녕", out int result))
            //{
            //    Console.WriteLine(result);  //  변환 실패시 반환값은 false이므로 result는 0으로 초기화됨
            //}

            //if (int.TryParse("1234", out int result2))
            //{
            //    Console.WriteLine(result2);  //  변환 성공시 반환값은 true이므로 result2는 1234로 초기화됨
            //}

            // Console.Write("첫 번째 숫자 입력 : ");
            //int.TryParse(Console.ReadLine(), out int num1);

            //Console.Write("두 번째 숫자 입력 : ");
            //int.TryParse(Console.ReadLine(), out int num2);

            //if (num1 > num2) Console.WriteLine($"{num1} 은 더 큰수");
            //else Console.WriteLine($"{num2} 은 더 큰수");

            //Console.Write("대문자 혹은 소문자 입력 : ");
            //char.TryParse(Console.ReadLine(), out var result);

            //if ('A' <= result && result <= 'Z')
            //    Console.WriteLine($"{result}는 대문자 입니다.");
            //else if ('a' <= result && result <= 'z') Console.WriteLine($"{result}는 소문자 입니다.");
            //else Console.WriteLine("영어문자가 아닙니다.");

            //Console.Write("점수 : ");
            //int.TryParse(Console.ReadLine(), out int score);

            //switch (score)
            //{
            //    case > 100:
            //        Console.WriteLine("잘못된 점수");
            //        break;
            //    case >= 90 and <= 100:
            //        Console.WriteLine("A등급");
            //        break;
            //    case >= 80 and < 90:
            //        Console.WriteLine("B등급");
            //        break;
            //    case >= 70 and < 80:
            //        Console.WriteLine("C등급");
            //        break;
            //    default:
            //        Console.WriteLine("낙오");
            //        break;

            //Console.Write("숫자 입력 : ");
            //bool isNumber = double.TryParse(Console.ReadLine(), out double number); //숫자가 아니면 false반환   

            //if (!isNumber) Console.WriteLine("숫자가 아닙니다.");
            //else if (number > 0) Console.WriteLine("양수");
            //else if (number == 0) Console.WriteLine("0");
            //else Console.WriteLine("음수");

            //Console.Write("점수를 입력하세요 : ");
            //bool isScore = int.TryParse(Console.ReadLine(), out int score);
            //bool trueScore = (0 <= score && score <= 100);

            //if (!isScore) Console.WriteLine("숫자(정수)가 아닙니다.");   // isScore이 숫자형식이 아니면 바로 종료
            //else if (!trueScore) Console.WriteLine("0~100 점 사이가 아닙니다.");  // 0~100점 사이인지 확인
            //else  //  둘다 확인 했으니 이제 점수와 등급 확인
            //{
            //    string grade = "";
            //    switch (score)
            //    {
            //        case >= 90:
            //            grade = "A";
            //            break;
            //        case >= 80:
            //            grade = "B";
            //            break;
            //        case >= 70:
            //            grade = "C";
            //            break;
            //        case >= 60:
            //            grade = "D";
            //            break;
            //        default:
            //            grade = "F";
            //            break;
            //    }
            //    Console.WriteLine($"당신의 점수는 {score}점이고 학점은 {grade}등급 입니다.");
            //}

            //string data1 = "1234";
            //string data2 = "abcd";

            //if (int.TryParse(data1, out var result1))
            //{
            //    Console.WriteLine($"{result1} : {result1.GetType()}타입 ");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}

            //if (int.TryParse(data2, out var result2))
            //{
            //    Console.WriteLine($"{result2} : {result2.GetType()}타입 ");
            //}
            //else
            //{
            //    Console.WriteLine("거짓");
            //}

            //Console.Write("1~5번 보기 중에 정답을 고르시오 : ");
            //bool isTrue = int.TryParse(Console.ReadLine(), out var answer);

            //if (!isTrue) Console.WriteLine("잘못된 입력입니다.");
            //else if (!(1 <= answer && answer <= 5)) Console.WriteLine("잘못된 보기 선택입니다.");
            //else Console.WriteLine($"{answer}번 으로 선택하셨군요.");

            //Console.Write("몇 팩토리얼을 구하고 싶으신가요 > : ");
            //bool isNumber = int.TryParse(Console.ReadLine(), out var result);

            //if (!isNumber) Console.WriteLine("잘못된 형식으로 입력하셨습니다.");
            //else if (result <= 0) Console.WriteLine("0초과의 자연수를 입력해주세요.");
            //else
            //{
            //    int factorial = 1;
            //    for (int i = 1; i <= result; i++)
            //    {
            //        factorial *= i;
            //        Console.WriteLine($"{i}! = {factorial}");
            //    }
            //}

            //Console.Write(" 몇 단을 출력하고 싶으신가요 > : ");
            //bool isNumber = int.TryParse(Console.ReadLine(), out var dan);

            //if (!isNumber) Console.WriteLine("잘못된 형식 출력");
            //else if (dan <= 0) Console.WriteLine(" 자연수를 선택 해주세요.");
            //else
            //{
            //    for (int i = 1; i <= 9; i++)
            //    {
            //        Console.WriteLine($"{dan}*{i}={dan * i}");
            //    }
            //}

            //for (int i = 2; i <= 9; i++)
            //{
            //    Console.Write($"{i}단\t");
            //}
            //Console.WriteLine();
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 2; j <= 9; j++)
            //    {
            //        Console.Write($"{j}*{i}={i * j}\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(" 몇 번 반복할까요? :");
            //int.TryParse(Console.ReadLine(), out var result);
            //int count = 1;
            //while (count <= result)
            //{
            //    Console.WriteLine($"{count}번째 입니다.");
            //    count++;
            //}

            //Console.WriteLine("몇 번째 피보나치 수열을 원하나요 > : ");
            //bool isNumber = int.TryParse(Console.ReadLine(), out var Fibonacci);

            //if (!isNumber) Console.WriteLine("잘못된 입력형식 입니다.");
            //else if (Fibonacci <= 0) Console.WriteLine("자연수 형식을 입력해주세요.");
            //else
            //{
            //    int first = 0;
            //    int second = 1;
            //    int n = 1;
            //    while (n <= Fibonacci)
            //    {
            //        Console.WriteLine(second);
            //        int temp = first + second;
            //        first = second;
            //        second = temp;
            //        n++;
            //    }
            //}

            //Console.WriteLine("문자열에서 문자 하나씩 뽑아 출력");
            //string str = "123ABC";

            //foreach (var c in str)
            //{
            //    Console.WriteLine(c);
            //}









        }



    }
}

