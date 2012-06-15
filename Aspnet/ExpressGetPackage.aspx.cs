using System;


namespace Chukou1Demo.Aspnet
{
    public partial class ExpressGetPackage : System.Web.UI.Page
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
            txtItemSign.Text = "";
            txtCustom.Text = "";
            pnlResponse.Visible = false;
            pnlRequest.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            CK1.CK1SoapClient clint = new CK1.CK1SoapClient();
            UserKeyAndToken ukt = new UserKeyAndToken();
            CK1.OutStoreGetPackageRequest request = new CK1.OutStoreGetPackageRequest()
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                Custom = txtCustom.Text,
                Sign = txtItemSign.Text,
                Version = txtVersion.Text,
            };

            CK1.OutStoreGetPackageResponse response = clint.OutStoreGetPackage(request);

            lblAck.Text = response.Ack.ToString();
            lblInvocationID.Text = response.InvocationID;
            lblMessage.Text = response.Message;

            if (response.PackageDetail != null)
            {
                lblPackageDetail.Text = response.PackageDetail.ToString();
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