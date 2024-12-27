namespace ProductionOrderManagement
{
    partial class frmOrderPosition
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.номерпозициизаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркасталиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.диаметрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стенкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объемпозицииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пОЗИЦИИBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionOrderManagementDataSet = new ProductionOrderManagement.ProductionOrderManagementDataSet();
            this.пОЗИЦИИTableAdapter = new ProductionOrderManagement.ProductionOrderManagementDataSetTableAdapters.ПОЗИЦИИTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пОЗИЦИИBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionOrderManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(257, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 29);
            this.textBox1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Марка стали",
            "Диаметр",
            "Стенка"});
            this.comboBox1.Location = new System.Drawing.Point(1, 364);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 29);
            this.comboBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(914, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Возврат на Главное меню";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-3, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(834, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выберите из списка столбец для поиска, введите значение в текстовое поле и нажмит" +
    "е кнопку Поиск:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1138, 325);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные позиций заказов";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(828, 272);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 47);
            this.button5.TabIndex = 7;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(998, 272);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 47);
            this.button6.TabIndex = 8;
            this.button6.Text = "Снять фильтр";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерпозициизаказаDataGridViewTextBoxColumn,
            this.номерзаказаDataGridViewTextBoxColumn,
            this.маркасталиDataGridViewTextBoxColumn,
            this.диаметрDataGridViewTextBoxColumn,
            this.стенкаDataGridViewTextBoxColumn,
            this.объемпозицииDataGridViewTextBoxColumn,
            this.единицаизмеренияDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.пОЗИЦИИBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 238);
            this.dataGridView1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Image = global::ProductionOrderManagement.Properties.Resources.Удаление_записи;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(361, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 47);
            this.button4.TabIndex = 2;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Image = global::ProductionOrderManagement.Properties.Resources.Редактирование_записи;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(163, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 47);
            this.button3.TabIndex = 1;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Image = global::ProductionOrderManagement.Properties.Resources.Добавление_записи;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(6, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 47);
            this.button2.TabIndex = 0;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // номерпозициизаказаDataGridViewTextBoxColumn
            // 
            this.номерпозициизаказаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.номерпозициизаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер_позиции_заказа";
            this.номерпозициизаказаDataGridViewTextBoxColumn.HeaderText = "Номер позиции заказа";
            this.номерпозициизаказаDataGridViewTextBoxColumn.Name = "номерпозициизаказаDataGridViewTextBoxColumn";
            this.номерпозициизаказаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерпозициизаказаDataGridViewTextBoxColumn.Width = 196;
            // 
            // номерзаказаDataGridViewTextBoxColumn
            // 
            this.номерзаказаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.номерзаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер_заказа";
            this.номерзаказаDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.номерзаказаDataGridViewTextBoxColumn.Name = "номерзаказаDataGridViewTextBoxColumn";
            this.номерзаказаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерзаказаDataGridViewTextBoxColumn.Width = 130;
            // 
            // маркасталиDataGridViewTextBoxColumn
            // 
            this.маркасталиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.маркасталиDataGridViewTextBoxColumn.DataPropertyName = "Марка_стали";
            this.маркасталиDataGridViewTextBoxColumn.HeaderText = "Марка стали";
            this.маркасталиDataGridViewTextBoxColumn.Name = "маркасталиDataGridViewTextBoxColumn";
            this.маркасталиDataGridViewTextBoxColumn.ReadOnly = true;
            this.маркасталиDataGridViewTextBoxColumn.Width = 124;
            // 
            // диаметрDataGridViewTextBoxColumn
            // 
            this.диаметрDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.диаметрDataGridViewTextBoxColumn.DataPropertyName = "Диаметр";
            this.диаметрDataGridViewTextBoxColumn.HeaderText = "Диаметр";
            this.диаметрDataGridViewTextBoxColumn.Name = "диаметрDataGridViewTextBoxColumn";
            this.диаметрDataGridViewTextBoxColumn.ReadOnly = true;
            this.диаметрDataGridViewTextBoxColumn.Width = 104;
            // 
            // стенкаDataGridViewTextBoxColumn
            // 
            this.стенкаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.стенкаDataGridViewTextBoxColumn.DataPropertyName = "Стенка";
            this.стенкаDataGridViewTextBoxColumn.HeaderText = "Стенка";
            this.стенкаDataGridViewTextBoxColumn.Name = "стенкаDataGridViewTextBoxColumn";
            this.стенкаDataGridViewTextBoxColumn.ReadOnly = true;
            this.стенкаDataGridViewTextBoxColumn.Width = 91;
            // 
            // объемпозицииDataGridViewTextBoxColumn
            // 
            this.объемпозицииDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.объемпозицииDataGridViewTextBoxColumn.DataPropertyName = "Объем_позиции";
            this.объемпозицииDataGridViewTextBoxColumn.HeaderText = "Объем позиции";
            this.объемпозицииDataGridViewTextBoxColumn.Name = "объемпозицииDataGridViewTextBoxColumn";
            this.объемпозицииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // единицаизмеренияDataGridViewTextBoxColumn
            // 
            this.единицаизмеренияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.единицаизмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единица_измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.Name = "единицаизмеренияDataGridViewTextBoxColumn";
            this.единицаизмеренияDataGridViewTextBoxColumn.ReadOnly = true;
            this.единицаизмеренияDataGridViewTextBoxColumn.Width = 177;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.ReadOnly = true;
            this.статусDataGridViewTextBoxColumn.Width = 90;
            // 
            // пОЗИЦИИBindingSource
            // 
            this.пОЗИЦИИBindingSource.DataMember = "ПОЗИЦИИ";
            this.пОЗИЦИИBindingSource.DataSource = this.productionOrderManagementDataSet;
            // 
            // productionOrderManagementDataSet
            // 
            this.productionOrderManagementDataSet.DataSetName = "ProductionOrderManagementDataSet";
            this.productionOrderManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пОЗИЦИИTableAdapter
            // 
            this.пОЗИЦИИTableAdapter.ClearBeforeFill = true;
            // 
            // frmOrderPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1142, 413);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOrderPosition";
            this.Text = "Позиции заказов";
            this.Load += new System.EventHandler(this.frmOrderPosition_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пОЗИЦИИBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionOrderManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private ProductionOrderManagementDataSet productionOrderManagementDataSet;
        private System.Windows.Forms.BindingSource пОЗИЦИИBindingSource;
        private ProductionOrderManagementDataSetTableAdapters.ПОЗИЦИИTableAdapter пОЗИЦИИTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпозициизаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркасталиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn диаметрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стенкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объемпозицииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
    }
}