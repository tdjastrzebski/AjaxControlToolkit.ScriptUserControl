<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AjaxControlToolkit.ScriptUserControlDemo.Default" %>
<%@ Register Src="MyWebUserControl.ascx" TagName="MyWebUserControl" TagPrefix="uc1" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        
        <div style="width:100%; height:600px;">
        
        <asp:UpdatePanel runat="server" ID="UpdatePanel1" UpdateMode="Always" >
        <ContentTemplate>
            <uc1:MyWebUserControl id="MyWebUserControl1" runat="server" />
        </ContentTemplate>
        </asp:UpdatePanel>
        
        </div>
    </form>
</body>
</html>