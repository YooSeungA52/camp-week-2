using System.Security.Cryptography.X509Certificates;

namespace MyProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isGameRunning = true; //게임 실행 상태

            StartGame startGame = new StartGame();
            Village village = new Village();
            Item item = new Item();

            string userName = "UnKnown";

            //유저 이름 받기
            startGame.PrintStart();
            userName = Console.ReadLine(); //최초 유저 이름 받기

            UserInfo userInfo = new UserInfo(userName);
            Shop shop = new Shop(userInfo); //userInfo 객체 전달

            shop.AddItems(); //상점에 아이템 추가

            Inventory inventory = new Inventory(shop, userInfo); //shop 객체 전달

            int userActionInput = 0;  //유저가 선택한 값

            while (isGameRunning)
            {
                Console.Clear();

                //마을에서 행동 고르기
                village.PrintVillage();
                userActionInput = int.Parse(Console.ReadLine());

                //1~3 사이의 값이 아니면 다시 입력 받기
                while (userActionInput < 1 || userActionInput > 3)
                {
                    Console.Write("잘못된 입력입니다. 다시 입력해 주세요. \n>> ");
                    userActionInput = int.Parse(Console.ReadLine());
                }

                Console.Clear();

                switch (userActionInput)
                {
                    case 1: //상태 보기
                        userInfo.PrintUserInfo();
                        userActionInput = int.Parse(Console.ReadLine());

                        while (userActionInput != 0)
                        {
                            Console.Write("잘못된 입력입니다. 다시 입력해 주세요. \n>> ");
                            userActionInput = int.Parse(Console.ReadLine());
                        }
                        break;

                    case 2: //인벤토리
                        inventory.PrintUserInventory();
                        userActionInput = int.Parse(Console.ReadLine());

                        while (userActionInput != 1 && userActionInput != 0)
                        {
                            Console.Write("잘못된 입력입니다. 다시 입력해 주세요. \n>> ");
                            userActionInput = int.Parse(Console.ReadLine());
                        }

                        if (userActionInput == 1)
                        {
                            Console.Clear();
                            inventory.PrintToggleEquipItem();
                            userActionInput = int.Parse(Console.ReadLine());

                            inventory.ToggleEquipItem(userActionInput);
                        }

                        break;

                    case 3: //상점
                        shop.PrintShopItemList(userInfo.GoldAmount);
                        userActionInput = int.Parse(Console.ReadLine());

                        while (userActionInput != 1 && userActionInput != 0)
                        {
                            Console.Write("잘못된 입력입니다. 다시 입력해 주세요. \n>> ");
                            userActionInput = int.Parse(Console.ReadLine());
                        }

                        int itemListCount = shop.GetItemListCount();

                        //아이템 구매
                        if (userActionInput == 1)
                        {
                            Console.Clear();
                            shop.PrintBuyShopItem(userInfo.GoldAmount);
                            userActionInput = int.Parse(Console.ReadLine());

                            while (userActionInput < 0 || userActionInput > itemListCount)
                            {
                                Console.Write("잘못된 입력입니다. 다시 입력해 주세요. \n>> ");
                                userActionInput = int.Parse(Console.ReadLine());
                            }

                            shop.BuyShopItem(userActionInput, userInfo.GoldAmount);

                            //Console.Clear();
                            //shop.PrintShopItemList(userInfo.GoldAmount);
                            //userActionInput = int.Parse(Console.ReadLine());

                        }
                        break;

                    default:
                        Console.Write("잘못된 입력입니다. 다시 입력해 주세요. \n>> ");
                        userActionInput = int.Parse(Console.ReadLine());
                        break;
                }
                //게임 끝내기
                //isGameRunning = false;
            }
        }

    }
}