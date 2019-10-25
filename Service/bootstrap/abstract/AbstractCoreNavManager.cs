////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using System.Linq;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public abstract class AbstractCoreNavManager : AbstractSafeNestedToolsManager
    {
        public void DisableNavItem(string disable_nav_by_id)
        {
            disable_nav_by_id = disable_nav_by_id.ToLower();
            foreach (NavItemModel nav_item in Childs)
            {
                if (nav_item.Id_DOM.ToLower() == disable_nav_by_id)
                {
                    nav_item.IsDisabled = true;
                    return;
                }
                foreach (NavItemModel nav_sub_item in nav_item.GetChilds().Where(x => !(x is null)))
                {
                    if (nav_sub_item.Id_DOM.ToLower() == disable_nav_by_id)
                    {
                        nav_sub_item.IsDisabled = true;
                        return;
                    }
                }
            }
        }

        public void ActivateNavItem(string activate_nav_by_id)
        {
            activate_nav_by_id = activate_nav_by_id.ToLower();

            foreach (NavItemModel nav_item in Childs)
            {
                if (nav_item.Id_DOM.ToLower() == activate_nav_by_id)
                {
                    nav_item.IsActive = true;
                    return;
                }
                foreach (NavItemModel nav_sub_item in nav_item.GetChilds().Where(x => !(x is null)))
                {
                    if (nav_sub_item.Id_DOM.ToLower() == activate_nav_by_id)
                    {
                        nav_sub_item.IsActive = true;
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Сброс состояния (IsActive||IsDisable) всех пунктов меню
        /// </summary>
        public void ResetNavItems()
        {
            foreach (NavItemModel nav_item in Childs)
                nav_item.ResetNavItems();
        }
    }
}
