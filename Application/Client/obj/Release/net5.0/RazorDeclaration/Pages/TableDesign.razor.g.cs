// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Application.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Emel\Desktop\Application\Application\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emel\Desktop\Application\Application\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emel\Desktop\Application\Application\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emel\Desktop\Application\Application\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emel\Desktop\Application\Application\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Emel\Desktop\Application\Application\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Emel\Desktop\Application\Application\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Emel\Desktop\Application\Application\Client\_Imports.razor"
using Application.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
using Entities.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
using Entities.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tabledesign")]
    public partial class TableDesign : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 154 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
               


            private bool isChecked = false;
            private string columnName;
            private string entity;
            private int id;
            private string _value { get; set; }

            public Value val = new Value();

            CoreDbContext ctx = new CoreDbContext();
            List<Column> columns = new List<Column>();
            List<Value> Value = new List<Value>();
            List<Column> allColumns = new List<Column>();
            List<string> Logs = new List<string>();
            List<TableView> tableview = new List<TableView>();
            Dictionary<Column,Value> coltableview = new Dictionary<Column,Value>();
            List<TableView> tbView = new List<TableView>();

            protected void GetId(int value)
            {
                id = value;
            }


            protected override async Task OnInitializedAsync()
            {
                //bu ne boyle ya işin içinden çıkamadım 

                //columns = await Http.GetFromJsonAsync<List<Column>>("/api/Column/GetVisibleColumns");
                // Value = await Http.GetFromJsonAsync<List<Value>>("/api/Value/TableView");
               // coltableview = await Http.GetFromJsonAsync<Dictionary<Column,Value>>("/api/Column/TableView");
                //allColumns = await Http.GetFromJsonAsync<List<Column>>("/api/Column/GetAllColumns");
                //Logs = await Http.GetFromJsonAsync<List<string>>("api/SystemLog/GetAllLogs");
                //tableview = await Http.GetFromJsonAsync<List<TableView>>("api/Column/TableView");

                 tbView = await Http.GetFromJsonAsync<List<TableView>>("api/TableView/GetTableView");

               

            }

            private async void HandleValidSubmit()
            {

                Value Values = new Value {Value1=val.Value1,ColumnId=id };
                var response = await Http.PostAsJsonAsync<Value>("/api/Value/AddValue",Values);
                response.StatusCode.ToString();
                await OnInitializedAsync();
                // ctx.Update(Value);



            }

            private async Task AddNewColumn()
            {
                int? order = 0;
                var setOrderNumber = await Http.GetFromJsonAsync<List<Column>>("/api/Column/GetAllColumns");
                if (setOrderNumber.Count < 1)
                {
                    order = 1;
                }
                else if (setOrderNumber.Count > 0)
                {
                    var query = setOrderNumber.OrderByDescending(x => x.Order).FirstOrDefault();
                    order = query.Order + 1;
                }
                Column column = new Column { Name = columnName, IsVisible = true, Order = order };
                var response = await Http.PostAsJsonAsync<Column>("/api/Column/AddColumn", column);
                response.StatusCode.ToString();

                await OnInitializedAsync();

            }



            private async Task DeleteColumn(int Id)
            {
                var response = await Http.DeleteAsync("/api/Column/Delete/" + Id);
                response.StatusCode.ToString();

                await OnInitializedAsync();
            }

            private async Task UpdateColumn(KeyboardEventArgs e)
            {
                if (e.Code == "Enter")
                {
                    var oldRecord = await Http.GetFromJsonAsync<List<Column>>("/api/Column/GetAll");
                    var list = oldRecord.FirstOrDefault(x => x.Id == id);

                    Column col = new Column { Name = _value, IsVisible = list.IsVisible, Order = list.Order };
                    var response = await Http.PutAsJsonAsync($"/api/Column/UpdateColumns/{id}", col);
                    await OnInitializedAsync();
                }


            }
            private async Task Hide(ChangeEventArgs e)  //bir takım bokluklar tezahür etmekte
            {
                isChecked = Convert.ToBoolean(e.Value);
                var get = await Http.GetFromJsonAsync<List<Column>>("/api/Column/GetAll");
                var oldRecord = get.FirstOrDefault(x => x.Id == id);

                Column column = new Column { IsVisible = isChecked, Order = oldRecord.Order, Name = oldRecord.Name };

                var result = await Http.PutAsJsonAsync<Column>($"/api/Column/UpdateRecord/{id}", column);
                var repsonse = result.StatusCode.ToString();
                await OnInitializedAsync();
            }


            private async Task ChangeColumnOrder(int? order, int id)
            {
                var list = await Http.GetFromJsonAsync<List<Column>>("/api/Column/GetAllColumns");
                var col1 = list.FirstOrDefault(x => x.Id == id);
                var col2 = list.FirstOrDefault(x => x.Order == order);

                Column column1 = new Column { Name = col1.Name, Order = col2.Order, IsVisible = col1.IsVisible };
                Column column2 = new Column { Name = col2.Name, Order = col1.Order, IsVisible = col2.IsVisible };


                var response2 = await Http.PutAsJsonAsync($"/api/Column/UpdateColumns/{col1.Id}", column1);

                var response = await Http.PutAsJsonAsync($"/api/Column/UpdateColumns/{col2.Id}", column2);
                response.StatusCode.ToString();
                response2.StatusCode.ToString();

                await OnInitializedAsync();
            }
            private async Task AddRecord()
            {
                var response = await Http.PostAsJsonAsync<Value>("/api/Column/AddValue", val);
                await OnInitializedAsync();


            }





        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591