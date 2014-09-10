using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using KryptonAccessController.Common;
using KryptonAccessController.ResourcesFile;

namespace KryptonAccessController.RelationManage
{
    public partial class FormChangePassword : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        AccessDataBase.Model.Manager modelManager = new AccessDataBase.Model.Manager();
        AccessDataBase.BLL.Manager bllManager = new AccessDataBase.BLL.Manager();
        public FormChangePassword()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Icon = GetResourcesFile.getSystemIco();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

        }
        private Boolean VerifyOldPassword()
        {

            if (string.IsNullOrEmpty(kryptonTextBoxOldPassword.Text.Trim()))
            {
                labelFailInfo.Text = "���벻��Ϊ��";
                return false;
            }

            if (RegexMatch.IsManagerPassword(kryptonTextBoxOldPassword.Text.Trim()) == false)
            {
                labelFailInfo.Text =  "�����ʽ��Ч";
                return false;

            }
            if (!Admin.password.Equals(kryptonTextBoxOldPassword.Text))
            {
                labelFailInfo.Text = "�������";
                return false;
            }
            return true;
        }
        private Boolean VerifyNewPassword1()
        {

            if (string.IsNullOrEmpty(kryptonTextBoxNewPassword1.Text.Trim()))
            {
                labelFailInfo.Text = "���벻��Ϊ��";
                return false;
            }

            if (RegexMatch.IsManagerPassword(kryptonTextBoxNewPassword1.Text.Trim()) == false)
            {
                labelFailInfo.Text = "�����ʽ��Ч";
                return false;

            }
            return true;
        }
        private Boolean VerifyNewPassword2()
        {

            if (string.IsNullOrEmpty(kryptonTextBoxNewPassword2.Text.Trim()))
            {
                labelFailInfo.Text = "���벻��Ϊ��";
                WidgetThread.WidgetThread.shakeLable(labelFailInfo);
                return false;
            }

            if (RegexMatch.IsManagerPassword(kryptonTextBoxNewPassword2.Text.Trim()) == false)
            {
                labelFailInfo.Text = "�����ʽ��Ч";
                WidgetThread.WidgetThread.shakeLable(labelFailInfo);
                return false;

            }
            return true;
        }

        private void kryptonButtonOK_Click(object sender, EventArgs e)
        {
            #region ��֤������
            if (VerifyOldPassword() == false)
            {
                WidgetThread.WidgetThread.shakeLable(labelFailInfo);
                kryptonTextBoxOldPassword.Focus();
                return;
            }
            #endregion

            #region ��֤������1
            if (VerifyNewPassword1() == false)
            {
                WidgetThread.WidgetThread.shakeLable(labelFailInfo);
                kryptonTextBoxNewPassword1.Focus();
                return;
            } 
            #endregion

            #region ��֤������2
            if (VerifyNewPassword2() == false)
            {
                WidgetThread.WidgetThread.shakeLable(labelFailInfo);
                kryptonTextBoxNewPassword2.Focus();
                return;
            }
            #endregion

            #region �Ա�����1 ������2
            if (!kryptonTextBoxNewPassword1.Text.Trim().Equals(kryptonTextBoxNewPassword2.Text.Trim()))
            {
                labelFailInfo.Text = "����1 ������2 ����ͬ";
                WidgetThread.WidgetThread.shakeLable(labelFailInfo);

                kryptonTextBoxNewPassword2.Focus();
                return;
            }
            #endregion

            modelManager.ManagerName = Admin.name;
            modelManager.ManagerPassWord = kryptonTextBoxNewPassword2.Text.Trim();

            if (bllManager.Update(modelManager))
            {
                MyMessageBox.MessageBoxOK("��������ɹ�");
                this.Close();
            }
            else
            {
                MyMessageBox.MessageBoxOK("��������ʧ��");
            }
        }

        private void kryptonButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}