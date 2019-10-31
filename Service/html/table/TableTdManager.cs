using BootstrapViewComponentsRazorLibrary.Components.html.table;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.table
{
    public class TableTdManager : AbstractNestedToolsManager
    {
        public override string ViewComponentName => nameof(TableTdBase);

        public string Header { get; set; }
    }
}
