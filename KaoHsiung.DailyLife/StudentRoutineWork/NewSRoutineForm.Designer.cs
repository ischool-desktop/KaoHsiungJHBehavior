namespace KaoHsiung.DailyLife.StudentRoutineWork
{
    partial class NewSRoutineForm
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.cbPrintUpdateStudentFile = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbPrintSaveFile = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbIsDoc = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbIsPdf = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.labelX1.Location = new System.Drawing.Point(22, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(281, 21);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "列印訓導記錄表除產生報表,您可以有以下選擇:";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.btnClose.Location = new System.Drawing.Point(318, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "關閉";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.btnSave.Location = new System.Drawing.Point(237, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "列印";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbPrintUpdateStudentFile
            // 
            this.cbPrintUpdateStudentFile.AutoSize = true;
            this.cbPrintUpdateStudentFile.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbPrintUpdateStudentFile.BackgroundStyle.Class = "";
            this.cbPrintUpdateStudentFile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbPrintUpdateStudentFile.Location = new System.Drawing.Point(38, 60);
            this.cbPrintUpdateStudentFile.Name = "cbPrintUpdateStudentFile";
            this.cbPrintUpdateStudentFile.Size = new System.Drawing.Size(147, 21);
            this.cbPrintUpdateStudentFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbPrintUpdateStudentFile.TabIndex = 7;
            this.cbPrintUpdateStudentFile.Text = "上傳為學生電子報表";
            // 
            // cbPrintSaveFile
            // 
            this.cbPrintSaveFile.AutoSize = true;
            this.cbPrintSaveFile.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbPrintSaveFile.BackgroundStyle.Class = "";
            this.cbPrintSaveFile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbPrintSaveFile.Location = new System.Drawing.Point(38, 92);
            this.cbPrintSaveFile.Name = "cbPrintSaveFile";
            this.cbPrintSaveFile.Size = new System.Drawing.Size(276, 21);
            this.cbPrintSaveFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbPrintSaveFile.TabIndex = 8;
            this.cbPrintSaveFile.Text = "進行單檔列印(一名學生一張報表另存新檔)";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(57, 124);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(257, 21);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "(檔名規格:學號_身分證號_班級_座號_姓名)";
            // 
            // cbIsDoc
            // 
            this.cbIsDoc.AutoSize = true;
            this.cbIsDoc.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbIsDoc.BackgroundStyle.Class = "";
            this.cbIsDoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsDoc.Checked = true;
            this.cbIsDoc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsDoc.CheckValue = "Y";
            this.cbIsDoc.Location = new System.Drawing.Point(38, 194);
            this.cbIsDoc.Name = "cbIsDoc";
            this.cbIsDoc.Size = new System.Drawing.Size(55, 21);
            this.cbIsDoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsDoc.TabIndex = 14;
            this.cbIsDoc.Text = ".Doc";
            this.cbIsDoc.CheckedChanged += new System.EventHandler(this.cbIsDoc_CheckedChanged);
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.labelX3.Location = new System.Drawing.Point(22, 167);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(90, 21);
            this.labelX3.TabIndex = 15;
            this.labelX3.Text = "檔案格式選擇:";
            // 
            // cbIsPdf
            // 
            this.cbIsPdf.AutoSize = true;
            this.cbIsPdf.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbIsPdf.BackgroundStyle.Class = "";
            this.cbIsPdf.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsPdf.Location = new System.Drawing.Point(130, 194);
            this.cbIsPdf.Name = "cbIsPdf";
            this.cbIsPdf.Size = new System.Drawing.Size(51, 21);
            this.cbIsPdf.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsPdf.TabIndex = 16;
            this.cbIsPdf.Text = ".Pdf";
            this.cbIsPdf.CheckedChanged += new System.EventHandler(this.cbIsPdf_CheckedChanged);
            // 
            // NewSRoutineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 250);
            this.Controls.Add(this.cbIsPdf);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.cbIsDoc);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cbPrintSaveFile);
            this.Controls.Add(this.cbPrintUpdateStudentFile);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.DoubleBuffered = true;
            this.Name = "NewSRoutineForm";
            this.Text = "學生訓導記錄表";
            this.Load += new System.EventHandler(this.NewSRoutineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbPrintUpdateStudentFile;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbPrintSaveFile;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsDoc;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsPdf;
    }
}