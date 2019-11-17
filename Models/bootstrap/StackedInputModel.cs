using BootstrapViewComponentsRazorLibrary.Service.bootstrap.input;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Models.bootstrap
{
    public class StackedInputModel
    {
        public bool IsInline { get; set; } = false;

        public CustomInputModel CustomInput { get; set; }
    }
}
