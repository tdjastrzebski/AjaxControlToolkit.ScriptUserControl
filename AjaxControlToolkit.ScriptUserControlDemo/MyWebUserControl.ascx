<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MyWebUserControl.ascx.cs" Inherits="AjaxControlToolkit.ScriptUserControlDemo.MyWebUserControl" %>

<asp:Panel ID="Panel1" runat="server" Style="width: 300px; height: 200px; border: solid 1px black; padding: 2px;" EnableViewState="false">
    <asp:Panel ID="Panel2" runat="server" Style="background-color: Gray; color: White; text-align: center; padding: 2px; cursor: move;">
        drag me!
    </asp:Panel>
    <asp:Button ID="Button1" runat="server" Text="click me" OnClick="Button1_Click" /><br />
    <asp:Label ID="Label1" runat="server" /><br />
    <asp:Label ID="Label2" runat="server" />
</asp:Panel>
<ajaxToolkit:DragPanelExtender ID="DragPanelExtender1" runat="server" TargetControlID="Panel1" DragHandleID="Panel2" />
