#pragma checksum "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3594c289277fe2eeeffdc54f928469f63e9cb160"
// <auto-generated/>
#pragma warning disable 1591
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
using Entities.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class TableDesign : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "table");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-12");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", "document.getElementById(\'form\').scrollIntoView({behavior:\'smooth\'})");
            __builder.AddAttribute(9, "onfocus", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                                             ()=>New()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "class", "btn btn-info m-1 p-1");
            __builder.AddContent(11, "New");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n             ");
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table");
            __builder.OpenElement(15, "thead");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "<th>Commands</th>\r\n\r\n                        ");
            __builder.AddMarkupContent(18, "<th>ID</th>");
#nullable restore
#line 19 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                         foreach (var item in columns)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "th");
            __builder.AddAttribute(20, "scope", "col");
#nullable restore
#line 21 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
__builder.AddContent(21, item.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "             \r\n                        ");
            __builder.OpenElement(23, "tbody");
#nullable restore
#line 27 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                      
                        var columnValues = new Dictionary<int, List<string>>();
                       
                        foreach (var value in tableview.Select(x => x._values).Where(val => columns.Any(col => col.Id == val.ColumnId)).ToList())
                        {
                                    if (columnValues.ContainsKey(value.ColumnId))
                                    {
                                        columnValues[value.ColumnId].Add(value.Value1);
                                    }
                                    else
                                    {
                                        columnValues.Add(value.ColumnId, new List<string> { value.Value1 });
                                    }
                        }
                     

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                       for (int i = 0; i <= tableview.Select(x => x._values).Count(); i++)
                    {
                        int colindex = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "tr");
