////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class brFormGroup : ViewComponent
    {
        public IViewComponentResult Invoke(absFormGroup SetObjectManager)
        {
            string view_name = SetObjectManager.GetType().Name;

            if (view_name.Contains("FormGroup"))
                view_name = view_name.Substring(view_name.IndexOf("FormGroup") + 9);

            return View(view_name, SetObjectManager);
        }
    }
}