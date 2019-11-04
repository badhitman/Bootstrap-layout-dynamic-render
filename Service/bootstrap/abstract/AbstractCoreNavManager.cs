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
        private void FindAllNavigationItems(ref List<NavItemModel> navItems, Predicate<NavItemModel> FindPredicateUnit = null)
        {
            foreach (NavItemModel nav_item in Childs.Where(x => !(x is null)))
            {
                if (FindPredicateUnit is null || FindPredicateUnit(nav_item))
                    navItems.Add(nav_item);

                nav_item.FindAllNavigationItems(ref navItems, FindPredicateUnit);
            }
        }

        /// <summary>
        /// Найти все элементы меню, которые соответствуют предикату
        /// 
        /// bool FindPredicateUnit(NavItemModel navItem) { return navItem.Id_DOM.ToLower() == activate_nav_by_id; };
        /// FindNavigationItems(FindPredicateUnit).ForEach(x => x);
        /// </summary>
        /// <param name="FindPredicateUnit"></param>
        /// <returns>Все элементы меню, которые соответствуют предикату</returns>
        public List<NavItemModel> FindNavigationItems(Predicate<NavItemModel> FindPredicateUnit = null)
        {
            List<NavItemModel> navItems = new List<NavItemModel>();
            FindAllNavigationItems(ref navItems, FindPredicateUnit);
            return navItems;
        }
    }
}
