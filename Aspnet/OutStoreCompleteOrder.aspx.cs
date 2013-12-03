using System;
using Chukou1Demo.CK1;

namespace Chukou1Demo.Aspnet
{
    public partial class OutStoreCompleteOrder : System.Web.UI.Page
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
            UserKeyAndToken ukt = new UserKeyAndToken();
            var request = new OutStoreCompleteOrderRequest()
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                OrderSign = txtOrderSign.Text,
                ActionType = ddlAction.Text == "Submit" ? EnumActionType.Submit : EnumActionType.Cancel,
                Version = txtVersion.Text,
            };

            OutStoreCompleteOrderResponse response = clint.OutStoreCompleteOrder(request);
            lblAck.Text = response.Ack.ToString();
            lblInvocationID.Text = response.InvocationID;
            lblMessage.Text = response.Message;

            pnlResponse.Visible = true;
            pnlRequest.Visible = false;
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Initialize();
        }
    }
}
