using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public abstract class AbstractInputGroupCuttingManager : DivBaseManager
    {
        public void AddFacetText(string header_text)
        {
            SpanManager span = new SpanManager() { Header = header_text };
            span.AddCSS("input-group-text");
            Childs.Add(span);
        }

        public void AddButton(string header_text)
        {
            ButtonBaseManager button = new ButtonBaseManager(header_text);

        }
    }
}
