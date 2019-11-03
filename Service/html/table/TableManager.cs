////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.html;
using BootstrapViewComponentsRazorLibrary.Service.html.table;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    public class TableManager : AbstractNestedToolsManager
    {
        public override string ViewComponentName => nameof(TableBase);

        public TableHeaderManager TableHeader { get; private set; } = new TableHeaderManager();

        public void AddRow(TableTrManager tableTr)
        {
            Childs.Add(tableTr);
        }
    }
}
