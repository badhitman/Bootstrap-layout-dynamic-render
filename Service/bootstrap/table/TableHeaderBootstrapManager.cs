////////////////////////////////////////////////
// MIT License. https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.html.table;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.bootstrap.table
{
    public class TableHeaderBootstrapManager : TableHeaderManager
    {
        public MonochromeColorSchemesEnum TableHeaderColorScheme { get; set; } = MonochromeColorSchemesEnum.NULL;

        public override string StringAttributes
        {
            get
            {
                if (TableHeaderColorScheme != MonochromeColorSchemesEnum.NULL)
                    AddCSS("thead-" + TableHeaderColorScheme.ToString().ToLower());

                return base.StringAttributes;
            }
        }
    }
}
