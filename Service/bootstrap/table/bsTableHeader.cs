////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class bsTableHeader : hsTableHeader
    {
        public bmMonochromeColorSchemesEnum TableHeaderColorScheme { get; set; } = bmMonochromeColorSchemesEnum.NULL;

        public override string GetStringAttributes()
        {
            if (TableHeaderColorScheme != bmMonochromeColorSchemesEnum.NULL)
                AddCSS("thead-" + TableHeaderColorScheme.ToString().ToLower());

            return base.GetStringAttributes();
        }
    }
}
