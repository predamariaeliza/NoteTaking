namespace NoteTaking
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
            this.labelTitlu = new System.Windows.Forms.Label();
            this.labelMesaj = new System.Windows.Forms.Label();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bttNew = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttRead = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Location = new System.Drawing.Point(51, 39);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(35, 17);
            this.labelTitlu.TabIndex = 0;
            this.labelTitlu.Text = "Titlu";
            this.labelTitlu.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMesaj
            // 
            this.labelMesaj.AutoSize = true;
            this.labelMesaj.Location = new System.Drawing.Point(51, 134);
            this.labelMesaj.Name = "labelMesaj";
            this.labelMesaj.Size = new System.Drawing.Size(45, 17);
            this.labelMesaj.TabIndex = 1;
            this.labelMesaj.Text = "Mesaj";
            // 
            // txtTitlu
            // 
            this.txtTitlu.Location = new System.Drawing.Point(54, 80);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(244, 22);
            this.txtTitlu.TabIndex = 2;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(54, 181);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(244, 190);
            this.txtMesaj.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 283);
            this.dataGridView1.TabIndex = 4;
            // 
            // bttNew
            // 
            this.bttNew.Location = new System.Drawing.Point(54, 414);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(75, 23);
            this.bttNew.TabIndex = 5;
            this.bttNew.Text = "New";
            this.bttNew.UseVisualStyleBackColor = true;
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(223, 414);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 6;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttRead
            // 
            this.bttRead.Location = new System.Drawing.Point(400, 414);
            this.bttRead.Name = "bttRead";
            this.bttRead.Size = new System.Drawing.Size(75, 23);
            this.bttRead.TabIndex = 7;
            this.bttRead.Text = "Read";
            this.bttRead.UseVisualStyleBackColor = true;
            this.bttRead.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(565, 414);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 8;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 485);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttRead);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.bttNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.labelMesaj);
            this.Controls.Add(this.labelTitlu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label labelMesaj;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button bttRead;
        private System.Windows.Forms.Button bttDelete;
    }
}

