////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;

namespace BootstrapAspDynamicRender.service
{
    public abstract class absCoreNav : ahsNestedTools
    {
        private void FindAllNavigationItems(ref List<bsNavItem> navItems, Predicate<bsNavItem> FindPredicateUnit = null)
        {
            foreach (bsNavItem nav_item in Childs.Where(x => !(x is null)))
            {
                if (FindPredicateUnit is null || FindPredicateUnit(nav_item))
                    navItems.Add(nav_item);

                nav_item.FindAllNavigationItems(ref navItems, FindPredicateUnit);
            }
        }

        /// <summary>
        /// Найти все элементы меню, которые соответствуют предикату
        /// 
        /// bool FindPredicateUnit(NavItemModel navItem) { return navItem.ID.ToLower() == activate_nav_by_id; };
        /// FindNavigationItems(FindPredicateUnit).ForEach(x => x);
        /// </summary>
        /// <param name="FindPredicateUnit"></param>
        /// <returns>Все элементы меню, которые соответствуют предикату</returns>
        public List<bsNavItem> FindNavigationItems(Predicate<bsNavItem> FindPredicateUnit = null)
        {
            List<bsNavItem> navItems = new List<bsNavItem>();
            FindAllNavigationItems(ref navItems, FindPredicateUnit);
            return navItems;
        }
    }
}
