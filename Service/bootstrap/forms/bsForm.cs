////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////

namespace BootstrapAspDynamicRender.service
{
    public class bsForm : hsForm
    {
        public bool IsInlineForm { get; set; } = false;

        public bool IsWasValidated { get; set; } = false;

        public override string GetStringCSS()
        {
            if (string.IsNullOrWhiteSpace(CacheCSS))
            {
                if (IsInlineForm)
                    AddCSS("form-inline");
                else
                    RemoveCSS("form-inline");

                if (IsWasValidated)
                    AddCSS("was-validated");
                else
                    RemoveCSS("was-validated");
            }
            return base.GetStringCSS();
        }
    }
}
