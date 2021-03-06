﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Inventory.Common.Models;

namespace OpenQbit.Inventory.BLL.BusinessService.Contr
{
    public interface IItemManager
    {
        bool RecordItem(Item item);

        bool UpdateItem(Item item);

        bool DeleteItem(Item item);

        Item FindItemByID(int id);

        List<Item> GetAllItems();
    }
}
