<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutStoreAddOrderNew.aspx.cs" Inherits="Chukou1Demo.Aspnet.OutStoreAddOrderNew" %>

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
					<div class="header"><b>OutStoreAddOrderNew Sample</b></div>
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
                        <asp:CheckBox ID="ccbSubmit" runat="server" Checked="True" />
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
                            <asp:ListItem Value="US">US-美国(旧金山)</asp:ListItem>
                            <asp:ListItem Value="NJ">NJ-美国(新泽西)</asp:ListItem>
                            <asp:ListItem Value="AU">AU-澳大利亚</asp:ListItem>
                            <asp:ListItem Value="UK">UK-英国</asp:ListItem>
                            <asp:ListItem Value="DE">DE-德国</asp:ListItem>
                        </asp:DropDownList>
                        
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        ServiceCode</td>
                    <td>
                        <select ID="ddlServiceCode" name="ServiceCode">
                            <optgroup label="US-本地">
                                                <option value="USNUS">USNUS - 美国邮政本地非挂号</option>
                                                <option value="USRUS">USRUS - 美国邮政本地挂号</option>
                                                <option value="USNLE">USNLE - 美国本地经济型派送非挂号</option>
                                                <option value="USRLE">USRLE - 美国本地经济型派送挂号</option>
                                                <option value="USRLS">USRLS - 美国本地标准型派送</option>
                                                <option value="USRLP">USRLP - 美国本地快捷型派送</option>
                                                <option value="USRSS">USRSS - 美国本地标准签收派送</option>
                                                <option value="USRPP">USRPP - 美国本地快捷签收派送</option>
                                                <option value="USFRE">USFRE - 美国邮政本地派送-Flat envelope</option>
                                                <option value="USNLL">USNLL - 美国邮政本地派送-large letter</option>
                                        </optgroup>
<optgroup label="US-国际">
                                                <option value="USNIU">USNIU - 美国邮政国际派送</option>
                                                <option value="USRIS">USRIS - 美国国际标准型派送</option>
                                        </optgroup>
<optgroup label="NJ-本地">
                                                <option value="NJNUS">NJNUS - 美国邮政本地非挂号</option>
                                                <option value="NJRUS">NJRUS - 美国邮政本地挂号</option>
                                                <option value="NJNLE">NJNLE - 美国本地经济派送非挂号</option>
                                                <option value="NJRLE">NJRLE - 美国本地经济派送挂号</option>
                                                <option value="NJRLS">NJRLS - 美国本地标准派送</option>
                                                <option value="NJRLP">NJRLP - 美国本地快捷型派送</option>
                                                <option value="NJRSS">NJRSS - 美国本地标准签收派送</option>
                                                <option value="NJRPP">NJRPP - 美国本地快捷签收派送</option>
                                                <option value="NJFRE">NJFRE - 美国邮政本地派送-Flat envelope</option>
                                                <option value="NJNLL">NJNLL - 美国邮政本地派送-large letter</option>
                                        </optgroup>
<optgroup label="NJ-国际">
                                                <option value="NJNIU">NJNIU - 美国邮政国际派送</option>
                                                <option value="NJRIS">NJRIS - 美国国际标准型派送</option>
                                        </optgroup>
<optgroup label="AU-本地">
                                                <option value="AUNAP">AUNAP - 澳洲邮政非挂号</option>
                                                <option value="AURAP">AURAP - 澳洲邮政挂号</option>
                                                <option value="AUREP">AUREP - 澳洲邮政eParcel派送</option>
                                                <option value="AURPP">AURPP - 澳洲邮政快捷派送</option>
                                                <option value="AURLT">AURLT - 澳洲本地大货派送</option>
                                                <option value="AURSP">AURSP - 澳洲本地标准派送</option>
                                        </optgroup>
<optgroup label="UK-本地">
                                                <option value="UKNRM">UKNRM - 英国邮政本地非挂号</option>
                                                <option value="UKRNX">UKRNX - 英国邮政-Nextday Delivery</option>
                                                <option value="UKRLS">UKRLS - 英国本地标准派送</option>
                                                <option value="UKRLE">UKRLE - 英国本地经济派送</option>
                                                <option value="UKNR2">UKNR2 - 英国邮政本地二级服务非挂号</option>
                                                <option value="UKRR2">UKRR2 - 英国邮政本地二级服务挂号</option>
                                                <option value="UKRLO">UKRLO - 英国本地泡货派送</option>
                                                <option value="UKRLH">UKRLH - 英国本地重货派送</option>
                                                <option value="UKRRM">UKRRM - 英国邮政本地挂号</option>
                                                <option value="UKNRT">UKNRT - 英国邮政本地特惠派送非挂号</option>
                                                <option value="UKPOD">UKPOD - 英国邮政本地派送含POD</option>
                                                <option value="UKRLF">UKRLF - 英国本地快捷派送</option>
                                        </optgroup>
<optgroup label="UK-国际">
                                                <option value="UKDPD">UKDPD - 英国国际泡货派送</option>
                                                <option value="UKRIS">UKRIS - 英国国际标准派送</option>
                                                <option value="UKRIP">UKRIP - 英国国际快捷派送</option>
                                                <option value="UKNIR">UKNIR - 英国邮政国际派送非挂号</option>
                                                <option value="UKRIR">UKRIR - 英国邮政国际派送挂号</option>
                                        </optgroup>
<optgroup label="DE-国际">
                                                <option value="DENID">DENID - 德国邮政国际派送</option>
                                                <option value="DERIS">DERIS - 德国国际标准派送</option>
                                                <option value="DERID">DERID - 德国邮政国际派送挂号</option>
                                                <option value="DERIT">DERIT - 德国国际大货派送</option>
                                        </optgroup>
<optgroup label="DE-本地">
                                                <option value="DERLS">DERLS - 德国本地标准派送</option>
                                                <option value="DENDE">DENDE - 德国邮政本地经济派送</option>
                                                <option value="DENDS">DENDS - 德国邮政本地标准派送非挂号</option>
                                                <option value="DERDS">DERDS - 德国邮政本地标准派送挂号</option>
                                                <option value="DERLT">DERLT - 德国本地大货派送</option>
                                        </optgroup>
                        </select>
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
                        None
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        Shipping</td>
                    <td>
                        None
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
                        <asp:TextBox ID="txtSKU" runat="server" Width="400px">testProduct</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200">
                        StorageNo</td>
                    <td>
                        <asp:TextBox ID="txtStorageNo" runat="server" Width="400px"></asp:TextBox>
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
