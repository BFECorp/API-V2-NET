<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerifyUser.aspx.cs" Inherits="Chukou1Demo.Aspnet.VerifyUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VerifyUser Sample</title>
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
    </style>
</head>
<body>
    <form runat="server">
		<table align="center" style="font-size: large">
			<tr>
				<td colspan="3" class="style1" align="center" width="408">
					<div class="header"><b>VerifyUser Sample</b></div>
				</td>
			</tr>
		</table>
		<br />
		<br />

        <asp:Panel ID="pnlRequest" runat="server">
		    <table align="center">
			    <tr align="right">
				    <td>Request</td>
			    </tr>
		    </table>
		    <table align="center" style="font-size: small">
			    <tr>
				    <td width="200">UserID(Consumer Key)</td>
				    <td>
					    <asp:TextBox ID="txtUserId" runat="server" Width="400px"></asp:TextBox>
				    </td>
			    </tr>
			    
			    <tr>
				    <td width="200">MessageID</td>
				    <td>
					    <asp:TextBox ID="txtMessageID" runat="server" Width="400px"></asp:TextBox></td>
			    </tr>
			    <tr>
				    <td width="200">Version</td>
				    <td>
                        <asp:TextBox ID="txtVersion" runat="server" Width="400px"></asp:TextBox>
				    </td>
			    </tr>
			    <tr>
					
				    <td width="200" align="right">
					    <asp:Button ID="btnSubmit" runat="server" Text="提交" Width="40px" 
                            onclick="btnSubmit_Click" />
				    </td>
					
			    </tr>
                <tr>
                   <td style="text-align: right">
                        <a href="Cell.aspx" style="text-align: right">返回接口目录</a>
                   </td>
                </tr>
		    </table>            
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
                    <td style="text-align: right">
                        <asp:Button ID="btnReturn" runat="server" onclick="btnReturn_Click" Text="返回" Width="40px" />
                    </td>
                    
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
