using BootstrapViewComponentsRazorLibrary.Service.bootstrap.input;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class FormGroupManager : AbstractCustomInputManager
    {
        public bool IsRow { get; set; }

        public void AddTextedControlGroup(AbstractTextedInputManager SetInput, string SetLabel)
        {
            if (string.IsNullOrWhiteSpace(SetInput.ID) && string.IsNullOrWhiteSpace(SetInput.NameDom))
                SetInput.ID = Guid.NewGuid().ToString();
        }

        public void AddLogicalControlGroup(AbstractInputValuableBoolManager SetBoolInput, string SetLabel)
        {

        }

        public override string GetStringCSS()
        {
            if (string.IsNullOrWhiteSpace(CacheCSS))
            {
                AddCSS("form-group");

                if (IsRow)
                    AddCSS("row");
                else
                    RemoveCSS("row");
            }
            return base.GetStringCSS();
        }


    }
}
