using System;


namespace Chukou1Demo.Aspnet
{
    public partial class InStoreGetOrder : System.Web.UI.Page
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
            txtOrderSign.Text = "";
            txtMessageID.Text = "";
            txtVersion.Text = "";
            pnlResponse.Visible = false;
            pnlRequest.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var clint = new CK1.CK1SoapClient();
            UserKeyAndToken ukt = new UserKeyAndToken();
            var request = new CK1.InStoreGetOrderRequest()
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                OrderSign = txtOrderSign.Text,
                Version = txtVersion.Text,
            };

            CK1.InStoreGetOrderResponse response = clint.InStoreGetOrder(request);

            lblAck.Text = response.Ack.ToString();
            lblInvocationID.Text = response.InvocationID;
            lblMessage.Text = response.Message;
            if (response.OrderDetail != null)
            {
                lblArriveTime.Text = response.OrderDetail.ArriveTime.ToString();
                lblCaseList.Text = response.OrderDetail.CaseList.ToString();
                lblOrderSign.Text = response.OrderDetail.OrderSign;
                if (response.OrderDetail.PickUpAddress != null)
                {
                    lblPickUpAddress.Text = response.OrderDetail.PickUpAddress.ToString();
                }
                lblPickupType.Text = response.OrderDetail.PickupType.ToString();
                lblRemark.Text = response.OrderDetail.Remark;
                lblShippingMethod.Text = response.OrderDetail.ShippingMethod.ToString();
                lblState.Text = response.OrderDetail.State.ToString();
                lblWarehouse.Text = response.OrderDetail.Warehouse.ToString();
            }

            pnlResponse.Visible = true;
            pnlRequest.Visible = false;
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Initialize();
        }
    }
}