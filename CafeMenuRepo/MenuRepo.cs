using System;
using System.Collections.Generic;
using _01_Cafe;

namespace CafeMenuRepo
{
    public class MenuRepo
    {
        private List<Menu> _MenuOrder = new List<Menu>();

        public void AddContentToMenu(Menu content)
        {
            _MenuOrder.Add(content);
        }

        public List<Menu> GetMenuOrder()
        {
            return _MenuOrder;
        }

        public bool RemoveContentFromMenu(Menu content)
        {
            int initialCount = _MenuOrder.Count;
            _MenuOrder.Remove(content);

            if (initialCount > _MenuOrder.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
