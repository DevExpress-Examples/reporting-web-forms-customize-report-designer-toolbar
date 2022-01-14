Imports DevExpress.DataAccess.Sql
Imports System
Imports SqlDataSource = DevExpress.DataAccess.Sql.SqlDataSource

Namespace DXWebApplication1

    Public Partial Class Designer
        Inherits Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsPostBack Then BindToData()
        End Sub

        Private Sub BindToData()
            ' Create a SQL data source with the specified connection string.
            Dim ds As DevExpress.DataAccess.Sql.SqlDataSource = New DevExpress.DataAccess.Sql.SqlDataSource("NWindConnectionString")
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
