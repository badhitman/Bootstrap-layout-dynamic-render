////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public class hsTable : ahsNestedTools
    {
        public override string ViewComponentName => nameof(hrTable);

        public hsTableHeader TableHeader { get; private set; } = new hsTableHeader();

        public void AddRow(hsTableTr tableTr)
        {
            ChildsNodes.Add(tableTr);
        }
    }
}
