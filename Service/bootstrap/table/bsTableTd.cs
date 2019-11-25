////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class bsTableTd : hsTableTd
    {
        public bmBackgroundColorThemesEnum ColorScheme { get; set; } = bmBackgroundColorThemesEnum.NULL;

        public override string GetStringCSS()
        {
            //get
            //{
            if (ColorScheme != bmBackgroundColorThemesEnum.NULL)
                AddCSS("table-" + ColorScheme.ToString().ToLower());

            return base.GetStringCSS();
            //}
        }
    }
}
