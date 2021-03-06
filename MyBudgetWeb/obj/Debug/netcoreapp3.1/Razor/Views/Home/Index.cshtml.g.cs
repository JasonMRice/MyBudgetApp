#pragma checksum "C:\Users\jason\source\repos\MyBudgetWebApplication\MyBudgetWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b97c862d65ec51d5912a5f9c4756b761e028393d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\jason\source\repos\MyBudgetWebApplication\MyBudgetWeb\Views\_ViewImports.cshtml"
using MyBudgetWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jason\source\repos\MyBudgetWebApplication\MyBudgetWeb\Views\_ViewImports.cshtml"
using MyBudgetWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b97c862d65ec51d5912a5f9c4756b761e028393d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8626ef399da6dca616dbb9728ff5fd0ec03ad49", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBudgetWeb.ViewModel.ExpenseViewModel>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jason\source\repos\MyBudgetWebApplication\MyBudgetWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b97c862d65ec51d5912a5f9c4756b761e028393d3554", async() => {
                WriteLiteral(@"
    <style>
        /* The Modal (background) */
        .modal {
            display: none; /* Hidden by default */
            position: fixed; /* Stay in place */
            z-index: 1; /* Sit on top */
            padding-top: 100px; /* Location of the box */
            left: 0;
            top: 0;
            width: 100%; /* Full width */
            height: 100%; /* Full height */
            overflow: auto; /* Enable scroll if needed */
            background-color: rgb(0,0,0); /* Fallback color */
            background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
        }

        .modal-header {
            background-color: lightgrey;
            margin: auto;
            padding: 20px;
            border: 1px solid #888;
            width: 40%;
            height: auto;
        }

        .modal-body {
            background-color: white;
            margin: auto;
            padding: 20px;
            border: 1px solid #888;
            width: 40%;
          ");
                WriteLiteral(@"  height: auto;
        }

        .modal-footer {
            background-color: lightgrey;
            margin: auto;
            padding: 20px;
            border: 1px solid #888;
            width: 40%;
            height: auto;
        }

        .modalTitle {
            display: inline-block;
            text-align: left;
        }

        .close {
            color: #111;
            text-align: right;
            font-size: 28px;
            font-weight: bold;
            display: inline-block;
        }

            .close:hover,
            .close:focus {
                color: #000;
                text-decoration: none;
                cursor: pointer;
            }

        .myMargin {
            margin-bottom: 18px;
        }
    </style>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b97c862d65ec51d5912a5f9c4756b761e028393d6377", async() => {
                WriteLiteral(@"

    <div class=""text-center myMargin"">
        <h1 class=""display-4"">Welcome</h1>
        <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
    </div>

    <div id=""chartContainerLine"" class=""myMargin"" style=""height: 500px; width: 100%;"">

    </div>

    <div id=""chartContainerPie"" class=""myMargin"" style=""height: 370px; width: 100%;""></div>

    <table id=""example"" class=""display myMargin"" style=""width:100%"">
        <thead>
            <tr>
                <th></th>
                <th>Id</th>
                <th>Description</th>
                <th>Day</th>
                <th>Day Total</th>
                <th>Running Total</th>
                <th>Paycheck</th>
            </tr>
        </thead>
    </table>

    <div id=""myModal"" class=""modal"">
        <div class=""modal-header"">
            <h2>Edit This Expense</h2>
            <span class=""close"">&times;</span>
        </div>
        <div class=""modal-body"" st");
                WriteLiteral("yle=\"text-align:center;\">\r\n            <div style=\"display:none;\">\r\n                ");
#nullable restore
#line 112 "C:\Users\jason\source\repos\MyBudgetWebApplication\MyBudgetWeb\Views\Home\Index.cshtml"
           Write(Html.EditorFor(model => model.ExpenseIdForEdit));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <h5 style=\"display:inline-block;width:40%;\">Description</h5>\r\n                ");
#nullable restore
#line 116 "C:\Users\jason\source\repos\MyBudgetWebApplication\MyBudgetWeb\Views\Home\Index.cshtml"
           Write(Html.EditorFor(model => model.DescriptionForEdit, new { htmlAttrributes = new { @class = "form-control", @style = "display:inline-block;" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <h5 style=\"display:inline-block;width:40%;\">Price</h5>\r\n                ");
#nullable restore
#line 120 "C:\Users\jason\source\repos\MyBudgetWebApplication\MyBudgetWeb\Views\Home\Index.cshtml"
           Write(Html.EditorFor(model => model.PriceForEdit, new { htmlAttrributes = new { @class = "form-control", @style = "display:inline-block;" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <h5 style=\"display:inline-block;width:40%;\">Day of Month</h5>\r\n                ");
#nullable restore
#line 124 "C:\Users\jason\source\repos\MyBudgetWebApplication\MyBudgetWeb\Views\Home\Index.cshtml"
           Write(Html.EditorFor(model => model.DayOfMonthForEdit, new { htmlAttrributes = new { @class = "form-control", @style = "display:inline-block;" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"modal-footer\">\r\n            <button type=\"button\" class=\"btn btn-danger btn-sm\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4183, "\"", 4193, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <i class=\"fas fa-trash\"></i> Delete Expense\r\n            </button>\r\n            <button type=\"button\" class=\"btn btn-success btn-sm\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4345, "\"", 4355, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <i class=""far fa-save""></i> Save Changes
            </button>
        </div>

    </div>



    <script>
        $(document).ready(function () {
            $.ajax({
                type: ""Get"",
                dataType: ""json"",
                url: ""/Home/GetNextThreeMonths"",
                success: function (data) {
                    $(""#example"").DataTable({
                        data: data,
                        columns: [
                            {
                                'data': null,
                                'defaultContent': '',
                                'className': 'select-checkbox',
                                'orderable': false
                            },
                            { 'data': ""dailyListId"" },
                            { 'data': ""dailyDescription"" },
                            {
                                'data': ""day"",
                                'render': function (data) {
         ");
                WriteLiteral(@"                           return data.slice(0, -23);
                                }
                            },
                            { 'data': ""dayTotal"" },
                            { 'data': ""runningTotal"" },
                            { 'data': ""paycheck"" }
                        ],
                        select: {
                            style: 'os',
                            selector: 'td:first-child'
                        },
                        columnDefs: [
                            {
                                targets: [1],
                                visible: false,
                                searchable: false
                            }
                        ]
                    })
                    CreateMyCharts(data);
                }
            })
        });

        var myModal = document.getElementById('myModal');
        var span = document.getElementsByClassName(""close"")[0];

        function OpenModal(action");
                WriteLiteral(@") {
            myModal.style.display = ""block"";
            var expenseId = $(""#ExpenseIdForEdit"").val();
            if (action == ""Activate"") {
                $(""#activateMessage"").show();
                $(""#inactivateMessage"").hide();
            }
        }

        // When the user clicks on <span> (x), close the myModal
        span.onclick = function () {
            myModal.style.display = ""none"";
        }

        // When the user clicks anywhere outside of the myModal, close it
        window.onclick = function (event) {
            if (event.target == myModal) {
                myModal.style.display = ""none"";
            }
        }
    </script>

    <script>
        function CreateMyCharts(data) {
            var chart = new CanvasJS.Chart(""chartContainerLine"", {
                animationEnabled: true,
                zoomEnabled: true,
                theme: ""dark2"",
                title: {
                    text: ""Business Growth From 2000 to 2017""
         ");
                WriteLiteral(@"       },
                axisX: {
                    title: ""Year"",
                    valueFormatString: ""####"",
                    interval: 2
                },
                axisY: {
                    logarithmic: true, //change it to false
                    title: ""Profit in USD (Log)"",
                    prefix: ""$"",
                    titleFontColor: ""#6D78AD"",
                    lineColor: ""#6D78AD"",
                    gridThickness: 0,
                    lineThickness: 1,
                    //includeZero: false,
                    labelFormatter: addSymbols
                },
                axisY2: {
                    title: ""Profit in USD"",
                    prefix: ""$"",
                    titleFontColor: ""#51CDA0"",
                    logarithmic: false, //change it to true
                    lineColor: ""#51CDA0"",
                    gridThickness: 0,
                    lineThickness: 1,
                    labelFormatter: addSymbols
              ");
                WriteLiteral(@"  },
                legend: {
                    verticalAlign: ""top"",
                    fontSize: 16,
                    dockInsidePlotArea: true
                },
                data: [{
                    type: ""line"",
                    xValueFormatString: ""####"",
                    yValueFormatString: ""$#,##0.##"",
                    showInLegend: true,
                    name: ""Log Scale"",
                    dataPoints: [
                        { x: 2001, y: 8000 },
                        { x: 2002, y: 20000 },
                        { x: 2003, y: 40000 },
                        { x: 2004, y: 60000 },
                        { x: 2005, y: 90000 },
                        { x: 2006, y: 140000 },
                        { x: 2007, y: 200000 },
                        { x: 2008, y: 400000 },
                        { x: 2009, y: 600000 },
                        { x: 2010, y: 800000 },
                        { x: 2011, y: 900000 },
                        { x: 2012,");
                WriteLiteral(@" y: 1400000 },
                        { x: 2013, y: 2000000 },
                        { x: 2014, y: 4000000 },
                        { x: 2015, y: 6000000 },
                        { x: 2016, y: 8000000 },
                        { x: 2017, y: 9000000 }
                    ]
                },
                {
                    type: ""line"",
                    xValueFormatString: ""####"",
                    yValueFormatString: ""$#,##0.##"",
                    axisYType: ""secondary"",
                    showInLegend: true,
                    name: ""Linear Scale"",
                    dataPoints: [
                        { x: 2001, y: 8000 },
                        { x: 2002, y: 20000 },
                        { x: 2003, y: 40000 },
                        { x: 2004, y: 60000 },
                        { x: 2005, y: 90000 },
                        { x: 2006, y: 140000 },
                        { x: 2007, y: 200000 },
                        { x: 2008, y: 400000 },
         ");
                WriteLiteral(@"               { x: 2009, y: 600000 },
                        { x: 2010, y: 800000 },
                        { x: 2011, y: 900000 },
                        { x: 2012, y: 1400000 },
                        { x: 2013, y: 2000000 },
                        { x: 2014, y: 4000000 },
                        { x: 2015, y: 6000000 },
                        { x: 2016, y: 8000000 },
                        { x: 2017, y: 9000000 }
                    ]
                }]
            });

            chart.render();

            function addSymbols(e) {
                var suffixes = ["""", ""K"", ""M"", ""B""];

                var order = Math.max(Math.floor(Math.log(e.value) / Math.log(1000)), 0);
                if (order > suffixes.length - 1)
                    order = suffixes.length - 1;

                var suffix = suffixes[order];
                return CanvasJS.formatNumber(e.value / Math.pow(1000, order)) + suffix;
            }





            var options = {
                tit");
                WriteLiteral(@"le: {
                    text: ""Desktop OS Market Share in 2017""
                },
                subtitles: [{
                    text: ""As of November, 2017""
                }],
                animationEnabled: true,
                data: [{
                    type: ""pie"",
                    startAngle: 40,
                    toolTipContent: ""<b>{label}</b>: {y}%"",
                    showInLegend: ""true"",
                    legendText: ""{label}"",
                    indexLabelFontSize: 16,
                    indexLabel: ""{label} - {y}%"",
                    dataPoints: [
                        { y: 48.36, label: ""Windows 7"" },
                        { y: 26.85, label: ""Windows 10"" },
                        { y: 1.49, label: ""Windows 8"" },
                        { y: 6.98, label: ""Windows XP"" },
                        { y: 6.53, label: ""Windows 8.1"" },
                        { y: 2.45, label: ""Linux"" },
                        { y: 3.32, label: ""Mac OS X 10.12"" },
    ");
                WriteLiteral(@"                    { y: 4.03, label: ""Others"" }
                    ]
                }]
            };
            $(""#chartContainerPie"").CanvasJSChart(options);
        }

        window.onload = function () {
            //var chart = new CanvasJS.Chart(""chartContainerLine"", {
            //    animationEnabled: true,
            //    zoomEnabled: true,
            //    theme: ""dark2"",
            //    title: {
            //        text: ""Business Growth From 2000 to 2017""
            //    },
            //    axisX: {
            //        title: ""Year"",
            //        valueFormatString: ""####"",
            //        interval: 2
            //    },
            //    axisY: {
            //        logarithmic: true, //change it to false
            //        title: ""Profit in USD (Log)"",
            //        prefix: ""$"",
            //        titleFontColor: ""#6D78AD"",
            //        lineColor: ""#6D78AD"",
            //        gridThickness: 0,
            ");
                WriteLiteral(@"//        lineThickness: 1,
            //        //includeZero: false,
            //        labelFormatter: addSymbols
            //    },
            //    axisY2: {
            //        title: ""Profit in USD"",
            //        prefix: ""$"",
            //        titleFontColor: ""#51CDA0"",
            //        logarithmic: false, //change it to true
            //        lineColor: ""#51CDA0"",
            //        gridThickness: 0,
            //        lineThickness: 1,
            //        labelFormatter: addSymbols
            //    },
            //    legend: {
            //        verticalAlign: ""top"",
            //        fontSize: 16,
            //        dockInsidePlotArea: true
            //    },
            //    data: [{
            //        type: ""line"",
            //        xValueFormatString: ""####"",
            //        yValueFormatString: ""$#,##0.##"",
            //        showInLegend: true,
            //        name: ""Log Scale"",
            //  ");
                WriteLiteral(@"      dataPoints: [
            //            { x: 2001, y: 8000 },
            //            { x: 2002, y: 20000 },
            //            { x: 2003, y: 40000 },
            //            { x: 2004, y: 60000 },
            //            { x: 2005, y: 90000 },
            //            { x: 2006, y: 140000 },
            //            { x: 2007, y: 200000 },
            //            { x: 2008, y: 400000 },
            //            { x: 2009, y: 600000 },
            //            { x: 2010, y: 800000 },
            //            { x: 2011, y: 900000 },
            //            { x: 2012, y: 1400000 },
            //            { x: 2013, y: 2000000 },
            //            { x: 2014, y: 4000000 },
            //            { x: 2015, y: 6000000 },
            //            { x: 2016, y: 8000000 },
            //            { x: 2017, y: 9000000 }
            //        ]
            //    },
            //    {
            //        type: ""line"",
            //        xValueForm");
                WriteLiteral(@"atString: ""####"",
            //        yValueFormatString: ""$#,##0.##"",
            //        axisYType: ""secondary"",
            //        showInLegend: true,
            //        name: ""Linear Scale"",
            //        dataPoints: [
            //            { x: 2001, y: 8000 },
            //            { x: 2002, y: 20000 },
            //            { x: 2003, y: 40000 },
            //            { x: 2004, y: 60000 },
            //            { x: 2005, y: 90000 },
            //            { x: 2006, y: 140000 },
            //            { x: 2007, y: 200000 },
            //            { x: 2008, y: 400000 },
            //            { x: 2009, y: 600000 },
            //            { x: 2010, y: 800000 },
            //            { x: 2011, y: 900000 },
            //            { x: 2012, y: 1400000 },
            //            { x: 2013, y: 2000000 },
            //            { x: 2014, y: 4000000 },
            //            { x: 2015, y: 6000000 },
            //");
                WriteLiteral(@"            { x: 2016, y: 8000000 },
            //            { x: 2017, y: 9000000 }
            //        ]
            //    }]
            //});

            //chart.render();

            //function addSymbols(e) {
            //    var suffixes = ["""", ""K"", ""M"", ""B""];

            //    var order = Math.max(Math.floor(Math.log(e.value) / Math.log(1000)), 0);
            //    if (order > suffixes.length - 1)
            //        order = suffixes.length - 1;

            //    var suffix = suffixes[order];
            //    return CanvasJS.formatNumber(e.value / Math.pow(1000, order)) + suffix;
            //}





            //var options = {
            //    title: {
            //        text: ""Desktop OS Market Share in 2017""
            //    },
            //    subtitles: [{
            //        text: ""As of November, 2017""
            //    }],
            //    animationEnabled: true,
            //    data: [{
            //        type: ""pie"",
            /");
                WriteLiteral(@"/        startAngle: 40,
            //        toolTipContent: ""<b>{label}</b>: {y}%"",
            //        showInLegend: ""true"",
            //        legendText: ""{label}"",
            //        indexLabelFontSize: 16,
            //        indexLabel: ""{label} - {y}%"",
            //        dataPoints: [
            //            { y: 48.36, label: ""Windows 7"" },
            //            { y: 26.85, label: ""Windows 10"" },
            //            { y: 1.49, label: ""Windows 8"" },
            //            { y: 6.98, label: ""Windows XP"" },
            //            { y: 6.53, label: ""Windows 8.1"" },
            //            { y: 2.45, label: ""Linux"" },
            //            { y: 3.32, label: ""Mac OS X 10.12"" },
            //            { y: 4.03, label: ""Others"" }
            //        ]
            //    }]
            //};
            //$(""#chartContainerPie"").CanvasJSChart(options);
        }

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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBudgetWeb.ViewModel.ExpenseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
