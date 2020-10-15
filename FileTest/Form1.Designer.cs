namespace FileTest
{
    partial class Main
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
            this.uiTlb_Main = new System.Windows.Forms.TableLayoutPanel();
            this.uiBtn_CreateFile = new System.Windows.Forms.Button();
            this.uiBtn_WriteFile = new System.Windows.Forms.Button();
            this.uiBtn_DeleteFile = new System.Windows.Forms.Button();
            this.uiTlb_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTlb_Main
            // 
            this.uiTlb_Main.ColumnCount = 3;
            this.uiTlb_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.uiTlb_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.uiTlb_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.uiTlb_Main.Controls.Add(this.uiBtn_DeleteFile, 2, 0);
            this.uiTlb_Main.Controls.Add(this.uiBtn_WriteFile, 1, 0);
            this.uiTlb_Main.Controls.Add(this.uiBtn_CreateFile, 0, 0);
            this.uiTlb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlb_Main.Location = new System.Drawing.Point(0, 0);
            this.uiTlb_Main.Name = "uiTlb_Main";
            this.uiTlb_Main.RowCount = 1;
            this.uiTlb_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTlb_Main.Size = new System.Drawing.Size(457, 130);
            this.uiTlb_Main.TabIndex = 0;
            // 
            // uiBtn_CreateFile
            // 
            this.uiBtn_CreateFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiBtn_CreateFile.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiBtn_CreateFile.Location = new System.Drawing.Point(3, 3);
            this.uiBtn_CreateFile.Name = "uiBtn_CreateFile";
            this.uiBtn_CreateFile.Size = new System.Drawing.Size(146, 124);
            this.uiBtn_CreateFile.TabIndex = 0;
            this.uiBtn_CreateFile.Text = "File Create";
            this.uiBtn_CreateFile.UseVisualStyleBackColor = true;
            // 
            // uiBtn_WriteFile
            // 
            this.uiBtn_WriteFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiBtn_WriteFile.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiBtn_WriteFile.Location = new System.Drawing.Point(155, 3);
            this.uiBtn_WriteFile.Name = "uiBtn_WriteFile";
            this.uiBtn_WriteFile.Size = new System.Drawing.Size(146, 124);
            this.uiBtn_WriteFile.TabIndex = 1;
            this.uiBtn_WriteFile.Text = "File Write";
            this.uiBtn_WriteFile.UseVisualStyleBackColor = true;
            // 
            // uiBtn_DeleteFile
            // 
            this.uiBtn_DeleteFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiBtn_DeleteFile.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiBtn_DeleteFile.Location = new System.Drawing.Point(307, 3);
            this.uiBtn_DeleteFile.Name = "uiBtn_DeleteFile";
            this.uiBtn_DeleteFile.Size = new System.Drawing.Size(147, 124);
            this.uiBtn_DeleteFile.TabIndex = 2;
            this.uiBtn_DeleteFile.Text = "File Delete";
            this.uiBtn_DeleteFile.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 130);
            this.Controls.Add(this.uiTlb_Main);
            this.Name = "Main";
            this.Text = "FileTestProgram";
            this.uiTlb_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uiTlb_Main;
        private System.Windows.Forms.Button uiBtn_DeleteFile;
        private System.Windows.Forms.Button uiBtn_WriteFile;
        private System.Windows.Forms.Button uiBtn_CreateFile;
    }
}

