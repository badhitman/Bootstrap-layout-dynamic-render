////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.html.input.valuable;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class TextareaManager : AbstractTextedBasicInputManager
    {
        public override string GetStringAttributes()
        {
            if (SizeArea > 0)
                SetAttribute("rows", SizeArea.ToString());
            else
                RemoveAttribute("rows");

            return base.GetStringAttributes();
        }
    }
}
