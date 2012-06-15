using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chukou1Demo.Aspnet
{
    public partial class ProductGetStorageNo : System.Web.UI.Page
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
        protected void btnOK_Click(object sender, EventArgs e)
        {
            CK1.CK1SoapClient clint = new CK1.CK1SoapClient();
            UserKeyAndToken ukt = new UserKeyAndToken();
            var request = new CK1.ProductGetStorageNoRequest()
            {
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                MessageID = txtMessageID.Text,
                SKU = tbTitle.Text,
                Version = txtVersion.Text

            };
            if(ddlStorage.SelectedIndex != 0)
            {
                switch (ddlStorage.SelectedIndex)
                {
                    case 1:
                        request.Warehouse = CK1.EnumWarehouse.US;
                        break;
                    case 2:
                        request.Warehouse = CK1.EnumWarehouse.AU;
                        break;
                    default:
                        request.Warehouse = CK1.EnumWarehouse.UK;
                        break;
                }
            }
            try
            {
                var response = clint.ProductGetStorageNo(request);
                lblAck.Text = response.Ack.ToString();
                lblInvocationID.Text = response.InvocationID;
                lblMessage.Text = response.Message;
                lblStorageNo.Text = response.StorageNo;
            }
            catch (Exception)
            {
                lblAck.Text = "Failure";
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