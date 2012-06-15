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
		<table align="center" style="font-size: large">
			<tr>
				<td colspan="3" class="style1" align="center" width="408">
					<div class="header"><b>ExpressAddOrder Sample</b></div>
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
                    <td width="200">Submit</td>
                    <td>
                        <asp:CheckBox ID="ccbSubmit" runat="server" />
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
                    <td width="200" class="style4">OrderDetail</td>
                    <td>
                        
                    </td>
                </tr>
			    <tr>
                    <td width="200">ExpressType</td>
                    <td>
                        <asp:DropDownList ID="ddlExpressType" runat="server">
                            <asp:ListItem Value="HKP">香港小包</asp:ListItem>
                            <asp:ListItem Value="CEE">中英专线</asp:ListItem>
                            <asp:ListItem Value="EMS">EMS专线</asp:ListItem>
                            <asp:ListItem Value="CNP">中国邮政小包</asp:ListItem>
                            <asp:ListItem Value="HKD">香港DHL</asp:ListItem>
                            <asp:ListItem Value="UPS">UPS专线</asp:ListItem>
                            <asp:ListItem Value="CDD">中德专线</asp:ListItem>
                            <asp:ListItem Value="EUB">国际E邮宝</asp:ListItem>
                            <asp:ListItem Value="CUE">中美专线</asp:ListItem>
                            <asp:ListItem Value="SHD">上海DHL</asp:ListItem>
                            <asp:ListItem Value="CES">上海中英专线</asp:ListItem>
                            <asp:ListItem Value="SGP">新加坡小包</asp:ListItem>
                            <asp:ListItem Value="EMD">EMD专线</asp:ListItem>
                            <asp:ListItem Value="CTU">CTU专线</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td width="200">IsTracking</td>
                    <td>
                        <asp:CheckBox ID="ccbIsTracking" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td width="200">Location</td>
                    <td>
                         <asp:TextBox ID="txtLocation" runat="server" Width="400px"></asp:TextBox>        
                    </td>
                </tr>
                <tr>
                    <td width="200">OrderSign</td>
                    <td>
                         <asp:TextBox ID="txtOrderSign" runat="server" Width="400px"></asp:TextBox>        
                    </td>
                </tr>
                <tr>
                    <td width="200">PackageList</td>
                    <td>
                         <asp:TextBox ID="txtPackageList" runat="server" Width="400px" Enabled="False"></asp:TextBox>        
                    </td>
                </tr>
                <tr>
                    <td width="200">PickUpAddress</td>
                    <td>   
                        <asp:TextBox ID="txtPickUpAddress" runat="server" Width="400px" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">PickUpType</td>
                    <td>
                        <asp:DropDownList ID="ddlPickUpType" runat="server">
                            <asp:ListItem Value="上门揽取">上门揽取</asp:ListItem>
                            <asp:ListItem Value="自送货">自送货</asp:ListItem>
                        </asp:DropDownList>    
                    </td>
                </tr>
                <tr>
                    <td width="200">Remark</td>
                    <td>
                         <asp:TextBox ID="txtRemark" runat="server" Width="400px"></asp:TextBox>        
                    </td>
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
