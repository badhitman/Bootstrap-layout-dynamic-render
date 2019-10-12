////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models;
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using System.Collections.Generic;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public abstract class AbstractNavManager : AbstractDomManager
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

        public List<NavItemModel> NavItems { get; private set; } = new List<NavItemModel>();

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
