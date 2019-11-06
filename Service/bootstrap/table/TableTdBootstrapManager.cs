﻿////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.html.table;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.bootstrap.table
{
    public class TableTdBootstrapManager : TableTdManager
    {
        public BackgroundColorThemesEnum ColorScheme { get; set; } = BackgroundColorThemesEnum.NULL;

        public override string GetStringCSS()
        {
            //get
            //{
                if (ColorScheme != BackgroundColorThemesEnum.NULL)
                    AddCSS("table-" + ColorScheme.ToString().ToLower());

                return base.GetStringCSS();
            //}
        }
    }
}