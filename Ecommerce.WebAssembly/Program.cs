using Ecommerce.WebAssembly;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using Ecommerce.WebAssembly.Servicios.Implementacion;
using Ecommerce.WebAssembly.Servicios.Contrato;

using CurrieTechnologies.Razor.SweetAlert2;

using Microsoft.AspNetCore.Components.Authorization;
using Ecommerce.WebAssembly.Extensiones;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5023/api/") });

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<IToastService, ToastService>();

builder.Services.AddScoped<IUsuarioServicio, UsuarioServicio>();
builder.Services.AddScoped<ICategoriaServicio, CategoriaServicio>();
builder.Services.AddScoped<IProductoServicio, ProductoServicio>();
builder.Services.AddScoped<ICarritoServicio, CarritoServicio>();
builder.Services.AddScoped<IVentaServicio, VentaServicio>();
builder.Services.AddScoped<IDashboardServicio, DashboardServicio>();

builder.Services.AddSweetAlert2();

builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, AutenticacionExtension>();

await builder.Build().RunAsync();
