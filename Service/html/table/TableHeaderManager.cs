////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.html.table;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.table
{
    public class TableHeaderManager : AbstractNestedToolsManager
    {
        public override string ViewComponentName => nameof(TableHeaderBase);

        public void AddColumnHeader(string name_header)
        {
            Childs.Add(new TableThManager() { Header = name_header });
        }
    }
}
