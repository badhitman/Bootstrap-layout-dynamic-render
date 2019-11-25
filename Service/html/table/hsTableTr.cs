////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public class hsTableTr : ahsNestedTools
    {
        public override string ViewComponentName => nameof(hrTableTr);

        public void AddCell(hsTableTh thManager)
        {
            Childs.Add(thManager);
        }

        public void AddCell(hsTableTd tdManager)
        {
            Childs.Add(tdManager);
        }
    }
}
