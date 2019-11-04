////////////////////////////////////////////////
// MIT License. https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.html.table;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.table
{
    public class TableTrManager : AbstractNestedToolsManager
    {
        public override string ViewComponentName => nameof(TableTrBase);

        public void AddCell(TableThManager thManager)
        {
            Childs.Add(thManager);
        }

        public void AddCell(TableTdManager tdManager)
        {
            Childs.Add(tdManager);
        }
    }
}
