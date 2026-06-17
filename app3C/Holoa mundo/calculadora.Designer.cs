namespace app3C.Holoa_mundo
{
    partial class frmcalculadora
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvaloor1 = new System.Windows.Forms.TextBox();
            this.txtValoor2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSumaar = new System.Windows.Forms.Button();
            this.lblResul = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtvaloor1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtValoor2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnSumaar, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblResul, 0, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 256);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "calculadora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "valor 1";
            // 
            // txtvaloor1
            // 
            this.txtvaloor1.Location = new System.Drawing.Point(3, 78);
            this.txtvaloor1.Name = "txtvaloor1";
            this.txtvaloor1.Size = new System.Drawing.Size(100, 20);
            this.txtvaloor1.TabIndex = 2;
            // 
            // txtValoor2
            // 
            this.txtValoor2.Location = new System.Drawing.Point(3, 148);
            this.txtValoor2.Name = "txtValoor2";
            this.txtValoor2.Size = new System.Drawing.Size(100, 20);
            this.txtValoor2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "valor 2";
            // 
            // btnSumaar
            // 
            this.btnSumaar.Location = new System.Drawing.Point(3, 183);
            this.btnSumaar.Name = "btnSumaar";
            this.btnSumaar.Size = new System.Drawing.Size(75, 23);
            this.btnSumaar.TabIndex = 5;
            this.btnSumaar.Text = "sumar";
            this.btnSumaar.UseVisualStyleBackColor = true;
            this.btnSumaar.Click += new System.EventHandler(this.btnSumaar_Click);
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Location = new System.Drawing.Point(3, 215);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(50, 13);
            this.lblResul.TabIndex = 6;
            this.lblResul.Text = "resultado";
            // 
            // frmcalculadora
            // 
            this.ClientSize = new System.Drawing.Size(284, 259);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmcalculadora";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvaloor1;
        private System.Windows.Forms.TextBox txtValoor2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSumaar;
        private System.Windows.Forms.Label lblResul;
    }
}