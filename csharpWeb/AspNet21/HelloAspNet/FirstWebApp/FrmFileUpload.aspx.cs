using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmFileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Expires = 20;
            // 캐싱출력
            LblCached.Text = DateTime.Now.ToLongTimeString();
        }

        public static string GetCurrenTime(HttpContext context)
        {
            return DateTime.Now.ToLongTimeString();
        }

        protected void BtnUpload_Click(object sender, EventArgs e)
        {
            if (CtlUpload.HasFile)
            {
                CtlUpload.SaveAs(Server.MapPath(".") + "\\Files\\" + CtlUpload.FileName); // 저장

                LblResult.Text = $"<a href='{"./Files/"}{Server.UrlEncode(CtlUpload.FileName)}'>{Server.UrlEncode(CtlUpload.FileName)}</a>";
            }
        }
    }
}