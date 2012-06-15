<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InStoreAddOrder.aspx.cs" Inherits="Chukou1Demo.Aspnet.InStoreAddOrder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>InStoreAddOrder Sample</title>
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
					<div class="header"><b>InStoreAddOrder Sample</b></div>
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
                    <td width="200" class="style3">
                        ArriveTime</td>
                    <td>
                        <asp:TextBox ID="txtArriveTime" runat="server" Width="400px" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200" class="style3">
                        CaseList</td>
                    <td>
                        <asp:TextBox ID="txtCaseList" runat="server" Width="400px" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200" class="style3">
                        Location</td>
                    <td>
                        
                        <asp:DropDownList ID="ddlLocation" runat="server">
                            <asp:ListItem Value="GZ">广州处理点</asp:ListItem>
                            <asp:ListItem Value="SZ">深圳处理点</asp:ListItem>
                            <asp:ListItem Value="SH">上海处理点</asp:ListItem>
                        </asp:DropDownList>
                        
                    </td>
                </tr>
                <tr>
                    <td width="200" class="style3">
                        OrderSign</td>
                    <td>
                        
                        <asp:TextBox ID="txtOrderSign" runat="server" Width="400px"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                    <td width="200" class="style3">
                        PickupType</td>
                    <td>
                        <asp:DropDownList ID="ddlPickupType" runat="server">
                            <asp:ListItem>上门揽取</asp:ListItem>
                            <asp:ListItem>自送货</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td width="200" class="style3">
                        Remark</td>
                    <td>
                        <asp:TextBox ID="txtRemark" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200" class="style3">
                        ShippingMethod</td>
                    <td>
                        <asp:DropDownList ID="ddlShippingMethod" runat="server">
                            <asp:ListItem Value="AIR">空运</asp:ListItem>
                            <asp:ListItem Value="SEA">海运</asp:ListItem>
                            <asp:ListItem>EMS</asp:ListItem>
                            <asp:ListItem>DHL</asp:ListItem>
                            <asp:ListItem>UPS</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td width="200" class="style3">
                        Warehouse</td>
                    <td>
                        <asp:DropDownList ID="ddlWarehouse" runat="server">
                            <asp:ListItem Value="US">美国</asp:ListItem>
                            <asp:ListItem Value="AU">澳大利亚</asp:ListItem>
                            <asp:ListItem Value="UK">英国</asp:ListItem>
                            <asp:ListItem Value="MA">马来西亚</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
			    <tr>
					
				    <td width="200" style="text-align: right">
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
