﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutStoreGetPackage.aspx.cs" Inherits="Chukou1Demo.Aspnet.OutStoreGetPackage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>OutStoreGetPackage Sample</title>
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
    <form id="Form1" runat="server">
		<table align="center" style="font-size: large">
			<tr>
				<td colspan="3" class="style1" align="center" width="408">
					<div class="header"><b>OutStoreGetPackage Sample</b></div>
				</td>
			</tr>
		</table>
		<br />

        <asp:Panel ID="pnlRequest" runat="server">
		    <table align="center">
			    <tr align="right">
				    <td>Request</td>
			    </tr>
		    </table>
		    <table align="center" style="font-size: small">
			    
			    <tr>
                    <td width="200">Custom</td>
                    <td>
                        <asp:TextBox ID="txtCustom" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
			    <tr>
                    <td width="200">Sign</td>
                    <td>
                        <asp:TextBox ID="txtSign" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">MessageID</td>
                    <td>
                        <asp:TextBox ID="txtMessageID" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
			    <tr>
				    <td width="200">Version</td>
				    <td>
					    <asp:TextBox ID="txtVersion" runat="server" Width="400px"></asp:TextBox></td>
			    </tr>
			    <tr>
				    <td width="200" align="right">
                        <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" Text="提交" 
                            Width="40px" />
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
                    <td class="style3" width="200">Custom</td>
                    <td class="style2">
                        <asp:Label ID="lblCustom" runat="server" Text=" "></asp:Label></td>
                </tr>
                <tr>
                    <td class="style3" width="200">PackageList</td>
                    <td class="style2">
                        <asp:Label ID="lblPackageList" runat="server" Text=" "></asp:Label></td>
                </tr>
                <tr>
                    <td class="style3" width="200">Remark</td>
                    <td class="style2">
                        <asp:Label ID="lblRemark" runat="server" Text=" "></asp:Label></td>
                </tr>
                <tr>
                    <td class="style3" width="200">Services</td>
                    <td class="style2">
                        <asp:Label ID="lblServices" runat="server" Text=" "></asp:Label></td>
                </tr>
                <tr>
                    <td class="style3" width="200">
                        Shipping</td>
                    <td class="style2">
                        <asp:Label ID="lblShipping" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>

		        <tr>
                    <td class="style3" width="200">
                        ShipToAddress</td>
                    <td class="style2">
                        <asp:Label ID="lblShipToAddress" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style3" width="200">
                        Sign</td>
                    <td class="style2">
                        <asp:Label ID="lblSign" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style3" width="200">
                        State</td>
                    <td class="style2">
                        <asp:Label ID="lblState" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style3" width="200">
                        TrackingNumber</td>
                    <td class="style2">
                        <asp:Label ID="lblTrackingNumber" runat="server" Text=" "></asp:Label>
                    </td>
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
