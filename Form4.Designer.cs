namespace WindowsFormsApp1
{
    partial class Form4
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
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.commautoMay19BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comm_auto_May19TableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.comm_auto_May19TableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOABBREVNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOLICYBRANCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOSSEVENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOSSEVENTDESCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOLNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOSSDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCCURNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOSSCHARTCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCOFLOSSCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLSTATUSCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLINCURREDAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLLINETYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iBCKINDOFLOSSCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVGLOSSPDAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVGEXPNPDAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVGNETPDAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVGRESRAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVGINCURREDAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMMUWINDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEDUCTAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROVABBREVNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPOSTYPECDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineofbusinessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commautoMay19BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cOABBREVNAMEDataGridViewTextBoxColumn,
            this.pOLICYBRANCHDataGridViewTextBoxColumn,
            this.lOSSEVENTIDDataGridViewTextBoxColumn,
            this.lOSSEVENTDESCDataGridViewTextBoxColumn,
            this.pOLNUMDataGridViewTextBoxColumn,
            this.lOSSDTDataGridViewTextBoxColumn,
            this.oCCURNUMDataGridViewTextBoxColumn,
            this.lOSSCHARTCDDataGridViewTextBoxColumn,
            this.dESCOFLOSSCDDataGridViewTextBoxColumn,
            this.cLSTATUSCDDataGridViewTextBoxColumn,
            this.cLINCURREDAMTDataGridViewTextBoxColumn,
            this.cLLINETYPEDataGridViewTextBoxColumn,
            this.iBCKINDOFLOSSCDDataGridViewTextBoxColumn,
            this.cVGLOSSPDAMTDataGridViewTextBoxColumn,
            this.cVGEXPNPDAMTDataGridViewTextBoxColumn,
            this.cVGNETPDAMTDataGridViewTextBoxColumn,
            this.cVGRESRAMTDataGridViewTextBoxColumn,
            this.cVGINCURREDAMTDataGridViewTextBoxColumn,
            this.cOMMUWINDDataGridViewTextBoxColumn,
            this.cLNUMDataGridViewTextBoxColumn,
            this.dEDUCTAMTDataGridViewTextBoxColumn,
            this.pROVABBREVNAMEDataGridViewTextBoxColumn,
            this.eXPOSTYPECDDataGridViewTextBoxColumn,
            this.lineofbusinessDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.commautoMay19BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commautoMay19BindingSource
            // 
            this.commautoMay19BindingSource.DataMember = "comm_auto_May19";
            this.commautoMay19BindingSource.DataSource = this.dataSet1;
            // 
            // comm_auto_May19TableAdapter
            // 
            this.comm_auto_May19TableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOABBREVNAMEDataGridViewTextBoxColumn
            // 
            this.cOABBREVNAMEDataGridViewTextBoxColumn.DataPropertyName = "CO_ABBREV_NAME";
            this.cOABBREVNAMEDataGridViewTextBoxColumn.HeaderText = "CO_ABBREV_NAME";
            this.cOABBREVNAMEDataGridViewTextBoxColumn.Name = "cOABBREVNAMEDataGridViewTextBoxColumn";
            // 
            // pOLICYBRANCHDataGridViewTextBoxColumn
            // 
            this.pOLICYBRANCHDataGridViewTextBoxColumn.DataPropertyName = "POLICY_BRANCH";
            this.pOLICYBRANCHDataGridViewTextBoxColumn.HeaderText = "POLICY_BRANCH";
            this.pOLICYBRANCHDataGridViewTextBoxColumn.Name = "pOLICYBRANCHDataGridViewTextBoxColumn";
            // 
            // lOSSEVENTIDDataGridViewTextBoxColumn
            // 
            this.lOSSEVENTIDDataGridViewTextBoxColumn.DataPropertyName = "LOSS_EVENT_ID";
            this.lOSSEVENTIDDataGridViewTextBoxColumn.HeaderText = "LOSS_EVENT_ID";
            this.lOSSEVENTIDDataGridViewTextBoxColumn.Name = "lOSSEVENTIDDataGridViewTextBoxColumn";
            // 
            // lOSSEVENTDESCDataGridViewTextBoxColumn
            // 
            this.lOSSEVENTDESCDataGridViewTextBoxColumn.DataPropertyName = "LOSS_EVENT_DESC";
            this.lOSSEVENTDESCDataGridViewTextBoxColumn.HeaderText = "LOSS_EVENT_DESC";
            this.lOSSEVENTDESCDataGridViewTextBoxColumn.Name = "lOSSEVENTDESCDataGridViewTextBoxColumn";
            // 
            // pOLNUMDataGridViewTextBoxColumn
            // 
            this.pOLNUMDataGridViewTextBoxColumn.DataPropertyName = "POL_NUM";
            this.pOLNUMDataGridViewTextBoxColumn.HeaderText = "POL_NUM";
            this.pOLNUMDataGridViewTextBoxColumn.Name = "pOLNUMDataGridViewTextBoxColumn";
            // 
            // lOSSDTDataGridViewTextBoxColumn
            // 
            this.lOSSDTDataGridViewTextBoxColumn.DataPropertyName = "LOSS_DT";
            this.lOSSDTDataGridViewTextBoxColumn.HeaderText = "LOSS_DT";
            this.lOSSDTDataGridViewTextBoxColumn.Name = "lOSSDTDataGridViewTextBoxColumn";
            // 
            // oCCURNUMDataGridViewTextBoxColumn
            // 
            this.oCCURNUMDataGridViewTextBoxColumn.DataPropertyName = "OCCUR_NUM";
            this.oCCURNUMDataGridViewTextBoxColumn.HeaderText = "OCCUR_NUM";
            this.oCCURNUMDataGridViewTextBoxColumn.Name = "oCCURNUMDataGridViewTextBoxColumn";
            // 
            // lOSSCHARTCDDataGridViewTextBoxColumn
            // 
            this.lOSSCHARTCDDataGridViewTextBoxColumn.DataPropertyName = "LOSS_CHART_CD";
            this.lOSSCHARTCDDataGridViewTextBoxColumn.HeaderText = "LOSS_CHART_CD";
            this.lOSSCHARTCDDataGridViewTextBoxColumn.Name = "lOSSCHARTCDDataGridViewTextBoxColumn";
            // 
            // dESCOFLOSSCDDataGridViewTextBoxColumn
            // 
            this.dESCOFLOSSCDDataGridViewTextBoxColumn.DataPropertyName = "DESC_OF_LOSS_CD";
            this.dESCOFLOSSCDDataGridViewTextBoxColumn.HeaderText = "DESC_OF_LOSS_CD";
            this.dESCOFLOSSCDDataGridViewTextBoxColumn.Name = "dESCOFLOSSCDDataGridViewTextBoxColumn";
            // 
            // cLSTATUSCDDataGridViewTextBoxColumn
            // 
            this.cLSTATUSCDDataGridViewTextBoxColumn.DataPropertyName = "CL_STATUS_CD";
            this.cLSTATUSCDDataGridViewTextBoxColumn.HeaderText = "CL_STATUS_CD";
            this.cLSTATUSCDDataGridViewTextBoxColumn.Name = "cLSTATUSCDDataGridViewTextBoxColumn";
            // 
            // cLINCURREDAMTDataGridViewTextBoxColumn
            // 
            this.cLINCURREDAMTDataGridViewTextBoxColumn.DataPropertyName = "CL_INCURRED_AMT";
            this.cLINCURREDAMTDataGridViewTextBoxColumn.HeaderText = "CL_INCURRED_AMT";
            this.cLINCURREDAMTDataGridViewTextBoxColumn.Name = "cLINCURREDAMTDataGridViewTextBoxColumn";
            // 
            // cLLINETYPEDataGridViewTextBoxColumn
            // 
            this.cLLINETYPEDataGridViewTextBoxColumn.DataPropertyName = "CL_LINE_TYPE";
            this.cLLINETYPEDataGridViewTextBoxColumn.HeaderText = "CL_LINE_TYPE";
            this.cLLINETYPEDataGridViewTextBoxColumn.Name = "cLLINETYPEDataGridViewTextBoxColumn";
            // 
            // iBCKINDOFLOSSCDDataGridViewTextBoxColumn
            // 
            this.iBCKINDOFLOSSCDDataGridViewTextBoxColumn.DataPropertyName = "IBC_KINDOF_LOSS_CD";
            this.iBCKINDOFLOSSCDDataGridViewTextBoxColumn.HeaderText = "IBC_KINDOF_LOSS_CD";
            this.iBCKINDOFLOSSCDDataGridViewTextBoxColumn.Name = "iBCKINDOFLOSSCDDataGridViewTextBoxColumn";
            // 
            // cVGLOSSPDAMTDataGridViewTextBoxColumn
            // 
            this.cVGLOSSPDAMTDataGridViewTextBoxColumn.DataPropertyName = "CVG_LOSS_PD_AMT";
            this.cVGLOSSPDAMTDataGridViewTextBoxColumn.HeaderText = "CVG_LOSS_PD_AMT";
            this.cVGLOSSPDAMTDataGridViewTextBoxColumn.Name = "cVGLOSSPDAMTDataGridViewTextBoxColumn";
            // 
            // cVGEXPNPDAMTDataGridViewTextBoxColumn
            // 
            this.cVGEXPNPDAMTDataGridViewTextBoxColumn.DataPropertyName = "CVG_EXPN_PD_AMT";
            this.cVGEXPNPDAMTDataGridViewTextBoxColumn.HeaderText = "CVG_EXPN_PD_AMT";
            this.cVGEXPNPDAMTDataGridViewTextBoxColumn.Name = "cVGEXPNPDAMTDataGridViewTextBoxColumn";
            // 
            // cVGNETPDAMTDataGridViewTextBoxColumn
            // 
            this.cVGNETPDAMTDataGridViewTextBoxColumn.DataPropertyName = "CVG_NET_PD_AMT";
            this.cVGNETPDAMTDataGridViewTextBoxColumn.HeaderText = "CVG_NET_PD_AMT";
            this.cVGNETPDAMTDataGridViewTextBoxColumn.Name = "cVGNETPDAMTDataGridViewTextBoxColumn";
            // 
            // cVGRESRAMTDataGridViewTextBoxColumn
            // 
            this.cVGRESRAMTDataGridViewTextBoxColumn.DataPropertyName = "CVG_RESR_AMT";
            this.cVGRESRAMTDataGridViewTextBoxColumn.HeaderText = "CVG_RESR_AMT";
            this.cVGRESRAMTDataGridViewTextBoxColumn.Name = "cVGRESRAMTDataGridViewTextBoxColumn";
            // 
            // cVGINCURREDAMTDataGridViewTextBoxColumn
            // 
            this.cVGINCURREDAMTDataGridViewTextBoxColumn.DataPropertyName = "CVG_INCURRED_AMT";
            this.cVGINCURREDAMTDataGridViewTextBoxColumn.HeaderText = "CVG_INCURRED_AMT";
            this.cVGINCURREDAMTDataGridViewTextBoxColumn.Name = "cVGINCURREDAMTDataGridViewTextBoxColumn";
            // 
            // cOMMUWINDDataGridViewTextBoxColumn
            // 
            this.cOMMUWINDDataGridViewTextBoxColumn.DataPropertyName = "COMM_UW_IND";
            this.cOMMUWINDDataGridViewTextBoxColumn.HeaderText = "COMM_UW_IND";
            this.cOMMUWINDDataGridViewTextBoxColumn.Name = "cOMMUWINDDataGridViewTextBoxColumn";
            // 
            // cLNUMDataGridViewTextBoxColumn
            // 
            this.cLNUMDataGridViewTextBoxColumn.DataPropertyName = "CL_NUM";
            this.cLNUMDataGridViewTextBoxColumn.HeaderText = "CL_NUM";
            this.cLNUMDataGridViewTextBoxColumn.Name = "cLNUMDataGridViewTextBoxColumn";
            // 
            // dEDUCTAMTDataGridViewTextBoxColumn
            // 
            this.dEDUCTAMTDataGridViewTextBoxColumn.DataPropertyName = "DEDUCT_AMT";
            this.dEDUCTAMTDataGridViewTextBoxColumn.HeaderText = "DEDUCT_AMT";
            this.dEDUCTAMTDataGridViewTextBoxColumn.Name = "dEDUCTAMTDataGridViewTextBoxColumn";
            // 
            // pROVABBREVNAMEDataGridViewTextBoxColumn
            // 
            this.pROVABBREVNAMEDataGridViewTextBoxColumn.DataPropertyName = "PROV_ABBREV_NAME";
            this.pROVABBREVNAMEDataGridViewTextBoxColumn.HeaderText = "PROV_ABBREV_NAME";
            this.pROVABBREVNAMEDataGridViewTextBoxColumn.Name = "pROVABBREVNAMEDataGridViewTextBoxColumn";
            // 
            // eXPOSTYPECDDataGridViewTextBoxColumn
            // 
            this.eXPOSTYPECDDataGridViewTextBoxColumn.DataPropertyName = "EXPOS_TYPE_CD";
            this.eXPOSTYPECDDataGridViewTextBoxColumn.HeaderText = "EXPOS_TYPE_CD";
            this.eXPOSTYPECDDataGridViewTextBoxColumn.Name = "eXPOSTYPECDDataGridViewTextBoxColumn";
            // 
            // lineofbusinessDataGridViewTextBoxColumn
            // 
            this.lineofbusinessDataGridViewTextBoxColumn.DataPropertyName = "line_of_business";
            this.lineofbusinessDataGridViewTextBoxColumn.HeaderText = "line_of_business";
            this.lineofbusinessDataGridViewTextBoxColumn.Name = "lineofbusinessDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commautoMay19BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource commautoMay19BindingSource;
        private DataSet1TableAdapters.comm_auto_May19TableAdapter comm_auto_May19TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOABBREVNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOLICYBRANCHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOSSEVENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOSSEVENTDESCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOLNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOSSDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCCURNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOSSCHARTCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCOFLOSSCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLSTATUSCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLINCURREDAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLLINETYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iBCKINDOFLOSSCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVGLOSSPDAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVGEXPNPDAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVGNETPDAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVGRESRAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVGINCURREDAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMMUWINDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEDUCTAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROVABBREVNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPOSTYPECDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineofbusinessDataGridViewTextBoxColumn;
    }
}