
namespace Winform
{
    partial class FormTugas
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
            this.Tombolproses = new System.Windows.Forms.Button();
            this.LabelKosong = new System.Windows.Forms.Label();
            this.BoxInput = new System.Windows.Forms.TextBox();
            this.InputData = new System.Windows.Forms.Label();
            this.Attention = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tombolproses
            // 
            this.Tombolproses.Location = new System.Drawing.Point(12, 170);
            this.Tombolproses.Name = "Tombolproses";
            this.Tombolproses.Size = new System.Drawing.Size(94, 29);
            this.Tombolproses.TabIndex = 0;
            this.Tombolproses.Text = "Proses";
            this.Tombolproses.UseVisualStyleBackColor = true;
            this.Tombolproses.Click += new System.EventHandler(this.Tombolproses_Click);
            // 
            // LabelKosong
            // 
            this.LabelKosong.AutoSize = true;
            this.LabelKosong.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelKosong.Location = new System.Drawing.Point(12, 219);
            this.LabelKosong.Name = "LabelKosong";
            this.LabelKosong.Size = new System.Drawing.Size(277, 81);
            this.LabelKosong.TabIndex = 1;
            this.LabelKosong.Text = "[EMPTY]";
            this.LabelKosong.Click += new System.EventHandler(this.LabelKosong_Click);
            // 
            // BoxInput
            // 
            this.BoxInput.Location = new System.Drawing.Point(12, 121);
            this.BoxInput.Name = "BoxInput";
            this.BoxInput.Size = new System.Drawing.Size(688, 27);
            this.BoxInput.TabIndex = 2;
            this.BoxInput.TextChanged += new System.EventHandler(this.BoxInput_TextChanged);
            // 
            // InputData
            // 
            this.InputData.AutoSize = true;
            this.InputData.Location = new System.Drawing.Point(13, 90);
            this.InputData.Name = "InputData";
            this.InputData.Size = new System.Drawing.Size(86, 20);
            this.InputData.TabIndex = 3;
            this.InputData.Text = "Input Data :";
            // 
            // Attention
            // 
            this.Attention.AutoSize = true;
            this.Attention.Location = new System.Drawing.Point(12, 52);
            this.Attention.Name = "Attention";
            this.Attention.Size = new System.Drawing.Size(326, 20);
            this.Attention.TabIndex = 4;
            this.Attention.Text = "Harap Tulis Menggunakan Huruf Kecil Semua :D";
            // 
            // FormTugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 441);
            this.Controls.Add(this.Attention);
            this.Controls.Add(this.InputData);
            this.Controls.Add(this.BoxInput);
            this.Controls.Add(this.LabelKosong);
            this.Controls.Add(this.Tombolproses);
            this.Name = "FormTugas";
            this.Text = "Form Tugas :D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tombolproses;
        private System.Windows.Forms.Label LabelKosong;
        private System.Windows.Forms.TextBox BoxInput;
        private System.Windows.Forms.Label InputData;
        private System.Windows.Forms.Label Attention;
    }
}

