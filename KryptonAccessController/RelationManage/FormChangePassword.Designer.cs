namespace KryptonAccessController.RelationManage
{
    partial class FormChangePassword
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
            this.components = new System.ComponentModel.Container();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.labelFailInfo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButtonCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabelNewPassword2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxNewPassword2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelNewPassword1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelOldPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxNewPassword1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBoxOldPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.labelFailInfo);
            this.kryptonPanel.Controls.Add(this.kryptonButtonCancel);
            this.kryptonPanel.Controls.Add(this.kryptonButtonOK);
            this.kryptonPanel.Controls.Add(this.kryptonLabelNewPassword2);
            this.kryptonPanel.Controls.Add(this.kryptonTextBoxNewPassword2);
            this.kryptonPanel.Controls.Add(this.kryptonLabelNewPassword1);
            this.kryptonPanel.Controls.Add(this.kryptonLabelOldPassword);
            this.kryptonPanel.Controls.Add(this.kryptonTextBoxNewPassword1);
            this.kryptonPanel.Controls.Add(this.kryptonTextBoxOldPassword);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(292, 246);
            this.kryptonPanel.TabIndex = 0;
            // 
            // labelFailInfo
            // 
            this.labelFailInfo.Location = new System.Drawing.Point(26, 157);
            this.labelFailInfo.Name = "labelFailInfo";
            this.labelFailInfo.Size = new System.Drawing.Size(6, 2);
            this.labelFailInfo.TabIndex = 12;
            this.labelFailInfo.Values.Text = "";
            // 
            // kryptonButtonCancel
            // 
            this.kryptonButtonCancel.Location = new System.Drawing.Point(149, 183);
            this.kryptonButtonCancel.Name = "kryptonButtonCancel";
            this.kryptonButtonCancel.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonCancel.TabIndex = 11;
            this.kryptonButtonCancel.Values.Text = "ȡ��";
            this.kryptonButtonCancel.Click += new System.EventHandler(this.kryptonButtonCancel_Click);
            // 
            // kryptonButtonOK
            // 
            this.kryptonButtonOK.Location = new System.Drawing.Point(24, 183);
            this.kryptonButtonOK.Name = "kryptonButtonOK";
            this.kryptonButtonOK.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonOK.TabIndex = 10;
            this.kryptonButtonOK.Values.Text = "ȷ��";
            this.kryptonButtonOK.Click += new System.EventHandler(this.kryptonButtonOK_Click);
            // 
            // kryptonLabelNewPassword2
            // 
            this.kryptonLabelNewPassword2.Location = new System.Drawing.Point(24, 115);
            this.kryptonLabelNewPassword2.Name = "kryptonLabelNewPassword2";
            this.kryptonLabelNewPassword2.Size = new System.Drawing.Size(51, 20);
            this.kryptonLabelNewPassword2.TabIndex = 9;
            this.kryptonLabelNewPassword2.Values.Text = "������:";
            // 
            // kryptonTextBoxNewPassword2
            // 
            this.kryptonTextBoxNewPassword2.Location = new System.Drawing.Point(94, 112);
            this.kryptonTextBoxNewPassword2.Name = "kryptonTextBoxNewPassword2";
            this.kryptonTextBoxNewPassword2.Size = new System.Drawing.Size(100, 20);
            this.kryptonTextBoxNewPassword2.TabIndex = 8;
            // 
            // kryptonLabelNewPassword1
            // 
            this.kryptonLabelNewPassword1.Location = new System.Drawing.Point(24, 75);
            this.kryptonLabelNewPassword1.Name = "kryptonLabelNewPassword1";
            this.kryptonLabelNewPassword1.Size = new System.Drawing.Size(51, 20);
            this.kryptonLabelNewPassword1.TabIndex = 7;
            this.kryptonLabelNewPassword1.Values.Text = "������:";
            // 
            // kryptonLabelOldPassword
            // 
            this.kryptonLabelOldPassword.Location = new System.Drawing.Point(24, 22);
            this.kryptonLabelOldPassword.Name = "kryptonLabelOldPassword";
            this.kryptonLabelOldPassword.Size = new System.Drawing.Size(51, 20);
            this.kryptonLabelOldPassword.TabIndex = 6;
            this.kryptonLabelOldPassword.Values.Text = "������:";
            // 
            // kryptonTextBoxNewPassword1
            // 
            this.kryptonTextBoxNewPassword1.Location = new System.Drawing.Point(94, 72);
            this.kryptonTextBoxNewPassword1.Name = "kryptonTextBoxNewPassword1";
            this.kryptonTextBoxNewPassword1.Size = new System.Drawing.Size(100, 20);
            this.kryptonTextBoxNewPassword1.TabIndex = 5;
            // 
            // kryptonTextBoxOldPassword
            // 
            this.kryptonTextBoxOldPassword.Location = new System.Drawing.Point(94, 19);
            this.kryptonTextBoxOldPassword.Name = "kryptonTextBoxOldPassword";
            this.kryptonTextBoxOldPassword.Size = new System.Drawing.Size(100, 20);
            this.kryptonTextBoxOldPassword.TabIndex = 4;
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 246);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FormChangePassword";
            this.Text = "�޸�����";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelNewPassword2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxNewPassword2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelNewPassword1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelOldPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxNewPassword1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxOldPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonOK;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelFailInfo;
    }
}

