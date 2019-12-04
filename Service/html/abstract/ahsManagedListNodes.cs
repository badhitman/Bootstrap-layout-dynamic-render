////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////

namespace BootstrapAspDynamicRender.service
{
    public abstract class ahsManagedListNodes : ahsNestedTools
    {
        public void AddChild(ahsDom AddedChildNode)
        {
            ChildsNodes.Add(AddedChildNode);
        }

        public void AddRangeChilds(ahsDom[] AddedChildNodes) => ChildsNodes.AddRange(AddedChildNodes);
    }
}
