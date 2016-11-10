namespace EyeCT4Events
{
    partial class BetaalForm
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
            this.lbPaid = new System.Windows.Forms.ListBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.btnPayReservation = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldoEuro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPaid
            // 
            this.lbPaid.FormattingEnabled = true;
            this.lbPaid.Location = new System.Drawing.Point(12, 23);
            this.lbPaid.Name = "lbPaid";
            this.lbPaid.Size = new System.Drawing.Size(214, 251);
            this.lbPaid.TabIndex = 0;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(12, 7);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(90, 13);
            this.lblPaid.TabIndex = 1;
            this.lblPaid.Text = "Uw reserveringen";
            // 
            // btnPayReservation
            // 
            this.btnPayReservation.Location = new System.Drawing.Point(257, 221);
            this.btnPayReservation.Name = "btnPayReservation";
            this.btnPayReservation.Size = new System.Drawing.Size(137, 53);
            this.btnPayReservation.TabIndex = 2;
            this.btnPayReservation.Text = "Betaal Reservering";
            this.btnPayReservation.UseVisualStyleBackColor = true;
            this.btnPayReservation.Click += new System.EventHandler(this.btnPayReservation_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(241, 23);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblSaldoEuro
            // 
            this.lblSaldoEuro.AutoSize = true;
            this.lblSaldoEuro.Location = new System.Drawing.Point(302, 23);
            this.lblSaldoEuro.Name = "lblSaldoEuro";
            this.lblSaldoEuro.Size = new System.Drawing.Size(35, 13);
            this.lblSaldoEuro.TabIndex = 4;
            this.lblSaldoEuro.Text = "euro\'s";
            // 
            // BetaalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 286);
            this.Controls.Add(this.lblSaldoEuro);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnPayReservation);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.lbPaid);
            this.Name = "BetaalForm";
            this.Text = "BetaalForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BetaalForm_FormClosing);
            this.Load += new System.EventHandler(this.BetaalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPaid;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Button btnPayReservation;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSaldoEuro;
    }
}