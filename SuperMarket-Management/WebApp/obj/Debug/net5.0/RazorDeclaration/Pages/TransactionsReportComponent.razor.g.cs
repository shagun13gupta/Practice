// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\_Imports.razor"
using UseCases.UseCaseInterfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\_Imports.razor"
using UseCases;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\_Imports.razor"
using WebApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\Pages\TransactionsReportComponent.razor"
           [Authorize(Policy = "AdminOnly")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transactions")]
    public partial class TransactionsReportComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\Pages\TransactionsReportComponent.razor"
       

    private string cashierName;
    private DateTime startDate;
    private DateTime endDate;
    public IEnumerable<Transaction> transactions;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        startDate = DateTime.Today;
        endDate = DateTime.Today;
    }
    public void LoadTransaction()
    {
        transactions = GetTransactionsUseCase.Execute(cashierName, startDate, endDate);
    }
    public void PrintReport()
    {
        JSRuntime.InvokeVoidAsync("print");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetTransactionsUseCase GetTransactionsUseCase { get; set; }
    }
}
#pragma warning restore 1591
