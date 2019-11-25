////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using System;

namespace BootstrapAspDynamicRender.models
{
    /*
        <img src="data:image/gif;base64,R0lGODlhEAAOALMAAOazToeHh0tLS/7LZv/0j
        vb29t/f3//Ub//ge8WSLf/rhf/3kdbW1mxsbP//mf///yH5BAAAAAAALAAAAAAQAA4AAA
        Re8L1Ekyky67QZ1hLnjM5UUde0ECwLJoExKcppV0aCcGCmTIHEIUEqjgaORCMxIC6e0Cc
        guWw6aFjsVMkkIr7g77ZKPJjPZqIyd7sJAgVGoEGv2xsBxqNgYPj/gAwXEQA7" width="16" 
        height="14" alt="внедренная иконка папки"/>
    */
    public class hmDataUrl
    {
        public string MimeType { get; set; }

        /// <summary>
        /// Данные для сохранения
        /// </summary>
        public byte[] Bytes { get; set; }

        public override string ToString()
        {
            string ret_val = "data:";
            if (MimeType.ToLower().Contains("/"))
                ret_val += MimeType.ToLower();
            else
                ret_val += "image/" + MimeType.ToLower();
            ret_val += ";base64," + Convert.ToBase64String(Bytes);
            return ret_val;
        }
    }
}
