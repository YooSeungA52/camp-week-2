using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1
{
    internal class UserInfo
    {
        private int level;          //레벨
        private string name;        //이름
        private string job;         //직업
        private int attackPower;    //공격력
        private int defensePower;   //방어력
        private int healthPoints;   //체력
        private int goldAmount;     //소지골드
        private int bonusStatsAP;   //장비로 올라간 공격력 추가 스탯
        private int bonusStatsDP;   //장비로 올라간 방어력 추가 스탯

        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Job
        {
            get { return job; }
            set { job = value; }
        }

        public int AttackPower
        {
            get { return attackPower; }
            set { attackPower = value; }
        }

        public int DefensePower
        {
            get { return defensePower; }
            set { defensePower = value; }
        }

        public int HealthPoints
        {
            get { return healthPoints; }
            set { healthPoints = value; }
        }

        public int GoldAmount
        {
            get { return goldAmount; }
            set { goldAmount = value; }
        }

        public int BonusStatsAP
        {
            get { return bonusStatsAP; }
            set { bonusStatsAP = value; }
        }
        public int BonusStatsDP
        {
            get { return bonusStatsDP; }
            set { bonusStatsDP = value; }
        }

        public UserInfo(string _userName)
        {
            level = 1;
            name = _userName;
            job = "전사";
            attackPower = 10;
            defensePower = 5;
            healthPoints = 100;
            goldAmount = 1500;
        }

        public void PrintUserInfo()
        {
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine();
            Console.WriteLine("Lv. " + level);
            Console.WriteLine($"{name} ( {job} )");

            if(bonusStatsAP == 0)
            {
                Console.WriteLine("공격력 : " + attackPower);
            } else
            {
                Console.WriteLine($"공격력 : {attackPower} (+{bonusStatsAP})");
            }

            if(bonusStatsDP == 0)
            {
                Console.WriteLine("방어력 : " + defensePower);
            }
            else
            {
                Console.WriteLine($"방어력 : {defensePower} (+{bonusStatsDP})");
            }

            Console.WriteLine("체　력 : " + healthPoints);
            Console.WriteLine("Gold : " + goldAmount + " G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해 주세요. \n>> ");
        }
    }
}
