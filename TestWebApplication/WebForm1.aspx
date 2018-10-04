<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Robs Web App</title>
</head>
<body style="background-color:burlywood">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Table runat="server" Width="80%">
                    <asp:TableRow Width="100%">                        
                        <asp:TableCell Width="20%"><asp:Label runat="server" ID="lblFromAddress" Text="Your email address and password"></asp:Label></asp:TableCell><asp:TableCell Width="80%"><asp:TextBox runat="server"  ID="txtboxFromAddress"></asp:TextBox><asp:TextBox runat="server" ID="txtboxPassword"></asp:TextBox></asp:TableCell> 
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell Width="20%"><asp:Label runat="server" ID="lblToAddress" Text="Cell number to text:"></asp:Label></asp:TableCell><asp:TableCell Width="80%"><asp:TextBox runat="server" ID="txtboxCellNumber"></asp:TextBox> </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell Width="20%"><asp:Label runat="server" ID="lblCarrier" Text="Cell carrier:"></asp:Label></asp:TableCell><asp:TableCell><asp:DropDownList runat="server" ID="ddlCarrier"><asp:ListItem>U.S. Cellular</asp:ListItem><asp:ListItem>ATT</asp:ListItem><asp:ListItem>Verizon</asp:ListItem></asp:DropDownList></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell></asp:TableCell><asp:TableCell></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell></asp:TableCell><asp:TableCell></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>                                
                <br/>
                <asp:Label runat="server" ID="lblBody" Text="Body"></asp:Label>
                <br/>
                <asp:TextBox runat="server" TextMode="MultiLine"  Width="75%" Height="150px" MaxLength="918" ID="txtBoxMsg"></asp:TextBox>                
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:Button ID="btnSendInformation" runat="server" Text="Send Information" OnClick="btnSendInformation_Click"  />  
        <asp:Button ID="btnNExtPage" runat="server" Text ="Next Page" OnClick="btnNExtPage_Click" />    
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <br/>
                <asp:Label runat="server" ID="lblPreviousTexts" Text="Previous Texts:"></asp:Label>
                <br/>
                <asp:ListBox ID="lstboxPreviousTexts" runat="server" Width="25%"/>                
            </ContentTemplate>
        </asp:UpdatePanel>
      </form>
</body>
</html>
