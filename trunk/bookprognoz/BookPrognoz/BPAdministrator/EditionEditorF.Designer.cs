namespace BPAdministrator
{
    partial class EditionEditorF
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
            this._editionNumber = new System.Windows.Forms.MaskedTextBox();
            this._applyB = new System.Windows.Forms.Button();
            this._dateOfEndL = new System.Windows.Forms.Label();
            this._endDateDTP = new System.Windows.Forms.DateTimePicker();
            this._editionNumberL = new System.Windows.Forms.Label();
            this._eventsGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this._startDateDTP = new System.Windows.Forms.DateTimePicker();
            this._cancelB = new System.Windows.Forms.Button();
            this._numberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._homeTeamCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._awayTeamCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._eventsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // _editionNumber
            // 
            this._editionNumber.Location = new System.Drawing.Point(100, 9);
            this._editionNumber.Name = "_editionNumber";
            this._editionNumber.Size = new System.Drawing.Size(100, 20);
            this._editionNumber.TabIndex = 12;
            // 
            // _applyB
            // 
            this._applyB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._applyB.Location = new System.Drawing.Point(359, 360);
            this._applyB.Name = "_applyB";
            this._applyB.Size = new System.Drawing.Size(123, 23);
            this._applyB.TabIndex = 11;
            this._applyB.Text = "Принять";
            this._applyB.UseVisualStyleBackColor = true;
            this._applyB.Click += new System.EventHandler(this._saveB_Click);
            // 
            // _dateOfEndL
            // 
            this._dateOfEndL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._dateOfEndL.AutoSize = true;
            this._dateOfEndL.Location = new System.Drawing.Point(393, 40);
            this._dateOfEndL.Name = "_dateOfEndL";
            this._dateOfEndL.Size = new System.Drawing.Size(89, 13);
            this._dateOfEndL.TabIndex = 10;
            this._dateOfEndL.Text = "Дата окончания";
            // 
            // _endDateDTP
            // 
            this._endDateDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._endDateDTP.CustomFormat = "dd.MM.yyyy hh:mm";
            this._endDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._endDateDTP.Location = new System.Drawing.Point(488, 36);
            this._endDateDTP.Name = "_endDateDTP";
            this._endDateDTP.Size = new System.Drawing.Size(127, 20);
            this._endDateDTP.TabIndex = 9;
            // 
            // _editionNumberL
            // 
            this._editionNumberL.AutoSize = true;
            this._editionNumberL.Location = new System.Drawing.Point(13, 12);
            this._editionNumberL.Name = "_editionNumberL";
            this._editionNumberL.Size = new System.Drawing.Size(81, 13);
            this._editionNumberL.TabIndex = 8;
            this._editionNumberL.Text = "Номер тиража";
            // 
            // _eventsGrid
            // 
            this._eventsGrid.AllowUserToAddRows = false;
            this._eventsGrid.AllowUserToDeleteRows = false;
            this._eventsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._eventsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._eventsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._numberCol,
            this._homeTeamCol,
            this._awayTeamCol});
            this._eventsGrid.Location = new System.Drawing.Point(12, 62);
            this._eventsGrid.Name = "_eventsGrid";
            this._eventsGrid.Size = new System.Drawing.Size(603, 292);
            this._eventsGrid.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Дата начала";
            // 
            // _startDateDTP
            // 
            this._startDateDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._startDateDTP.CustomFormat = "dd.MM.yyyy hh:mm";
            this._startDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._startDateDTP.Location = new System.Drawing.Point(488, 9);
            this._startDateDTP.Name = "_startDateDTP";
            this._startDateDTP.Size = new System.Drawing.Size(127, 20);
            this._startDateDTP.TabIndex = 13;
            // 
            // _cancelB
            // 
            this._cancelB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelB.Location = new System.Drawing.Point(492, 360);
            this._cancelB.Name = "_cancelB";
            this._cancelB.Size = new System.Drawing.Size(123, 23);
            this._cancelB.TabIndex = 15;
            this._cancelB.Text = "Отмена";
            this._cancelB.UseVisualStyleBackColor = true;
            // 
            // _numberCol
            // 
            this._numberCol.DataPropertyName = "number";
            this._numberCol.FillWeight = 10F;
            this._numberCol.HeaderText = "N";
            this._numberCol.Name = "_numberCol";
            this._numberCol.ReadOnly = true;
            this._numberCol.Width = 30;
            // 
            // _homeTeamCol
            // 
            this._homeTeamCol.DataPropertyName = "homeTeam";
            this._homeTeamCol.HeaderText = "Хозяева";
            this._homeTeamCol.Name = "_homeTeamCol";
            // 
            // _awayTeamCol
            // 
            this._awayTeamCol.DataPropertyName = "awayTeam";
            this._awayTeamCol.HeaderText = "Гости";
            this._awayTeamCol.Name = "_awayTeamCol";
            // 
            // EditionEditorF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 389);
            this.Controls.Add(this._cancelB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._startDateDTP);
            this.Controls.Add(this._editionNumber);
            this.Controls.Add(this._applyB);
            this.Controls.Add(this._dateOfEndL);
            this.Controls.Add(this._endDateDTP);
            this.Controls.Add(this._editionNumberL);
            this.Controls.Add(this._eventsGrid);
            this.Name = "EditionEditorF";
            this.ShowInTaskbar = false;
            this.Text = "Редактор тиража";
            ((System.ComponentModel.ISupportInitialize)(this._eventsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox _editionNumber;
        private System.Windows.Forms.Button _applyB;
        private System.Windows.Forms.Label _dateOfEndL;
        private System.Windows.Forms.DateTimePicker _endDateDTP;
        private System.Windows.Forms.Label _editionNumberL;
        private System.Windows.Forms.DataGridView _eventsGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker _startDateDTP;
        private System.Windows.Forms.Button _cancelB;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn _homeTeamCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn _awayTeamCol;
    }
}