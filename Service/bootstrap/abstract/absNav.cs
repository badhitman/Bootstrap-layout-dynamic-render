////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public abstract class absNav : absCoreNav
    {
        public override string ViewComponentName => nameof(brNavBase);

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
        /// По умолчанию bmNavOrientationsEnum.HorizontallyLeftAligned: к блоку не будет применяться ни каких стилей
        /// </summary>
        public bmNavOrientationsEnum NavigationOrientation { get; set; } = bmNavOrientationsEnum.HorizontallyLeftAligned;

        /// <summary>
        /// Тип внешнего DOM для оборачивания "Bootstrap Navs"
        /// </summary>
        public bmNavWrappersEnum NavWrapperType { get; set; } = bmNavWrappersEnum.ul;
             
        public absNav()
        {
            AddCSS("nav");
            
            if (this is bsNavJavaScriptBehavior)
                SetAttribute("role", "tablist");

        }
    }
}
