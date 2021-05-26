## How to customize the Web Report Designer's toolbar

This example demonstrates how to use the client-side [CustomizeMenuActions](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientReportDesigner.CustomizeMenuActions) event to hide the existing **Validate Bindings** toolbar command and add a new **Refresh** command that refreshes the current report tab. 

To obtain the existing command, call the event argument's [GetById](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientCustomizeMenuActionsEventArgs.GetById(System.String)) method  and pass the command ID as a parameter. Then, disable the obtained command's **visible** property to hide it.

To add a new toolbar command, specify its settings and push it to the event argument's **Actions** collection. 

See the following documentation topics for more information:

* [Customize the Report Designer Toolbar (ASP.NET WebForms)](https://docs.devexpress.com/XtraReports/17626/create-end-user-reporting-applications/web-reporting/asp-net-webforms-reporting/end-user-report-designer/api-and-customization/customize-the-report-designer-toolbar)
* [Customize the Report Designer Toolbar (ASP.NET MVC)](https://docs.devexpress.com/XtraReports/400203/create-end-user-reporting-applications/web-reporting/asp-net-mvc-reporting/end-user-report-designer/api-and-customization/customize-the-report-designer-toolbar)
* [Customize the Report Designer Toolbar (ASP.NET Core)](https://docs.devexpress.com/XtraReports/400281/create-end-user-reporting-applications/web-reporting/asp-net-core-reporting/end-user-report-designer/api-and-customization/customize-the-report-designer-toolbar)
