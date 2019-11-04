////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.html;
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.bootstrap
{
    public class TableBootstrapManager : TableManager
    {
        /// <summary>
        /// Use .table-striped to add zebra-striping to any table row within the <tbody>.
        /// </summary>
        public bool IsStriped { get; set; } = true;

        /// <summary>
        /// Small table
        /// Adding .table-sm to make tables more compact by cutting cell padding in half.
        /// </summary>
        public bool IsSmall { get; set; } = false;

        /// <summary>
        /// Bordered table: adding .table-bordered for borders on all sides of the table and cells.
        /// Borderless table: adding .table-borderless for a table without borders.
        /// </summary>
        public bool? IsBordered { get; set; } = null;

        /// <summary>
        /// Hoverable rows
        /// Adding .table-hover to enable a hover state on table rows within a <tbody>.
        /// </summary>
        public bool IsHoverableRows { get; set; } = true;

        public BackgroundColorThemesEnum TableColorScheme { get; set; } = BackgroundColorThemesEnum.NULL;

        /// <summary>
        /// A <caption> functions like a heading for a table. It helps users with screen readers to find a table and understand what it’s about and decide if they want to read it.
        /// </summary>
        public string CaptionText { get; set; }

        public override string GetStringCSS
        {
            get
            {
                AddCSS("table");

                if (IsSmall)
                    AddCSS("table-sm");

                if (IsBordered == true)
                    AddCSS("table-bordered");
                else if(IsBordered == false)
                    AddCSS("table-borderless");

                if (IsStriped)
                    AddCSS("table-striped");

                if (TableColorScheme != BackgroundColorThemesEnum.NULL)
                    AddCSS("table-" + TableColorScheme.ToString().ToLower());

                if (IsHoverableRows)
                    AddCSS("table-hover");

                return base.GetStringCSS;
            }
        }
    }
}
