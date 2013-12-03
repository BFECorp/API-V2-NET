using System;
using Chukou1Demo.CK1;


namespace Chukou1Demo.Aspnet
{
    public partial class OutStoreGetOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Initialize();
            }
        }

        private void Initialize()
        {
            txtMessageID.Text = "";
            txtVersion.Text = "";
            pnlResponse.Visible = false;
            pnlRequest.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var clint = new CK1SoapClient();
            var ukt = new UserKeyAndToken();
            var request = new OutStoreGetOrderRequest()
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                OrderSign = txtOrderSign.Text,
                Version = txtVersion.Text,
            };

            var response = clint.OutStoreGetOrder(request);

            lblAck.Text = response.Ack.ToString();
            lblInvocationID.Text = response.InvocationID;
            lblMessage.Text = response.Message;

            pnlResponse.Visible = true;
            pnlRequest.Visible = false;

            if (response.Ack != EnumAck.Success)
            {
                Response.End();
            }

            if (response.OrderDetail != null)
            {
                lblOrderSign.Text = response.OrderDetail.OrderSign;
                lblPackageList.Text = response.OrderDetail.PackageList.ToString(); ;
                lblRemark.Text = response.OrderDetail.Remark;
                lblState.Text = response.OrderDetail.State.ToString();
                lblWarehouse.Text = response.OrderDetail.Warehouse.ToString();
                if (response.OrderDetail.PackageList != null)
                {
                    int i = 0;
                    foreach (var package in response.OrderDetail.PackageList)
                    {
                        i++;
                        Response.Write(String.Format("包裹{0}信息: <br>", i));
                        Response.Write(String.Format("处理号: {0}<br>", package.Sign));
                        Response.Write(String.Format("State: {0}<br>", package.State.ToString()));
                        Response.Write(String.Format("Custom: {0}<br>", package.Custom));
                        Response.Write(String.Format("TrackingNumber: {0}<br>", package.TrackingNumber));
                        Response.Write(String.Format("Shipping: {0}<br>", package.Shipping.ToString()));
                        Response.Write(String.Format("ShippingV2_1: {0}<br>", package.ShippingV2_1.ToString()));
                        Response.Write(String.Format("Services: {0}<br>", package.Services));
                        Response.Write(String.Format("ShipToAddress: {0}<br>", package.ShipToAddress.ToString()));
                        Response.Write(String.Format("ProductList: {0}<br>", package.ProductList.ToString()));
                        Response.Write(String.Format("Remark: {0}<br>", package.Remark));
                        Response.Write(String.Format("BuyerID: {0}<br>", package.BuyerID));
                        Response.Write(String.Format("ItemID: {0}<br>", package.ItemID));
                        Response.Write(String.Format("BuyerEmail: {0}<br>", package.BuyerEmail));
                    }
                }
            }
            else
            {
                string nullOrderDetail = "No Order Detail Returned!";
                lblOrderSign.Text = nullOrderDetail;
                lblPackageList.Text = nullOrderDetail; ;
                lblRemark.Text = nullOrderDetail;
                lblState.Text = nullOrderDetail;
                lblWarehouse.Text = nullOrderDetail;
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Initialize();
        }
    }
}
