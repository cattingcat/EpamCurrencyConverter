<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlTest.aspx.cs" Inherits="CurrencyConverter.ControlTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ctrl:TextWithCaptionControl runat="server"  DefaultText="100" TextCaption="Сумма" CaptionPosition="Left" Separator=":"/>
        <input type="submit" name="qwe" value="qwe" /> 
    </div>
    </form>
</body>
</html>
