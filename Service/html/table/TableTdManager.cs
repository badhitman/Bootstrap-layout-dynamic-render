////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.html.table;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.table
{
    public class TableTdManager : ManagedListNodesManager
    {
        public override string ViewComponentName => nameof(TableTdBase);

        public string Header { get; set; }
    }
}
