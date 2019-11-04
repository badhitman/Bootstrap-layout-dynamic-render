////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.html.table;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.bootstrap.table
{
    public class TableTrBootstrapManager : TableTrManager
    {
        public BackgroundColorThemesEnum TableColorScheme { get; set; } = BackgroundColorThemesEnum.NULL;

        public void AddCell(TableTdBootstrapManager tdBootstrapManager)
        {
            Childs.Add(tdBootstrapManager);
        }

        public override string StringCSS
        {
            get
            {
                if (TableColorScheme != BackgroundColorThemesEnum.NULL)
                    AddCSS("table-" + TableColorScheme.ToString().ToLower());

                return base.StringCSS;
            }
        }
    }
}
