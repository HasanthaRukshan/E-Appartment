
namespace E_Appartments
{
    partial class MPC1
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
            this._E_AppartmentsDataSet1 = new E_Appartments._E_AppartmentsDataSet1();
            this.colombo1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colombo_1TableAdapter = new E_Appartments._E_AppartmentsDataSet1TableAdapters.Colombo_1TableAdapter();
            this.buildingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appartmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._E_AppartmentsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colombo1BindingSource)).BeginInit();
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
            this.parkingIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.colombo1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(958, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // _E_AppartmentsDataSet1
            // 
            this._E_AppartmentsDataSet1.DataSetName = "_E_AppartmentsDataSet1";
            this._E_AppartmentsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colombo1BindingSource
            // 
            this.colombo1BindingSource.DataMember = "Colombo_1";
            this.colombo1BindingSource.DataSource = this._E_AppartmentsDataSet1;
            // 
            // colombo_1TableAdapter
            // 
            this.colombo_1TableAdapter.ClearBeforeFill = true;
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
            // parkingIDDataGridViewTextBoxColumn
            // 
            this.parkingIDDataGridViewTextBoxColumn.DataPropertyName = "ParkingID";
            this.parkingIDDataGridViewTextBoxColumn.HeaderText = "ParkingID";
            this.parkingIDDataGridViewTextBoxColumn.Name = "parkingIDDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // MPC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 585);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MPC1";
            this.Text = "MPC1";
            this.Load += new System.EventHandler(this.MPC1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._E_AppartmentsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colombo1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _E_AppartmentsDataSet1 _E_AppartmentsDataSet1;
        private System.Windows.Forms.BindingSource colombo1BindingSource;
        private _E_AppartmentsDataSet1TableAdapters.Colombo_1TableAdapter colombo_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appartmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}