////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public abstract class AbstractCoreNavManager : AbstractNestedToolsManager
    {
        private void FindAllNavigationItems(ref List<NavItemManager> navItems, Predicate<NavItemManager> FindPredicateUnit = null)
        {
            foreach (NavItemManager nav_item in Childs.Where(x => !(x is null)))
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
        public List<NavItemManager> FindNavigationItems(Predicate<NavItemManager> FindPredicateUnit = null)
        {
            List<NavItemManager> navItems = new List<NavItemManager>();
            FindAllNavigationItems(ref navItems, FindPredicateUnit);
            return navItems;
        }
    }
}
