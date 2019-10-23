////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models;
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public abstract class AbstractNavManager : AbstractCoreNavManager
    {
        /// <summary>
        /// доступная глубина вложенности пунктов навигации
        /// </summary>
        protected short AvailableNestingDepth { get; } = 2;

        /// <summary>
        /// Takes the basic nav from above and adds the .nav-tabs class to generate a tabbed interface.
        /// Use them to create tabbable regions with our tab JavaScript plugin.
        /// </summary>
        public bool IsTabsStyle { get; set; } = false;

        /// <summary>
        /// Ориентация блока навигации (вертикально/горизонтально+).
        /// По умолчанию NavOrientationsEnum.HorizontallyLeftAligned: к блоку не будет применяться ни каких стилей
        /// </summary>
        public NavOrientationsEnum NavigationOrientation { get; set; } = NavOrientationsEnum.HorizontallyLeftAligned;

        /// <summary>
        /// Тип внешнего DOM для оборачивания "Bootstrap Navs"
        /// </summary>
        public NavWrapperTypesEnum NavWrapperType { get; set; } = NavWrapperTypesEnum.ul;
             
        public AbstractNavManager()
        {
            AddCSS("nav");
            
            if (this is NavJavaScriptBehaviorManager)
                SetAttribute("role", "tablist");

        }
    }
}
