namespace KaoHsiung.DailyLife
{
    partial class DailyLifeConfigForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.gpPublicService = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvPublicService = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpGroupActivity = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvGroupActivity = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpSchoolSpecial = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvSchoolSpecial = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.gpDailyBehavior = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvDailyBehavior = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkDailyBehavior = new System.Windows.Forms.LinkLabel();
            this.txtDailyBehavior = new System.Windows.Forms.TextBox();
            this.txtPublicService = new System.Windows.Forms.TextBox();
            this.txtSchoolSpecial = new System.Windows.Forms.TextBox();
            this.txtGroupActivity = new System.Windows.Forms.TextBox();
            this.lnkPublicService = new System.Windows.Forms.LinkLabel();
            this.lnkGroupActivity = new System.Windows.Forms.LinkLabel();
            this.lnkSchoolSpecial = new System.Windows.Forms.LinkLabel();
            this.gpDailyLifeRecommend = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lnkDailyLifeRecommend = new System.Windows.Forms.LinkLabel();
            this.txtDailyLifeRecommend = new System.Windows.Forms.TextBox();
            this.gpPublicService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicService)).BeginInit();
            this.gpGroupActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupActivity)).BeginInit();
            this.gpSchoolSpecial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolSpecial)).BeginInit();
            this.gpDailyBehavior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyBehavior)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.btnSave.Location = new System.Drawing.Point(619, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "儲存";
            this.btnSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // gpPublicService
            // 
            this.gpPublicService.BackColor = System.Drawing.Color.Transparent;
            this.gpPublicService.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpPublicService.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpPublicService.Controls.Add(this.dgvPublicService);
            this.gpPublicService.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.gpPublicService.Location = new System.Drawing.Point(265, 193);
            this.gpPublicService.Name = "gpPublicService";
            this.gpPublicService.Size = new System.Drawing.Size(249, 160);
            // 
            // 
            // 
            this.gpPublicService.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpPublicService.Style.BackColorGradientAngle = 90;
            this.gpPublicService.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpPublicService.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpPublicService.Style.BorderBottomWidth = 1;
            this.gpPublicService.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpPublicService.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpPublicService.Style.BorderLeftWidth = 1;
            this.gpPublicService.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpPublicService.Style.BorderRightWidth = 1;
            this.gpPublicService.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpPublicService.Style.BorderTopWidth = 1;
            this.gpPublicService.Style.Class = "";
            this.gpPublicService.Style.CornerDiameter = 4;
            this.gpPublicService.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpPublicService.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpPublicService.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpPublicService.StyleMouseDown.Class = "";
            this.gpPublicService.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpPublicService.StyleMouseOver.Class = "";
            this.gpPublicService.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpPublicService.TabIndex = 2;
            this.gpPublicService.Text = "公共服務表現";
            // 
            // dgvPublicService
            // 
            this.dgvPublicService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublicService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPublicService.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPublicService.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPublicService.Location = new System.Drawing.Point(7, 6);
            this.dgvPublicService.Name = "dgvPublicService";
            this.dgvPublicService.RowTemplate.Height = 24;
            this.dgvPublicService.Size = new System.Drawing.Size(228, 120);
            this.dgvPublicService.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "項目名稱";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "顯示順序";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // gpGroupActivity
            // 
            this.gpGroupActivity.BackColor = System.Drawing.Color.Transparent;
            this.gpGroupActivity.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpGroupActivity.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpGroupActivity.Controls.Add(this.dgvGroupActivity);
            this.gpGroupActivity.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.gpGroupActivity.Location = new System.Drawing.Point(11, 193);
            this.gpGroupActivity.Name = "gpGroupActivity";
            this.gpGroupActivity.Size = new System.Drawing.Size(248, 160);
            // 
            // 
            // 
            this.gpGroupActivity.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpGroupActivity.Style.BackColorGradientAngle = 90;
            this.gpGroupActivity.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpGroupActivity.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpGroupActivity.Style.BorderBottomWidth = 1;
            this.gpGroupActivity.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpGroupActivity.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpGroupActivity.Style.BorderLeftWidth = 1;
            this.gpGroupActivity.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpGroupActivity.Style.BorderRightWidth = 1;
            this.gpGroupActivity.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpGroupActivity.Style.BorderTopWidth = 1;
            this.gpGroupActivity.Style.Class = "";
            this.gpGroupActivity.Style.CornerDiameter = 4;
            this.gpGroupActivity.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpGroupActivity.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpGroupActivity.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpGroupActivity.StyleMouseDown.Class = "";
            this.gpGroupActivity.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpGroupActivity.StyleMouseOver.Class = "";
            this.gpGroupActivity.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpGroupActivity.TabIndex = 3;
            this.gpGroupActivity.Text = "團體活動表現";
            // 
            // dgvGroupActivity
            // 
            this.dgvGroupActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGroupActivity.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGroupActivity.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvGroupActivity.Location = new System.Drawing.Point(7, 6);
            this.dgvGroupActivity.Name = "dgvGroupActivity";
            this.dgvGroupActivity.RowTemplate.Height = 24;
            this.dgvGroupActivity.Size = new System.Drawing.Size(228, 120);
            this.dgvGroupActivity.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "項目名稱";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "顯示順序";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // gpSchoolSpecial
            // 
            this.gpSchoolSpecial.BackColor = System.Drawing.Color.Transparent;
            this.gpSchoolSpecial.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpSchoolSpecial.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpSchoolSpecial.Controls.Add(this.dgvSchoolSpecial);
            this.gpSchoolSpecial.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.gpSchoolSpecial.Location = new System.Drawing.Point(522, 193);
            this.gpSchoolSpecial.Name = "gpSchoolSpecial";
            this.gpSchoolSpecial.Size = new System.Drawing.Size(245, 160);
            // 
            // 
            // 
            this.gpSchoolSpecial.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpSchoolSpecial.Style.BackColorGradientAngle = 90;
            this.gpSchoolSpecial.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpSchoolSpecial.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpSchoolSpecial.Style.BorderBottomWidth = 1;
            this.gpSchoolSpecial.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpSchoolSpecial.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpSchoolSpecial.Style.BorderLeftWidth = 1;
            this.gpSchoolSpecial.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpSchoolSpecial.Style.BorderRightWidth = 1;
            this.gpSchoolSpecial.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpSchoolSpecial.Style.BorderTopWidth = 1;
            this.gpSchoolSpecial.Style.Class = "";
            this.gpSchoolSpecial.Style.CornerDiameter = 4;
            this.gpSchoolSpecial.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpSchoolSpecial.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpSchoolSpecial.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpSchoolSpecial.StyleMouseDown.Class = "";
            this.gpSchoolSpecial.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpSchoolSpecial.StyleMouseOver.Class = "";
            this.gpSchoolSpecial.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpSchoolSpecial.TabIndex = 4;
            this.gpSchoolSpecial.Text = "校內外特殊表現";
            // 
            // dgvSchoolSpecial
            // 
            this.dgvSchoolSpecial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchoolSpecial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSchoolSpecial.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSchoolSpecial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSchoolSpecial.Location = new System.Drawing.Point(5, 6);
            this.dgvSchoolSpecial.Name = "dgvSchoolSpecial";
            this.dgvSchoolSpecial.RowTemplate.Height = 24;
            this.dgvSchoolSpecial.Size = new System.Drawing.Size(229, 120);
            this.dgvSchoolSpecial.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "項目名稱";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "顯示順序";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 85;
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.btnExit.Location = new System.Drawing.Point(690, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "關閉";
            this.btnExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // gpDailyBehavior
            // 
            this.gpDailyBehavior.BackColor = System.Drawing.Color.Transparent;
            this.gpDailyBehavior.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpDailyBehavior.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpDailyBehavior.Controls.Add(this.dgvDailyBehavior);
            this.gpDailyBehavior.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.gpDailyBehavior.Location = new System.Drawing.Point(12, 7);
            this.gpDailyBehavior.Name = "gpDailyBehavior";
            this.gpDailyBehavior.Size = new System.Drawing.Size(755, 180);
            // 
            // 
            // 
            this.gpDailyBehavior.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpDailyBehavior.Style.BackColorGradientAngle = 90;
            this.gpDailyBehavior.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpDailyBehavior.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDailyBehavior.Style.BorderBottomWidth = 1;
            this.gpDailyBehavior.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpDailyBehavior.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDailyBehavior.Style.BorderLeftWidth = 1;
            this.gpDailyBehavior.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDailyBehavior.Style.BorderRightWidth = 1;
            this.gpDailyBehavior.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDailyBehavior.Style.BorderTopWidth = 1;
            this.gpDailyBehavior.Style.Class = "";
            this.gpDailyBehavior.Style.CornerDiameter = 4;
            this.gpDailyBehavior.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpDailyBehavior.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpDailyBehavior.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpDailyBehavior.StyleMouseDown.Class = "";
            this.gpDailyBehavior.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpDailyBehavior.StyleMouseOver.Class = "";
            this.gpDailyBehavior.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpDailyBehavior.TabIndex = 0;
            this.gpDailyBehavior.Text = "日常行為表現";
            // 
            // dgvDailyBehavior
            // 
            this.dgvDailyBehavior.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyBehavior.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDailyBehavior.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDailyBehavior.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDailyBehavior.Location = new System.Drawing.Point(6, 7);
            this.dgvDailyBehavior.Name = "dgvDailyBehavior";
            this.dgvDailyBehavior.RowTemplate.Height = 24;
            this.dgvDailyBehavior.Size = new System.Drawing.Size(738, 136);
            this.dgvDailyBehavior.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "項目";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // column2
            // 
            this.column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column2.HeaderText = "指標";
            this.column2.Name = "column2";
            // 
            // lnkDailyBehavior
            // 
            this.lnkDailyBehavior.AutoSize = true;
            this.lnkDailyBehavior.BackColor = System.Drawing.Color.Transparent;
            this.lnkDailyBehavior.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.lnkDailyBehavior.Location = new System.Drawing.Point(694, 9);
            this.lnkDailyBehavior.Name = "lnkDailyBehavior";
            this.lnkDailyBehavior.Size = new System.Drawing.Size(60, 17);
            this.lnkDailyBehavior.TabIndex = 6;
            this.lnkDailyBehavior.TabStop = true;
            this.lnkDailyBehavior.Text = "修改名稱";
            this.lnkDailyBehavior.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDailyBehavior_LinkClicked);
            // 
            // txtDailyBehavior
            // 
            this.txtDailyBehavior.Location = new System.Drawing.Point(16, 7);
            this.txtDailyBehavior.Name = "txtDailyBehavior";
            this.txtDailyBehavior.Size = new System.Drawing.Size(150, 25);
            this.txtDailyBehavior.TabIndex = 7;
            this.txtDailyBehavior.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDailyBehavior_KeyDown);
            // 
            // txtPublicService
            // 
            this.txtPublicService.Location = new System.Drawing.Point(269, 193);
            this.txtPublicService.Name = "txtPublicService";
            this.txtPublicService.Size = new System.Drawing.Size(150, 25);
            this.txtPublicService.TabIndex = 8;
            this.txtPublicService.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPublicService_KeyDown);
            // 
            // txtSchoolSpecial
            // 
            this.txtSchoolSpecial.Location = new System.Drawing.Point(526, 193);
            this.txtSchoolSpecial.Name = "txtSchoolSpecial";
            this.txtSchoolSpecial.Size = new System.Drawing.Size(150, 25);
            this.txtSchoolSpecial.TabIndex = 9;
            this.txtSchoolSpecial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSchoolSpecial_KeyDown);
            // 
            // txtGroupActivity
            // 
            this.txtGroupActivity.Location = new System.Drawing.Point(15, 193);
            this.txtGroupActivity.Name = "txtGroupActivity";
            this.txtGroupActivity.Size = new System.Drawing.Size(150, 25);
            this.txtGroupActivity.TabIndex = 10;
            this.txtGroupActivity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGroupActivity_KeyDown);
            // 
            // lnkPublicService
            // 
            this.lnkPublicService.AutoSize = true;
            this.lnkPublicService.BackColor = System.Drawing.Color.Transparent;
            this.lnkPublicService.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.lnkPublicService.Location = new System.Drawing.Point(441, 197);
            this.lnkPublicService.Name = "lnkPublicService";
            this.lnkPublicService.Size = new System.Drawing.Size(60, 17);
            this.lnkPublicService.TabIndex = 11;
            this.lnkPublicService.TabStop = true;
            this.lnkPublicService.Text = "修改名稱";
            this.lnkPublicService.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPublicService_LinkClicked);
            // 
            // lnkGroupActivity
            // 
            this.lnkGroupActivity.AutoSize = true;
            this.lnkGroupActivity.BackColor = System.Drawing.Color.Transparent;
            this.lnkGroupActivity.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.lnkGroupActivity.Location = new System.Drawing.Point(187, 197);
            this.lnkGroupActivity.Name = "lnkGroupActivity";
            this.lnkGroupActivity.Size = new System.Drawing.Size(60, 17);
            this.lnkGroupActivity.TabIndex = 12;
            this.lnkGroupActivity.TabStop = true;
            this.lnkGroupActivity.Text = "修改名稱";
            this.lnkGroupActivity.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGroupActivity_LinkClicked);
            // 
            // lnkSchoolSpecial
            // 
            this.lnkSchoolSpecial.AutoSize = true;
            this.lnkSchoolSpecial.BackColor = System.Drawing.Color.Transparent;
            this.lnkSchoolSpecial.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.lnkSchoolSpecial.Location = new System.Drawing.Point(694, 197);
            this.lnkSchoolSpecial.Name = "lnkSchoolSpecial";
            this.lnkSchoolSpecial.Size = new System.Drawing.Size(60, 17);
            this.lnkSchoolSpecial.TabIndex = 13;
            this.lnkSchoolSpecial.TabStop = true;
            this.lnkSchoolSpecial.Text = "修改名稱";
            this.lnkSchoolSpecial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSchoolSpecial_LinkClicked);
            // 
            // gpDailyLifeRecommend
            // 
            this.gpDailyLifeRecommend.BackColor = System.Drawing.Color.Transparent;
            this.gpDailyLifeRecommend.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpDailyLifeRecommend.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpDailyLifeRecommend.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.gpDailyLifeRecommend.Location = new System.Drawing.Point(11, 359);
            this.gpDailyLifeRecommend.Name = "gpDailyLifeRecommend";
            this.gpDailyLifeRecommend.Size = new System.Drawing.Size(503, 58);
            // 
            // 
            // 
            this.gpDailyLifeRecommend.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpDailyLifeRecommend.Style.BackColorGradientAngle = 90;
            this.gpDailyLifeRecommend.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpDailyLifeRecommend.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDailyLifeRecommend.Style.BorderBottomWidth = 1;
            this.gpDailyLifeRecommend.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpDailyLifeRecommend.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDailyLifeRecommend.Style.BorderLeftWidth = 1;
            this.gpDailyLifeRecommend.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDailyLifeRecommend.Style.BorderRightWidth = 1;
            this.gpDailyLifeRecommend.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDailyLifeRecommend.Style.BorderTopWidth = 1;
            this.gpDailyLifeRecommend.Style.Class = "";
            this.gpDailyLifeRecommend.Style.CornerDiameter = 4;
            this.gpDailyLifeRecommend.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpDailyLifeRecommend.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpDailyLifeRecommend.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpDailyLifeRecommend.StyleMouseDown.Class = "";
            this.gpDailyLifeRecommend.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpDailyLifeRecommend.StyleMouseOver.Class = "";
            this.gpDailyLifeRecommend.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpDailyLifeRecommend.TabIndex = 14;
            this.gpDailyLifeRecommend.Text = "日常生活表現具體建議";
            // 
            // lnkDailyLifeRecommend
            // 
            this.lnkDailyLifeRecommend.AutoSize = true;
            this.lnkDailyLifeRecommend.BackColor = System.Drawing.Color.Transparent;
            this.lnkDailyLifeRecommend.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.lnkDailyLifeRecommend.Location = new System.Drawing.Point(441, 362);
            this.lnkDailyLifeRecommend.Name = "lnkDailyLifeRecommend";
            this.lnkDailyLifeRecommend.Size = new System.Drawing.Size(60, 17);
            this.lnkDailyLifeRecommend.TabIndex = 15;
            this.lnkDailyLifeRecommend.TabStop = true;
            this.lnkDailyLifeRecommend.Text = "修改名稱";
            this.lnkDailyLifeRecommend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDailyLifeRecommend_LinkClicked);
            // 
            // txtDailyLifeRecommend
            // 
            this.txtDailyLifeRecommend.Location = new System.Drawing.Point(15, 359);
            this.txtDailyLifeRecommend.Name = "txtDailyLifeRecommend";
            this.txtDailyLifeRecommend.Size = new System.Drawing.Size(151, 25);
            this.txtDailyLifeRecommend.TabIndex = 16;
            this.txtDailyLifeRecommend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDailyLifeRecommend_KeyDown);
            // 
            // DailyLifeConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 428);
            this.Controls.Add(this.lnkDailyLifeRecommend);
            this.Controls.Add(this.gpDailyLifeRecommend);
            this.Controls.Add(this.lnkSchoolSpecial);
            this.Controls.Add(this.lnkGroupActivity);
            this.Controls.Add(this.lnkPublicService);
            this.Controls.Add(this.lnkDailyBehavior);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gpSchoolSpecial);
            this.Controls.Add(this.gpGroupActivity);
            this.Controls.Add(this.gpPublicService);
            this.Controls.Add(this.gpDailyBehavior);
            this.Controls.Add(this.txtDailyBehavior);
            this.Controls.Add(this.txtPublicService);
            this.Controls.Add(this.txtSchoolSpecial);
            this.Controls.Add(this.txtGroupActivity);
            this.Controls.Add(this.txtDailyLifeRecommend);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DailyLifeConfigForm";
            this.Text = "日常生活表現評量設定";
            this.gpPublicService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicService)).EndInit();
            this.gpGroupActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupActivity)).EndInit();
            this.gpSchoolSpecial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolSpecial)).EndInit();
            this.gpDailyBehavior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyBehavior)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gpPublicService;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPublicService;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.GroupPanel gpGroupActivity;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvGroupActivity;
        private DevComponents.DotNetBar.Controls.GroupPanel gpSchoolSpecial;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSchoolSpecial;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.Controls.GroupPanel gpDailyBehavior;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDailyBehavior;
        private System.Windows.Forms.LinkLabel lnkDailyBehavior;
        private System.Windows.Forms.TextBox txtDailyBehavior;
        private System.Windows.Forms.TextBox txtPublicService;
        private System.Windows.Forms.TextBox txtSchoolSpecial;
        private System.Windows.Forms.TextBox txtGroupActivity;
        private System.Windows.Forms.LinkLabel lnkPublicService;
        private System.Windows.Forms.LinkLabel lnkGroupActivity;
        private System.Windows.Forms.LinkLabel lnkSchoolSpecial;
        private DevComponents.DotNetBar.Controls.GroupPanel gpDailyLifeRecommend;
        private System.Windows.Forms.LinkLabel lnkDailyLifeRecommend;
        private System.Windows.Forms.TextBox txtDailyLifeRecommend;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}