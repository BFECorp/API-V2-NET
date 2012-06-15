using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.MobileControls;

namespace Chukou1Demo.Aspnet
{
    public class UserKeyAndToken
    {
        public static readonly string userKey = "wr5qjqh4gj";//填写你的TOKEN
        //public static readonly string token = "2B635AFD91FA288A0F096CEDA9B2F0D2";
        public static readonly string token = "887E99B5F89BB18BEA12B204B620D236";
        
        public string getUserKey() { return userKey;}
        public string getToken() { return token; }


    }
}