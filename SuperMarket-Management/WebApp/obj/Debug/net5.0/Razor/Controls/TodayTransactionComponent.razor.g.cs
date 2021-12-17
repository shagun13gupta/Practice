#pragma checksum "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\Controls\TodayTransactionComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1693dfdb447a61b0315e73b7fef6ce889f7323e3"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Controls
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
    public partial class TodayTransactionComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\Controls\TodayTransactionComponent.razor"
 if (transactions != null) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table");
            __builder.AddMarkupContent(2, "<thead><tr><th>Cashier Name</th>\r\n            <th>Product Name</th>\r\n            <th>Date Time</th>\r\n            <th>Qty Before</th>\r\n            <th>Qty Sold</th>\r\n            <th>Qty After</th>\r\n            <th>Sold Amount</th></tr></thead>\r\n    ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 18 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\Controls\TodayTransactionComponent.razor"
             foreach (var tran in transactions)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 21 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\Controls\TodayTransactionComponent.razor"
                         tran.CashierName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                    ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 22 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\Controls\TodayTransactionComponent.razor"
                         tran.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 23 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\Controls\TodayTransactionComponent.razor"
                         tran.TimeStamp.ToString("yyyy-MM-dd hh:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 24 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\Controls\TodayTransactionComponent.razor"
                         tran.BeforeQty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 25 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\Controls\TodayTransactionComponent.razor"
                         tran.SoldQty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 26 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\Controls\TodayTransactionComponent.razor"
                          tran.BeforeQty-tran.SoldQty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "style", "text-align:right");
            __builder.AddContent(25, 
#nullable restore
#line 27 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\Controls\TodayTransactionComponent.razor"
                                                   string.Format("{0:c}",tran.SoldQty * tran.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\Controls\TodayTransactionComponent.razor"
            }     

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\Controls\TodayTransactionComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\TTN\source\repos\SuperMarket-Management\WebApp\Controls\TodayTransactionComponent.razor"
       
    private IEnumerable<Transaction> transactions;
    public void LoadTransactions(string cashierName)
    {
        transactions = GetTodayTransactionUseCase.Execute(cashierName);
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetTodayTransactionUseCase GetTodayTransactionUseCase { get; set; }
    }
}
#pragma warning restore 1591
