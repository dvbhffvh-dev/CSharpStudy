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

            메서드                설명
            convert.ToString()   다른 데이터 형식을 문자열로 변환
            convert.ToInt32()    다른 데이터 형식을 정수형으로 변환
            convert.ToDouble()   다른 데이터 형식을 실수형으로 변환
            convert.ToChar()     다른 데이터 형식을 문자형으로 변환

         
         */
        static void Main(string[] args)
        {
            const int Max = 100;
            Console.WriteLine(Max);
        }
    }
}
