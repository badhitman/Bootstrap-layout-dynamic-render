////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class bsTableTr : hsTableTr
    {
        public bmBackgroundColorThemesEnum TableColorScheme { get; set; } = bmBackgroundColorThemesEnum.NULL;

        public void AddCell(bsTableTd tdBootstrapManager)
        {
            Childs.Add(tdBootstrapManager);
        }

        public override string GetStringCSS()
        {
            //get
            //{
                if (TableColorScheme != bmBackgroundColorThemesEnum.NULL)
                    AddCSS("table-" + TableColorScheme.ToString().ToLower());

                return base.GetStringCSS();
            //}
        }
    }
}
