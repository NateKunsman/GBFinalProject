using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    //CRUD
    //Create
    //Read (Not needed for this challenge)
    //Update
    //Delete
    class MenuRepository
    {
        private readonly List<Menu> _menuDirectory = new List<Menu>();
        //Create
        public bool CreatNewMenuItem(Menu menu)
        {
            int startingCount = _menuDirectory.Count;
            _menuDirectory.Add(menu);
            bool wasCreated = (_menuDirectory.Count > startingCount) ? true : false;
            return wasCreated;
        }
        //Read
        public List<Menu> ShowMenuItems()
        {
            return _menuDirectory;
        }
        //Delete
        public bool DeleteMenuItem(Menu existingMenu)
        {
            bool result = _menuDirectory.Remove(existingMenu);
            return result;
        }
    }
}
