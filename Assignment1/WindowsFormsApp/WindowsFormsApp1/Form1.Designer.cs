// Tovah Parnes, tovah@parnes.com, L0002B, Uppgift 1 Forms-variant

namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbPaid = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(412, 99);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(183, 43);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Kalkulera växel";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(52, 68);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(230, 26);
            this.tbPrice.TabIndex = 2;
            // 
            // tbPaid
            // 
            this.tbPaid.Location = new System.Drawing.Point(52, 145);
            this.tbPaid.Name = "tbPaid";
            this.tbPaid.Size = new System.Drawing.Size(230, 26);
            this.tbPaid.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(48, 40);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(80, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Ange pris:";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(48, 122);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(104, 20);
            this.lblPaid.TabIndex = 5;
            this.lblPaid.Text = "Ange betalat:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(48, 207);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(105, 20);
            this.lblChange.TabIndex = 6;
            this.lblChange.Text = "Växel tillbaka:";
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.BackColor = System.Drawing.Color.Brown;
            this.btnExitProgram.Location = new System.Drawing.Point(646, 12);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(142, 43);
            this.btnExitProgram.TabIndex = 7;
            this.btnExitProgram.Text = "Stäng program";
            this.btnExitProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExitProgram.UseVisualStyleBackColor = false;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitProgram);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbPaid);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbPaid;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btnExitProgram;
    }
}

