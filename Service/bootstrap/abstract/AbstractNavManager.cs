////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models;
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using System.Collections.Generic;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public abstract class AbstractNavManager : AbstractToolsManager
    {
        /// <summary>
        /// доступная глубина вложенности пунктов навигации
        /// </summary>
        protected abstract short AvailableNestingDepth { get; }

        public NavOrientationsEnum NavigationOrientation { get; set; } = NavOrientationsEnum.HorizontallyLeftAligned;

        /// <summary>
        /// Формат навигационной панели
        /// </summary>
        public NavFormatsEnum NavFormat { get; set; } = NavFormatsEnum.ListUL;

        protected List<NavItemModel> NavItems { get; private set; } = new List<NavItemModel>();
    }
}
