#pragma checksum "C:\Users\minditsys\source\repos\WebAppl-todo\WebAppl-todo\Views\Home\Task.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2912b947b285580c56e43161841b808e5cc4ccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Task), @"mvc.1.0.view", @"/Views/Home/Task.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\minditsys\source\repos\WebAppl-todo\WebAppl-todo\Views\_ViewImports.cshtml"
using WebAppl_todo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\minditsys\source\repos\WebAppl-todo\WebAppl-todo\Views\_ViewImports.cshtml"
using WebAppl_todo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2912b947b285580c56e43161841b808e5cc4ccd", @"/Views/Home/Task.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f51cec7a5f7a5f9e1e09c3af2c5b7011189716", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Task : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAppl_todo.Models.List>>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2912b947b285580c56e43161841b808e5cc4ccd3654", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <!-- Bootstrap CSS -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <script defer src=""https://use.fontawesome.com/releases/v5.15.4/js/all.js"" integrity=""sha384-rOA1PnstxnOBLzCLMcre8ybwbTmemjzdNlILg8O7z1lUkLXozs4DHonlDtnE7fpc"" crossorigin=""anonymous""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2912b947b285580c56e43161841b808e5cc4ccd5220", async() => {
                WriteLiteral(@"
    <br />
    <br />


    <!-- Button trigger modal -->
    <button type=""button"" id=""addbtn"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#staticBackdrop"">
        Add Task
    </button>

    <!-- Modal -->
    <div class=""modal fade"" id=""staticBackdrop"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""staticBackdropLabel"">Task</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2912b947b285580c56e43161841b808e5cc4ccd6332", async() => {
                    WriteLiteral(@"
                        <div class=""form-group"">
                            <label for=""exampleFormControlInput1"" >Title</label>
                            <input type=""email"" class=""form-control""  placeholder=""Title"" id=""addTaskI"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleFormControlInput1"" >Time Spend</label>
                            <input type=""email"" class=""form-control"" id=""addTime"" placeholder=""TimeSpend in Hr`s"">
                        </div>

                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"" id=""added"">Add</button>
                </div>
            </div>
        </div>
    </div>





    <button type=""button"" id=""Delete"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#staticBackdrop1"">
        Delete All
    </button>

    <!-- Modal -->
    <div class=""modal fade"" id=""staticBackdrop1"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""staticBackdropLabel"">Delete All</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
 ");
                WriteLiteral(@"               </div>
                <div class=""modal-body"">
                    Sure want to Delete All .?
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">No</button>
                    <button type=""button"" class=""btn btn-primary"" id=""dltall"">Yes</button>
                </div>
            </div>
        </div>
    </div>
    <table id=""t01"" class=""table table-bordered"">
        <thead>
            <tr>
                <th scope=""col"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2912b947b285580c56e43161841b808e5cc4ccd9952", async() => {
                    WriteLiteral(@"
                        <ul>
                            <li class=""list-inline-item"">Select All </li>
                            <li class=""list-inline-item"">
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox""");
                    BeginWriteAttribute("value", " value=\"", 4021, "\"", 4029, 0);
                    EndWriteAttribute();
                    WriteLiteral(" id=\"select-all\">\r\n                                </div>\r\n\r\n                            </li>\r\n                        </ul>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </th>

                <th scope=""col"">Id</th>
                <th scope=""col"">Title</th>
                <th scope=""col"">TimeSpend</th>
                <th scope=""col"">CreatedAt</th>
                <th scope=""col"">Actions</th>
            </tr>
        </thead>
");
#nullable restore
#line 105 "C:\Users\minditsys\source\repos\WebAppl-todo\WebAppl-todo\Views\Home\Task.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <th scope=\"row\">\r\n                    <div class=\"form-check\">\r\n                        <input class=\"form-check-input\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 4693, "\"", 4701, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"vehicle\" id=\"flexCheckDefault1\">\r\n                    </div>\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 114 "C:\Users\minditsys\source\repos\WebAppl-todo\WebAppl-todo\Views\Home\Task.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 117 "C:\Users\minditsys\source\repos\WebAppl-todo\WebAppl-todo\Views\Home\Task.cshtml"
               Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 120 "C:\Users\minditsys\source\repos\WebAppl-todo\WebAppl-todo\Views\Home\Task.cshtml"
               Write(Html.DisplayFor(modelItem => item.time_spend));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 123 "C:\Users\minditsys\source\repos\WebAppl-todo\WebAppl-todo\Views\Home\Task.cshtml"
               Write(Html.DisplayFor(modelItem => item.created_at));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </td>
                <td>
                   
                        <li class=""list-inline-item"">
                            <button class=""btn btn-success btn-sm rounded-0"" data-bs-toggle=""modal"" data-bs-target=""#staticBackdrop2"" type=""button"" data-toggle=""tooltip"" data-placement=""top"" title=""Edit"" id=""editbtn"" ><i class=""fa fa-edit""></i></button>
                            <div class=""modal fade"" id=""staticBackdrop2"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel2"" aria-hidden=""true"">
                                <div class=""modal-dialog"">
                                    <div class=""modal-content"">
                                        <div class=""modal-header"">
                                            <h5 class=""modal-title"" id=""staticBackdropLabel2"">Edit Data</h5>
                                            <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
       ");
                WriteLiteral("                                 </div>\r\n                                        <div class=\"modal-body\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2912b947b285580c56e43161841b808e5cc4ccd15461", async() => {
                    WriteLiteral(@"
                                                <div class=""form-group"">
                                                    <label for=""exampleFormControlInput1"" >Title</label>
                                                    <input type=""email"" class=""form-control"" id=""edit-title"" placeholder=""Title"">
                                                </div>
                                                <div class=""form-group"">
                                                    <label for=""exampleFormControlInput1"" >Time Spend</label>
                                                    <input type=""email"" class=""form-control"" id=""edit-time"" placeholder=""TimeSpend in Hr`s"">
                                                </div>

                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <div class=""modal-footer"">
                                            <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                                            <button type=""button"" class=""btn btn-primary"" id=""updatebtn"">Edit</button>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        
                        </li>
                    
                   
                        <li class=""list-inline-item"">
                            <button id=""deletebtn"" class=""btn btn-danger btn-sm rounded-0"" type=""button"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete""><i class=""fa fa-trash""></i></button>
                        </li>
                    
                </td>
            </tr>
");
#nullable restore
#line 167 "C:\Users\minditsys\source\repos\WebAppl-todo\WebAppl-todo\Views\Home\Task.cshtml"



        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </table>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" crossorigin=""anonymous""></script>
    <script>
        document.getElementById('select-all').onclick = function () {
            var checkboxes = document.getElementsByName('vehicle');
            for (var checkbox of checkboxes) {
                checkbox.checked = this.checked;
            }
        }</script>


    <script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>
    <script type=""text/javascript"" src=""https://ajax.cdnjs.com/ajax/libs/json2/20110223/json2.js""></script>
    <script>

        
        $(document).on('click', '#dltall', function () {




            
            $.ajax({
                type: ""GET"",
                url: '/Home/DeleteAll',
                dataType: ""json"",
                contentType: ""application/jso");
                WriteLiteral(@"n"",
                success: function () {
                    alert(""ALL data Deleted"");
                    window.location.reload();



                },
                error: function () {
                    alert(""Error while Deleting data"");
                }
            })
        });
     



        $(document).on('click', '#deletebtn', function () {
            


            var data = { id: $(this).closest('tr').children()[1].innerText }
            console.log(data);



            $.ajax({
                type: ""GET"",
                data: data,
                url: '/Home/Delete',
                dataType: ""json"",
                contentType: ""application/json"",
                success: function () {
                   
                    window.location.reload();
                    alert(""Deleted Successfully"");


                },
                error: function () {
                    alert(""Error while deleting data"");
                }
     ");
                WriteLiteral(@"       })
        });

        $(document).on('click', '#editbtn', function () {
        
            document.getElementById('edit-title').value = $(this).closest('tr').children()[2].innerText;
            document.getElementById('edit-time').value = $(this).closest('tr').children()[3].innerText;
           
            
           
            var id = $(this).closest('tr').children()[1].innerText;
            $(document).on('click', '#updatebtn', function () {
                alert('updated successfully');
                
                var data = { id, title: $(""#edit-title"").val(), time_spend: $(""#edit-time"").val() }
                $.ajax({
                    type: ""POST"",
                    data: data,
                    url: '/Home/Update',
                    datatype: ""json"",
                    contenttype: ""application/json"",
                    success: function () {
                        window.location.reload();
                    },
                    error: fu");
                WriteLiteral(@"nction () {
                        alert(""error while editing data...."");
                    }
                })
            });
        });


        $(document).on('click', '#added', function () {
            var data = { title: $(""#addTaskI"").val(), time_spend: $(""#addTime"").val() }
            $.ajax({
                type: ""POST"",
                data: data,
                url: '/Home/Insert',
                datatype: ""json"",
                contenttype: ""application/json"",
                success: function () {
                    alert(""Added Successfully"")
                    window.location.reload();
                },
                error: function () {
                    alert(""error while inserting data...."");
                }
            });

        });



    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAppl_todo.Models.List>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
