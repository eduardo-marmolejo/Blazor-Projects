using Microsoft.JSInterop;
using Ecommerce.WebAssembly.Servicios.Contrato;

namespace Ecommerce.WebAssembly.Servicios.Implementacion
{
    public class ToastService : IToastService
    {
        private readonly IJSRuntime _jsRuntime;

        public ToastService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async void ShowSuccess(string message)
        {
            try { await _jsRuntime.InvokeVoidAsync("toastr.success", message); } catch { }
        }

        public async void ShowError(string message)
        {
            try { await _jsRuntime.InvokeVoidAsync("toastr.error", message); } catch { }
        }

        public async void ShowInfo(string message)
        {
            try { await _jsRuntime.InvokeVoidAsync("toastr.info", message); } catch { }
        }

        public async void ShowWarning(string message)
        {
            try { await _jsRuntime.InvokeVoidAsync("toastr.warning", message); } catch { }
        }
    }
}
