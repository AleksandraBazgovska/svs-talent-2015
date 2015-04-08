﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowEmployee.aspx.cs" Inherits="ShowEmployeeSite.ShowEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<form id="form1" runat="server">
      <h2>
        Welcome to Sale Service</h2><table class="style1">
            <tr>
                <td style="text-align: right">
                    Enter First Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" 
                    runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Last Name</td>
                <td>
                    <asp:TextBox ID="TextBox2" 
                    runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Age</td>
                <td>
                    <asp:TextBox ID="TextBox3" 
                    runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" 
                    onclick="Button1_Click" Text="Save" />
                </td>
            </tr>
        </table>
    
<p>
        <asp:GridView ID="GridView1" runat="server" 
        AllowPaging="True"  DataKeyNames="EmployeeID"
            AllowSorting="True" AutoGenerateDeleteButton="True" 
            onrowdeleting="GridView1_RowDeleting">
        </asp:GridView>
</p>
    <p>
        <asp:Label ID="Label1" runat="server" 
        Text="Label"></asp:Label>
    </form>
</html>
