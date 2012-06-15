using System;


namespace Chukou1Demo.Aspnet
{
    public partial class GetTracking : System.Web.UI.Page
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
            var request = new CK1.GetTrackingRequest()
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                ItemSign = txtItemSign.Text,
                ClientNo = txtClintNo.Text,
                Custom = txtCustom.Text,
                Version = txtVersion.Text,
            };

            switch (ddlOrderType.SelectedIndex)
            {
                case 0:
                    request.OrderType = CK1.OrderType.Express;
                    break;
                default:
                    request.OrderType = CK1.OrderType.OutStore;
                    break;
            }

            CK1.GetTrackingResponse response = clint.GetTracking(request);

            lblAck.Text = response.Ack.ToString();
            lblInvocationID.Text = response.InvocationID;
            lblMessage.Text = response.Message;
            if (response.TrackingDetail != null)
            {
                lblDate.Text = response.TrackingDetail.TrackDetails[0].Date.ToString();
                lblDesc.Text = response.TrackingDetail.TrackDetails[0].Desc;
                lblLocation.Text = response.TrackingDetail.TrackDetails[0].Location;
                lblAddress.Text = response.TrackingDetail.TrackSummmary.Address.ToString();
                lblCarrier.Text = response.TrackingDetail.TrackSummmary.Carrier;
                lblDeliveryTime.Text = response.TrackingDetail.TrackSummmary.DeliveryTime.ToString();
                lblLocation1.Text = response.TrackingDetail.TrackSummmary.Location;
                lblShipTime.Text = response.TrackingDetail.TrackSummmary.ShipTime.ToString();
                lblStatus.Text = response.TrackingDetail.TrackSummmary.Status;
                lblTrackNumber.Text = response.TrackingDetail.TrackSummmary.TrackNumber;
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