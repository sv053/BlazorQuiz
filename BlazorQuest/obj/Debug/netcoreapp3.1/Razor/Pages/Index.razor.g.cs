#pragma checksum "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72e27cfda138d650ccbdef3cd3d1df20dd523228"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorQuest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using BlazorQuest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using BlazorQuest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hi there,</h1>\r\n\r\nlet me show you smth! How do you like this responsive chart?:)\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "border:" + " 1px" + " solid" + " red;width:" + (
#nullable restore
#line 9 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
                                         ContainerWidth

#line default
#line hidden
#nullable disable
            ) + ";" + " height:" + " " + (
#nullable restore
#line 9 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
                                                                  ContainerHeight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikStockChart>(4);
            __builder.AddAttribute(5, "Width", "100%");
            __builder.AddAttribute(6, "Height", "450px");
            __builder.AddAttribute(7, "DateField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
                                   nameof(StockDataPoint.Date)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.StockChartCategoryAxes>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "\r\n            ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.StockChartCategoryAxis>(13);
                    __builder3.AddAttribute(14, "BaseUnit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartCategoryAxisBaseUnit?>(
#nullable restore
#line 17 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
                                               ChartCategoryAxisBaseUnit.Months

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.StockChartSeriesItems>(17);
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(19, "\r\n            ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.StockChartSeries>(20);
                    __builder3.AddAttribute(21, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.StockChartSeriesType?>(
#nullable restore
#line 21 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
                                    StockChartSeriesType.Candlestick

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Name", "Product 1");
                    __builder3.AddAttribute(23, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 23 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
                                     StockChartProduct1Data

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "OpenField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
                                          nameof(StockDataPoint.Open)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "CloseField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
                                           nameof(StockDataPoint.Close)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "HighField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
                                          nameof(StockDataPoint.High)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "LowField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
                                         nameof(StockDataPoint.Low)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.StockChartNavigator>(30);
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(32, "\r\n            ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.StockChartNavigatorSeriesItems>(33);
                    __builder3.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(35, "\r\n                ");
                        __builder4.OpenComponent<Telerik.Blazor.Components.StockChartNavigatorSeries>(36);
                        __builder4.AddAttribute(37, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.StockChartSeriesType?>(
#nullable restore
#line 33 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
                                                 StockChartSeriesType.Line

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(38, "Name", "Product 1");
                        __builder4.AddAttribute(39, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 35 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
                                                  StockChartProduct1Data

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(40, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
                                                    nameof(StockDataPoint.High)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "CategoryField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
                                                            nameof(StockDataPoint.Date)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(42, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n\r\n    ");
            }
            ));
            __builder.AddComponentReferenceCapture(45, (__value) => {
#nullable restore
#line 14 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
                             myStockChartRef = (Telerik.Blazor.Components.TelerikStockChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\Index.razor"
       
    Telerik.Blazor.Components.TelerikStockChart myStockChartRef { get; set; }

    string ContainerWidth { get; set; } = "400px";
    string ContainerHeight { get; set; } = "300px";

    public List<StockDataPoint> StockChartProduct1Data { get; set; }

    async Task ResizeChart()
    {
        ContainerHeight = "500px";
        ContainerWidth = "800px";

        await Task.Delay(20);

        myStockChartRef.Refresh();
    }

    protected override async Task OnInitializedAsync()
    {
        await GenerateChartData();
    }

    public async Task GenerateChartData()
    {
        StockChartProduct1Data = new List<StockDataPoint>()
{
            new StockDataPoint(new DateTime(2019, 1, 1), 41.62m, 40.12m, 41.69m, 39.81m, 2632000),
            new StockDataPoint(new DateTime(2019, 2, 1), 39.88m, 40.12m, 41.12m, 39.75m, 3584700),
            new StockDataPoint(new DateTime(2019, 3, 1), 42m, 42.62m, 43.31m, 41.38m, 7631700),
            new StockDataPoint(new DateTime(2019, 4, 1), 42.25m, 43.06m, 43.31m, 41.12m, 4922200)
        };

        await Task.FromResult(StockChartProduct1Data);
    }

    public class StockDataPoint
    {
        public StockDataPoint() { }

        public StockDataPoint(DateTime date, decimal open, decimal close, decimal high, decimal low, int volume)
        {
            Date = date;
            Open = open;
            Close = close;
            High = high;
            Low = low;
            Volume = volume;
        }
        public DateTime Date { get; set; }

        public decimal Open { get; set; }

        public decimal Close { get; set; }

        public decimal High { get; set; }

        public decimal Low { get; set; }

        public int Volume { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
