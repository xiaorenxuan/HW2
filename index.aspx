<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <label for = "Wage">Hourly Wage</label>
        <asp:TextBox ID="HourWageTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <label for = "hours">No. of hours work this week</label>
        <asp:TextBox ID="NoOfHoursTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <label for = "preTax">Pre-tax deduction</label>
        <asp:TextBox ID="PreTaxTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <label for = "afterTax">After tax deduction</label>
        <asp:TextBox ID="AfterTaxTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Calculate" />

        <asp:Button ID="Button2" runat="server" Text="Clear" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
