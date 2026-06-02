namespace Ecommerce.WebAssembly.Servicios.Contrato
{
    public interface IToastService
    {
        void ShowSuccess(string message);
        void ShowError(string message);
        void ShowInfo(string message);
        void ShowWarning(string message);
    }
}
