using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindApp
{
    public partial class FrmNorthwind : Form
    {
        public FrmNorthwind()
        {
            InitializeComponent();
        }

        private void FrmNorthwind_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'northwindDataSet.Employees' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //DataSource로부터 DataSet 객체를 추출
            //TestDBDataSet은 자동 생성된 DataSet 파생클래스
            BindingSource bs = (BindingSource)DgvEmployee.DataSource;
            NorthwindDataSet ds = bs.DataSource as NorthwindDataSet;

            // 자동 생성된 TableAdapter 클래스의 Update() 호출. 
            // 갱신데이타 소스인 DataTable을 파라미터로 넘김
            this.employeesTableAdapter.Update(ds.Employees);
        }
    }
}
