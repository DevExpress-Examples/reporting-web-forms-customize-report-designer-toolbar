<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Designer.aspx.vb" Inherits="DXWebApplication1.Designer" %>

<%@ Register Assembly="DevExpress.XtraReports.v18.2.Web.WebForms, Version=18.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/html" id="refresh">
        <svg version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 24 24" style="enable-background: new 0 0 24 24;" xml:space="preserve">
            <path class="dxd-icon-fill" d="M22,2v8h-0.2h-3.09H14l2.94-2.94C15.68,5.79,13.93,5,12,5c-3.87,0-7,3.13-7,7H2C2,6.48,6.48,2,12,2
	c2.76,0,5.26,1.12,7.07,2.93L22,2z M12,19c-1.93,0-3.68-0.79-4.94-2.06L10,14H5.29H2.2H2v8l2.93-2.93C6.74,20.88,9.24,22,12,22
	c5.52,0,10-4.48,10-10h-3C19,15.87,15.87,19,12,19z" />
        </svg>
    </script>
    <script type="text/javascript">
        function customizeActions(s, e) {
            e.Actions.push({
                text: "Refresh",
                imageTemplateName: "refresh",
                visible: true,
                disabled: false,
                clickAction: function () {
                    reportDesigner.GetCurrentTab().refresh();
                }
            });
            var validateBindingsAction = e.GetById(DevExpress.Designer.Report.ActionId.ValidateBindings);
            if (validateBindingsAction)
                validateBindingsAction.visible = false;
        }
    </script>
    <dx:ASPxReportDesigner ID="ASPxReportDesigner1" ClientInstanceName="reportDesigner" runat="server">
        <ClientSideEvents CustomizeMenuActions="customizeActions" />
    </dx:ASPxReportDesigner>
</asp:Content>