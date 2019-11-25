////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public class hsTableTr : ahsNestedTools
    {
        public override string ViewComponentName => nameof(hrTableTr);

        public hsTableTr AddCell(hsTableTh thManager)
        {
            Childs.Add(thManager);
            return this;
        }

        public hsTableTr AddCell(hsTableTd tdManager)
        {
            Childs.Add(tdManager);
            return this;
        }
    }
}
