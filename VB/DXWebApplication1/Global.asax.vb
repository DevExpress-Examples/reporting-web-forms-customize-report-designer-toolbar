Imports System
Imports System.IO
Imports System.Web
Imports DevExpress.XtraReports.Web

Namespace DXWebApplication1

    Public Class Global_asax
        Inherits HttpApplication

        Private Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
            Routing.RouteTable.Routes.MapPageRoute("defaultRoute", "", "~/Designer.aspx")
            DevExpress.XtraReports.Configuration.Settings.[Default].UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Expressions
            DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = SessionState.SessionStateBehavior.Default
            DevExpress.XtraReports.Web.QueryBuilder.Native.QueryBuilderBootstrapper.SessionState = SessionState.SessionStateBehavior.Default
            DevExpress.XtraReports.Web.ReportDesigner.Native.ReportDesignerBootstrapper.SessionState = SessionState.SessionStateBehavior.Default
            DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(New ReportStorageWebExtension1(Path.Combine(HttpRuntime.AppDomainAppPath, "Reports")))
            ASPxReportDesigner.StaticInitialize()
        End Sub
    End Class
End Namespace
