﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>  
     <form id="form1" runat="server">  
     <div>  
         <table border="2" cellpadding="2" cellspacing="2">  
             <tr>  
                 <td align="right">  
                     <asp:Label ID="Label1" runat="server" Text="Enter 1st Number"></asp:Label>  
                 </td>  
                 <td align="left">  
                     <asp:TextBox ID="txtFno" runat="server"></asp:TextBox>  
                 </td>  
             </tr>  
             <tr>  
                 <td align="right">  
                     <asp:Label ID="Label2" runat="server" Text="Enter 2nd Number"></asp:Label>  
                 </td>  
                 <td align="left">  
                     <asp:TextBox ID="txtSno" runat="server"></asp:TextBox>  
                 </td>  
             </tr>  
             <tr>  
                 <td align="right">  
                     <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>  
                 </td>  
                 <td align="left">  
                     <asp:Label ID="lblResult" runat="server"></asp:Label>  
                 </td>  
             </tr>  
             <tr>  
                 <td align="center">  
                     <asp:Button ID="btnAdd" runat="server" Text="Add(+)" OnClick="btnAdd_Click" />  
                 </td>  
                 <td align="center">  
                     <asp:Button ID="btnSub" runat="server" Text="Sub(-)" OnClick="btnSub_Click" />  
                 </td>  
             </tr>  
             <tr>  
                 <td align="center">  
                     <asp:Button ID="BtnMul" runat="server" Text="Mul(*)" OnClick="BtnMul_Click" />  
                 </td>  
                 <td align="center">  
                     <asp:Button ID="btnDiv" runat="server" Text="Div(/)" OnClick="btnDiv_Click" />  
                 </td>  
             </tr> 
             <tr>  
                 <td align="center">  
                     <asp:Button ID="BtnFac" runat="server" Text="Fac(n!)" OnClick="BtnFac_Click" />  
                 </td>  
                 <td align="center">  
                     <asp:Button ID="BtnExp" runat="server" Text="Exp(^)" OnClick="btnExp_Click" style="height: 35px" />  
                 </td>  
             </tr> 
                

         </table>  
     </div>  
     </form>  
 </body>  
</html>
