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
            this._editionViewer = new BPAdministrator.EditionViewer();
            this._mainTC.SuspendLayout();
            this._addEditionTC.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainTC
            // 
            this._mainTC.Controls.Add(this._addEditionTC);
            this._mainTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTC.Location = new System.Drawing.Point(0, 0);
            this._mainTC.Name = "_mainTC";
            this._mainTC.SelectedIndex = 0;
            this._mainTC.Size = new System.Drawing.Size(627, 422);
            this._mainTC.TabIndex = 0;
            // 
            // _addEditionTC
            // 
            this._addEditionTC.Controls.Add(this._editionViewer);
            this._addEditionTC.Location = new System.Drawing.Point(4, 22);
            this._addEditionTC.Name = "_addEditionTC";
            this._addEditionTC.Padding = new System.Windows.Forms.Padding(3);
            this._addEditionTC.Size = new System.Drawing.Size(619, 396);
            this._addEditionTC.TabIndex = 0;
            this._addEditionTC.Text = "Добавление тиража";
            this._addEditionTC.UseVisualStyleBackColor = true;
            // 
            // _editionViewer
            // 
            this._editionViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._editionViewer.FbConnection = null;
            this._editionViewer.Location = new System.Drawing.Point(3, 3);
            this._editionViewer.Name = "_editionViewer";
            this._editionViewer.Size = new System.Drawing.Size(613, 390);
            this._editionViewer.TabIndex = 0;
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 422);
            this.Controls.Add(this._mainTC);
            this.Name = "MainF";
            this.Text = "BPAdministrator";
            this.Load += new System.EventHandler(this.MainF_Load);
            this._mainTC.ResumeLayout(false);
            this._addEditionTC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _mainTC;
        private System.Windows.Forms.TabPage _addEditionTC;
        private EditionViewer _editionViewer;
    }
}

