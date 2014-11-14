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
               this.btnClose.AutoSize = true;
               this.btnClose.BackColor = System.Drawing.Color.Transparent;
               this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
               this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
               this.btnClose.Location = new System.Drawing.Point(317, 137);
               this.btnClose.Name = "btnClose";
               this.btnClose.Size = new System.Drawing.Size(75, 25);
               this.btnClose.TabIndex = 4;
               this.btnClose.Text = "關閉";
               this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
               // 
               // btnSave
               // 
               this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
               this.btnSave.AutoSize = true;
               this.btnSave.BackColor = System.Drawing.Color.Transparent;
               this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
               this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
               this.btnSave.Location = new System.Drawing.Point(236, 137);
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
               this.cbPrintUpdateStudentFile.Size = new System.Drawing.Size(201, 21);
               this.cbPrintUpdateStudentFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
               this.cbPrintUpdateStudentFile.TabIndex = 7;
               this.cbPrintUpdateStudentFile.Text = "列印完成上傳為學生電子報表";
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
               this.cbPrintSaveFile.Size = new System.Drawing.Size(343, 21);
               this.cbPrintSaveFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
               this.cbPrintSaveFile.TabIndex = 8;
               this.cbPrintSaveFile.Text = "列印完成另存新檔(需另外選擇儲存檔案之資料夾位置)";
               // 
               // NewSRoutineForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(402, 168);
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
    }
}