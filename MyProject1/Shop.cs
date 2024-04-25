using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1
{
    internal class Shop
    {

        List<Item> itemList = new List<Item>();

        UserInfo userInfo;

        public Shop(UserInfo userInfo)
        {
            //생성자에서 userInfo 객체 받아서 할당
            this.userInfo = userInfo;
        }

        public void AddItems()
        {
            // 아이템 추가
            itemList.Add(new Item(1, "수련자 갑옷", "방어력", 5, "수련에 도움을 주는 갑옷입니다.", 1000, false, false));
            itemList.Add(new Item(2, "무쇠갑옷", "방어력", 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 2000, false, false));
            itemList.Add(new Item(3, "스파르타의 갑옷", "방어력", 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3500, false, false));
            itemList.Add(new Item(4, "낡은 검", "공격력", 2, "쉽게 볼 수 있는 낡은 검 입니다.", 600, false, false));
            itemList.Add(new Item(5, "청동 도끼", "공격력", 5, "어디선가 사용됐던 것 같은 도끼입니다.", 1500, false, false));
            itemList.Add(new Item(6, "스파르타의 창", "공격력", 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 3000, false, false));
        }

        //아이템 목록
        public void PrintShopItemList(int _goldAmount)
        {
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine(_goldAmount + " G");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");

            foreach (var item in itemList)
            {
                string itemName = item.ItemName.PadRight(10);
                string itemType = (item.ItemType + " " + $"+{item.ItemStats}").PadRight(3);
                string itemDescription = item.ItemDescription.PadRight(30);
                string itemPrice = $"{item.ItemPrice} G";
                bool hasItem = item.HasItem;

                if (hasItem == true)
                {
                    itemPrice = "구매완료";
                }

                Console.WriteLine($"- {itemName} | {itemType} | {itemDescription} | {itemPrice}");
            }

            Console.WriteLine();
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해 주세요. \n>> ");

        }

        //아이템 구매 리스트
        public void PrintBuyShopItem(int _goldAmount)
        {
            Console.WriteLine("상점 - 아이템 구매");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine(_goldAmount + " G");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");

            foreach (var item in itemList)
            {
                int itemIndex = item.ItemIndex;
                string itemName = item.ItemName.PadRight(10);
                string itemType = (item.ItemType + " " + $"+{item.ItemStats}").PadRight(3);
                string itemDescription = item.ItemDescription.PadRight(30);
                string itemPrice = $"{item.ItemPrice} G";
                bool hasItem = item.HasItem;

                if (hasItem == true)
                {
                    itemPrice = "구매완료";
                }

                Console.WriteLine($"- {itemIndex}. {itemName} | {itemType} | {itemDescription} | {itemPrice}");
            }

            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해 주세요. \n>> ");
        }

        //아이템 구매
        public void BuyShopItem(int _userActionInput, int _userGoldAmount)
        {
            int itemIndex;
            string itemName;
            int itemPrice;
            bool hasItem;

            foreach (var item in itemList)
            {
                itemIndex = item.ItemIndex;
                itemName = item.ItemName;
                itemPrice = item.ItemPrice;
                hasItem = item.HasItem;

                if (_userActionInput == itemIndex)
                {
                    if (_userGoldAmount >= itemPrice && hasItem == false)
                    {
                        userInfo.GoldAmount -= itemPrice;
                        item.HasItem = true;
                        Console.WriteLine($"[{itemName}] 구매를 완료했습니다.");

                        for (int i = 3; i > 0; i--)
                        {
                            Console.WriteLine($"{i}초 뒤 마을로 이동합니다.");
                            Thread.Sleep(1000);
                        }
                    }

                    //[오류] 다시 입력받은 후 입력했던 값 또 입력 시 마을로 되돌아감.
                    //else if를 거친 후 구매를 완료하여도 적용 안 됨.
                    else if(hasItem == true)
                    {
                        Console.Write("이미 구매한 아이템입니다. 다시 입력해 주세요. \n>> ");
                        _userActionInput = int.Parse(Console.ReadLine());

                        //같은 값 두 번 입력 시 메소드가 종료됨.
                    }
                    else if(_userGoldAmount < itemPrice)
                    {
                        Console.Write("Gold가 부족합니다. 다시 입력해 주세요. \n>> ");
                        _userActionInput = int.Parse(Console.ReadLine());
                    }
                }
            }

        }

        //아이템 구매 성공
        public void BuySuccessShopItem()
        {

        }

        //아이템 목록 길이
        public int GetItemListCount()
        {
            return itemList.Count;
        }

        //아이템 목록
        public List<Item> GetItemList()
        {
            return itemList;
        }

    }
}
