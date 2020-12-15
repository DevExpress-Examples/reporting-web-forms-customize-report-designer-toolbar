using DevExpress.DataAccess.Sql;
using System;
using SqlDataSource = DevExpress.DataAccess.Sql.SqlDataSource;

namespace DXWebApplication1
{
    public partial class Designer : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(!IsPostBack) 
                BindToData();
        }

        void BindToData() {
            // Create a SQL data source with the specified connection string.
            SqlDataSource ds = new SqlDataSource("NWindConnectionString");

            // Create a SQL query to access the Products data table.
            SelectQuery query = SelectQueryFluentBuilder.AddTable("Products").SelectAllColumnsFromTable().Build("Products");
            ds.Queries.Add(query);
            ds.RebuildResultSchema();

            // Add the created data source to the list of default data sources. 
            ASPxReportDesigner1.DataSources.Add("Northwind", ds);
            ASPxReportDesigner1.OpenReport("Report");
        }
    }
}