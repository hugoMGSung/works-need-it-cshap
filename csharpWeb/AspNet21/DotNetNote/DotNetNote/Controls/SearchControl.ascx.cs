using System;

namespace DotNetNote.Controls
{
    public partial class SearchControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string strQuery = $"BoardList.aspx?SearchField={SearchField.SelectedItem.Value}&SearchQuery={SearchQuery.Text}";
            Response.Redirect(strQuery);
        }
    }
}