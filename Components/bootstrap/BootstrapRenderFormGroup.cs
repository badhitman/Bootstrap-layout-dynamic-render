using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap.forms;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap
{
    public class BootstrapRenderFormGroup : ViewComponent
    {
        public IViewComponentResult Invoke(AbstractFormGroupManager SetObjectManager)
        {
            string view_name = SetObjectManager.GetType().Name;

            if (view_name.StartsWith("FormGroup"))
                view_name = view_name.Substring(9);

            if (view_name.EndsWith("Manager"))
                view_name = view_name.Substring(0, view_name.Length - 7);

            return View(view_name, SetObjectManager);
        }
    }
}