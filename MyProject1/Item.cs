using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1
{
    internal class Item
    {
        private int itemIndex;          //아이템 번호
        private string itemName;        //아이템 이름
        private string itemType;        //아이템 종류
        private int itemStats;          //아이템 스탯
        private string itemDescription; //아이템 설명
        private int itemPrice;          //아이템 가격
        private bool hasItem;           //아이템 보유 상태
        private bool isUsing;           //아이템 장착 상태

        public int ItemIndex
        {
            get { return itemIndex; }
            set { itemIndex = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }

        public int ItemStats
        {
            get { return itemStats; }
            set { itemStats = value; }
        }

        public string ItemDescription
        {
            get { return itemDescription; }
            set { itemDescription = value; }
        }

        public int ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }

        public bool HasItem
        {
            get { return hasItem; }
            set { hasItem = value; }
        }

        public bool IsUsing
        {
            get { return isUsing; }
            set { isUsing = value; }
        }

        public Item()
        {

        }
        public Item(int _itemIndex, string _itemName, string _itemType, int _itemStats, string _itemDescription, int _itemPrice, bool _hasItem, bool _isUsing)
        {
            itemIndex = _itemIndex;
            itemName = _itemName;
            itemType = _itemType;
            itemStats = _itemStats;
            itemDescription = _itemDescription;
            itemPrice = _itemPrice;
            hasItem = _hasItem;
            isUsing = _isUsing;
        }

        List<Item> itemList = new List<Item>();

        public void AddItem(int _itemIndex, string _itemName, string _itemType, int _itemStats, string _itemDescription, int _itemPrice, bool _hasItem, bool _isUsing)
        {
            itemList.Add(new Item(_itemIndex, _itemName, _itemType, _itemStats, _itemDescription, _itemPrice, _hasItem, _isUsing));
        }

    }
}
