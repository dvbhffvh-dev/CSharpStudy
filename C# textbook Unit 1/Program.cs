using System.Buffers;

namespace C__textbook_Unit_1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /* 
                C# 기본 구조 : 네임스페이스 -> 클래스 -> Main() 메서드
                정규화된 이름 : System.Console.WriteLine();
                                ↓       ↓       ↓
                            네임스페이스 클래스    메서드
                Main() 메서드가 2개이면 오류 Main() 메서드는 반드시 1개여야함
                Main() 메서드는 프로그램의 진입점
                svm + tab + tab -> Main() 메서드 단축키
                cw + tab + tab -> Console.WriteLine(); 단축키(메서드 내부에서만 가능)
                WriteLine() 메서드 : 자동 줄 바꿈
                Write() 메서드 : 자동 줄 바꿈 X
                줄 바꿈 기호 : \n
                // : 한 줄 주석
                /* * / : 여러 줄 주석
                자리 표시자 : Console.WriteLine("{0},{1}","Hello","C#"};
            */
            Console.WriteLine("Hello, World!");
            Console.WriteLine("{0},{1}","Hello","C#");
            
        }
       
    }
    
}
