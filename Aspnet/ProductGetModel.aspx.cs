using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chukou1Demo.Aspnet
{
    public partial class ProductGetModel : System.Web.UI.Page
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
            txtCustom.Text = "";
            txtSKU.Text = "";
            txtMessageID.Text = "";
            txtVersion.Text = "";
            pnlResponse.Visible = false;
            pnlRequest.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var clint = new CK1.CK1SoapClient();
            UserKeyAndToken ukt = new UserKeyAndToken();
            var request = new CK1.ProductGetModelRequest()
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                SKU = txtSKU.Text,
                Custom = txtCustom.Text,
                Version = txtVersion.Text,
            };

            var response = clint.ProductGetModel(request);
    
            lblAck.Text = response.Ack.ToString();
            lblInvocationID.Text = response.InvocationID;
            lblMessage.Text = response.Message;
            if (response.ModelDetail != null)
            {
                lblCatetory.Text = response.ModelDetail.Category;
                lblCustom.Text = response.ModelDetail.Custom;
                lblDeclareName.Text = response.ModelDetail.DeclareName;
                lblDeclareValue.Text = response.ModelDetail.DeclareValue.ToString();
                lblDescroption.Text = response.ModelDetail.Description;
                lblPacking.Text = response.ModelDetail.Packing.Length.ToString() 
                    + "*" +response.ModelDetail.Packing.Width.ToString() 
                    + "*" +response.ModelDetail.Packing.Height.ToString();
                lblProductFlag.Text = response.ModelDetail.ProductFlag.ToString();
                lblWarning.Text = response.ModelDetail.Warning.ToString();
                lblWeight.Text = response.ModelDetail.Weight.ToString();
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