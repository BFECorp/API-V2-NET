﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductGetStorageNo.aspx.cs" Inherits="Chukou1Demo.Aspnet.ProductGetStorageNo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>获取库存编码</title>
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
    <form id="form1" runat="server">
    <table align="center" style="font-size: large">
		<tr>
			<td colspan="3" class="style1" align="center" width="408">
				<div class="header"><b>ProductGetStorageNo Sample</b></div>
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
    <table align="center"  style="font-size: small">
        <tr>
            <td colspan="2" class="tline"></td>
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
            <td class="lb">仓库选择</td>
            <td>
                <asp:DropDownList ID="ddlStorage"  DataTextField="Value" DataValueField="Key"  runat="server"> 
                    <asp:ListItem Value="" Selected="True">选择仓库</asp:ListItem>
                    <asp:ListItem Value="US">洛杉矶仓库</asp:ListItem> 
                    <asp:ListItem Value="AU">澳大利亚仓库</asp:ListItem> 
                    <asp:ListItem Value="UK">英国仓库</asp:ListItem> 
                </asp:DropDownList> 
            </td>            
        </tr>
        <tr>
            <td class="lb" valign="top">产品名称(Title)</td>
            <td>
                <asp:TextBox ID="tbTitle" TextMode="MultiLine" Rows="8" Width="260px" runat="server"></asp:TextBox> 
            </td>
        </tr>
        <tr> 
            <td></td>           
            <td colspan="2">                            
                <asp:Button ID="btnOK" runat="server" Text=" 确定 " CssClass="btn" 
                    onclick="btnOK_Click" />&nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="2" class="tline"></td>
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
                    <td class="style3" width="200">StorageNo</td>
                    <td class="style2">
                        <asp:Label ID="lblStorageNo" runat="server" Text=" "></asp:Label></td>
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
