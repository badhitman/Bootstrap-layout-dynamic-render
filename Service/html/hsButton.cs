﻿////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsButton : ahsDisengageableDom
    {
        public hmButtonTypesEnum ButtonType { get; set; } = hmButtonTypesEnum.button;

        public string Header { get; set; }

        public override string ViewComponentName => nameof(hrButton);

        public hsButton(string SetHeader)
        {
            Header = SetHeader;
        }

        public override string GetStringAttributes()
        {
            if (ButtonType != hmButtonTypesEnum.NULL)
                SetAttribute("type", ButtonType.ToString());

            return base.GetStringAttributes();
        }
    }
}
