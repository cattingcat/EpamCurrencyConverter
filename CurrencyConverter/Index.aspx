<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CurrencyConverter.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div> 
            Source: 
            <asp:DropDownList ID="srcCurrency" runat="server" AutoPostBack="true" />
            <asp:TextBox ID="srcCourse" runat="server" />
        </div>
        <asp:TextBox ID="srcSum" runat="server" />
        <div> 
            Dest: 
            <asp:DropDownList ID="destCurrency" runat="server" AutoPostBack="true" />
            <asp:TextBox ID="destCourse" runat="server" />
        </div>
        <asp:Button ID="calc" runat="server" Text="Calculate" OnClick="calc_Click" />
        <asp:Label ID="resultString" runat="server" />

    </div>
    </form>
</body>
</html>
