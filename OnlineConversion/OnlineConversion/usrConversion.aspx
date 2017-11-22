<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usrConversion.aspx.cs" Inherits="OnlineConversion.usrConversion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Conversion</title>
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <style>
		html, body {
			height: 100%;
}
		body {
			background-image: url(img/bg.jpeg);
			background-size: auto;
			background-position: center;
}
		@font-face {
			font-family: workSans;
			src: url(font/WorkSans-ExtraLight.ttf);
		}
		ul li a {
			font-size: 17px;
			font-family: "workSans";
			color: rgb(255, 255, 255);
			font-weight: bold;  
		}
		
		ul li a:hover {
			color: #443020;
		}
		
		.form-row button { 
			font-size: 17px;  
			font-family: "workSans";
			font-weight: bold;
		}
		
		h1, p, input {
			font-family: 'workSans';
		}
		input {
			font-weight: bold;
		}	
        form {
                display: inline-block;
                text-align: center;
            }
	</style>
</head>
<body>
    <form id="frmConverstion" runat="server">
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2">
                    <asp:Label ID="lblIntro" runat="server" Text="       "></asp:Label> &nbsp; <asp:TextBox id="txtInput" runat="server" Text="Enter the converstion value:"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button id="btnKmToMile" runat="server" Text="Km To Ml" OnClick="KmToMile" /> &nbsp;
                <%--</asp:TableCell>
                <asp:TableCell>--%>
                    <asp:Button id="btnMileToKm" runat="server" Text="Ml To Km" OnClick="MileToKm" /> 
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button id="btnCtoF" runat="server" Text="Cel To Far" OnClick="CeltoFar" />  &nbsp;
                <%--</asp:TableCell>
                <asp:TableCell>--%>
                    <asp:Button id="btnFtoC" runat="server" Text="Far To Cel" OnClick="FartoCel" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button id="btnKgToLbs" runat="server" Text="Kg To Lbs" OnClick="KgToLbs" />  &nbsp;
                <%--</asp:TableCell>
                <asp:TableCell>--%>
                    <asp:Button id="btnLbsToKg" runat="server" Text="Lbs To Kg" OnClick="LbsToKg" /> 
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2">
                    <asp:Label ID="lblBlank" runat="server" Text="             "></asp:Label> &nbsp; 
                    <asp:TextBox id="txtResult" runat="server" Text="Result: "></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>

    </form>
</body>
</html>
