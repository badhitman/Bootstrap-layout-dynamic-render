////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class bsTableTr : hsTableTr
    {
        public bmBackgroundColorThemesEnum TableColorScheme { get; set; } = bmBackgroundColorThemesEnum.NULL;

        public hsTableTr AddCell(bsTableTd tdBootstrapManager)
        {
            ChildsNodes.Add(tdBootstrapManager);
            return this;
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
