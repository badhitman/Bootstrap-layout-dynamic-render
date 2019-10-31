using BootstrapViewComponentsRazorLibrary.Components.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    public abstract class ManagedListNodesManager : AbstractNestedToolsManager
    {
        public void AddChild(AbstractDomManager child_node) => Childs.Add(child_node);

        public void AddRangeChilds(AbstractDomManager[] child_nodes) => Childs.AddRange(child_nodes);
    }
}
