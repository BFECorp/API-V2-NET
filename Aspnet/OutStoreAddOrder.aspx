<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutStoreAddOrder.aspx.cs" Inherits="Chukou1Demo.Aspnet.OutStoreAddOrder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>OutStoreAddOrder Sample</title>
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
					<div class="header"><b>OutStoreAddOrder Sample</b></div>
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
                    <td width="200">
                        OrderSign</td>
                    <td>
                        <asp:TextBox ID="txtOrderSign" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        Remark</td>
                    <td>
                        <asp:TextBox ID="txtRemark" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
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
                    <td width="200" class="style4">
                        PackageList</td>
                    <td>
                        
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        Custom</td>
                    <td>
                        <asp:TextBox ID="txtCustom" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        Remark</td>
                    <td>
                        <asp:TextBox ID="txtRemark1" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        Services</td>
                    <td>
                        <asp:TextBox ID="txtServices" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        Shipping</td>
                    <td>
                        <asp:DropDownList ID="ddlShipping" runat="server">
                            <asp:ListItem>RoyalMail</asp:ListItem>
                            <asp:ListItem>DHL</asp:ListItem>
                            <asp:ListItem>UPS</asp:ListItem>
                            <asp:ListItem>USPS</asp:ListItem>
                            <asp:ListItem>AuPost</asp:ListItem>
                            <asp:ListItem>Parcelforce</asp:ListItem>
                            <asp:ListItem>Fedex</asp:ListItem>
                            <asp:ListItem>DPD</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        Sign</td>
                    <td>
                        <asp:TextBox ID="txtSign" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        TrackingNumer</td>
                    <td>
                        <asp:TextBox ID="txtTrackingNumer" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td width="200">
                        <span class="style4">ProductList</span></td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td width="200">
                        Quantity</td>
                    <td>
                        <asp:TextBox ID="txtQuantity" runat="server" Width="400px">1</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        SKU</td>
                    <td>
                        <asp:TextBox ID="txtSKU" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        StorageNo</td>
                    <td>
                        <asp:TextBox ID="txtStorageNo" runat="server" Width="400px">LTST00000115</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        <span class="style4">ShipToAddress</span></td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td width="200">
                        City</td>
                    <td>
                        <asp:TextBox ID="txtCity" runat="server" Width="400px">a</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        Company</td>
                    <td>
                        <asp:TextBox ID="txtCompany" runat="server" Width="400px">a</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        Contact</td>
                    <td>
                        <asp:TextBox ID="txtContact" runat="server" Width="400px">a</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        Country</td>
                    <td>
                        <asp:TextBox ID="txtCountry" runat="server" Width="400px">US</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        Phone</td>
                    <td>
                        <asp:TextBox ID="txtPhone" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        postCode</td>
                    <td>
                        <asp:TextBox ID="txtpostCode" runat="server" Width="400px">12333</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        Province</td>
                    <td>
                        <asp:TextBox ID="txtProvince" runat="server" Width="400px">a</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        Street1</td>
                    <td>
                        <asp:TextBox ID="txtStreet1" runat="server" Width="400px">a</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        Street2</td>
                    <td>
                        <asp:TextBox ID="txtStreet2" runat="server" Width="400px"></asp:TextBox>
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
