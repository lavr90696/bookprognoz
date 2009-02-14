namespace BookPrognoz
{
    partial class SelectPunctF
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
            this._punctCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._okB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _punctCB
            // 
            this._punctCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._punctCB.FormattingEnabled = true;
            this._punctCB.Location = new System.Drawing.Point(33, 46);
            this._punctCB.Name = "_punctCB";
            this._punctCB.Size = new System.Drawing.Size(215, 21);
            this._punctCB.TabIndex = 0;
            this._punctCB.SelectedIndexChanged += new System.EventHandler(this._punctCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите пункт";
            // 
            // _okB
            // 
            this._okB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okB.Location = new System.Drawing.Point(173, 80);
            this._okB.Name = "_okB";
            this._okB.Size = new System.Drawing.Size(75, 23);
            this._okB.TabIndex = 2;
            this._okB.Text = "Ok";
            this._okB.UseVisualStyleBackColor = true;
            // 
            // SelectPunctF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 115);
            this.Controls.Add(this._okB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._punctCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectPunctF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectPunctF";
            this.Load += new System.EventHandler(this.SelectPunctF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _punctCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _okB;
    }
}