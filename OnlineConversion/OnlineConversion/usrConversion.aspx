<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usrConversion.aspx.cs" Inherits="OnlineConversion.usrConversion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmConverstion" runat="server">
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox id="txtInput" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button id="btnKmToMile" runat="server" Text="Km To Mile" OnClick="KmToMile" /> &nbsp;
        <asp:Button id="btnMileToKm" runat="server" Text="Mile To Km" OnClick="MileToKm" /> <br />
        <asp:Button id="btnCtoF" runat="server" Text="Cel To Far" OnClick="CeltoFar" /> &nbsp;
        <asp:Button id="btnFtoC" runat="server" Text="Far To Cel" OnClick="FartoCel" /> <br />
        <asp:Button id="btnKgToLbs" runat="server" Text="Kg To Lbs" OnClick="KgToLbs" /> &nbsp;
        <asp:Button id="btnLbsToKg" runat="server" Text="Lbs To Kg" OnClick="LbsToKg" /> 
        <br />
        <br />
        <asp:TextBox id="txtResult" runat="server" Text="Result: "></asp:TextBox>

    </form>
</body>
</html>
