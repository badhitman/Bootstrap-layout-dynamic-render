////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////

namespace BootstrapAspDynamicRender.service
{
    public abstract class absInputGroupFacet : hsDiv
    {
        public void AddFacetText(string header_text)
        {
            hsSpan span = new hsSpan() { Header = header_text };
            span.AddCSS("input-group-text");
            ChildsNodes.Add(span);
        }
    }
}
