namespace C__textbook_Unit_3
{
    internal class Program
    {
        /* 
         함수 정의는 함수를 만드는 작업

         기본적인 형태
         static void 함수이름()
        {
            함수내용
        }

        함수를 호출하는 형태
        1.함수이름();
        2.함수이름(매개변수);
        3.결과값 = 함수이름(매개변수);

        Main() 메서드 앞 또는 뒤에 위치해도 상관없음.
        Main()메서드 우선 실행

        ●매개변수(인자,파라미터)가 없는 함수 : 매개변수도 없고 반환값도 없는 함수 형태는 가장 단순한 형태의 함수. 
                                           함수 이름 뒤에 따라오는 괄호에 인자로 아무 값도 지정하지 않는 형태를 의미
                                           앞에서 사용한 함수 중에서 모든 변수에 있는 값을 문자열로 변환시키는 ToString()메서드 처럼 빈 괄호만 있는 함수 형식을 나타냄

        ●매개변수가 있는 함수 : 특정 함수에 인자 값을 1개 이상 전달하는 방식
                              정수형,실수형,문자형,문자열형,개체형 등 여러가지 데이터 형식을 인자 값으로 전달가능

        ●반환값이 있는 함수 : 함수의 처리 결과를 함수를 호출한 쪽으로 반환할때는 return 키워드를 사용하여 데이터를 돌려줌
        (결과값이 있는 함수)

        ●매개변수가 가변(여러개)인 함수 : 클래스 하나에 매개변수의 형식과 개수를 달리하여 이름이 동일한 함수를 여러개 만들 수 있음
                                       이를 가리켜 함수 중복 또는 함수 오버로드 라고 함

        함수 선언 형식과 관련 용어 정리
        ●Main() 메서드 선언 형식 : 메서드를 만들 때 사용하는 public, static, void 는 다른 값으로 변경되어 서로 다른 형태로 보일 수 있는데,
                                 이를 메서드 시그니처 라고 합니다.

        ●public : 메서드의 액세스 한정자를 나타냄. public이면 현재 메서드를 모든 클래스에서 사용가능하고,
                   private이면 현재 클래스에서만 사용 가능한 메서드를 만들 수 있음.

        ●static : static키워드가 붙느냐(정적인 메서드) 붙지 않느냐(인스턴스 메서드)에 따라 그 의미가 다름.
                   
        구분	                static 메서드	    일반 메서드
        소속	                클래스 자체	        만들어진 객체 하나하나
        객체생성	            필요 없음	            필요함
        호출	                클래스명.메서드()	    객체명.메서드()
        인스턴스 변수 접근	    직접 접근 불가	    접근 가능

        ●void : 메서드의 반환 형식이 오는 자리이며, void 키워드는 반환값x

        ●Main : 메서드 이름을 나타내며 영문 대문자로 시작

        ●stringp[] args : 매개변수 영역으로, 메서드에 어떤 값을 넘겨줄 때 또는 넘겨받을 때 이를 잠시 보관해 놓는 그릇 역할을 하는 매개체가 되는 변수(배열)을 나타냄.
                           
        XML 문서 주석 : /// <summary> ~ /// <summary> 형태로 슬래시 기호 3개을 연속해서 주석 영역에 작성.

        메서드를 선언할 때 매개변수를 선언과 동시에 초기화해 놓으면, 메서드를 호출할 때 매개변수를 지정하지 않아도 기본값으로 자동 설정
        이 기능을 기본 매개변수 또는 선택적 인수 라고함



        










         */

        /* 
         * ●함수 생성
         * static void Show()
         * {
         *  Console.WriteLine("Show 함수");
         *  => 매개변수 x 반환값 x
         *  }
         * 
         * 
            static void ShowMessage(string message)
            {
                Console.WriteLine(message);
            }

            static string GetString()
            {
                return "반환값(Return Value)";
            }

            static double SumNumber(double x, double y)
            {
                return x + y;
            }

            static double Abs(double x)
            {
                return x >= 0 ? x : -x;
            }

            /// <summary>
            /// 두 수를 더하여 그 결과값을 반환시켜 주는 함수
            /// </summary>
            /// <param name="a">첫 번째 매개변수</param>
            /// <param name="b">두 번째 매개변수</param>
            /// <returns>a + b  결과</returns>
            static int AddNum(int a, int b)
            {
                return a + b;
            }

            static void Log(string message, byte level = 1)
            {
                Console.WriteLine($"{message} , {level}");
            }           
            
            
         

         *  
         
         */

        static void Main(string[] args)
        {
            /* 
                Show();     => Show함수 호춞
             
                ShowMessage("매개변수");
                ShowMessage("Parameter");
             
                string returnValue = GetString();
                Console.WriteLine(returnValue);

                Console.WriteLine("입력한 두 수의 합을 구하겠습니다.");
                Console.Write("첫 번째 수 를 입력해주세요.");
                double num1, num2;
                while(!double.TryParse(Console.ReadLine(),out num1))
                {
                    Console.WriteLine("숫자 형식이 아닙니다. 다시 입력해주세요.");
                }
                Console.Write("두 번째 수를 엽력해주세요.");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("숫자 형식이 아닙니다. 다시 입력해주세요.");
                }
                Console.WriteLine($"두 수의 합은 {SumNumber(num1, num2)} 입니다");

                double num1;
                Console.Write("절댓값 구할 한 숫자 입력 : ");
                while(!double.TryParse(Console.ReadLine(),out num1))
                {
                    Console.Write("숫자 형식 x 다시 입력 : ");
                }
                Console.WriteLine($"입력한 수의 절댓값은 {Abs(num1)} 입니다.");

            
                Log("디버그");
                Log("레벨", 4);


                

                
                
             */
        }
    }
}
