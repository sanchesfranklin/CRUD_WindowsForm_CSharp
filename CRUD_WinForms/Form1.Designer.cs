
namespace CRUD_WinForms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nomeProduto = new System.Windows.Forms.TextBox();
            this.corProduto = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataVencimento = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.idProduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD C# e SQL Server - Produtos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(166, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Produto *";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(166, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Item *";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(166, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cor *";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(166, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Situação";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(166, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data Vencimento";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nomeProduto
            // 
            this.nomeProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeProduto.Location = new System.Drawing.Point(330, 125);
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.Size = new System.Drawing.Size(235, 29);
            this.nomeProduto.TabIndex = 7;
            this.nomeProduto.TextChanged += new System.EventHandler(this.nomeProduto_TextChanged);
            // 
            // corProduto
            // 
            this.corProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.corProduto.FormattingEnabled = true;
            this.corProduto.Items.AddRange(new object[] {
            "Preto",
            "Branco",
            "Prata",
            "Vermelho"});
            this.corProduto.Location = new System.Drawing.Point(330, 180);
            this.corProduto.Name = "corProduto";
            this.corProduto.Size = new System.Drawing.Size(235, 29);
            this.corProduto.TabIndex = 11;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(346, 231);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 25);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ativado";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(449, 231);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 25);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Desativado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataVencimento
            // 
            this.dataVencimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataVencimento.Location = new System.Drawing.Point(330, 284);
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.Size = new System.Drawing.Size(235, 29);
            this.dataVencimento.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(256, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(142, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(566, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(390, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 29);
            this.button2.TabIndex = 17;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(522, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 29);
            this.button3.TabIndex = 18;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(594, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 29);
            this.button4.TabIndex = 19;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // idProduto
            // 
            this.idProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idProduto.Location = new System.Drawing.Point(330, 77);
            this.idProduto.Name = "idProduto";
            this.idProduto.Size = new System.Drawing.Size(235, 29);
            this.idProduto.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(794, 524);
            this.Controls.Add(this.idProduto);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataVencimento);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.corProduto);
            this.Controls.Add(this.nomeProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nomeProduto;
        private System.Windows.Forms.ComboBox corProduto;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker dataVencimento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox idProduto;
    }
}

