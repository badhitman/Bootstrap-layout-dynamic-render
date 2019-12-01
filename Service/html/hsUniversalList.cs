////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    /// <summary>
    /// Универсальный сервис для рендеринга составных HTML объектов
    /// </summary>
    public class hsUniversalList : ahsNestedTools
    {
        public override string ViewComponentName => nameof(hrUniversalList);
    }
}
