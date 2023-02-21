namespace Calculadora
{
    partial class master_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResult = new System.Windows.Forms.Label();
            this.rdbPlus = new System.Windows.Forms.RadioButton();
            this.rdbMenos = new System.Windows.Forms.RadioButton();
            this.rdbTimes = new System.Windows.Forms.RadioButton();
            this.rdbDivided = new System.Windows.Forms.RadioButton();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResult.Location = new System.Drawing.Point(12, 24);
            this.lblResult.MaximumSize = new System.Drawing.Size(100, 100);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 54);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "0";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // rdbPlus
            // 
            this.rdbPlus.AutoSize = true;
            this.rdbPlus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbPlus.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbPlus.Location = new System.Drawing.Point(237, 105);
            this.rdbPlus.Name = "rdbPlus";
            this.rdbPlus.Size = new System.Drawing.Size(44, 32);
            this.rdbPlus.TabIndex = 1;
            this.rdbPlus.TabStop = true;
            this.rdbPlus.Text = "+";
            this.rdbPlus.UseVisualStyleBackColor = true;
            // 
            // rdbMenos
            // 
            this.rdbMenos.AutoSize = true;
            this.rdbMenos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbMenos.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbMenos.Location = new System.Drawing.Point(236, 154);
            this.rdbMenos.Name = "rdbMenos";
            this.rdbMenos.Size = new System.Drawing.Size(38, 32);
            this.rdbMenos.TabIndex = 2;
            this.rdbMenos.TabStop = true;
            this.rdbMenos.Text = "-";
            this.rdbMenos.UseVisualStyleBackColor = true;
            // 
            // rdbTimes
            // 
            this.rdbTimes.AutoSize = true;
            this.rdbTimes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbTimes.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbTimes.Location = new System.Drawing.Point(237, 203);
            this.rdbTimes.Name = "rdbTimes";
            this.rdbTimes.Size = new System.Drawing.Size(38, 32);
            this.rdbTimes.TabIndex = 3;
            this.rdbTimes.TabStop = true;
            this.rdbTimes.Text = "*";
            this.rdbTimes.UseVisualStyleBackColor = true;
            // 
            // rdbDivided
            // 
            this.rdbDivided.AutoSize = true;
            this.rdbDivided.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbDivided.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbDivided.Location = new System.Drawing.Point(236, 253);
            this.rdbDivided.Name = "rdbDivided";
            this.rdbDivided.Size = new System.Drawing.Size(38, 32);
            this.rdbDivided.TabIndex = 4;
            this.rdbDivided.TabStop = true;
            this.rdbDivided.Text = "/";
            this.rdbDivided.UseVisualStyleBackColor = true;
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(12, 154);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.PlaceholderText = "Primeiro número";
            this.txtFirstNumber.Size = new System.Drawing.Size(191, 23);
            this.txtFirstNumber.TabIndex = 5;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(12, 213);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.PlaceholderText = "Segundo número";
            this.txtSecondNumber.Size = new System.Drawing.Size(191, 23);
            this.txtSecondNumber.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 262);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Calcular";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(128, 262);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // master_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(300, 311);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.rdbDivided);
            this.Controls.Add(this.rdbTimes);
            this.Controls.Add(this.rdbMenos);
            this.Controls.Add(this.rdbPlus);
            this.Controls.Add(this.lblResult);
            this.Name = "master_form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblResult;
        private RadioButton rdbPlus;
        private RadioButton rdbMenos;
        private RadioButton rdbTimes;
        private RadioButton rdbDivided;
        private TextBox txtFirstNumber;
        private TextBox txtSecondNumber;
        private Button btnSend;
        private Button btnClean;
    }
}