<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Robs Web App</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:TextBox runat="server" TextMode="MultiLine"  Width="100%" Height="250px" MaxLength="918" ID="txtBoxMsg" OnTextChanged="txtBoxMsg_TextChanged"></asp:TextBox>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:Button ID="btnSendInformation" runat="server" Text="Send Information" OnClick="btnSendInformation_Click"  />  
        <asp:Button ID="btnNExtPage" runat="server" Text ="Next Page" OnClick="btnNExtPage_Click" />
               
    </form>
</body>
</html>
