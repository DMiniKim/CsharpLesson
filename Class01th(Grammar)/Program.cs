namespace Program
{
    internal class Program      // public 보다 더 높은 느낌의 접근 지정자 internal
    {

        static void Main(string[] args)
        {
            #region 박싱 ( Boxing )
            // 값 형식의 데이터를 참조 형식으로 변환하는 과정.

            //int value = 100;
            //
            //object generic = value;
            //

            //Console.WriteLine("Value : " + value);
            //Console.WriteLine("Generic : " + generic);

            #endregion

            #region 언박싱 ( UnBoxing )
            // 참조 형식의 데이터를 값 형식으로 변환하는 과정.

            //int box = (int)generic;
            //Console.WriteLine("box : " + box);

            #endregion

            #region 매개 변수 한정자
            // 함수의 매개 변수 앞에 해당하는 인자의 전달 방식을 지정하는 키워드
            //Utility utility = new Utility();
            //utility.Pause();
            //int a = 0;
            //int b = 1;
            //utility.Swap(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //
            ////int c = 3;
            //float f = 0.0f;
            //float g = 0.0f;
            //
            //Vector2 direction2 = new Vector2(2, 5);
            //utility.direction = new Vector2(1, 2);
            //
            //utility.Magnitude(utility.direction,out f);
            //Console.WriteLine(f);
            //utility.Magnitude(direction2, out g);
            //Console.WriteLine(g);
            #endregion


        }
    }
}
// Cpp 과 Cs 의 가장 큰 차이를 비유를 통해서 내가 이해한 방식

// SF세계관에서 

// 행성안에서 살던 사람들이 근처 행성을 발견하고 
// 그 행성을 방문하기 위해 항공을 설치함 -> C++ 식 접근 방법

// 사실 행성과 행성은 우리 은하계라는 더 큰 세계관 내에 존재하던
// 신께서 "너희 그냥 이동하기 쉽게 텔포 설치해줄게 ㅎㅎ 무리하지마 " -> C#

// Value Type               Reference Type
// =========================================================
// Stack                    Managed Heap
// 
// char     long            class               array
// bool     float           interface           string
// byte     double          abstract class      object
// short    decimal         delegate            dynamic
// int      struct          
// enum


// 매개 변수 한정자
// ref  =   참조로 전달 ( 읽기 / 쓰기 )
// out  =   참조로 전달 ( 쓰기 )
// in   =   참조로 전달 ( 읽기 )
// params = 가변 인자