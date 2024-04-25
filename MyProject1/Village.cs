using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1
{
    internal class Village
    {
        //마을 출력
        public void PrintVillage()
        {
            Console.WriteLine("Hello, Sparta Village!");
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전, 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해 주세요. \n>> ");
        }

        //마을로 돌아가기
        //public void ReturnToVillage(int _villageActionInput)
        //{
        //    if (_villageActionInput == 0)
        //    {
        //        Console.Clear();
        //        PrintVillage();
        //        _villageActionInput = int.Parse(Console.ReadLine());

        //    }
        //}
    }
}
