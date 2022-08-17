using System;
using System.Web.UI;

namespace FirstWebApp
{
    public partial class FrmResponseBuffer : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Expires = -1; // 현재 페이지를 매번 새로 읽어옴
            Response.Buffer = true; // 버퍼 사용, 메모리 화면에 처리할 것들 다 담아둔뒤에 한꺼번 출력
            Response.Write("[1] 현재 글이 보여짐");
            Response.Flush();  // 버퍼에 있는 내용 출력
            Response.Write("[3] 현재 글은?");            
            Response.Clear(); // 버퍼에 있는 내용을 지움
            Response.Write("[4] 출력");
            Response.End(); // 별로 쓸일없음
            Response.Write("[5] 출력이 안됨");
        }
    }
}