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
            this._eventsDGV = new System.Windows.Forms.DataGridView();
            this._homeTeamCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._awayTeamCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._homeWinsCOL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._drawCOL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._awayWinsCOL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._ticketNumberL = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this._addTicketB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._eventsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // _eventsDGV
            // 
            this._eventsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._eventsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._eventsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._eventsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._homeTeamCOL,
            this._awayTeamCOL,
            this._homeWinsCOL,
            this._drawCOL,
            this._awayWinsCOL});
            this._eventsDGV.Location = new System.Drawing.Point(12, 42);
            this._eventsDGV.Name = "_eventsDGV";
            this._eventsDGV.Size = new System.Drawing.Size(456, 352);
            this._eventsDGV.TabIndex = 0;
            // 
            // _homeTeamCOL
            // 
            this._homeTeamCOL.FillWeight = 35F;
            this._homeTeamCOL.HeaderText = "Хозяева";
            this._homeTeamCOL.Name = "_homeTeamCOL";
            this._homeTeamCOL.ReadOnly = true;
            // 
            // _awayTeamCOL
            // 
            this._awayTeamCOL.FillWeight = 35F;
            this._awayTeamCOL.HeaderText = "Гости";
            this._awayTeamCOL.Name = "_awayTeamCOL";
            this._awayTeamCOL.ReadOnly = true;
            // 
            // _homeWinsCOL
            // 
            this._homeWinsCOL.FillWeight = 10F;
            this._homeWinsCOL.HeaderText = "1";
            this._homeWinsCOL.Name = "_homeWinsCOL";
            // 
            // _drawCOL
            // 
            this._drawCOL.FillWeight = 10F;
            this._drawCOL.HeaderText = "X";
            this._drawCOL.Name = "_drawCOL";
            // 
            // _awayWinsCOL
            // 
            this._awayWinsCOL.FillWeight = 10F;
            this._awayWinsCOL.HeaderText = "2";
            this._awayWinsCOL.Name = "_awayWinsCOL";
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(97, 9);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(125, 20);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // _addTicketB
            // 
            this._addTicketB.Location = new System.Drawing.Point(330, 400);
            this._addTicketB.Name = "_addTicketB";
            this._addTicketB.Size = new System.Drawing.Size(137, 23);
            this._addTicketB.TabIndex = 3;
            this._addTicketB.Text = "Добавить";
            this._addTicketB.UseVisualStyleBackColor = true;
            // 
            // BPMainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 435);
            this.Controls.Add(this._addTicketB);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this._ticketNumberL);
            this.Controls.Add(this._eventsDGV);
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _homeTeamCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn _awayTeamCOL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _homeWinsCOL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _drawCOL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _awayWinsCOL;
        private System.Windows.Forms.Button _addTicketB;
    }
}

