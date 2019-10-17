////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models;
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using System.Linq;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public abstract class AbstractNavManager : AbstractNestedToolsManager
    {
        /// <summary>
        /// доступная глубина вложенности пунктов навигации
        /// </summary>
        protected short AvailableNestingDepth { get; } = 2;

        /// <summary>
        /// Takes the basic nav from above and adds the .nav-tabs class to generate a tabbed interface.
        /// Use them to create tabbable regions with our tab JavaScript plugin.
        /// </summary>
        public bool IsTabsStyle { get; private set; }

        public NavOrientationsEnum NavigationOrientation { get; set; } = NavOrientationsEnum.HorizontallyLeftAligned;

        /// <summary>
        /// Тип внешнего DOM для оборачивания "Bootstrap Navs"
        /// </summary>
        public NavWrapperTypesEnum NavWrapperType { get; set; } = NavWrapperTypesEnum.ul;

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

        public AbstractNavManager(NavOrientationsEnum SetNavigationOrientation, bool SetTabsStyle = false)
        {
            IsTabsStyle = SetTabsStyle;
            NavigationOrientation = SetNavigationOrientation;
            AddCSS("nav");
            switch (NavigationOrientation)
            {
                case NavOrientationsEnum.HorizontallyCenterAligned:
                    AddCSS("justify-content-center");
                    break;
                case NavOrientationsEnum.HorizontallyRightAligned:
                    AddCSS("justify-content-end");
                    break;
                case NavOrientationsEnum.Vertically:
                    AddCSS("flex-column");
                    break;
                case NavOrientationsEnum.HorizontallyFill:
                    AddCSS("nav-fill");
                    break;
                case NavOrientationsEnum.HorizontallyFlexUtilities:
                    AddCSS("flex-column flex-sm-row", true);
                    NavWrapperType = NavWrapperTypesEnum.nav;
                    break;
                case NavOrientationsEnum.HorizontallyJustified:
                    AddCSS("nav-justified");
                    break;
                default:

                    break;
            }
        }
    }
}