#nullable restore
#line 47 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                if(number_of_vertical_records.Count()>i)
                               {
                                        int _index = i;
                                        int uniqueId = tableview[_index]._values.Id + 5;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "td");
            __builder.AddAttribute(26, "class", " row btn-group-sm");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "onclick", "document.getElementById(\'form\').scrollIntoView({behavior:\'smooth\'})");
            __builder.AddAttribute(29, "class", "row btn-group-sm");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                                                                                                 ()=>isUpdate(number_of_vertical_records[_index])

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "class", " btn btn-outline-info");
            __builder.AddContent(33, "Update");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                        ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "class", "m-0 row btn-group-sm");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                      ()=>DeleteValue(number_of_vertical_records[_index])

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "class", " btn btn-outline-danger");
            __builder.AddContent(40, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                        ");
            __builder.OpenElement(42, "td");
#nullable restore
#line 55 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
__builder.AddContent(43, uniqueId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                               }
                               else
                               {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "<td class=\"row\" hidden><a class=\"btn btn-outline-info\">Update</a> <a class=\"btn btn-outline-primary\">Delete</a></td>");
#nullable restore
#line 60 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                     foreach (var column in columns)
                                    {
                                             
                                        if (columnValues.ContainsKey(column.Id) && columnValues[column.Id].Count > colindex)
                                        {
                                  

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "td");
#nullable restore
#line 67 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
__builder.AddContent(46, columnValues[column.Id][colindex]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "<td hidden>N/A</td>");
#nullable restore
#line 72 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "row m-0 p-0");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col-md-12");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "container");
            __builder.AddMarkupContent(55, "<h4 class=\"text-info  card-header\">Table Design</h4>\r\n            ");
            __builder.OpenElement(56, "ul");
            __builder.AddAttribute(57, "class", "list-group");
#nullable restore
#line 89 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                 for (int i = 0; i < allColumns.Count; i++)
                {
                    int _index = i;
                    


#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "li");
            __builder.AddAttribute(59, "class", "list-group-horizontal");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "class", "btn btn-outline-danger m-1 p-1");
            __builder.AddAttribute(62, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                     ()=>DeleteColumn(allColumns[_index].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(63, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\r\n                            ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "placeholder", 
#nullable restore
#line 97 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                 allColumns[_index].Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(67, "id", 
#nullable restore
#line 97 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                               allColumns[_index].Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(68, "type", "text");
            __builder.AddAttribute(69, "onkeydown", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 97 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                                                                             UpdateColumn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                                                                                                     ()=>GetId(allColumns[_index].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 97 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                                                         _value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _value = __value, _value));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 98 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                         if (allColumns[_index].IsVisible == true)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(73, "input");
            __builder.AddAttribute(74, "type", "checkbox");
            __builder.AddAttribute(75, "checked", "checked");
            __builder.AddAttribute(76, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 100 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                       ()=>GetId(allColumns[_index].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "class", "m-1 p-1");
            __builder.AddAttribute(78, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 100 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                                                                                    Hide

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddContent(79, " ");
            __builder.AddMarkupContent(80, "<label>Visible</label>");
#nullable restore
#line 101 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                         if (allColumns[_index].IsVisible == false)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "type", "checkbox");
            __builder.AddAttribute(83, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 105 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                     ()=>GetId(allColumns[_index].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "class", "m-1 p-1");
            __builder.AddAttribute(85, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 105 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                                                                  Hide

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddContent(86, " ");
            __builder.AddMarkupContent(87, "<label>Visible</label>");
#nullable restore
#line 106 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                         if (_index != 0)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(88, "button");
            __builder.AddAttribute(89, "class", "btn btn-outline-info p-1 m-1");
            __builder.AddAttribute(90, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                           ()=>ChangeColumnOrder(allColumns[_index-1].Order,allColumns[_index].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(91, "Up");
            __builder.CloseElement();
#nullable restore
#line 111 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                         if (_index != allColumns.Count - 1)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(92, "button");
            __builder.AddAttribute(93, "class", "btn btn-outline-info p-1 m-1");
            __builder.AddAttribute(94, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 114 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                           ()=>ChangeColumnOrder(allColumns[_index+1].Order,allColumns[_index].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(95, "Down");
            __builder.CloseElement();
#nullable restore
#line 115 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 117 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n        ");
            __builder.AddMarkupContent(97, "<label class=\"col-form-label m-1 p-1\">Column Name :</label>\r\n        ");
            __builder.OpenElement(98, "input");
            __builder.AddAttribute(99, "type", "text");
            __builder.AddAttribute(100, "placeholder", "New Column");
            __builder.AddAttribute(101, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 122 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                  columnName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => columnName = __value, columnName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n            ");
            __builder.OpenElement(104, "button");
            __builder.AddAttribute(105, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 123 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                              AddNewColumn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(106, "class", "btn btn-danger m-1 p-1");
            __builder.AddContent(107, "Add");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n\r\n");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "row m-0 p-0");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "col-md-12");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "container");
            __builder.AddMarkupContent(115, "<h4 class=\"text-info card-header\">Form View</h4>\r\n              ");
            __builder.OpenElement(116, "form");
            __builder.AddAttribute(117, "id", "form");
            __builder.AddAttribute(118, "method", "post");
            __builder.AddAttribute(119, "onsubmit", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.EventArgs>(this, 
#nullable restore
#line 133 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                       HandleValidSubmit

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 135 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                 for (int i=0;i<columns.Count;i++)
                {
                    int index = i;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                     if(_updateClicked)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(120, "label");
            __builder.AddAttribute(121, "class", "col-form-label");
            __builder.AddAttribute(122, "for", "Name");
#nullable restore
#line 140 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
__builder.AddContent(123, columns[i].Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                      ");
            __builder.OpenElement(125, "input");
            __builder.AddAttribute(126, "value", 
#nullable restore
#line 141 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                     values_to_update[index]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(127, "class", "input-group-text");
            __builder.AddAttribute(128, "type", "text");
            __builder.AddAttribute(129, "name", "Value1");
            __builder.AddAttribute(130, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 141 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                                                             ()=>SaveAll(columns[index].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(131, "oninput", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 141 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                                                                                                       OnInputEvent

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 142 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                    }
                    else 
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(132, "label");
            __builder.AddAttribute(133, "class", "col-form-label");
            __builder.AddAttribute(134, "for", "Name");
#nullable restore
#line 145 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
__builder.AddContent(135, columns[i].Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                         ");
            __builder.OpenElement(137, "input");
            __builder.AddAttribute(138, "class", "input-group-text");
            __builder.AddAttribute(139, "type", "text");
            __builder.AddAttribute(140, "name", "Value1");
            __builder.AddAttribute(141, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 146 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                               ()=>SaveAll(columns[index].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(142, "oninput", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 146 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                                                                                                                                         OnInputEvent

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 147 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(143, "<button class=\"btn btn-outline-danger m-2 align-self-center\" type=\"submit\" value=\"submit\" onclick=\"document.getElementById(\'table\').scrollIntoView({behavior:\'smooth\'})\">Save</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n\r\n\r\n");
            __builder.OpenElement(145, "div");
            __builder.AddAttribute(146, "class", "row m-0 p-0");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "col-md-12");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "class", "container ");
            __builder.AddMarkupContent(151, "<h4 class=\"text-info card-header\">System Logs</h4>\r\n            ");
            __builder.OpenElement(152, "ul");
            __builder.AddAttribute(153, "class", "list-group");
#nullable restore
#line 165 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                 foreach (var item in Logs)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(154, "li");
#nullable restore
#line 167 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
__builder.AddContent(155, item);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 168 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 179 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
       
    private bool isChecked = false;
    private string columnName;
    private int id;
    private string _value { get; set; }
    string recordId ="";
    private string inputValue;
    public Value val = new Value();
    private int colId;
    // private ElementReference formRef;
    string recordID;
    private bool _updateClicked;
    List<Column> columns = new List<Column>();
    List<Column> allColumns = new List<Column>();
    List<string> Logs = new List<string>();
    List<TableView> tableview = new List<TableView>();
    List<Value> inputValues = new List<Value>();
    List<string> number_of_vertical_records = new List<string>();
    List<string> values_to_update = new List<string>();

    private void isUpdate(string recordId)
    {
        recordID = recordId;
        values_to_update=tableview.Where(x => x._values.RecordId == recordId).Select(x => x._values.Value1).ToList();
        _updateClicked=true;
    }

    protected void GetColId(int value)
    {
        colId = value;

    }

    protected void GetId(int value)
    {
        id = value;
    }

    protected async void New()
    {
        await OnInitializedAsync();
        await InvokeAsync(StateHasChanged);  
    }

    protected void SaveAll(int value)
    {
        Value val = new Value();
        colId = value;

        if(inputValue.Length>0&&inputValues.Where(x=>x.Value1==inputValue).Count()==0)
        {
            val.Value1 = inputValue;
            val.ColumnId = colId;
            if(_updateClicked==true)
            {
                var _id = tableview.Where(x => x._values.ColumnId == colId && x._values.RecordId == recordID).First()._values.Id;
                val.Id = _id;
            }
            else
            inputValues.Add(val);
        }


    }

    protected override async Task OnInitializedAsync()
    {
        columns = await Http.GetFromJsonAsync<List<Column>>("/api/Column/GetAllColumns");
        allColumns = await Http.GetFromJsonAsync<List<Column>>("/api/Column/GetAll");
        Logs = await Http.GetFromJsonAsync<List<string>>("api/SystemLog/GetAllLogs");
        tableview = await Http.GetFromJsonAsync<List<TableView>>("api/Column/TableView");
        int takelast = tableview.Select(x => x._values.ColumnId).First();
        number_of_vertical_records = tableview.Where(x => x._values.ColumnId == takelast).Select(x=>x._values.RecordId.ToString()).ToList();//column silinip de silinen columna ait valuelar kalırsa sıkıntı çıkabilir
        _updateClicked = false;
       
    }

    private void OnInputEvent(ChangeEventArgs changeEvent)
    {
        inputValue = (string)changeEvent.Value;
    }

    private async void HandleValidSubmit()
    { 
        recordId = Guid.NewGuid().ToString();
       
        if(_updateClicked)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 267 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
             for (int i = 0; i <inputValues.Count ; i++)
            {
                int inx = i;
                var oldRecord = await Http.GetFromJsonAsync<List<Value>>("/api/Value/GetAll");
                Value Values = new Value { RecordId =recordID, Value1 = inputValues[inx].Value1, ColumnId = inputValues[inx].ColumnId };
                var response = await Http.PutAsJsonAsync($"/api/Value/Update/{inputValues[inx].Id}", Values);
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 273 "C:\Users\Emel\Desktop\Application\Application\Client\Pages\TableDesign.razor"
             
            await OnInitializedAsync();
        }

        else
        {
            foreach (var item in inputValues)
            {
                Value Values = new Value { RecordId = recordId, Value1 = item.Value1, ColumnId = item.ColumnId };
                var response = await Http.PostAsJsonAsync<Value>("/api/Value/AddValue", Values);
                response.StatusCode.ToString();
            }

        }
        await InvokeAsync(StateHasChanged);  

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

    private async Task Hide(ChangeEventArgs e)
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

    private async Task DeleteValue(string recordId)
    {
        var record = tableview.Where(x => x._values.RecordId == recordId).Select(x => x._values.Id).ToList();
        foreach (var item in record)
        {
            var response = await Http.DeleteAsync("/api/Value/Delete/" + item);
             response.StatusCode.ToString();
        }
        await OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
