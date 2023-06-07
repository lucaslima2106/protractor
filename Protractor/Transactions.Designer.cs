
namespace Protractor
{
    partial class transactionsForm
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
            this.lblSearchTX = new System.Windows.Forms.Label();
            this.txtBoxSearchTX = new System.Windows.Forms.TextBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.WorkOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchTX
            // 
            this.lblSearchTX.AutoSize = true;
            this.lblSearchTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTX.Location = new System.Drawing.Point(62, 41);
            this.lblSearchTX.Name = "lblSearchTX";
            this.lblSearchTX.Size = new System.Drawing.Size(124, 25);
            this.lblSearchTX.TabIndex = 0;
            this.lblSearchTX.Text = "Search TX#:";
            // 
            // txtBoxSearchTX
            // 
            this.txtBoxSearchTX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearchTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchTX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxSearchTX.Location = new System.Drawing.Point(196, 37);
            this.txtBoxSearchTX.Name = "txtBoxSearchTX";
            this.txtBoxSearchTX.Size = new System.Drawing.Size(285, 30);
            this.txtBoxSearchTX.TabIndex = 1;
            this.txtBoxSearchTX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxSearchTX_KeyUp);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkOrder,
            this.Entry,
            this.Description,
            this.Amount});
            this.dgvResult.Location = new System.Drawing.Point(67, 105);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersWidth = 51;
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(739, 307);
            this.dgvResult.TabIndex = 2;
            // 
            // WorkOrder
            // 
            this.WorkOrder.HeaderText = "WorkOrder";
            this.WorkOrder.MinimumWidth = 6;
            this.WorkOrder.Name = "WorkOrder";
            this.WorkOrder.ReadOnly = true;
            this.WorkOrder.Width = 125;
            // 
            // Entry
            // 
            this.Entry.HeaderText = "Entry";
            this.Entry.MinimumWidth = 6;
            this.Entry.Name = "Entry";
            this.Entry.ReadOnly = true;
            this.Entry.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 125;
            // 
            // transactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 437);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.txtBoxSearchTX);
            this.Controls.Add(this.lblSearchTX);
            this.Name = "transactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Related Transactions Associated with TX Number";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchTX;
        private System.Windows.Forms.TextBox txtBoxSearchTX;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}

