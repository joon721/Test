using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLS;

namespace Cressem
{
    public partial class FormManual : Form
    {
        public bool isWorking = false;

        private string xmlPath = System.Environment.CurrentDirectory + @"\DB\TenkeyList.xml";
        public static CXmlFile tenkeyListXml;
        private string mainNode = "/Tenkey/Name";
        public string newDescription = "";

        public FormManual()
        {
            if (System.IO.File.Exists(xmlPath))
            {
                tenkeyListXml = new CXmlFile(System.Environment.CurrentDirectory + @"\DB\TenkeyList.xml");

                InitializeComponent();
                InitializeChannelComboBox();
                InitializeGrid();

            }
            else
            {
                string msg = "TenkeyList.xml 파일이 없거나, 올바른 경로에 있지 않습니다!!" + "\n" + "Check " + xmlPath;
                MessageBox.Show(msg);
                Application.Exit();
            }
        }

        #region 채널 선택 콤보박스 초기화
        public void InitializeChannelComboBox()
        {
            comboBoxChannel.Items.Add("0 ~ 49");
            comboBoxChannel.Items.Add("50 ~ 99");
            comboBoxChannel.Items.Add("100 ~ 149");
            comboBoxChannel.Items.Add("150 ~ 199");

            comboBoxChannel.SelectedIndex = 0;
        }
        #endregion

        #region Tenkey Grid초기화
        private void InitializeGrid()
        {
            comboBoxChannel.SelectedIndex = 0;
            gridManual.AllowUserToAddRows = false; // Grid에 자동으로 마지막 행을 추가하는 기능 없애기.
            gridManual.AutoGenerateColumns = false;
            DataGridViewRow row = this.gridManual.RowTemplate;
            row.Height = 32;
            row.MinimumHeight = 20;

            gridManual.ReadOnly = true;
            gridManual.Columns["No1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridManual.Columns["No2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewButtonColumn c = new DataGridViewButtonColumn();
            c.FlatStyle = FlatStyle.Popup;
            c.DefaultCellStyle.ForeColor = Color.Navy;
            c.DefaultCellStyle.BackColor = Color.Yellow;

            gridManual.Rows.Clear();
            for (int idx = 0; idx < 25; idx++)
                GetInitRow(idx);
        }

        private int GetInitRow(int index)
        {
            int idx = 0;
            idx = index + (comboBoxChannel.SelectedIndex * 50);

            string node1 = tenkeyListXml.GetNodeVal(mainNode + idx.ToString());
            string node2 = tenkeyListXml.GetNodeVal(mainNode + (idx + 25).ToString());

            gridManual.Rows.Add(idx, node1, idx + 25, node2);
            
            gridManual[1, index].Style.ForeColor = Color.LimeGreen;
            gridManual[1, index].Style.Font = new System.Drawing.Font("Segoe UI", 10);
            
            gridManual[3, index].Style.Font = new System.Drawing.Font("Segoe UI", 10);
            gridManual[3, index].Style.ForeColor = Color.LimeGreen;

            return 1;
        }
        #endregion

        private void checkBoxModify_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModify.Checked)
            {
                isWorking = true;

                gridManual.ReadOnly = false;
                gridManual.Columns[1].ReadOnly = false;
                gridManual.Columns[2].ReadOnly = false;//
                gridManual.Columns[3].ReadOnly = false;
            }
            else
            {
                isWorking = false;

                gridManual.ReadOnly = true;
                gridManual.Columns[1].ReadOnly = true;
                gridManual.Columns[2].ReadOnly = true;//
                gridManual.Columns[3].ReadOnly = true;
            }
        }

        private void gridManual_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 1 || e.ColumnIndex == 3)
            {
                if (checkBoxModify.Checked)
                {
                    FormEditTenkeyName.oldTextBox = gridManual[e.ColumnIndex, e.RowIndex].Value.ToString();
                    FormEditTenkeyName form = new FormEditTenkeyName();
                    form.ShowDialog();
                    Descrip_CellValueChanged(e.RowIndex, e.ColumnIndex);
                }
                else
                {
                    int nTenkeyNum;
                    nTenkeyNum = Convert.ToInt32(gridManual[e.ColumnIndex - 1, e.RowIndex].Value.ToString());
                    string msg = string.Format("Ten Key [{0}] : {1}", nTenkeyNum, gridManual[e.ColumnIndex, e.RowIndex].Value.ToString());
                    if (MessageBox.Show(msg + "\n 실행하시겠습니까?", "Information", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                }
            }
        }

        private void Descrip_CellValueChanged(int row, int col)
        {
            if (!checkBoxModify.Checked)
                return;

            int nSelCh = comboBoxChannel.SelectedIndex;

            if (col == 1)
            {
                int nSelNo = nSelCh * 50;
                if (!gridManual.Columns[1].ReadOnly)
                {
                    try
                    {
                        gridManual[col, row].Value = newDescription;
                        tenkeyListXml.SetNodeVal(mainNode + (row + nSelNo).ToString(), newDescription);
                    }
                    catch (System.Exception)
                    {
                        tenkeyListXml.SetNodeVal(mainNode + (row + nSelNo).ToString(), " ");
                    }
                    
                }
            }
            else if (col == 3)
            {

                int nSelNo = 25 + (nSelCh * 50);
                if (!gridManual.Columns[1].ReadOnly)
                {
                    try
                    {
                        gridManual[col, row].Value = newDescription;
                        tenkeyListXml.SetNodeVal(mainNode + (row + nSelNo).ToString(), newDescription);
                    }
                    catch (System.Exception)
                    {
                        tenkeyListXml.SetNodeVal(mainNode + (row + nSelNo).ToString(), " ");
                    }
                }
            }
        }

        private void Descrip_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (!checkBoxModify.Checked)
            //    return;
            //if (e.ColumnIndex == 1)
            //{
            //    if (!gridManual.Columns[1].ReadOnly)
            //    {
            //        string strMainNode = "/Tenkey/Name";
            //        XmlNode node = TenkeyList.SelectSingleNode(strMainNode + e.RowIndex.ToString());

            //        try
            //        {
            //            node.InnerText = gridManual[e.ColumnIndex, e.RowIndex].Value.ToString();
            //        }
            //        catch (System.Exception)
            //        {
            //            node.InnerText = "";
            //        }
            //        TenkeyList.Save(m_strDBfile);
            //    }
            //}
            //else if (e.ColumnIndex == 3)
            //{
            //    if (!gridManual.Columns[1].ReadOnly)
            //    {
            //        string strMainNode = "/Tenkey/Name";
            //        XmlNode node = TenkeyList.SelectSingleNode(strMainNode + (e.RowIndex + 100).ToString());
            //        node.InnerText = gridManual[e.ColumnIndex, e.RowIndex].Value.ToString();
            //        TenkeyList.Save(m_strDBfile);
            //    }
            //}
        }

        private void comboBoxChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridManual.Rows.Clear();
            for (int cnt = 0; cnt < 25; cnt++)
                GetInitRow(cnt);
        }
    }
}
