namespace Subconsultas__group_by_y_having
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvFechas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDclientesDataSet = new Subconsultas__group_by_y_having.BDclientesDataSet();
            this.btnConsultarFechas = new System.Windows.Forms.Button();
            this.dtpFechaFiltro = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ventasTableAdapter = new Subconsultas__group_by_y_having.BDclientesDataSetTableAdapters.VentasTableAdapter();
            this.dgvHaving = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrarHaving = new System.Windows.Forms.Button();
            this.txtUmbral = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDclientesDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaving)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(23, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1274, 503);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvFechas);
            this.tabPage1.Controls.Add(this.btnConsultarFechas);
            this.tabPage1.Controls.Add(this.dtpFechaFiltro);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1266, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtro por fechas";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgvFechas
            // 
            this.dgvFechas.AutoGenerateColumns = false;
            this.dgvFechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFechas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.fechaVentaDataGridViewTextBoxColumn});
            this.dgvFechas.DataSource = this.ventasBindingSource;
            this.dgvFechas.Location = new System.Drawing.Point(57, 148);
            this.dgvFechas.Name = "dgvFechas";
            this.dgvFechas.RowHeadersWidth = 51;
            this.dgvFechas.RowTemplate.Height = 24;
            this.dgvFechas.Size = new System.Drawing.Size(1150, 204);
            this.dgvFechas.TabIndex = 2;
            this.dgvFechas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // fechaVentaDataGridViewTextBoxColumn
            // 
            this.fechaVentaDataGridViewTextBoxColumn.DataPropertyName = "FechaVenta";
            this.fechaVentaDataGridViewTextBoxColumn.HeaderText = "FechaVenta";
            this.fechaVentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaVentaDataGridViewTextBoxColumn.Name = "fechaVentaDataGridViewTextBoxColumn";
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.bDclientesDataSet;
            // 
            // bDclientesDataSet
            // 
            this.bDclientesDataSet.DataSetName = "BDclientesDataSet";
            this.bDclientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnConsultarFechas
            // 
            this.btnConsultarFechas.Location = new System.Drawing.Point(454, 29);
            this.btnConsultarFechas.Name = "btnConsultarFechas";
            this.btnConsultarFechas.Size = new System.Drawing.Size(195, 79);
            this.btnConsultarFechas.TabIndex = 1;
            this.btnConsultarFechas.Text = "Consular Ventas";
            this.btnConsultarFechas.UseVisualStyleBackColor = true;
            this.btnConsultarFechas.Click += new System.EventHandler(this.btnConsultarFechas_Click);
            // 
            // dtpFechaFiltro
            // 
            this.dtpFechaFiltro.Location = new System.Drawing.Point(57, 64);
            this.dtpFechaFiltro.Name = "dtpFechaFiltro";
            this.dtpFechaFiltro.Size = new System.Drawing.Size(328, 22);
            this.dtpFechaFiltro.TabIndex = 0;
            this.dtpFechaFiltro.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1266, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Group By";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtUmbral);
            this.tabPage3.Controls.Add(this.btnFiltrarHaving);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.dgvHaving);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1266, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Filtro Having";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1266, 474);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Subconsultas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // dgvHaving
            // 
            this.dgvHaving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHaving.Location = new System.Drawing.Point(29, 186);
            this.dgvHaving.Name = "dgvHaving";
            this.dgvHaving.RowHeadersWidth = 51;
            this.dgvHaving.RowTemplate.Height = 24;
            this.dgvHaving.Size = new System.Drawing.Size(850, 150);
            this.dgvHaving.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mostrar clientes con total acumulado mayor a ($):";
            // 
            // btnFiltrarHaving
            // 
            this.btnFiltrarHaving.Location = new System.Drawing.Point(615, 65);
            this.btnFiltrarHaving.Name = "btnFiltrarHaving";
            this.btnFiltrarHaving.Size = new System.Drawing.Size(204, 54);
            this.btnFiltrarHaving.TabIndex = 2;
            this.btnFiltrarHaving.Text = "Filtrar con HAVING";
            this.btnFiltrarHaving.UseVisualStyleBackColor = true;
            this.btnFiltrarHaving.Click += new System.EventHandler(this.btnFiltrarHaving_Click);
            // 
            // txtUmbral
            // 
            this.txtUmbral.Location = new System.Drawing.Point(343, 81);
            this.txtUmbral.Name = "txtUmbral";
            this.txtUmbral.Size = new System.Drawing.Size(100, 22);
            this.txtUmbral.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 535);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDclientesDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaving)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker dtpFechaFiltro;
        private System.Windows.Forms.DataGridView dgvFechas;
        private System.Windows.Forms.Button btnConsultarFechas;
        private BDclientesDataSet bDclientesDataSet;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private BDclientesDataSetTableAdapters.VentasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtUmbral;
        private System.Windows.Forms.Button btnFiltrarHaving;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHaving;
    }
}

