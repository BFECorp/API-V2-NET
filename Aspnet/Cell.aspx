<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cell.aspx.cs" Inherits="Chukou1Demo.Aspnet.Cell" %>

<!DOCTYPE html PUBLIC "-//W3C//Dtd XHTML 1.0 transitional//EN" "http://www.w3.org/tr/xhtml1/Dtd/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chukou1 SDK Samples Main Page</title>
    <style type="text/css">
        #calls {
            width: 450px;
            font-size: small;
        }
        .style2
        {
            height: 26px;
        }
    </style>
</head>
    <body>
		<form id="Call" method="post" runat="server">
			<center>
				<h4>
					Welcome to the Chukou1 SDK Samples Main Page</h4>
				<table id="calls">
					<tr>
						<th class="style2">
							VerifyUser Samples
						</th>
					</tr>
					<tr>
						<td style="text-align: left">
							<a id="VerifyUserLink" href="VerifyUser.aspx">VerifyUser</a>
                             - 验证用户
						</td>
					</tr>

                    <tr>
						<th class="style2">
							ProductManage Samples 
						</th>
					</tr>

					<tr>
						<td style="text-align: left">
							<a id="ProductAddModelLink" href="ProductAddModel.aspx">ProductAddModel</a>
						    - 产品添加</td>
					</tr>
					<tr>
						<td style="text-align: left">
							<a id="ProductGetModelLink" href="ProductGetModel.aspx">ProductGetModel</a>
                             - 查询产品信息</td>
					</tr>
					<tr>
						<td style="text-align: left">
							<a id="ProductGetStockLink" href="ProductGetStock.aspx">ProductGetStock</a>
						    - 获取产品库存</td>
					</tr>

                    <tr>
						<th class="style2">
							InStoreOrder Samples
						</th>
					</tr>
                    
					<tr>
						<td style="text-align: left">
							<a id="ProductGetStorageNoLink" href="ProductGetStorageNo.aspx">ProductGetStorageNo</a>
						    - 获取库存编码
						</td>
					</tr>
					<tr>
						<td style="text-align: left">
							<a id="InStoreAddOrderLink" href="InStoreAddOrder.aspx">InStoreAddOrder</a>
						    - 添加入库单
						</td>
					</tr>
					<tr>
						<td style="text-align: left">
                            <a id="InStoreCompleteOrderLink" href="InStoreCompleteOrder.aspx">InStoreCompleteOrder</a> 
                            - 提审或取消订单</td>
					</tr>
					<tr>
						<td style="text-align: left">
							<a id="InStoreGetOrderLink" href="InStoreGetOrder.aspx">InStoreGetOrder</a>
                             - 查询入库单</td>
					</tr>

                    <tr>
						<th class="style2">
							OutStoreOrder Samples
						</th>
					</tr>

					<tr>
						<td style="text-align: left">
							<a id="OutStoreAddOrderLink" href="OutStoreAddOrder.aspx">OutStoreAddOrder</a> 
                            - 添加出库单（已过时）</td>
					</tr>
                    <tr>
						<td style="text-align: left">
							<a id="OutStoreAddOrderLink2" href="OutStoreAddOrder_V2_1.aspx">OutStoreAddOrder</a> 
                            - 添加出库单(V2.1)（已过时）</td>
					</tr>

					<tr>
						<td style="text-align: left">
							<a id="OutStoreAddOrderLink3" href="OutStoreAddOrderNew.aspx">OutStoreAddOrderNew</a> 
                            - 添加出库单（新）</td>
					</tr>
					<tr>
						<td style="text-align: left">
							<a id="OutStoreGetPackageLink" href="OutStoreGetPackage.aspx">OutStoreGetPackage</a> 
                            - 获取出库产品</td>
					</tr>
					<tr>
						<td style="text-align: left">
							<a id="OutStoreGetOrderLink" href="OutStoreGetOrder.aspx">OutStoreGetOrder</a> 
                            - 获取出库单详细</td>
					</tr>
					<tr>
						<td style="text-align: left">
							<a id="OutStoreCompleteOrderLink" href="OutStoreCompleteOrder.aspx">OutStoreCompleteOrder</a> 
                            - 提审或取消订单</td>
					</tr>

                    <tr>
						<th class="style2">
							ExpressOrder Samples
						</th>
					</tr>

					<tr>
						<td style="text-align: left">
							<a id="ExpressAddOrderLink" href="ExpressAddOrder.aspx">ExpressAddOrder</a>
                             - 添加专线订单</td>
					</tr>
                                        
                     <tr>
						<td style="text-align: left">
                            <a id="A1" href="ExpressAddPackage.aspx">ExpressAddackage</a> 
                            - 添加专线订单包裹</td>
					</tr>

                    <tr>
						<td style="text-align: left">
                            <a id="ExpressGetPackageLink" href="ExpressGetPackage.aspx">ExpressGetPackage</a> 
                            - 查询专线包裹信息</td>
					</tr>

					<tr>
						<td style="text-align: left">
                            <a id="ExpressCompleteOrderLink" href="ExpressCompleteOrder.aspx">ExpressCompleteOrder</a> 
                            - 提审或取消专线订单</td>
					</tr>

                    <tr>
						<td style="text-align: left">
                            <a id="ExpressAddEUBPackageLink" href="ExpressAddEUBPackage.aspx">ExpressAddEUBPackage</a> 
                            - 添加E邮宝包裹</td>
					</tr>
                    <tr>
						<td style="text-align: left">
                            <a id="ExpressGetEUBPackage" href="ExpressGetEUBPackage.aspx">ExpressGetEUBPackage</a>
                             - 查询E邮宝详细信息</td>
					</tr>
					<tr>
						<td style="text-align: left">
                            <a id="ExpressGetEUBPackageStatusLink" href="ExpressGetEUBPackageStatus.aspx">ExpressGetEUBPackageStatus</a> 
                            - 查询E邮宝包裹状态</td>
					</tr>
					<tr>
						<td style="text-align: left">
                            <a id="GetTrackingLink" href="GetTracking.aspx">GetTracking</a>
                             - 查询Tracking</td>
					</tr>
				</table><a href="../Default.aspx" style="text-align: right">返回主页</a>
			</center>
			
		</form>
    </body>
</html>
