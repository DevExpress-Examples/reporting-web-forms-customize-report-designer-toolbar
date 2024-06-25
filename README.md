<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/167317455/23.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830474)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for ASP.NET Web Forms - How to Customize the Web Report Designer Toolbar

This example demonstrates how to use the client-side [CustomizeMenuActions](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientReportDesigner.CustomizeMenuActions) event to hide the existing **Validate Bindings** toolbar command and add a new **Refresh** command that refreshes the current report tab. 

## Implementation Details

To obtain the existing command, call the event argument's [GetById](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientCustomizeMenuActionsEventArgs.GetById(System.String)) method  and pass the command ID as a parameter. Then, disable the obtained command's **visible** property to hide it.

To add a new toolbar command, specify its settings and push it to the event argument's **Actions** collection. 

## Documentation

* [Customize the Report Designer Toolbar (ASP.NET WebForms)](https://docs.devexpress.com/XtraReports/17626/create-end-user-reporting-applications/web-reporting/asp-net-webforms-reporting/end-user-report-designer/api-and-customization/customize-the-report-designer-toolbar)
* [Customize the Report Designer Toolbar (ASP.NET MVC)](https://docs.devexpress.com/XtraReports/400203/create-end-user-reporting-applications/web-reporting/asp-net-mvc-reporting/end-user-report-designer/api-and-customization/customize-the-report-designer-toolbar)
* [Customize the Report Designer Toolbar (ASP.NET Core)](https://docs.devexpress.com/XtraReports/400281/create-end-user-reporting-applications/web-reporting/asp-net-core-reporting/end-user-report-designer/api-and-customization/customize-the-report-designer-toolbar)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-forms-customize-report-designer-toolbar&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-forms-customize-report-designer-toolbar&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
