namespace MEDICAL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menulogout = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sELLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPANYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalStockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGEUSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cHNAEGPASSWORDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblday = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.gplogin = new System.Windows.Forms.GroupBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gplogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.mENUToolStripMenuItem,
            this.sELLToolStripMenuItem,
            this.cOMPANYToolStripMenuItem,
            this.cLIENTSToolStripMenuItem,
            this.rEPORTSToolStripMenuItem,
            this.mANAGEUSERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1732, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menulogout,
            this.eXITToolStripMenuItem});
            this.hOMEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(120, 34);
            this.hOMEToolStripMenuItem.Text = "🏠HOME";
            // 
            // menulogout
            // 
            this.menulogout.Name = "menulogout";
            this.menulogout.Size = new System.Drawing.Size(201, 38);
            this.menulogout.Text = "LOGOUT";
            this.menulogout.Visible = false;
            this.menulogout.Click += new System.EventHandler(this.menulogout_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(201, 38);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem,
            this.updateStockToolStripMenuItem,
            this.deleteStockToolStripMenuItem,
            this.repotsToolStripMenuItem});
            this.mENUToolStripMenuItem.Enabled = false;
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(126, 34);
            this.mENUToolStripMenuItem.Text = "🏬STOCK";
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.nEWToolStripMenuItem.Text = "New Stock";
            this.nEWToolStripMenuItem.Click += new System.EventHandler(this.nEWToolStripMenuItem_Click);
            // 
            // updateStockToolStripMenuItem
            // 
            this.updateStockToolStripMenuItem.Name = "updateStockToolStripMenuItem";
            this.updateStockToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.updateStockToolStripMenuItem.Text = "Update Stock";
            this.updateStockToolStripMenuItem.Click += new System.EventHandler(this.updateStockToolStripMenuItem_Click);
            // 
            // deleteStockToolStripMenuItem
            // 
            this.deleteStockToolStripMenuItem.Name = "deleteStockToolStripMenuItem";
            this.deleteStockToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.deleteStockToolStripMenuItem.Text = "Delete Stock";
            this.deleteStockToolStripMenuItem.Click += new System.EventHandler(this.deleteStockToolStripMenuItem_Click);
            // 
            // repotsToolStripMenuItem
            // 
            this.repotsToolStripMenuItem.Name = "repotsToolStripMenuItem";
            this.repotsToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.repotsToolStripMenuItem.Text = "Repots";
            this.repotsToolStripMenuItem.Click += new System.EventHandler(this.repotsToolStripMenuItem_Click);
            // 
            // sELLToolStripMenuItem
            // 
            this.sELLToolStripMenuItem.Enabled = false;
            this.sELLToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sELLToolStripMenuItem.Name = "sELLToolStripMenuItem";
            this.sELLToolStripMenuItem.Size = new System.Drawing.Size(102, 34);
            this.sELLToolStripMenuItem.Text = "☑️SELL";
            this.sELLToolStripMenuItem.Click += new System.EventHandler(this.sELLToolStripMenuItem_Click);
            // 
            // cOMPANYToolStripMenuItem
            // 
            this.cOMPANYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWToolStripMenuItem1,
            this.dELETEToolStripMenuItem1,
            this.rEPORTSToolStripMenuItem2});
            this.cOMPANYToolStripMenuItem.Enabled = false;
            this.cOMPANYToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOMPANYToolStripMenuItem.Name = "cOMPANYToolStripMenuItem";
            this.cOMPANYToolStripMenuItem.Size = new System.Drawing.Size(161, 34);
            this.cOMPANYToolStripMenuItem.Text = "🏛️COMPANY";
            // 
            // aDDNEWToolStripMenuItem1
            // 
            this.aDDNEWToolStripMenuItem1.Name = "aDDNEWToolStripMenuItem1";
            this.aDDNEWToolStripMenuItem1.Size = new System.Drawing.Size(270, 38);
            this.aDDNEWToolStripMenuItem1.Text = "ADD NEW";
            this.aDDNEWToolStripMenuItem1.Click += new System.EventHandler(this.aDDNEWToolStripMenuItem1_Click);
            // 
            // dELETEToolStripMenuItem1
            // 
            this.dELETEToolStripMenuItem1.Name = "dELETEToolStripMenuItem1";
            this.dELETEToolStripMenuItem1.Size = new System.Drawing.Size(270, 38);
            this.dELETEToolStripMenuItem1.Text = "DELETE";
            this.dELETEToolStripMenuItem1.Click += new System.EventHandler(this.dELETEToolStripMenuItem1_Click);
            // 
            // rEPORTSToolStripMenuItem2
            // 
            this.rEPORTSToolStripMenuItem2.Name = "rEPORTSToolStripMenuItem2";
            this.rEPORTSToolStripMenuItem2.Size = new System.Drawing.Size(270, 38);
            this.rEPORTSToolStripMenuItem2.Text = "REPORTS";
            this.rEPORTSToolStripMenuItem2.Click += new System.EventHandler(this.rEPORTSToolStripMenuItem2_Click);
            // 
            // cLIENTSToolStripMenuItem
            // 
            this.cLIENTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWToolStripMenuItem2,
            this.dELETEToolStripMenuItem2,
            this.vIEWToolStripMenuItem});
            this.cLIENTSToolStripMenuItem.Enabled = false;
            this.cLIENTSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTSToolStripMenuItem.Name = "cLIENTSToolStripMenuItem";
            this.cLIENTSToolStripMenuItem.Size = new System.Drawing.Size(139, 34);
            this.cLIENTSToolStripMenuItem.Text = "🧑CLIENTS";
            // 
            // aDDNEWToolStripMenuItem2
            // 
            this.aDDNEWToolStripMenuItem2.Name = "aDDNEWToolStripMenuItem2";
            this.aDDNEWToolStripMenuItem2.Size = new System.Drawing.Size(214, 38);
            this.aDDNEWToolStripMenuItem2.Text = "ADD NEW";
            this.aDDNEWToolStripMenuItem2.Click += new System.EventHandler(this.aDDNEWToolStripMenuItem2_Click);
            // 
            // dELETEToolStripMenuItem2
            // 
            this.dELETEToolStripMenuItem2.Name = "dELETEToolStripMenuItem2";
            this.dELETEToolStripMenuItem2.Size = new System.Drawing.Size(214, 38);
            this.dELETEToolStripMenuItem2.Text = "DELETE ";
            this.dELETEToolStripMenuItem2.Click += new System.EventHandler(this.dELETEToolStripMenuItem2_Click);
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(214, 38);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            this.vIEWToolStripMenuItem.Click += new System.EventHandler(this.vIEWToolStripMenuItem_Click);
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockReportToolStripMenuItem,
            this.sellReportToolStripMenuItem,
            this.totalStockReportToolStripMenuItem});
            this.rEPORTSToolStripMenuItem.Enabled = false;
            this.rEPORTSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(144, 34);
            this.rEPORTSToolStripMenuItem.Text = "📕REPORTS";
            // 
            // stockReportToolStripMenuItem
            // 
            this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(291, 38);
            this.stockReportToolStripMenuItem.Text = "StockIn Report";
            this.stockReportToolStripMenuItem.Click += new System.EventHandler(this.stockReportToolStripMenuItem_Click);
            // 
            // sellReportToolStripMenuItem
            // 
            this.sellReportToolStripMenuItem.Name = "sellReportToolStripMenuItem";
            this.sellReportToolStripMenuItem.Size = new System.Drawing.Size(291, 38);
            this.sellReportToolStripMenuItem.Text = "Sales Report";
            this.sellReportToolStripMenuItem.Click += new System.EventHandler(this.sellReportToolStripMenuItem_Click);
            // 
            // totalStockReportToolStripMenuItem
            // 
            this.totalStockReportToolStripMenuItem.Name = "totalStockReportToolStripMenuItem";
            this.totalStockReportToolStripMenuItem.Size = new System.Drawing.Size(291, 38);
            this.totalStockReportToolStripMenuItem.Text = "Total Stock Report";
            this.totalStockReportToolStripMenuItem.Click += new System.EventHandler(this.totalStockReportToolStripMenuItem_Click);
            // 
            // mANAGEUSERToolStripMenuItem
            // 
            this.mANAGEUSERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWToolStripMenuItem,
            this.dELETEToolStripMenuItem,
            this.rEPORTSToolStripMenuItem1,
            this.cHNAEGPASSWORDToolStripMenuItem});
            this.mANAGEUSERToolStripMenuItem.Enabled = false;
            this.mANAGEUSERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mANAGEUSERToolStripMenuItem.Name = "mANAGEUSERToolStripMenuItem";
            this.mANAGEUSERToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.mANAGEUSERToolStripMenuItem.Text = "MANAGE USER";
            // 
            // aDDNEWToolStripMenuItem
            // 
            this.aDDNEWToolStripMenuItem.Name = "aDDNEWToolStripMenuItem";
            this.aDDNEWToolStripMenuItem.Size = new System.Drawing.Size(322, 38);
            this.aDDNEWToolStripMenuItem.Text = "ADD NEW";
            this.aDDNEWToolStripMenuItem.Click += new System.EventHandler(this.aDDNEWToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(322, 38);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // rEPORTSToolStripMenuItem1
            // 
            this.rEPORTSToolStripMenuItem1.Name = "rEPORTSToolStripMenuItem1";
            this.rEPORTSToolStripMenuItem1.Size = new System.Drawing.Size(322, 38);
            this.rEPORTSToolStripMenuItem1.Text = "REPORTS";
            this.rEPORTSToolStripMenuItem1.Click += new System.EventHandler(this.rEPORTSToolStripMenuItem1_Click);
            // 
            // cHNAEGPASSWORDToolStripMenuItem
            // 
            this.cHNAEGPASSWORDToolStripMenuItem.Name = "cHNAEGPASSWORDToolStripMenuItem";
            this.cHNAEGPASSWORDToolStripMenuItem.Size = new System.Drawing.Size(322, 38);
            this.cHNAEGPASSWORDToolStripMenuItem.Text = "CHNAEG PASSWORD";
            this.cHNAEGPASSWORDToolStripMenuItem.Click += new System.EventHandler(this.cHNAEGPASSWORDToolStripMenuItem_Click);
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.BackColor = System.Drawing.Color.White;
            this.lblday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.Location = new System.Drawing.Point(1611, 94);
            this.lblday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(64, 25);
            this.lblday.TabIndex = 15;
            this.lblday.Text = "label4";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(1610, 125);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(64, 25);
            this.lbltime.TabIndex = 14;
            this.lbltime.Text = "label3";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.White;
            this.lbltitle.Font = new System.Drawing.Font("Franklin Gothic Demi", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbltitle.Location = new System.Drawing.Point(650, 75);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(608, 65);
            this.lbltitle.TabIndex = 13;
            this.lbltitle.Text = "MEDICAL STORE SYSTEM";
            this.lbltitle.Click += new System.EventHandler(this.lbltitle_Click);
            // 
            // gplogin
            // 
            this.gplogin.BackColor = System.Drawing.Color.Silver;
            this.gplogin.Controls.Add(this.btnlogin);
            this.gplogin.Controls.Add(this.txtpass);
            this.gplogin.Controls.Add(this.txtname);
            this.gplogin.Controls.Add(this.label2);
            this.gplogin.Controls.Add(this.label1);
            this.gplogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gplogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gplogin.Location = new System.Drawing.Point(728, 214);
            this.gplogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gplogin.Name = "gplogin";
            this.gplogin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gplogin.Size = new System.Drawing.Size(496, 309);
            this.gplogin.TabIndex = 16;
            this.gplogin.TabStop = false;
            this.gplogin.Text = "Login";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Honeydew;
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlogin.Location = new System.Drawing.Point(218, 200);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(112, 46);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.Honeydew;
            this.txtpass.Location = new System.Drawing.Point(218, 134);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(148, 30);
            this.txtpass.TabIndex = 3;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Honeydew;
            this.txtname.Location = new System.Drawing.Point(218, 63);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(148, 30);
            this.txtname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(54, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "🔑Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(39, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "🔐LoginName :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblname.Location = new System.Drawing.Point(1617, 183);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 29);
            this.lblname.TabIndex = 23;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(528, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 82);
            this.label3.TabIndex = 25;
            this.label3.Text = "🏥";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.OldLace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepPink;
            this.label6.Location = new System.Drawing.Point(1282, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 82);
            this.label6.TabIndex = 28;
            this.label6.Text = "⚕️";
            // 
            
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1732, 955);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.gplogin);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gplogin.ResumeLayout(false);
            this.gplogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menulogout;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.GroupBox gplogin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem updateStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sELLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGEUSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cHNAEGPASSWORDToolStripMenuItem;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ToolStripMenuItem cOMPANYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalStockReportToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}

