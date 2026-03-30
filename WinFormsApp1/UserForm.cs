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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();

            queryUser();
        }

        private void queryUser()
        {
            List<UserEntity> list = SqlHelper.GetInstance.Queryable<UserEntity>().ToList();

           var result = SqlHelper.GetInstance.Queryable<UserEntity>()
                .LeftJoin<UserverAndAuthority>((u, ua) => u.uid == ua.uid)
                .LeftJoin<AuthorityEntity>((u, ua, a) => ua.aid == a.aid)
                .Select((u, ua, a) => new {
                    Uid=u.uid,
                    UserName = u.userName,
                    Account = u.accountNumber,
                    Password = u.password,
                    IoManage = a.IoManage,
                    CameraManage = a.CameraManage,
                    LogManage = a.LogManage,
                    CountManage = a.CountManage,
                    UserManage = a.UserManage,
                    Aid = ua.aid,
                    })
                .ToList();
            Debug.WriteLine(result.Count.ToString());

            this.uiDataGridView1.DataSource = null;
            this.uiDataGridView1.DataSource = result;

        }
    }
}
