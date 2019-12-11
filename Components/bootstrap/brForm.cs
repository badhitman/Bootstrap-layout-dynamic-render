////////////////////////////////////////////////
// https://github.com/badhitman 
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace BootstrapAspDynamicRender.components
{
    public class brForm : ViewComponent
    {
        protected ILogger logger { get; set; }

        public brForm(ILoggerFactory SetloggerFactory)
        {
            if (SetloggerFactory is null)
                throw new ArgumentNullException(nameof(SetloggerFactory));

            logger = SetloggerFactory.CreateLogger(this.GetType().Name + "Class");
        }

        public IViewComponentResult Invoke(hsForm SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
