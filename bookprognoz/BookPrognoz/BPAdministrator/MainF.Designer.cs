namespace BPAdministrator
{
    partial class MainF
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
            this._mainTC = new System.Windows.Forms.TabControl();
            this._addEditionTC = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HomeTeamCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwayTeamCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._editionNumberL = new System.Windows.Forms.Label();
            this._endDateDTP = new System.Windows.Forms.DateTimePicker();
            this._dateOfEndL = new System.Windows.Forms.Label();
            this._addEditionB = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this._mainTC.SuspendLayout();
            this._addEditionTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainTC
            // 
            this._mainTC.Controls.Add(this._addEditionTC);
            this._mainTC.Controls.Add(this.tabPage2);
            this._mainTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTC.Location = new System.Drawing.Point(0, 0);
            this._mainTC.Name = "_mainTC";
            this._mainTC.SelectedIndex = 0;
            this._mainTC.Size = new System.Drawing.Size(627, 422);
            this._mainTC.TabIndex = 0;
            // 
            // _addEditionTC
            // 
            this._addEditionTC.Controls.Add(this.maskedTextBox1);
            this._addEditionTC.Controls.Add(this._addEditionB);
            this._addEditionTC.Controls.Add(this._dateOfEndL);
            this._addEditionTC.Controls.Add(this._endDateDTP);
            this._addEditionTC.Controls.Add(this._editionNumberL);
            this._addEditionTC.Controls.Add(this.dataGridView1);
            this._addEditionTC.Location = new System.Drawing.Point(4, 22);
            this._addEditionTC.Name = "_addEditionTC";
            this._addEditionTC.Padding = new System.Windows.Forms.Padding(3);
            this._addEditionTC.Size = new System.Drawing.Size(619, 396);
            this._addEditionTC.TabIndex = 0;
            this._addEditionTC.Text = "Добавление тиража";
            this._addEditionTC.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HomeTeamCOL,
            this.AwayTeamCOL});
            this.dataGridView1.Location = new System.Drawing.Point(8, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // HomeTeamCOL
            // 
            this.HomeTeamCOL.HeaderText = "Хозяева";
            this.HomeTeamCOL.Name = "HomeTeamCOL";
            // 
            // AwayTeamCOL
            // 
            this.AwayTeamCOL.HeaderText = "Гости";
            this.AwayTeamCOL.Name = "AwayTeamCOL";
            // 
            // _editionNumberL
            // 
            this._editionNumberL.AutoSize = true;
            this._editionNumberL.Location = new System.Drawing.Point(9, 16);
            this._editionNumberL.Name = "_editionNumberL";
            this._editionNumberL.Size = new System.Drawing.Size(81, 13);
            this._editionNumberL.TabIndex = 2;
            this._editionNumberL.Text = "Номер тиража";
            // 
            // _endDateDTP
            // 
            this._endDateDTP.CustomFormat = "dd.MM.yyyy hh:mm";
            this._endDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._endDateDTP.Location = new System.Drawing.Point(458, 13);
            this._endDateDTP.Name = "_endDateDTP";
            this._endDateDTP.Size = new System.Drawing.Size(153, 20);
            this._endDateDTP.TabIndex = 3;
            // 
            // _dateOfEndL
            // 
            this._dateOfEndL.AutoSize = true;
            this._dateOfEndL.Location = new System.Drawing.Point(363, 17);
            this._dateOfEndL.Name = "_dateOfEndL";
            this._dateOfEndL.Size = new System.Drawing.Size(89, 13);
            this._dateOfEndL.TabIndex = 4;
            this._dateOfEndL.Text = "Дата окончания";
            // 
            // _addEditionB
            // 
            this._addEditionB.Location = new System.Drawing.Point(443, 364);
            this._addEditionB.Name = "_addEditionB";
            this._addEditionB.Size = new System.Drawing.Size(167, 23);
            this._addEditionB.TabIndex = 5;
            this._addEditionB.Text = "Добавить тираж";
            this._addEditionB.UseVisualStyleBackColor = true;
            this._addEditionB.Click += new System.EventHandler(this._addEditionB_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(96, 13);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 422);
            this.Controls.Add(this._mainTC);
            this.Name = "MainF";
            this.Text = "BPAdministrator";
            this._mainTC.ResumeLayout(false);
            this._addEditionTC.ResumeLayout(false);
            this._addEditionTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _mainTC;
        private System.Windows.Forms.TabPage _addEditionTC;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label _editionNumberL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeTeamCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwayTeamCOL;
        private System.Windows.Forms.Button _addEditionB;
        private System.Windows.Forms.Label _dateOfEndL;
        private System.Windows.Forms.DateTimePicker _endDateDTP;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

