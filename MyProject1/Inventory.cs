using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1
{
    internal class Inventory
    {
        Shop shop;
        UserInfo userInfo;

        public Inventory()
        {

        }

        public Inventory(Shop shop, UserInfo userInfo)
        {
            //생성자에서 shop, userInfo 객체 받아서 할당
            this.shop = shop;
            this.userInfo = userInfo;
        }


        //인벤토리 출력
        public void PrintUserInventory()
        {
            List<Item> itemList = shop.GetItemList(); //Shop에서 아이템 목록 가져오기

            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");

            foreach (var item in itemList)
            {
                string itemName = item.ItemName.PadRight(10);
                string itemType = (item.ItemType + " " + $"+{item.ItemStats}").PadRight(3);
                string itemDescription = item.ItemDescription.PadRight(30);
                bool hasItem = item.HasItem;
                bool isUsing = item.IsUsing;

                if (hasItem == true)
                {
                    if (isUsing == true)
                    {
                        Console.WriteLine($"- [E]{itemName} | {itemType} | {itemDescription}");
                    }
                    else
                    {
                        Console.WriteLine($"- {itemName} | {itemType} | {itemDescription}");
                    }
                }

            }

            Console.WriteLine();
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해 주세요. \n>> ");

        }

        //장착 관리 출력
        public void PrintToggleEquipItem()
        {
            List<Item> itemList = shop.GetItemList(); //Shop에서 아이템 목록 가져오기

            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");

            foreach (var item in itemList)
            {
                int itemIndex = item.ItemIndex;
                string itemName = item.ItemName.PadRight(10);
                string itemType = (item.ItemType + " " + $"+{item.ItemStats}").PadRight(3);
                string itemDescription = item.ItemDescription.PadRight(30);
                bool hasItem = item.HasItem;
                bool isUsing = item.IsUsing;

                if (hasItem == true)
                {
                    if (isUsing == true)
                    {
                        Console.WriteLine($"- {itemIndex}. [E]{itemName} | {itemType} | {itemDescription}");
                    }
                    else
                    {
                        Console.WriteLine($"- {itemIndex}. {itemName} | {itemType} | {itemDescription}");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해 주세요. \n>> ");
        }

        //장착 관리
        public void ToggleEquipItem(int _userActionInput)
        {
            List<Item> itemList = shop.GetItemList(); //Shop에서 아이템 목록 가져오기

            int itemIndex;
            string itemType;
            int itemStats;
            bool hasItem;
            bool isUsing;

            int itemListCount = 0;

            foreach(var item in itemList)
            {
                hasItem = item.HasItem;
                if(hasItem == true)
                {
                    itemListCount++;
                }
            }

            while (_userActionInput < 0 || _userActionInput > itemListCount)
            {
                Console.Write("잘못된 입력입니다. 다시 입력해 주세요. \n>> ");
                _userActionInput = int.Parse(Console.ReadLine());
            }

            foreach (var item in itemList)
            {
                itemIndex = item.ItemIndex;
                itemType = item.ItemType;
                itemStats = item.ItemStats;
                isUsing = item.IsUsing;

                if(_userActionInput == itemIndex)
                {
                    if(isUsing == true)
                    {
                        item.IsUsing = false;

                        if (itemType == "공격력")
                        {
                            userInfo.AttackPower -= itemStats;
                            userInfo.BonusStatsAP -= itemStats;
                        }
                        else if (itemType == "방어력")
                        {
                            userInfo.DefensePower -= itemStats;
                            userInfo.BonusStatsDP -= itemStats;
                        }
                    }
                    else
                    {
                        item.IsUsing = true;

                        if(itemType == "공격력")
                        {
                            userInfo.AttackPower += itemStats;
                            userInfo.BonusStatsAP += itemStats;
                        }
                        else if(itemType == "방어력")
                        {
                            userInfo.DefensePower += itemStats;
                            userInfo.BonusStatsDP += itemStats;
                        }
                    }
                }
            }
        }
    }
}
