using BootstrapViewComponentsRazorLibrary.Components.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class ModalManager : ManagedListNodesManager
    {
        public override string ViewComponentName => nameof(BootstrapRenderModal);
    }
}
