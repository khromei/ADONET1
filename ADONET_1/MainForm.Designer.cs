namespace ADONET_1
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Fill = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_ExportXML = new System.Windows.Forms.Button();
            this.button_ImportXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_Fill
            // 
            this.button_Fill.Location = new System.Drawing.Point(532, 28);
            this.button_Fill.Name = "button_Fill";
            this.button_Fill.Size = new System.Drawing.Size(110, 23);
            this.button_Fill.TabIndex = 1;
            this.button_Fill.Text = "Fill";
            this.button_Fill.UseVisualStyleBackColor = true;
            this.button_Fill.Click += new System.EventHandler(this.button_Fill_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(532, 57);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(110, 23);
            this.button_Update.TabIndex = 2;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_ExportXML
            // 
            this.button_ExportXML.Location = new System.Drawing.Point(532, 86);
            this.button_ExportXML.Name = "button_ExportXML";
            this.button_ExportXML.Size = new System.Drawing.Size(110, 23);
            this.button_ExportXML.TabIndex = 3;
            this.button_ExportXML.Text = "ExportXML";
            this.button_ExportXML.UseVisualStyleBackColor = true;
            this.button_ExportXML.Click += new System.EventHandler(this.button_EX_Click);
            // 
            // button_ImportXML
            // 
            this.button_ImportXML.Location = new System.Drawing.Point(532, 115);
            this.button_ImportXML.Name = "button_ImportXML";
            this.button_ImportXML.Size = new System.Drawing.Size(110, 23);
            this.button_ImportXML.TabIndex = 4;
            this.button_ImportXML.Text = "importXML";
            this.button_ImportXML.UseVisualStyleBackColor = true;
            this.button_ImportXML.Click += new System.EventHandler(this.button_IM_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 352);
            this.Controls.Add(this.button_ImportXML);
            this.Controls.Add(this.button_ExportXML);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Fill);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Fill;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_ExportXML;
        private System.Windows.Forms.Button button_ImportXML;
    }
}

