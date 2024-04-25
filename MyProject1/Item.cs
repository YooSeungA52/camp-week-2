using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1
{
    internal class Item
    {
        private int itemIndex;
        private string itemName;
        private string itemType;
        private int itemStats;
        private string itemDescription;
        private int itemPrice;
        private bool hasItem;
        private bool isUsing;

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
