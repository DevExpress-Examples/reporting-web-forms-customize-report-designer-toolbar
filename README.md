<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830474)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
## How to customize the Web Report Designer's toolbar

This example demonstrates how to use the client-side [CustomizeMenuActions](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientReportDesigner.CustomizeMenuActions?v=18.2) event to hide the existing **Validate Bindings** toolbar command and add a new **Refresh** command that refreshes the current report tab. 

To obtain the existing command, call the event argument's [GetById](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientCustomizeMenuActionsEventArgs.GetById(System.String)?v=18.2) method  and pass the command ID as a parameter. Then, disable the obtained command's **visible** property to hide it.

To add a new toolbar command, specify its [settings](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientMenuAction._members?v=18.2) and push it to the event argument's **Actions** collection. 

See the following documentation topics for more information:

* [Customize the Report Designer Toolbar (ASP.NET WebForms)](https://docs.devexpress.com/XtraReports/17626/create-end-user-reporting-applications/web-reporting/asp-net-webforms-reporting/end-user-report-designer/api-and-customization/customize-the-report-designer-toolbar?v=18.2)
* [Customize the Report Designer Toolbar (ASP.NET MVC)](https://docs.devexpress.com/XtraReports/400203/create-end-user-reporting-applications/web-reporting/asp-net-mvc-reporting/end-user-report-designer/api-and-customization/customize-the-report-designer-toolbar?v=18.2)
* [Customize the Report Designer Toolbar (ASP.NET Core)](https://docs.devexpress.com/XtraReports/400281/create-end-user-reporting-applications/web-reporting/asp-net-core-reporting/end-user-report-designer/api-and-customization/customize-the-report-designer-toolbar?v=18.2)
