// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorQuest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using BlazorQuest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using BlazorQuest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\scena\source\repos\BlazorQuest\BlazorQuest\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/first")]
    public partial class MyFirstComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "c:\Users\scena\source\repos\BlazorQuest\BlazorQuest\Pages\MyFirstComponent.razor"
       
    public IEnumerable<SampleData> MyData = Enumerable.Range(1, 30).Select(x => new SampleData
    {
        Id = x,
        Name = "name " + x,
        Team = "team " + x % 5,
        HireDate = DateTime.Now.AddDays(-x).Date
    });

    public class SampleData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public DateTime HireDate { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
