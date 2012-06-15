using System;


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
            var clint = new CK1.CK1SoapClient();
            UserKeyAndToken ukt = new UserKeyAndToken();
            var request = new CK1.OutStoreGetOrderRequest()
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
            if (response.OrderDetail != null)
            {
                lblOrderSign.Text = response.OrderDetail.OrderSign;
                lblPackageList.Text = response.OrderDetail.PackageList.ToString(); ;
                lblRemark.Text = response.OrderDetail.Remark;
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