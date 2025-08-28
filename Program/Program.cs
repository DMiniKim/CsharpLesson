using System.Reflection;

namespace Program
{
    internal class Program     
    {        
        static void Main(string[] args)
        {
            #region 단일 책임 원칙
            //// 클래스의 구성 단위는 하나의 책임만 가질 수 있도록
            //// 설계해야 되는 원칙.
            //
            //List<Quest> list = new List<Quest>();
            //
            //list.Add(new Quest("스킬 배우기", "너가 약하니 저기 가서 배워오도록 해라",new Reward(50.0f,300)));         
            //list.Add(new Quest("슬라임 3마리 잡기", "너는 약하니 저기 가서 실력 좀 키워 오거라",new Reward(75.0f, 500)));            
            //list.Add(new Quest("마을 밖으로 나가기", "다 배웠으니 여기서 꺼져", new Reward(100.0f, 1000)));
            //
            //for (int i = 0; i < list.Count; i++)
            //{
            //    list[i].Describe();
            //}
            //
            #endregion

            #region 개방 폐쇄 원칙
            // 소프트웨어의 구성 요소는 확장에는 열려 있어야하고,
            // 변경에는 닫혀 있어야 한다.
            // => 기존의 코드를 변경 하지 않으면서 추가 코드에 문제가 없어야 한다.
            // 버드란드 마이어 ( Bertrand Meyer )
            Enchant enchant = new Enchant();
            enchant.Enhance(new Item("검", 10, 5, 0));
            enchant.Enhance(new Item("목걸이", 1, 1, 10));
            enchant.Enhance(new Item("신발", 0, 20, 0));

            #endregion

        }
    }
}
