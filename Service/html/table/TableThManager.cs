using BootstrapViewComponentsRazorLibrary.Components.html.table;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.table
{
    public class TableThManager : AbstractDomManager
    {
        public string Header { get; set; }
        public override string ViewComponentName => nameof(TableThBase);
    }
}
