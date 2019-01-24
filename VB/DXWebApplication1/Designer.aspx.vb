Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.DataAccess.Sql
Imports SqlDataSource = DevExpress.DataAccess.Sql.SqlDataSource

Namespace DXWebApplication1
    Partial Public Class Designer
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsPostBack Then
                BindToData()
            End If
        End Sub

        Private Sub BindToData()
            ' Create a SQL data source with the specified connection string.
            Dim ds As New SqlDataSource("NWindConnectionString")

            ' Create a SQL query to access the Products data table.
            Dim query As SelectQuery = SelectQueryFluentBuilder.AddTable("Products").SelectAllColumnsFromTable().Build("Products")
            ds.Queries.Add(query)
            ds.RebuildResultSchema()

            ' Add the created data source to the list of default data sources. 
            ASPxReportDesigner1.DataSources.Add("Northwind", ds)
            ASPxReportDesigner1.OpenReport("Report")
        End Sub
    End Class
End Namespace