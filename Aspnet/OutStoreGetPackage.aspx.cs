using System;

namespace Chukou1Demo.Aspnet
{
    public partial class OutStoreGetPackage : System.Web.UI.Page
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
            txtSign.Text = "";
            txtCustom.Text = "";
            pnlResponse.Visible = false;
            pnlRequest.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var clint = new CK1.CK1SoapClient();
            UserKeyAndToken ukt = new UserKeyAndToken();
            var request = new CK1.OutStoreGetPackageRequest()
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                Custom = txtCustom.Text,
                Sign = txtSign.Text,
                Version = txtVersion.Text,
            };

            var response = clint.OutStoreGetPackage(request);

            lblAck.Text = response.Ack.ToString();
            lblInvocationID.Text = response.InvocationID;
            lblMessage.Text = response.Message;

            if (response.PackageDetail != null)
            {
                lblCustom.Text = response.PackageDetail.Custom;
                lblPackageList.Text = response.PackageDetail.ProductList.ToString();
                lblRemark.Text = response.PackageDetail.Remark;
                lblServices.Text = response.PackageDetail.Services;
                lblShipping.Text = response.PackageDetail.Shipping.ToString();
                lblShipToAddress.Text = response.PackageDetail.ShipToAddress.ToString();
                lblSign.Text = response.PackageDetail.Sign;
                lblState.Text = response.PackageDetail.State.ToString();
                lblTrackingNumber.Text = response.PackageDetail.TrackingNumber;
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