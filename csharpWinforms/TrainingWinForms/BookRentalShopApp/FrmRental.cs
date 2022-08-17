using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmRental : MetroForm
    {
        #region 전역변수 영역

        private bool isNew = false; // false (수정) / true (신규)

        #endregion

        #region 이벤트 영역

        public FrmRental()
        {
            InitializeComponent();
        }

        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            isNew = true; // 신규 초기화
            InitCboData(); // 콤보박스 들어가는 데이터 초기화
            RefreshData(); // 테이블 조회

            DtpRentalDate.CustomFormat = "yyyy-MM-dd";
            DtpRentalDate.Format = DateTimePickerFormat.Custom;
        }       

        private void FrmDivCode_Resize(object sender, EventArgs e)
        {
            DgvData.Height = this.ClientRectangle.Height - 90;
            GrbDetail.Height = this.ClientRectangle.Height - 90;
        }

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // 선택된 값이 존재하면
            {
                var selData = DgvData.Rows[e.RowIndex];
                AsignToControls(selData);
                isNew = false;  // 수정
                BtnSearchBook.Enabled = BtnSearchMember.Enabled = false;
                DtpRentalDate.Enabled = false;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Validation
            if (CheckValidation() == false) return;
            // 삭제질문
            if (MetroMessageBox.Show(this, "삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            DeleteData();
            RefreshData();
            ClearInputs();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation 체크
            if (CheckValidation() == false) return;

            SaveData();
            RefreshData();
            ClearInputs();
        }

        #endregion

        #region 커스텀 메서드 영역

        private void InitCboData()
        {
            try
            {
                var temp = new Dictionary<string, string>();
                temp.Add("R", "대여중");
                temp.Add("T", "반납");

                CboRentalState.DataSource = new BindingSource(temp, null);
                CboRentalState.DisplayMember = "Value";
                CboRentalState.ValueMember = "Key";
                CboRentalState.SelectedIndex = -1;
            }
            catch { }
        }

        private void AsignToControls(DataGridViewRow selData)
        {
            TxtIdx.Text = selData.Cells[0].Value.ToString();
            selMemberIdx = (int)selData.Cells[1].Value;
            Debug.WriteLine($">>>> selMemberIdx : {selMemberIdx}");
            TxtMemberName.Text = selData.Cells[2].Value.ToString();
            selBookIdx = (int)selData.Cells[3].Value;
            Debug.WriteLine($">>>> selBookIdx : {selBookIdx}");
            TxtBookName.Text = selData.Cells[4].Value.ToString();
            DtpRentalDate.Value = (DateTime)selData.Cells[5].Value;
            TxtReturnDate.Text = selData.Cells[6].Value == null ? "" : selData.Cells[6].Value.ToString();
            CboRentalState.SelectedValue = selData.Cells[7].Value;            
        }

        /// <summary>
        /// 삭제처리 프로세스
        /// </summary>
        private void DeleteData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = @"DELETE FROM [dbo].[bookstbl] 
                                   WHERE [Idx] = @Idx ";
                    cmd.CommandText = query;

                    var pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    pIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(pIdx);                    

                    var result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MetroMessageBox.Show(this, "삭제 성공", "삭제",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "삭제 실패", "삭제",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void RefreshData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = @"SELECT r.Idx
                                      ,r.memberIdx
	                                  ,m.Names as memberName
                                      ,r.bookIdx
	                                  ,b.Names as bookName
                                      ,r.rentalDate
                                      ,r.returnDate
	                                  ,r.rentalState
                                      ,case r.rentalState 
	                                      when 'R' then '대여중'
	                                      when 'T' then '반납' 
	                                      else '상태없음'
	                                   end as StateDesc
                                  FROM dbo.rentaltbl as r
                                 INNER JOIN dbo.membertbl as m
                                    ON r.memberIdx = m.Idx
                                 INNER JOIN dbo.bookstbl as b
                                    ON r.bookIdx = b.Idx "; // 
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "rentaltbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "rentaltbl";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // 데이터그리드뷰 컬럼 화면에서 안보이게
            var column = DgvData.Columns[1]; // memberIdx 컬럼
            column.Visible = false;
            column = DgvData.Columns[3]; // bookIdx
            column.Visible = false;
            column = DgvData.Columns[7]; // rentalState
            column.Visible = false;

            column = DgvData.Columns[0]; // Idx
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        /// <summary>
        /// 입력(수정)처리 프로세스
        /// </summary>
        private void SaveData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = "";

                    if (isNew == true) // ISNERT
                    {
                        query = @"INSERT INTO [dbo].[rentaltbl]
                                       ([memberIdx]
                                       ,[bookIdx]
                                       ,[rentalDate]
                                       ,[rentalState])
                                 VALUES
                                       (@memberIdx
                                       ,@bookIdx
                                       ,@rentalDate
                                       ,@rentalState) ";
                    }
                    else // UPDATE
                    {
                        query = @"UPDATE [dbo].[rentaltbl]
                                       SET [returnDate] = case @rentalState
                                                          when 'T' then GETDATE()
                                                          when 'R' then null end
                                          ,[rentalState] = @rentalState
                                     WHERE Idx = @Idx ";
                    }
                    cmd.CommandText = query;

                    if (isNew == true) // 신규
                    {
                        var pMemberIdx = new SqlParameter("@memberIdx", SqlDbType.Int);
                        pMemberIdx.Value = selMemberIdx;
                        cmd.Parameters.Add(pMemberIdx);

                        var pBookIdx = new SqlParameter("@bookIdx", SqlDbType.Int);
                        pBookIdx.Value = selBookIdx;
                        cmd.Parameters.Add(pBookIdx);

                        var pRentalDate = new SqlParameter("@rentalDate", SqlDbType.Date);
                        pRentalDate.Value = DtpRentalDate.Value;
                        cmd.Parameters.Add(pRentalDate);

                        var pRentalState = new SqlParameter("@rentalState", SqlDbType.Char, 1);
                        pRentalState.Value = CboRentalState.SelectedValue;
                        cmd.Parameters.Add(pRentalState);
                    }                   
                    else // 업데이트일땐
                    {
                        var pRentalState = new SqlParameter("@rentalState", SqlDbType.Char, 1);
                        pRentalState.Value = CboRentalState.SelectedValue;
                        cmd.Parameters.Add(pRentalState);

                        var pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                        pIdx.Value = TxtIdx.Text;
                        cmd.Parameters.Add(pIdx);
                    }

                    var result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MetroMessageBox.Show(this, "저장 성공", "저장",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "저장 실패", "저장",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 입력값 유효성 체크 메서드
        /// </summary>
        /// <returns></returns>
        private bool CheckValidation()
        {
            if (string.IsNullOrEmpty(TxtMemberName.Text) ||
                string.IsNullOrEmpty(TxtBookName.Text) || 
                DtpRentalDate.Value == null ||
                CboRentalState.SelectedIndex < 0)
            {
                MetroMessageBox.Show(this, "빈값은 처리할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            selMemberIdx = selBookIdx = 0;
            selMemberName = selBookName = "";
            TxtIdx.Text = TxtBookName.Text = TxtMemberName.Text = "";
            DtpRentalDate.Value = DateTime.Now; // 오늘 날짜로 초기화
            TxtReturnDate.Text = "";
            TxtIdx.ReadOnly = true;
            CboRentalState.SelectedIndex = -1;

            BtnSearchBook.Enabled = BtnSearchMember.Enabled = true;
            DtpRentalDate.Enabled = true;
            isNew = true;
        }

        #endregion

        private int selMemberIdx = 0; // 선택된 회원번호
        private string selMemberName = ""; // 선택된 회원이름

        private void BtnSearchMember_Click(object sender, EventArgs e)
        {
            FrmMemberPopup frm = new FrmMemberPopup();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                selMemberIdx = frm.SelIdx;
                TxtMemberName.Text = selMemberName = frm.SelName;
            }
        }

        private int selBookIdx = 0;
        private string selBookName = "";

        private void BtnSearchBook_Click(object sender, EventArgs e)
        {
            FrmBooksPopup frm = new FrmBooksPopup();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                selBookIdx = frm.SelIdx;
                TxtBookName.Text = selBookName = frm.SelName;
            }
        }
    }
}
