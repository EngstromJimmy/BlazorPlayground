using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.JSInterop
{
    public static class JSInteropExtensions
    {
        public static ValueTask<object> SaveAs(this IJSRuntime js, string filename, byte[] data, string type = "application/octet-stream")
        {
            return js.InvokeAsync<object>("JSRuntimeExtensions.saveAsFile", filename, type, Convert.ToBase64String(data));
        }   
    }
}
