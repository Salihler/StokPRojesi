
namespace StokProjesi
{
    partial class islemGetirForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btnGet = new DevExpress.XtraEditors.SimpleButton();
            this.lblStartingDate = new DevExpress.XtraEditors.LabelControl();
            this.lblEndDate = new DevExpress.XtraEditors.LabelControl();
            this.cbProductSelect = new System.Windows.Forms.ComboBox();
            this.dtpStartingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndingDate = new System.Windows.Forms.DateTimePicker();
            this.vgData = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnToExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.vgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(241, 85);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "Getir";
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lblStartingDate
            // 
            this.lblStartingDate.Location = new System.Drawing.Point(12, 23);
            this.lblStartingDate.Name = "lblStartingDate";
            this.lblStartingDate.Size = new System.Drawing.Size(73, 13);
            this.lblStartingDate.TabIndex = 4;
            this.lblStartingDate.Text = "Başlangıç Tarihi";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(12, 69);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(48, 13);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "Bitiş Tarihi";
            // 
            // cbProductSelect
            // 
            this.cbProductSelect.FormattingEnabled = true;
            this.cbProductSelect.Location = new System.Drawing.Point(241, 42);
            this.cbProductSelect.Name = "cbProductSelect";
            this.cbProductSelect.Size = new System.Drawing.Size(121, 21);
            this.cbProductSelect.TabIndex = 6;
            // 
            // dtpStartingDate
            // 
            this.dtpStartingDate.Location = new System.Drawing.Point(12, 43);
            this.dtpStartingDate.Name = "dtpStartingDate";
            this.dtpStartingDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartingDate.TabIndex = 7;
            // 
            // dtpEndingDate
            // 
            this.dtpEndingDate.Location = new System.Drawing.Point(13, 87);
            this.dtpEndingDate.Name = "dtpEndingDate";
            this.dtpEndingDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndingDate.TabIndex = 8;
            // 
            // vgData
            // 
            this.vgData.Location = new System.Drawing.Point(13, 139);
            this.vgData.MainView = this.gridView1;
            this.vgData.Name = "vgData";
            this.vgData.Size = new System.Drawing.Size(441, 276);
            this.vgData.TabIndex = 9;
            this.vgData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.vgData;
            this.gridView1.Name = "gridView1";
            // 
            // btnToExcel
            // 
            this.btnToExcel.Location = new System.Drawing.Point(379, 421);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(75, 23);
            this.btnToExcel.TabIndex = 10;
            this.btnToExcel.Text = "Excel\'e Aktar";
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            // 
            // islemGetirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.btnToExcel);
            this.Controls.Add(this.vgData);
            this.Controls.Add(this.dtpEndingDate);
            this.Controls.Add(this.dtpStartingDate);
            this.Controls.Add(this.cbProductSelect);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartingDate);
            this.Controls.Add(this.btnGet);
            this.Name = "islemGetirForm";
            this.Text = "İşlem Getir";
            ((System.ComponentModel.ISupportInitialize)(this.vgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.SimpleButton btnGet;
        private DevExpress.XtraEditors.LabelControl lblStartingDate;
        private DevExpress.XtraEditors.LabelControl lblEndDate;
        private System.Windows.Forms.ComboBox cbProductSelect;
        private System.Windows.Forms.DateTimePicker dtpStartingDate;
        private System.Windows.Forms.DateTimePicker dtpEndingDate;
        private DevExpress.XtraGrid.GridControl vgData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnToExcel;
    }
}

