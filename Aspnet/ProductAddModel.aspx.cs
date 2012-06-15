using System;


namespace Chukou1Demo.Aspnet
{
    public partial class ProductAddModel : System.Web.UI.Page
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
            txtCatetory.Text = "";
            txtCustom.Text = "";
            txtDeclareName.Text = "";
            pnlResponse.Visible = false;
            pnlRequest.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            CK1.CK1SoapClient clint = new CK1.CK1SoapClient();
            UserKeyAndToken ukt = new UserKeyAndToken();
            var request = new CK1.ProductAddModelRequest()
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                ModelDetail = new CK1.ProductModel()
                {
                
                    Category = txtCatetory.Text,
                    Custom = txtCustom.Text,
                    DeclareName = txtDeclareName.Text,
                    DeclareValue = 10,
                    Description = txtDescription.Text,
                    Packing = new CK1.Packing()
                    {
                        Height = 10,
                        Length = 10,
                        Width = 10,
                    },
                    ProductFlag = ddlProductFlag.SelectedIndex == 1 ? CK1.ProductFlag.Normal : CK1.ProductFlag.Special,
                    SKU = txtSKU.Text,
                    Warning = 10,
                    Weight = 10,
                },
                Version = txtVersion.Text,
            };

            var response = clint.ProductAddModel(request);

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