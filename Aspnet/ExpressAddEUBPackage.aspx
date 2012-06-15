<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExpressAddEUBPackage.aspx.cs" Inherits="Chukou1Demo.Aspnet.ExpressAddEUBPackage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>ExpressAddEUBPackage Sample</title>
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
					<div class="header"><b>ExpressAddEUBPackage Sample</b></div>
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
                    <td width="200">MessageID</td>
                    <td colspan="3">
                        <asp:TextBox ID="txtMessageID" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">Version</td>
                    <td colspan="3">
                        <asp:TextBox ID="txtVersion" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
			    <tr>
                    <td width="200">
                        PickUpAddress</td>
                    <td colspan="3">
                        <asp:TextBox ID="txtPickUpAddress" runat="server" Width="400px" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        PickupType</td>
                    <td colspan="3">
                        <asp:DropDownList ID="ddlPickupType" runat="server">
                            <asp:ListItem>上門揽取</asp:ListItem>
                            <asp:ListItem>自送货</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style4" width="200">
                        PackageDetail</td>
                    <td colspan="3">
                        &nbsp;</td>
                </tr>
			    <tr>
                    <td width="200" class="style3">
                        Custom</td>
                    <td colspan="3">
                        <asp:TextBox ID="txtCustom" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200" class="style3">
                        ItemSign</td>
                    <td colspan="3">
                        <asp:TextBox ID="txtItemSign" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200" class="style3">
                        Packing</td>
                    <td>
                        <asp:TextBox ID="txtLength" runat="server" Width="120" Enabled="False">10</asp:TextBox>
                        *</td>
                    <td>
                        <asp:TextBox ID="txtWidth" runat="server" Width="120" Enabled="False">10</asp:TextBox>
                        *</td>
                    <td>
                        <asp:TextBox ID="txtHeight" runat="server" Width="120" Enabled="False">10</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200" class="style3">
                        PackingList</td>
                    <td colspan="3">
                        <asp:TextBox ID="txtPackingList" runat="server" Width="400" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200" class="style3">
                        Remark</td>
                    <td colspan="3">
                        <asp:TextBox ID="txtRemark" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200" class="style3">
                        ShipToAddress</td>
                    <td colspan="3">
                        <asp:TextBox ID="txtWarning" runat="server" Width="400px" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200" class="style3">
                        State</td>
                    <td colspan="3">
                        <asp:TextBox ID="txtSKU" runat="server" Width="400px" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200" class="style3">
                        TrackCode</td>
                    <td colspan="3">
                        <asp:TextBox ID="txtTrackCode" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200" class="style3">
                        Weight</td>
                    <td colspan="3">
                        <asp:TextBox ID="txtWeight" runat="server" Width="400px" Enabled="False">10</asp:TextBox>
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
                    <td class="style3" width="200">
                        Custom</td>
                    <td class="style2">
                        <asp:Label ID="lblCustom" runat="server" Text=" "></asp:Label></td>
                </tr>

		        <tr>
                    <td class="style3" width="200">
                        ItemSign</td>
                    <td class="style2">
                        <asp:Label ID="lblItemSign" runat="server" Text=" "></asp:Label></td>
                </tr>
                <tr>
                    <td class="style3" width="200">
                        TrackCode</td>
                    <td class="style2">
                        <asp:Label ID="lblTrackCode" runat="server" Text=" "></asp:Label></td>
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
