
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCM = new System.Windows.Forms.TextBox();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.txtlnfo = new System.Windows.Forms.TextBox();
            this.txtYard = new System.Windows.Forms.TextBox();
            this.txtFt = new System.Windows.Forms.TextBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "公分";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCM
            // 
            this.txtCM.Location = new System.Drawing.Point(21, 35);
            this.txtCM.Name = "txtCM";
            this.txtCM.Size = new System.Drawing.Size(179, 22);
            this.txtCM.TabIndex = 1;
            this.txtCM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCM_KeyUp);
            // 
            // btnAllClear
            // 
            this.btnAllClear.Location = new System.Drawing.Point(374, 45);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(86, 45);
            this.btnAllClear.TabIndex = 2;
            this.btnAllClear.Text = "清除";
            this.btnAllClear.UseVisualStyleBackColor = true;
            // 
            // txtlnfo
            // 
            this.txtlnfo.Location = new System.Drawing.Point(21, 380);
            this.txtlnfo.Name = "txtlnfo";
            this.txtlnfo.Size = new System.Drawing.Size(179, 22);
            this.txtlnfo.TabIndex = 5;
            // 
            // txtYard
            // 
            this.txtYard.Location = new System.Drawing.Point(21, 322);
            this.txtYard.Name = "txtYard";
            this.txtYard.Size = new System.Drawing.Size(179, 22);
            this.txtYard.TabIndex = 6;
            // 
            // txtFt
            // 
            this.txtFt.Location = new System.Drawing.Point(21, 261);
            this.txtFt.Name = "txtFt";
            this.txtFt.Size = new System.Drawing.Size(179, 22);
            this.txtFt.TabIndex = 7;
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(21, 204);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(179, 22);
            this.txtIn.TabIndex = 8;
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(21, 145);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(179, 22);
            this.txtKM.TabIndex = 9;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(21, 89);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(179, 22);
            this.txtM.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "說明文字";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "英碼";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "英呎";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "英吋";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "公里";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "公尺";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.txtFt);
            this.Controls.Add(this.txtYard);
            this.Controls.Add(this.txtlnfo);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.txtCM);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCM;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.TextBox txtlnfo;
        private System.Windows.Forms.TextBox txtYard;
        private System.Windows.Forms.TextBox txtFt;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

