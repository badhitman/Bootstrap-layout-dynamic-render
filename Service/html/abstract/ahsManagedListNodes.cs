////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////

namespace BootstrapAspDynamicRender.service
{
    public abstract class ahsManagedListNodes : ahsNestedTools
    {
        public void AddChild(ahsDom child_node)=> Childs.Add(child_node);

        public void AddRangeChilds(ahsDom[] child_nodes) => Childs.AddRange(child_nodes);
    }
}
