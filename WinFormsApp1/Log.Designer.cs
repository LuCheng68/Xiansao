namespace WinFormsApp1
{
    partial class Log
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiTextBox2 = new Sunny.UI.UITextBox();
            uiButton5 = new Sunny.UI.UIButton();
            uiButton4 = new Sunny.UI.UIButton();
            uiLabel4 = new Sunny.UI.UILabel();
            uiButton3 = new Sunny.UI.UIButton();
            uiLabel5 = new Sunny.UI.UILabel();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            uiDataGridView2 = new Sunny.UI.UIDataGridView();
            UsersName = new DataGridViewTextBoxColumn();
            LogTime = new DataGridViewTextBoxColumn();
            LogLevel = new DataGridViewTextBoxColumn();
            DeviceSouce = new DataGridViewTextBoxColumn();
            LogCentent = new DataGridViewTextBoxColumn();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            uiDatePicker1 = new Sunny.UI.UIDatePicker();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            uiPanel1.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView2).BeginInit();
            uiGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiTextBox2);
            uiPanel1.Controls.Add(uiButton5);
            uiPanel1.Controls.Add(uiButton4);
            uiPanel1.Controls.Add(uiLabel4);
            uiPanel1.Controls.Add(uiButton3);
            uiPanel1.Controls.Add(uiLabel5);
            uiPanel1.Dock = DockStyle.Bottom;
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(0, 545);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(1258, 72);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTextBox2
            // 
            uiTextBox2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTextBox2.Location = new Point(900, 14);
            uiTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiTextBox2.MinimumSize = new Size(1, 16);
            uiTextBox2.Name = "uiTextBox2";
            uiTextBox2.Padding = new Padding(5);
            uiTextBox2.ShowText = false;
            uiTextBox2.Size = new Size(112, 44);
            uiTextBox2.TabIndex = 2;
            uiTextBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox2.Watermark = "";
            // 
            // uiButton5
            // 
            uiButton5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton5.Location = new Point(1041, 18);
            uiButton5.MinimumSize = new Size(1, 1);
            uiButton5.Name = "uiButton5";
            uiButton5.Size = new Size(113, 36);
            uiButton5.TabIndex = 1;
            uiButton5.Text = "页面转跳";
            uiButton5.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton5.Click += uiButton5_Click_1;
            // 
            // uiButton4
            // 
            uiButton4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton4.Location = new Point(627, 18);
            uiButton4.MinimumSize = new Size(1, 1);
            uiButton4.Name = "uiButton4";
            uiButton4.Size = new Size(113, 36);
            uiButton4.TabIndex = 1;
            uiButton4.Text = "下一页";
            uiButton4.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton4.Click += uiButton4_Click;
            // 
            // uiLabel4
            // 
            uiLabel4.BackColor = Color.Transparent;
            uiLabel4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(12, 19);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(427, 34);
            uiLabel4.TabIndex = 3;
            uiLabel4.Text = "共10页，当前第1页    共900条数据";
            uiLabel4.Click += uiLabel4_Click;
            // 
            // uiButton3
            // 
            uiButton3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton3.Location = new Point(445, 18);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.Size = new Size(113, 36);
            uiButton3.TabIndex = 1;
            uiButton3.Text = "上一页";
            uiButton3.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton3.Click += uiButton3_Click;
            // 
            // uiLabel5
            // 
            uiLabel5.BackColor = Color.Transparent;
            uiLabel5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(746, 19);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(157, 34);
            uiLabel5.TabIndex = 3;
            uiLabel5.Text = "请输入页码：";
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(uiDataGridView2);
            uiGroupBox1.Controls.Add(uiGroupBox2);
            uiGroupBox1.Dock = DockStyle.Fill;
            uiGroupBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiGroupBox1.Location = new Point(0, 0);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(1258, 545);
            uiGroupBox1.TabIndex = 1;
            uiGroupBox1.Text = "日志管理";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiDataGridView2
            // 
            uiDataGridView2.AllowUserToAddRows = false;
            uiDataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView2.BackgroundColor = Color.White;
            uiDataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView2.ColumnHeadersHeight = 32;
            uiDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView2.Columns.AddRange(new DataGridViewColumn[] { UsersName, LogTime, LogLevel, DeviceSouce, LogCentent });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView2.Dock = DockStyle.Fill;
            uiDataGridView2.EnableHeadersVisualStyles = false;
            uiDataGridView2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView2.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView2.Location = new Point(0, 121);
            uiDataGridView2.Name = "uiDataGridView2";
            uiDataGridView2.ReadOnly = true;
            uiDataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            uiDataGridView2.RowHeadersVisible = false;
            uiDataGridView2.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView2.SelectedIndex = -1;
            uiDataGridView2.Size = new Size(1258, 424);
            uiDataGridView2.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView2.TabIndex = 9;
            // 
            // UsersName
            // 
            UsersName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            UsersName.DataPropertyName = "UsersName";
            UsersName.Frozen = true;
            UsersName.HeaderText = "用户名称";
            UsersName.MinimumWidth = 8;
            UsersName.Name = "UsersName";
            UsersName.ReadOnly = true;
            UsersName.Resizable = DataGridViewTriState.False;
            UsersName.Width = 141;
            // 
            // LogTime
            // 
            LogTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            LogTime.DataPropertyName = "LogTime";
            LogTime.HeaderText = "操作时间";
            LogTime.MinimumWidth = 200;
            LogTime.Name = "LogTime";
            LogTime.ReadOnly = true;
            LogTime.Width = 200;
            // 
            // LogLevel
            // 
            LogLevel.DataPropertyName = "LogLevel";
            LogLevel.HeaderText = "日志等级";
            LogLevel.MinimumWidth = 8;
            LogLevel.Name = "LogLevel";
            LogLevel.ReadOnly = true;
            LogLevel.Width = 150;
            // 
            // DeviceSouce
            // 
            DeviceSouce.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DeviceSouce.DataPropertyName = "DeviceSouce";
            DeviceSouce.HeaderText = "来源设备";
            DeviceSouce.MinimumWidth = 8;
            DeviceSouce.Name = "DeviceSouce";
            DeviceSouce.ReadOnly = true;
            DeviceSouce.Width = 141;
            // 
            // LogCentent
            // 
            LogCentent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LogCentent.DataPropertyName = "LogCentent";
            LogCentent.HeaderText = "操作内容";
            LogCentent.MinimumWidth = 8;
            LogCentent.Name = "LogCentent";
            LogCentent.ReadOnly = true;
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(uiComboBox1);
            uiGroupBox2.Controls.Add(uiDatePicker1);
            uiGroupBox2.Controls.Add(uiLabel3);
            uiGroupBox2.Controls.Add(uiLabel2);
            uiGroupBox2.Controls.Add(uiLabel1);
            uiGroupBox2.Controls.Add(uiTextBox1);
            uiGroupBox2.Controls.Add(uiButton2);
            uiGroupBox2.Controls.Add(uiButton1);
            uiGroupBox2.Dock = DockStyle.Top;
            uiGroupBox2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiGroupBox2.Location = new Point(0, 32);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.Size = new Size(1258, 89);
            uiGroupBox2.TabIndex = 0;
            uiGroupBox2.Text = "查询条件";
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiComboBox1
            // 
            uiComboBox1.DataSource = null;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiComboBox1.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiComboBox1.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiComboBox1.Location = new Point(838, 37);
            uiComboBox1.Margin = new Padding(4, 5, 4, 5);
            uiComboBox1.MinimumSize = new Size(63, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 30, 2);
            uiComboBox1.Size = new Size(174, 44);
            uiComboBox1.SymbolSize = 24;
            uiComboBox1.TabIndex = 8;
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.Watermark = "";
            // 
            // uiDatePicker1
            // 
            uiDatePicker1.DateCultureInfo = new System.Globalization.CultureInfo("");
            uiDatePicker1.FillColor = Color.White;
            uiDatePicker1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDatePicker1.Location = new Point(476, 37);
            uiDatePicker1.Margin = new Padding(4, 5, 4, 5);
            uiDatePicker1.MaxLength = 10;
            uiDatePicker1.MinimumSize = new Size(63, 0);
            uiDatePicker1.Name = "uiDatePicker1";
            uiDatePicker1.Padding = new Padding(0, 0, 30, 2);
            uiDatePicker1.Size = new Size(225, 44);
            uiDatePicker1.SymbolDropDown = 61555;
            uiDatePicker1.SymbolNormal = 61555;
            uiDatePicker1.SymbolSize = 24;
            uiDatePicker1.TabIndex = 5;
            uiDatePicker1.Text = "2026-04-01";
            uiDatePicker1.TextAlignment = ContentAlignment.MiddleLeft;
            uiDatePicker1.Value = new DateTime(2026, 4, 1, 0, 53, 6, 484);
            uiDatePicker1.Watermark = "";
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            uiLabel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(714, 42);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(111, 34);
            uiLabel3.TabIndex = 3;
            uiLabel3.Text = "日志等级";
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.Transparent;
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(352, 42);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(111, 34);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "选择时间";
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(12, 42);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(114, 34);
            uiLabel1.TabIndex = 3;
            uiLabel1.Text = "用户账号";
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTextBox1.Location = new Point(139, 37);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(200, 44);
            uiTextBox1.TabIndex = 2;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // uiButton2
            // 
            uiButton2.FillColor = Color.FromArgb(192, 255, 192);
            uiButton2.FillHoverColor = Color.FromArgb(128, 255, 128);
            uiButton2.FillPressColor = Color.Lime;
            uiButton2.FillSelectedColor = Color.FromArgb(0, 192, 0);
            uiButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.ForeColor = Color.Black;
            uiButton2.ForeHoverColor = Color.Black;
            uiButton2.ForePressColor = Color.Black;
            uiButton2.ForeSelectedColor = Color.Black;
            uiButton2.Location = new Point(1130, 41);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(92, 36);
            uiButton2.TabIndex = 1;
            uiButton2.Text = "重置";
            uiButton2.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.Click += uiButton2_Click;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Location = new Point(1025, 41);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(92, 36);
            uiButton1.TabIndex = 1;
            uiButton1.Text = "查询";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Click += uiButton1_Click;
            // 
            // Log
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 617);
            Controls.Add(uiGroupBox1);
            Controls.Add(uiPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Log";
            Text = "Log";
            uiPanel1.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView2).EndInit();
            uiGroupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIButton uiButton5;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIDataGridView uiDataGridView2;
        private DataGridViewTextBoxColumn UsersName;
        private DataGridViewTextBoxColumn LogTime;
        private DataGridViewTextBoxColumn LogLevel;
        private DataGridViewTextBoxColumn DeviceSouce;
        private DataGridViewTextBoxColumn LogCentent;
    }
}