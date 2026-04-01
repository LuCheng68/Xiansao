using SqlSugar;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Entity;
using WinFormsApp1.Helper;

namespace WinFormsApp1
{
    public partial class Log : Form
    {
        List<levelLog> list = new List<levelLog>();
        /// <summary>
        /// 当前页码 不能从0开始
        /// </summary>
        private int pageNumber = 1;
        /// <summary>
        /// 每页显示条数
        /// </summary>
        private int pageSize = 12;
        /// <summary>
        /// 总条数
        /// </summary>
        private int totalCount = 0;
        /// <summary>
        /// 总页数
        /// </summary>
        private int totalPage = 0;

        public Log()
        {
            InitializeComponent();

            queryData();
            uiDataGridView2.AutoGenerateColumns = false;
            levelLog();

        }

        public void levelLog()
        {
            list.Add(new levelLog() { Id = 1, Name = "信息" });
            list.Add(new levelLog() { Id = 2, Name = "警告" });
            list.Add(new levelLog() { Id = 3, Name = "报警" });

            uiComboBox1.DataSource = list;
            uiComboBox1.DisplayMember = "Name";
            uiComboBox1.ValueMember = "Id";
            //默认空
            uiComboBox1.SelectedIndex = -1;

            uiDatePicker1.Text = string.Empty;
        }

        private void queryData()
        {
            var expable = Expressionable.Create<logEntity>();
            if (!string.IsNullOrEmpty(uiTextBox1.Text.Trim()))
            {
                //模糊查询
                expable.And(l => l.userName.Contains(uiTextBox1.Text.Trim()));
            }
            if (!string.IsNullOrEmpty(uiDatePicker1.Text.Trim()))
            {
                expable.And(l => l.logTime >= DateTime.Parse(uiDatePicker1.Text));
            }
            if (uiComboBox1.SelectedIndex >= 0)
            {
                expable.And(l => l.logLevel == int.Parse(uiComboBox1.SelectedValue.ToString()));
            }

            this.uiDataGridView2.DataSource = null;
            this.uiDataGridView2.DataSource = SqlHelper.GetInstance.Queryable<logEntity>().Where(expable.ToExpression())
                .OrderBy(y => y.logTime, OrderByType.Desc).Select(t => new
                {
                    UsersName = t.userName,
                    LogTime = t.logTime,
                    LogLevel = t.logLevel == 1 ? "信息" : t.logLevel == 2 ? "警告" : "报警",
                    DeviceSouce = t.deviceSouce,
                    LogCentent = t.logCentene,
                }).ToPageList(pageNumber, pageSize, ref totalCount, ref totalPage);

            uiLabel4.Text = $"共{totalPage}页，当前第{pageNumber}页  共{totalCount}条数据";


        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            queryData();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            uiDatePicker1.Text = string.Empty;
            uiTextBox1.Text = string.Empty;
            uiComboBox1.SelectedIndex = -1;
            queryData();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            if (pageNumber <= 1)
            {
                this.ShowErrorTip("已经到顶了");
                return;
            }
            pageNumber--;
            queryData();
        }

        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            if (pageNumber >= totalPage)
            {
                this.ShowErrorTip("已经是最后一页");
                return;
            }
            pageNumber++;
            queryData();
        }

        private void uiButton5_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(uiTextBox2.Text, out int page))
            {
                this.ShowErrorTip("请输入数字！");
                return;
            }
            if (page > totalPage)
            {
                this.ShowErrorTip($"请输入1-{totalPage}的页数");
                return;
            }
            if (page < 1)
            {
                this.ShowErrorTip("请输入大于0的页数");
                return;
            }
            pageNumber = page;
            queryData();
        }
    }
}
