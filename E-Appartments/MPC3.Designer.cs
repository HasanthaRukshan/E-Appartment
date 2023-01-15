
namespace E_Appartments
{
    partial class MPC3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._E_AppartmentsDataSet3 = new E_Appartments._E_AppartmentsDataSet3();
            this.colombo3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colombo_3TableAdapter = new E_Appartments._E_AppartmentsDataSet3TableAdapters.Colombo_3TableAdapter();
            this.buildingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appartmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._E_AppartmentsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colombo3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildingIDDataGridViewTextBoxColumn,
            this.classNameDataGridViewTextBoxColumn,
            this.appartmentIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.colombo3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // _E_AppartmentsDataSet3
            // 
            this._E_AppartmentsDataSet3.DataSetName = "_E_AppartmentsDataSet3";
            this._E_AppartmentsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colombo3BindingSource
            // 
            this.colombo3BindingSource.DataMember = "Colombo_3";
            this.colombo3BindingSource.DataSource = this._E_AppartmentsDataSet3;
            // 
            // colombo_3TableAdapter
            // 
            this.colombo_3TableAdapter.ClearBeforeFill = true;
            // 
            // buildingIDDataGridViewTextBoxColumn
            // 
            this.buildingIDDataGridViewTextBoxColumn.DataPropertyName = "BuildingID";
            this.buildingIDDataGridViewTextBoxColumn.HeaderText = "BuildingID";
            this.buildingIDDataGridViewTextBoxColumn.Name = "buildingIDDataGridViewTextBoxColumn";
            // 
            // classNameDataGridViewTextBoxColumn
            // 
            this.classNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName";
            this.classNameDataGridViewTextBoxColumn.HeaderText = "ClassName";
            this.classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
            // 
            // appartmentIDDataGridViewTextBoxColumn
            // 
            this.appartmentIDDataGridViewTextBoxColumn.DataPropertyName = "AppartmentID";
            this.appartmentIDDataGridViewTextBoxColumn.HeaderText = "AppartmentID";
            this.appartmentIDDataGridViewTextBoxColumn.Name = "appartmentIDDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // MPC3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MPC3";
            this.Text = "MPC3";
            this.Load += new System.EventHandler(this.MPC3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._E_AppartmentsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colombo3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _E_AppartmentsDataSet3 _E_AppartmentsDataSet3;
        private System.Windows.Forms.BindingSource colombo3BindingSource;
        private _E_AppartmentsDataSet3TableAdapters.Colombo_3TableAdapter colombo_3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appartmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}