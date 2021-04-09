
namespace KarnOMap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.variables = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.tabl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabl)).BeginInit();
            this.SuspendLayout();
            // 
            // variables
            // 
            this.variables.FormattingEnabled = true;
            this.variables.Location = new System.Drawing.Point(181, 14);
            this.variables.Name = "variables";
            this.variables.Size = new System.Drawing.Size(36, 21);
            this.variables.TabIndex = 0;
            this.variables.Text = "3";
            this.variables.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.variables_KeyPress);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(223, 12);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(304, 12);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 23);
            this.calc.TabIndex = 1;
            this.calc.Text = "Обчислити";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // tabl
            // 
            this.tabl.AllowUserToAddRows = false;
            this.tabl.AllowUserToDeleteRows = false;
            this.tabl.AllowUserToResizeColumns = false;
            this.tabl.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(215)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.tabl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tabl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(240)))));
            this.tabl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.tabl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(205)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tabl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabl.DefaultCellStyle = dataGridViewCellStyle7;
            this.tabl.EnableHeadersVisualStyles = false;
            this.tabl.Location = new System.Drawing.Point(12, 41);
            this.tabl.Name = "tabl";
            this.tabl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabl.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tabl.RowHeadersVisible = false;
            this.tabl.Size = new System.Drawing.Size(565, 468);
            this.tabl.TabIndex = 4;
            this.tabl.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.tabl_EditingControlShowing);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 521);
            this.Controls.Add(this.tabl);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.variables);
            this.Name = "Form1";
            this.Text = "Karno map";
            ((System.ComponentModel.ISupportInitialize)(this.tabl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox variables;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.DataGridView tabl;
    }
}

