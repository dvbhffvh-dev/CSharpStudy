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

            Console.WriteLine("아무키나 누르세요 : ");
            ConsoleKeyInfo cki = Console.ReadKey(true); //true 쓰면 누른 키 문자를 콘솔에 표시하지 말라는 뜻
            Console.WriteLine("키 : {0}",cki.Key);
            Console.WriteLine("문자 : {0}", cki.KeyChar);
            Console.WriteLine("보조키 : {0}", cki.Modifiers);
            Console.WriteLine();



        }
    }
}
