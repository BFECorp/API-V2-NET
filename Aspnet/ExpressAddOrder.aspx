<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExpressAddOrder.aspx.cs" Inherits="Chukou1Demo.Aspnet.ExpressAddOrder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>ExpressAddOrder Sample</title>
    <style type="text/css">
        .style1
        {
            height: 30px;
        }
        .style2
        {
            width: 400px;
            height: 22px;
        }
        .style3
        {
            height: 23px;
        }
        .style4
        {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="Form1" runat="server">
        <div style="text-align:center;">
            <b>ExpressAddOrder Sample</b>
		</div>
		<br />

        <asp:Panel ID="pnlRequest" style="text-align:center;" runat="server">
		    <div>
                <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" Text="下单" 
                    Width="40px" />
		    </div>            
            <br />
		    <div>
                <a href="Cell.aspx" style="text-align: right">返回接口目录</a>
		    </div>            
        </asp:Panel>
        <asp:Panel ID="pnlResponse" runat="server">
		    <table align="center">
			    <tr align="right">
				    <td>Response</td>
			    </tr>
		    </table>
		    <table align="center" style="font-size: small">
			    <tr>
				    <td width="200" class="style3">Ack</td>
				    <td class="style2">
					    <asp:Label ID="lblAck" runat="server" Text=" "></asp:Label>
				    </td>
			    </tr>
			    <tr>
				    <td width="200" class="style3">InvocationID</td>
				    <td class="style2">
					    <asp:Label ID="lblInvocationID" runat="server" Text=" "></asp:Label></td>
			    </tr>
			    <tr>
				    <td width="200" class="style3">Message</td>
				    <td class="style2">
					    <asp:Label ID="lblMessage" runat="server" Text=" "></asp:Label></td>
			    </tr>
		        <tr>
                    <td class="style3" width="200">OrderSign</td>
                    <td class="style2">
                        <asp:Label ID="lblOrderSign" runat="server" Text=" "></asp:Label></td>
                </tr>
                <tr>
                    <td style="text-align: right">
                        <asp:Button ID="btnReturn" runat="server" onclick="btnReturn_Click" Text="返回" 
                            Width="40px" />
                    </td>
                    <td class="style2">
                        &nbsp;</td>
                </tr>
                <tr>
                   <td style="text-align: right">
                        <a href="Cell.aspx" style="text-align: right">返回接口目录</a>
                   </td>
                </tr>
		    </table>  
            
        </asp:Panel>
    </form>
</body>
</html>
