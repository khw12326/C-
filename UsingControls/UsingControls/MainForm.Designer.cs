namespace UsingControls
{
    partial class MainForm2
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.chkitalic = new System.Windows.Forms.CheckBox();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.txtSampleText = new System.Windows.Forms.TextBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.grbBar = new System.Windows.Forms.GroupBox();
            this.pgDummy = new System.Windows.Forms.ProgressBar();
            this.tbDummy = new System.Windows.Forms.TrackBar();
            this.grpForm = new System.Windows.Forms.GroupBox();
            this.btnMsgBox = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.btnModal = new System.Windows.Forms.Button();
            this.grpTreeList = new System.Windows.Forms.GroupBox();
            this.lvDummy = new System.Windows.Forms.ListView();
            this.tvDummy = new System.Windows.Forms.TreeView();
            this.btnAddRoot = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.grpFont.SuspendLayout();
            this.grbBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).BeginInit();
            this.grpForm.SuspendLayout();
            this.grpTreeList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.lblFont);
            this.grpFont.Controls.Add(this.chkitalic);
            this.grpFont.Controls.Add(this.cboFont);
            this.grpFont.Controls.Add(this.txtSampleText);
            this.grpFont.Controls.Add(this.chkBold);
            this.grpFont.Location = new System.Drawing.Point(12, 11);
            this.grpFont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFont.Name = "grpFont";
            this.grpFont.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFont.Size = new System.Drawing.Size(363, 124);
            this.grpFont.TabIndex = 0;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "ComboBox,CheckBox,TextBox";
            this.grpFont.Enter += new System.EventHandler(this.w);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(8, 34);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(37, 12);
            this.lblFont.TabIndex = 1;
            this.lblFont.Text = "Font :";
            // 
            // chkitalic
            // 
            this.chkitalic.AutoSize = true;
            this.chkitalic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkitalic.Location = new System.Drawing.Point(281, 33);
            this.chkitalic.Name = "chkitalic";
            this.chkitalic.Size = new System.Drawing.Size(60, 16);
            this.chkitalic.TabIndex = 1;
            this.chkitalic.Text = "이탤릭";
            this.chkitalic.UseVisualStyleBackColor = true;
            this.chkitalic.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(51, 31);
            this.cboFont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(154, 20);
            this.cboFont.TabIndex = 1;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtSampleText
            // 
            this.txtSampleText.Location = new System.Drawing.Point(51, 66);
            this.txtSampleText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSampleText.Name = "txtSampleText";
            this.txtSampleText.Size = new System.Drawing.Size(301, 21);
            this.txtSampleText.TabIndex = 1;
            this.txtSampleText.Text = "Hello, C#";
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.chkBold.Location = new System.Drawing.Point(225, 33);
            this.chkBold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(50, 16);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grbBar
            // 
            this.grbBar.Controls.Add(this.pgDummy);
            this.grbBar.Controls.Add(this.tbDummy);
            this.grbBar.Location = new System.Drawing.Point(12, 140);
            this.grbBar.Name = "grbBar";
            this.grbBar.Size = new System.Drawing.Size(363, 125);
            this.grbBar.TabIndex = 1;
            this.grbBar.TabStop = false;
            this.grbBar.Text = "TrackBar && ProgressBar";
            // 
            // pgDummy
            // 
            this.pgDummy.Location = new System.Drawing.Point(10, 71);
            this.pgDummy.Maximum = 20;
            this.pgDummy.Name = "pgDummy";
            this.pgDummy.Size = new System.Drawing.Size(342, 23);
            this.pgDummy.TabIndex = 3;
            this.pgDummy.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // tbDummy
            // 
            this.tbDummy.Location = new System.Drawing.Point(10, 20);
            this.tbDummy.Maximum = 20;
            this.tbDummy.Name = "tbDummy";
            this.tbDummy.Size = new System.Drawing.Size(342, 45);
            this.tbDummy.TabIndex = 2;
            // 
            // grpForm
            // 
            this.grpForm.Controls.Add(this.btnMsgBox);
            this.grpForm.Controls.Add(this.btnModaless);
            this.grpForm.Controls.Add(this.btnModal);
            this.grpForm.Location = new System.Drawing.Point(12, 271);
            this.grpForm.Name = "grpForm";
            this.grpForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpForm.Size = new System.Drawing.Size(363, 64);
            this.grpForm.TabIndex = 4;
            this.grpForm.TabStop = false;
            this.grpForm.Text = "Modal && Modaless";
            this.grpForm.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // btnMsgBox
            // 
            this.btnMsgBox.Location = new System.Drawing.Point(208, 17);
            this.btnMsgBox.Name = "btnMsgBox";
            this.btnMsgBox.Size = new System.Drawing.Size(121, 23);
            this.btnMsgBox.TabIndex = 2;
            this.btnMsgBox.Text = "MessageBox";
            this.btnMsgBox.UseVisualStyleBackColor = true;
            // 
            // btnModaless
            // 
            this.btnModaless.Location = new System.Drawing.Point(127, 17);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(75, 23);
            this.btnModaless.TabIndex = 1;
            this.btnModaless.Text = "Modaless";
            this.btnModaless.UseVisualStyleBackColor = true;
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(46, 17);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(75, 23);
            this.btnModal.TabIndex = 0;
            this.btnModal.Text = "Modal";
            this.btnModal.UseVisualStyleBackColor = true;
            // 
            // grpTreeList
            // 
            this.grpTreeList.Controls.Add(this.lvDummy);
            this.grpTreeList.Controls.Add(this.tvDummy);
            this.grpTreeList.Location = new System.Drawing.Point(12, 341);
            this.grpTreeList.Name = "grpTreeList";
            this.grpTreeList.Size = new System.Drawing.Size(363, 151);
            this.grpTreeList.TabIndex = 5;
            this.grpTreeList.TabStop = false;
            this.grpTreeList.Text = "TreeView && ListView";
            // 
            // lvDummy
            // 
            this.lvDummy.HideSelection = false;
            this.lvDummy.Location = new System.Drawing.Point(182, 17);
            this.lvDummy.Name = "lvDummy";
            this.lvDummy.Size = new System.Drawing.Size(170, 126);
            this.lvDummy.TabIndex = 1;
            this.lvDummy.UseCompatibleStateImageBehavior = false;
            this.lvDummy.View = System.Windows.Forms.View.Details;
            // 
            // tvDummy
            // 
            this.tvDummy.Location = new System.Drawing.Point(3, 17);
            this.tvDummy.Name = "tvDummy";
            this.tvDummy.Size = new System.Drawing.Size(173, 128);
            this.tvDummy.TabIndex = 0;
            this.tvDummy.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnAddRoot
            // 
            this.btnAddRoot.Location = new System.Drawing.Point(15, 498);
            this.btnAddRoot.Name = "btnAddRoot";
            this.btnAddRoot.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoot.TabIndex = 6;
            this.btnAddRoot.Text = "루트 추가";
            this.btnAddRoot.UseVisualStyleBackColor = true;
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(96, 498);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(75, 23);
            this.btnAddChild.TabIndex = 7;
            this.btnAddChild.Text = "자식 추가";
            this.btnAddChild.UseVisualStyleBackColor = true;
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 533);
            this.Controls.Add(this.btnAddChild);
            this.Controls.Add(this.btnAddRoot);
            this.Controls.Add(this.grpTreeList);
            this.Controls.Add(this.grpForm);
            this.Controls.Add(this.grbBar);
            this.Controls.Add(this.grpFont);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.grbBar.ResumeLayout(false);
            this.grbBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).EndInit();
            this.grpForm.ResumeLayout(false);
            this.grpTreeList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.TextBox txtSampleText;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkitalic;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.GroupBox grbBar;
        private System.Windows.Forms.ProgressBar pgDummy;
        private System.Windows.Forms.TrackBar tbDummy;
        private System.Windows.Forms.GroupBox grpForm;
        private System.Windows.Forms.Button btnMsgBox;
        private System.Windows.Forms.Button btnModaless;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.GroupBox grpTreeList;
        private System.Windows.Forms.ListView lvDummy;
        private System.Windows.Forms.TreeView tvDummy;
        private System.Windows.Forms.Button btnAddRoot;
        private System.Windows.Forms.Button btnAddChild;
    }
}

