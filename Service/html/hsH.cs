using BootstrapAspDynamicRender.components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapAspDynamicRender.service
{
    public class hsH : ahsNestedTools
    {
        public override string ViewComponentName => nameof(hrH);

        private short _HeaderIndex = 1;
        public short HeaderIndex
        {
            get => _HeaderIndex;
            set
            {
                if (value < 1)
                {
                    value = 1;
                }
                if (value >6)
                {
                    value = 6;
                }
                _HeaderIndex = value;
            }
        }

        public string Text { get; set; }

        public hsH(short SetHeaderIndex = 1)
        {
            HeaderIndex = SetHeaderIndex;
        }
    }
}
