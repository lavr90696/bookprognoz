namespace BookPrognoz
{
    partial class BPMainF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BPMainF));
            this._eventsDGV = new System.Windows.Forms.DataGridView();
            this.NumberCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._homeTeamCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._awayTeamCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ticketNumberL = new System.Windows.Forms.Label();
            this._ticketNumberME = new System.Windows.Forms.MaskedTextBox();
            this._addTicketB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._eventsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // _eventsDGV
            // 
            this._eventsDGV.AllowUserToAddRows = false;
            this._eventsDGV.AllowUserToDeleteRows = false;
            this._eventsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._eventsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._eventsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._eventsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberCOL,
            this._homeTeamCOL,
            this._awayTeamCOL});
            this._eventsDGV.Location = new System.Drawing.Point(12, 42);
            this._eventsDGV.Name = "_eventsDGV";
            this._eventsDGV.RowHeadersVisible = false;
            this._eventsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._eventsDGV.Size = new System.Drawing.Size(456, 352);
            this._eventsDGV.TabIndex = 0;
            this._eventsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._eventsDGV_CellContentClick);
            // 
            // NumberCOL
            // 
            this.NumberCOL.DataPropertyName = "Number";
            this.NumberCOL.FillWeight = 5F;
            this.NumberCOL.HeaderText = "N";
            this.NumberCOL.Name = "NumberCOL";
            this.NumberCOL.ReadOnly = true;
            // 
            // _homeTeamCOL
            // 
            this._homeTeamCOL.DataPropertyName = "home";
            this._homeTeamCOL.FillWeight = 35F;
            this._homeTeamCOL.HeaderText = "Хозяева";
            this._homeTeamCOL.Name = "_homeTeamCOL";
            this._homeTeamCOL.ReadOnly = true;
            // 
            // _awayTeamCOL
            // 
            this._awayTeamCOL.DataPropertyName = "away";
            this._awayTeamCOL.FillWeight = 35F;
            this._awayTeamCOL.HeaderText = "Гости";
            this._awayTeamCOL.Name = "_awayTeamCOL";
            this._awayTeamCOL.ReadOnly = true;
            // 
            // _ticketNumberL
            // 
            this._ticketNumberL.AutoSize = true;
            this._ticketNumberL.Location = new System.Drawing.Point(12, 12);
            this._ticketNumberL.Name = "_ticketNumberL";
            this._ticketNumberL.Size = new System.Drawing.Size(79, 13);
            this._ticketNumberL.TabIndex = 1;
            this._ticketNumberL.Text = "Номер билета";
            // 
            // _ticketNumberME
            // 
            this._ticketNumberME.Location = new System.Drawing.Point(97, 9);
            this._ticketNumberME.Mask = "999999";
            this._ticketNumberME.Name = "_ticketNumberME";
            this._ticketNumberME.Size = new System.Drawing.Size(125, 20);
            this._ticketNumberME.TabIndex = 2;
            // 
            // _addTicketB
            // 
            this._addTicketB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._addTicketB.Location = new System.Drawing.Point(330, 400);
            this._addTicketB.Name = "_addTicketB";
            this._addTicketB.Size = new System.Drawing.Size(137, 23);
            this._addTicketB.TabIndex = 3;
            this._addTicketB.Text = "Добавить";
            this._addTicketB.UseVisualStyleBackColor = true;
            this._addTicketB.Click += new System.EventHandler(this._addTicketB_Click);
            // 
            // BPMainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 435);
            this.Controls.Add(this._addTicketB);
            this.Controls.Add(this._ticketNumberME);
            this.Controls.Add(this._ticketNumberL);
            this.Controls.Add(this._eventsDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BPMainF";
            this.Text = "BookPrognoz";
            this.Load += new System.EventHandler(this.BPMainF_Load);
            ((System.ComponentModel.ISupportInitialize)(this._eventsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _eventsDGV;
        private System.Windows.Forms.Label _ticketNumberL;
        private System.Windows.Forms.MaskedTextBox _ticketNumberME;
        private System.Windows.Forms.Button _addTicketB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn _homeTeamCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn _awayTeamCOL;
    }
}

