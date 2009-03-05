namespace BPAdministrator
{
    partial class EditionViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._addEditionB = new System.Windows.Forms.Button();
            this._editionsGrid = new Add.Controls.AdvancedGrid();
            this.NumberCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._endDateCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._startDateCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._stateCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuspendLayout();
            // 
            // _addEditionB
            // 
            this._addEditionB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._addEditionB.Location = new System.Drawing.Point(447, 385);
            this._addEditionB.Name = "_addEditionB";
            this._addEditionB.Size = new System.Drawing.Size(132, 23);
            this._addEditionB.TabIndex = 3;
            this._addEditionB.Text = "Добавить тираж";
            this._addEditionB.UseVisualStyleBackColor = true;
            this._addEditionB.Click += new System.EventHandler(this._addEditionB_Click);
            // 
            // _editionsGrid
            // 
            this._editionsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._editionsGrid.AutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._editionsGrid.ChartDefenitionFilePath = null;
            this._editionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberCOL,
            this._endDateCOL,
            this._startDateCOL,
            this._stateCOL});
            this._editionsGrid.FiltersPanelVisilbe = false;
            this._editionsGrid.Location = new System.Drawing.Point(3, 3);
            this._editionsGrid.MultiSelect = true;
            this._editionsGrid.Name = "_editionsGrid";
            this._editionsGrid.QuickSearchPanelVisible = false;
            this._editionsGrid.ReportDefenitionFilePath = null;
            this._editionsGrid.ReportHeader = null;
            this._editionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this._editionsGrid.Size = new System.Drawing.Size(576, 379);
            this._editionsGrid.SummaryPanelVisible = true;
            this._editionsGrid.TabIndex = 2;
            this._editionsGrid.UserFilter = null;
            // 
            // NumberCOL
            // 
            this.NumberCOL.DataPropertyName = "number";
            this.NumberCOL.HeaderText = "N";
            this.NumberCOL.Name = "NumberCOL";
            this.NumberCOL.ReadOnly = true;
            this.NumberCOL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // _endDateCOL
            // 
            this._endDateCOL.DataPropertyName = "end_date";
            this._endDateCOL.HeaderText = "Завершение";
            this._endDateCOL.Name = "_endDateCOL";
            this._endDateCOL.ReadOnly = true;
            this._endDateCOL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // _startDateCOL
            // 
            this._startDateCOL.DataPropertyName = "start_state";
            this._startDateCOL.HeaderText = "Начало";
            this._startDateCOL.Name = "_startDateCOL";
            this._startDateCOL.ReadOnly = true;
            this._startDateCOL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // _stateCOL
            // 
            this._stateCOL.DataPropertyName = "state";
            this._stateCOL.HeaderText = "Состояние";
            this._stateCOL.Name = "_stateCOL";
            this._stateCOL.ReadOnly = true;
            this._stateCOL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this._stateCOL.Visible = false;
            // 
            // EditionViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._addEditionB);
            this.Controls.Add(this._editionsGrid);
            this.Name = "EditionViewer";
            this.Size = new System.Drawing.Size(582, 411);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _addEditionB;
        private Add.Controls.AdvancedGrid _editionsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn _endDateCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn _startDateCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn _stateCOL;
    }
}
