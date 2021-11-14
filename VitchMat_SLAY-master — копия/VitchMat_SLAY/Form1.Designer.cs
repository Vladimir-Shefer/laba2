
namespace VitchMat_SLAY
{
    partial class Form1
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
            this.t_raz = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.darkButton3 = new DarkUI.Controls.DarkButton();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkTextBox1 = new DarkUI.Controls.DarkTextBox();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.darkTextBox2 = new DarkUI.Controls.DarkTextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.darkLabel5 = new DarkUI.Controls.DarkLabel();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.darkTextBox3 = new DarkUI.Controls.DarkTextBox();
            this.darkTextBox4 = new DarkUI.Controls.DarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // t_raz
            // 
            this.t_raz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.t_raz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_raz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.t_raz.Location = new System.Drawing.Point(127, 42);
            this.t_raz.Margin = new System.Windows.Forms.Padding(4);
            this.t_raz.Name = "t_raz";
            this.t_raz.Size = new System.Drawing.Size(67, 22);
            this.t_raz.TabIndex = 0;
            this.t_raz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_raz_KeyPress);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(15, 44);
            this.darkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(98, 17);
            this.darkLabel1.TabIndex = 1;
            this.darkLabel1.Text = "Размерность:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(19, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(280, 280);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(445, 38);
            this.darkButton1.Margin = new System.Windows.Forms.Padding(4);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.darkButton1.Size = new System.Drawing.Size(125, 28);
            this.darkButton1.TabIndex = 50;
            this.darkButton1.Text = "Создать СЛАУ";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(513, 110);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(280, 91);
            this.dataGridView2.TabIndex = 51;
            // 
            // darkButton3
            // 
            this.darkButton3.Location = new System.Drawing.Point(339, 178);
            this.darkButton3.Margin = new System.Windows.Forms.Padding(4);
            this.darkButton3.Name = "darkButton3";
            this.darkButton3.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.darkButton3.Size = new System.Drawing.Size(143, 129);
            this.darkButton3.TabIndex = 53;
            this.darkButton3.Text = "Вычислить степенным методом";
            this.darkButton3.Click += new System.EventHandler(this.darkButton3_Click);
            // 
            // darkLabel2
            // 
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(569, 86);
            this.darkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(188, 22);
            this.darkLabel2.TabIndex = 54;
            this.darkLabel2.Text = "Первое приближение";
            this.darkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkTextBox1
            // 
            this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox1.Location = new System.Drawing.Point(219, 435);
            this.darkTextBox1.Name = "darkTextBox1";
            this.darkTextBox1.Size = new System.Drawing.Size(97, 22);
            this.darkTextBox1.TabIndex = 55;
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(19, 435);
            this.darkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(157, 17);
            this.darkLabel3.TabIndex = 56;
            this.darkLabel3.Text = "Количество итераций:";
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(226, 45);
            this.darkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(99, 17);
            this.darkLabel4.TabIndex = 58;
            this.darkLabel4.Text = "Погрешность:";
            // 
            // darkTextBox2
            // 
            this.darkTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox2.Location = new System.Drawing.Point(351, 42);
            this.darkTextBox2.Name = "darkTextBox2";
            this.darkTextBox2.Size = new System.Drawing.Size(64, 22);
            this.darkTextBox2.TabIndex = 57;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Location = new System.Drawing.Point(513, 361);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(280, 91);
            this.dataGridView3.TabIndex = 59;
            // 
            // darkLabel5
            // 
            this.darkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel5.Location = new System.Drawing.Point(569, 328);
            this.darkLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.darkLabel5.Name = "darkLabel5";
            this.darkLabel5.Size = new System.Drawing.Size(188, 22);
            this.darkLabel5.TabIndex = 61;
            this.darkLabel5.Text = "Собственные векторы";
            this.darkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkLabel6
            // 
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(569, 217);
            this.darkLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(188, 22);
            this.darkLabel6.TabIndex = 62;
            this.darkLabel6.Text = "Собственные числа";
            this.darkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkTextBox3
            // 
            this.darkTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox3.Location = new System.Drawing.Point(513, 265);
            this.darkTextBox3.Name = "darkTextBox3";
            this.darkTextBox3.Size = new System.Drawing.Size(97, 22);
            this.darkTextBox3.TabIndex = 63;
            // 
            // darkTextBox4
            // 
            this.darkTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox4.Location = new System.Drawing.Point(696, 265);
            this.darkTextBox4.Name = "darkTextBox4";
            this.darkTextBox4.Size = new System.Drawing.Size(97, 22);
            this.darkTextBox4.TabIndex = 64;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 481);
            this.Controls.Add(this.darkTextBox4);
            this.Controls.Add(this.darkTextBox3);
            this.Controls.Add(this.darkLabel6);
            this.Controls.Add(this.darkLabel5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.darkLabel4);
            this.Controls.Add(this.darkTextBox2);
            this.Controls.Add(this.darkLabel3);
            this.Controls.Add(this.darkTextBox1);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.darkButton3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.t_raz);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Вычисление собственных чисел и собственных векторов матриц степенным методом";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkTextBox t_raz;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DarkUI.Controls.DarkButton darkButton1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DarkUI.Controls.DarkButton darkButton3;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkTextBox darkTextBox1;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkTextBox darkTextBox2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private DarkUI.Controls.DarkLabel darkLabel5;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private DarkUI.Controls.DarkTextBox darkTextBox3;
        private DarkUI.Controls.DarkTextBox darkTextBox4;
    }
}

