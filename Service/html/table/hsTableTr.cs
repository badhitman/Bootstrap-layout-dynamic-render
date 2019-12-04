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
            ChildsNodes.Add(thManager);
            return this;
        }

        public hsTableTr AddCell(hsTableTd tdManager)
        {
            ChildsNodes.Add(tdManager);
            return this;
        }
    }
}
