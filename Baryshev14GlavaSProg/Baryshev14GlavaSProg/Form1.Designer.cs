
namespace Baryshev14GlavaSProg
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
            this.cboCulture = new System.Windows.Forms.ComboBox();
            this.lstMonth = new System.Windows.Forms.ListBox();
            this.lstWeek = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCulture
            // 
            this.cboCulture.FormattingEnabled = true;
            this.cboCulture.Location = new System.Drawing.Point(34, 22);
            this.cboCulture.Name = "cboCulture";
            this.cboCulture.Size = new System.Drawing.Size(121, 21);
            this.cboCulture.TabIndex = 0;
            this.cboCulture.SelectedIndexChanged += new System.EventHandler(this.cboCulture_SelectedIndexChanged);
            // 
            // lstMonth
            // 
            this.lstMonth.FormattingEnabled = true;
            this.lstMonth.Location = new System.Drawing.Point(34, 79);
            this.lstMonth.Name = "lstMonth";
            this.lstMonth.Size = new System.Drawing.Size(131, 290);
            this.lstMonth.TabIndex = 1;
            this.lstMonth.SelectedIndexChanged += new System.EventHandler(this.lstMonth_SelectedIndexChanged);
            // 
            // lstWeek
            // 
            this.lstWeek.FormattingEnabled = true;
            this.lstWeek.Location = new System.Drawing.Point(271, 79);
            this.lstWeek.Name = "lstWeek";
            this.lstWeek.Size = new System.Drawing.Size(131, 290);
            this.lstWeek.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "nextForm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstWeek);
            this.Controls.Add(this.lstMonth);
            this.Controls.Add(this.cboCulture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCulture;
        private System.Windows.Forms.ListBox lstMonth;
        private System.Windows.Forms.ListBox lstWeek;
        private System.Windows.Forms.Button button1;
    }
}

