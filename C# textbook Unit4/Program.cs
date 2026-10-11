namespace C__textbook_Unit4
{
    internal class Program
    {
        /* 
        .NET(닷넷) : C# 프로그램을 개발하고 실행할 수 있게 해주는 개발 플랫폼
        API : 다른 사람이 만들어 놓은 기능을 정해진 방법으로 사용할 수 있게 해주는 규칙과 인터페이스
        .NET API : .NET에서 제공하는 클래스와 메서드 등 프로그래밍 기능을 사용할 수 있게 해주는 인터페이스
        
        클래스(class) : Console 클래스, String 클래스 등 거의 대부분이 클래스
        구조체(struct) : DateTime구조체, TimeSpan 구조체 형태로 표현하며, 클래스와 거의 동일하게 사용
        열거형(enumeration) : Color 열거형 등이 있으며, 특정 목록을 과리할 때 편리함
        네임스페이스(namespace) : System 네임스페이스처럼 많은 양의 클래스와 구조체, 열겨형을 묶어서 관리

        구조체 : 이름 하나로 데이터를 묶어 관리하는 역할을 함. 변수는 이름 하나로 공간을 하나 갖고, 
                배열은 이름 하나로 데이터 형식이 동일한 공간을 여러 개 가짐.
                변수와 배열을 확장하여 이름 하나로 데이터 형식을 1개 또는 여러 개 보관하는 그릇 역할을 하는 것이 구조체
                구조체는 int,string 등 서로 다른 자료를 한 집단으로 정의하여 이름 하나로 지정할 수 있는 여러 항목의 모임
                즉, 구조체 변수란 이름 하나로 데이터 형식 1개 이상을 하나로 보관해 놓는 그릇 역할
                
        구조체 만들기
        struct 구조체이름
        {
            데이터형식 변수1;
            데이터형식 변수2;
            데이터형식 변수3;
        }

        구조체 배열
        명함구조체[] 명함배열 = new 명함구조체[1000];

        내장형 구조체 : 닷넷 프레임워크에 이미 내장된 구조체 중에서 날짜 처리를 전담하는 DateTime과 TimeSpan 구조체,
                      문자 관련 처리를 담당하는 Char 구조체를 자주 사용
        1. DateTime 구조체 : 시간/날짜 관련 모든 정보를 제공
        2. TimeSpan 구조체 : 시간/날짜 간격에 대한 모든 정보를 제공
        3. Char 구조체 : 문자 관련 모든 정보를 제공. 예를 들어 특정 문자가 숫자 형식인지 기호 문자인지 공백 문자인지 등을 판단하는 기능을 제공
        4. Guid 구조체 : 절대로 중복되지 않는 유일한 문자열을 생성




         
         
         
         
         
         
         
         
         */


        /*
         구조체
        // 구조체를 사용하여 하나 이상의 변수 또는 배열을 묶어 관리하기
         struct Point
        {
            public int x;   // public 키워드로 외부에서 int x 변수를 사용하도록 설정
            public int y;
        }

        // 구조체를 사용하여 변수 하나로 여러 개를 묶어 관리
        // 멤버가 3개인 Product 구조체 선언
        struct Product
        {
            public int Id;
            public string Title;
            public decimal Price;
        }   

        // 구조체 배열을 사용하여 데이터 대입 및 출력
        struct BusinessCard // 구조체 선언
        {
            public string Name;
            public int Age;
        }

        static void Print(string name, int age)//출력 전담 함수
            => Console.WriteLine($"{name}은(는) {age}살입니다.");

        // 구조체 매개변수 사용
        struct Member // Member 구조체 선언
        {
            public string Name;
            public int Age;

        }

        static void Print(string name, int age)
            => Console.WriteLine($"{name}은(는) {age}살입니다.");
        static void Print(Member member)
            => Console.WriteLine($"{member.Name}은(는) {member.Age}살입니다.");         

         
         
         
         
         
         
         
         
         
         
         */
        static void Main(string[] args)
        {
            /* 
            // 구조체를 사용하여 하나 이상의 변수 또는 배열을 묶어 관리하기
            Point p;
            p.x = 100;
            p.y = 200;
            Console.WriteLine(p.x);
            Console.WriteLine(p.y);

            // 구조체를 사용하여 변수 하나로 여러 개를 묶어 관리
            Product product;    // 구조체 형식 변수 선언

            product.Id = 1; // 구조체 변수의 각 멤버에 값을 할당
            product.Title = "좋은 책";
            product.Price = 10000M;

            string message =
                $"번호 : {product.Id}\n상품명 : {product.Title}\n가격 : {product.Price}";
            Console.WriteLine(message);
            
            // 구조체 배열을 사용하여 데이터 대입 및 출력
            BusinessCard biz;   // 구조체 형식 변수 선언
            biz.Name = "백승수";
            biz.Age = 17;
            Print(biz.Name, biz.Age);

            BusinessCard[] names = new BusinessCard[2]; // 구조체 형식 배열 선언 
            names[0].Name = "이세영"; names[0].Age = 102;
            names[1].Name = "권경민"; names[1].Age = 31;
            for (int i = 0; i < names.Length; i++)
                Print(names[i].Name, names[i].Age);

            // 구조체 매개변수 사용
            string name = "백승수";    // 변수 사용
            int age = 21;
            Print(name, age);   // 매개변수를 따로 선언

            Member m;   // 구조체 사용
            m.Name = "이세영"; ;
            m.Age = 100;
            Print(m);   //  구조체 매개변수를 사용하여 전달


            // TimeSpan 구조체 사용
            // 시간 차(D-Day) 구하기 : TimeSpan 구조체
            TimeSpan dday = Convert.ToDateTime("2026-12-25") - DateTime.Now;
            Console.WriteL
            // 지난 시간 구하기
            TimeSpan times = DateTime.Now - Convert.ToDateTime("1999-01-12");
            Console.WriteLine($"내가 지금까지 며칠 살았지 => {(int)times.TotalDays}");
            

             
             
             
             
             
             
             
             
             
             */




        }
    }
}
