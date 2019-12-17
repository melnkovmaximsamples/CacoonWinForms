namespace Cacoon
{
    partial class Cacoon
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tMethod = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bGo = new System.Windows.Forms.Button();
            this.SumCurr = new System.Windows.Forms.RichTextBox();
            this.SumTotal = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Efficiency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tMethod)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tMethod
            // 
            this.tMethod.AllowUserToAddRows = false;
            this.tMethod.AllowUserToDeleteRows = false;
            this.tMethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tMethod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Method,
            this.Column5,
            this.Chance,
            this.Efficiency,
            this.Column4,
            this.Column6});
            this.tMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.tMethod.Location = new System.Drawing.Point(0, 0);
            this.tMethod.Name = "tMethod";
            this.tMethod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tMethod.Size = new System.Drawing.Size(484, 174);
            this.tMethod.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bGo);
            this.panel1.Controls.Add(this.tMethod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 237);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Location = new System.Drawing.Point(12, 191);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bGo
            // 
            this.bGo.Dock = System.Windows.Forms.DockStyle.Right;
            this.bGo.Location = new System.Drawing.Point(321, 174);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(163, 63);
            this.bGo.TabIndex = 4;
            this.bGo.Text = "Рассчитать";
            this.bGo.UseVisualStyleBackColor = true;
            this.bGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // SumCurr
            // 
            this.SumCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumCurr.Location = new System.Drawing.Point(3, 25);
            this.SumCurr.Name = "SumCurr";
            this.SumCurr.Size = new System.Drawing.Size(191, 39);
            this.SumCurr.TabIndex = 4;
            this.SumCurr.Text = "";
            this.SumCurr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sum_KeyPress);
            // 
            // SumTotal
            // 
            this.SumTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumTotal.Location = new System.Drawing.Point(3, 25);
            this.SumTotal.Name = "SumTotal";
            this.SumTotal.Size = new System.Drawing.Size(191, 39);
            this.SumTotal.TabIndex = 5;
            this.SumTotal.Text = "";
            this.SumTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Общая сумма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сумма ставки";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SumCurr);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(284, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 74);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SumTotal);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 74);
            this.panel3.TabIndex = 9;
            // 
            // Method
            // 
            this.Method.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Method.HeaderText = "Метод";
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Коэффициент";
            this.Column5.Name = "Column5";
            // 
            // Chance
            // 
            this.Chance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Chance.HeaderText = "Шанс";
            this.Chance.Name = "Chance";
            this.Chance.ReadOnly = true;
            this.Chance.Width = 59;
            // 
            // Efficiency
            // 
            this.Efficiency.HeaderText = "Эффективность при n ставках";
            this.Efficiency.Name = "Efficiency";
            this.Efficiency.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "П/п";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Инфо";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Cacoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Cacoon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cacoon";
            ((System.ComponentModel.ISupportInitialize)(this.tMethod)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tMethod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox SumCurr;
        private System.Windows.Forms.Button bGo;
        private System.Windows.Forms.RichTextBox SumTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Efficiency;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

