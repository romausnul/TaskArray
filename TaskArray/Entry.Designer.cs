namespace TaskArray
{
    partial class frmEntry
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.lblArray = new System.Windows.Forms.Label();
            this.gridArray = new System.Windows.Forms.DataGridView();
            this.editLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridResult = new System.Windows.Forms.DataGridView();
            this.editResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArray)).BeginInit();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editNumber);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.chkRandom);
            this.groupBox1.Controls.Add(this.btnDefault);
            this.groupBox1.Controls.Add(this.btnInit);
            this.groupBox1.Controls.Add(this.lblArray);
            this.groupBox1.Controls.Add(this.gridArray);
            this.groupBox1.Controls.Add(this.editLength);
            this.groupBox1.Controls.Add(this.lblLength);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 212);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // editNumber
            // 
            this.editNumber.Location = new System.Drawing.Point(618, 89);
            this.editNumber.Name = "editNumber";
            this.editNumber.Size = new System.Drawing.Size(220, 30);
            this.editNumber.TabIndex = 12;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(614, 66);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(281, 25);
            this.lblNumber.TabIndex = 11;
            this.lblNumber.Text = "Число (при необходимости):";
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Location = new System.Drawing.Point(192, 25);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(559, 29);
            this.chkRandom.TabIndex = 10;
            this.chkRandom.Text = "Сгенерировать произвольные числа при инициализации";
            this.chkRandom.UseVisualStyleBackColor = true;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(333, 63);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(196, 26);
            this.btnDefault.TabIndex = 9;
            this.btnDefault.Text = "Тестовые данные";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(192, 63);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(135, 26);
            this.btnInit.TabIndex = 8;
            this.btnInit.Text = "Инициализация";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(26, 105);
            this.lblArray.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(85, 25);
            this.lblArray.TabIndex = 7;
            this.lblArray.Text = "Массив:";
            // 
            // gridArray
            // 
            this.gridArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArray.Location = new System.Drawing.Point(31, 134);
            this.gridArray.Name = "gridArray";
            this.gridArray.RowHeadersWidth = 51;
            this.gridArray.Size = new System.Drawing.Size(808, 78);
            this.gridArray.TabIndex = 6;
            // 
            // editLength
            // 
            this.editLength.Location = new System.Drawing.Point(30, 63);
            this.editLength.Name = "editLength";
            this.editLength.Size = new System.Drawing.Size(143, 30);
            this.editLength.TabIndex = 5;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(26, 40);
            this.lblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(192, 25);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Кол-во элементов:";
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.label1);
            this.gbResult.Controls.Add(this.gridResult);
            this.gbResult.Controls.Add(this.editResult);
            this.gbResult.Controls.Add(this.lblResult);
            this.gbResult.Location = new System.Drawing.Point(12, 230);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(856, 212);
            this.gbResult.TabIndex = 5;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Исходные данные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Итоговый массив (если есть в задаче):";
            // 
            // gridResult
            // 
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResult.Location = new System.Drawing.Point(30, 180);
            this.gridResult.Name = "gridResult";
            this.gridResult.RowHeadersWidth = 51;
            this.gridResult.Size = new System.Drawing.Size(808, 64);
            this.gridResult.TabIndex = 6;
            this.gridResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResult_CellContentClick);
            // 
            // editResult
            // 
            this.editResult.Location = new System.Drawing.Point(30, 103);
            this.editResult.Name = "editResult";
            this.editResult.Size = new System.Drawing.Size(143, 30);
            this.editResult.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(25, 55);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(362, 25);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Итоговое число (если есть в задаче):";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 576);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(856, 31);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистить все";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 671);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "МАМОН 2Г";
            this.Load += new System.EventHandler(this.FrmEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArray)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.DataGridView gridArray;
        private System.Windows.Forms.TextBox editLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridResult;
        private System.Windows.Forms.TextBox editResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.CheckBox chkRandom;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox editNumber;
        private System.Windows.Forms.Label lblNumber;
    }
}

