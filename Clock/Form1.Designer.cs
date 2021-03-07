
namespace Clock
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.компьютерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сейчасToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.минутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.минутToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.минутToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.минутToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.минутToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.минутToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.минутToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.минутToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.минутToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.минутToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.перезагрузкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сейчасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.минутToolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.минутToolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.минутToolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.минутToolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "___.___.______";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "00:00:00";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компьютерToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(232, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // компьютерToolStripMenuItem
            // 
            this.компьютерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выключениеToolStripMenuItem,
            this.перезагрузкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.компьютерToolStripMenuItem.Name = "компьютерToolStripMenuItem";
            this.компьютерToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.компьютерToolStripMenuItem.Text = "Управление";
            // 
            // выключениеToolStripMenuItem
            // 
            this.выключениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сейчасToolStripMenuItem2,
            this.минутToolStripMenuItem,
            this.минутToolStripMenuItem1,
            this.минутToolStripMenuItem2,
            this.минутToolStripMenuItem3,
            this.минутToolStripMenuItem4,
            this.минутToolStripMenuItem5,
            this.минутToolStripMenuItem6,
            this.минутToolStripMenuItem7,
            this.минутToolStripMenuItem8,
            this.минутToolStripMenuItem9});
            this.выключениеToolStripMenuItem.Name = "выключениеToolStripMenuItem";
            this.выключениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выключениеToolStripMenuItem.Text = "Выключение";
            // 
            // сейчасToolStripMenuItem2
            // 
            this.сейчасToolStripMenuItem2.Name = "сейчасToolStripMenuItem2";
            this.сейчасToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.сейчасToolStripMenuItem2.Text = "Сейчас";
            // 
            // минутToolStripMenuItem
            // 
            this.минутToolStripMenuItem.Name = "минутToolStripMenuItem";
            this.минутToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.минутToolStripMenuItem.Text = "30 минут";
            this.минутToolStripMenuItem.Click += new System.EventHandler(this.минутToolStripMenuItem_Click);
            // 
            // минутToolStripMenuItem1
            // 
            this.минутToolStripMenuItem1.Name = "минутToolStripMenuItem1";
            this.минутToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.минутToolStripMenuItem1.Text = "60 минут";
            // 
            // минутToolStripMenuItem2
            // 
            this.минутToolStripMenuItem2.Name = "минутToolStripMenuItem2";
            this.минутToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.минутToolStripMenuItem2.Text = "90 минут";
            // 
            // минутToolStripMenuItem3
            // 
            this.минутToolStripMenuItem3.Name = "минутToolStripMenuItem3";
            this.минутToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.минутToolStripMenuItem3.Text = "120 минут";
            // 
            // минутToolStripMenuItem4
            // 
            this.минутToolStripMenuItem4.Name = "минутToolStripMenuItem4";
            this.минутToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.минутToolStripMenuItem4.Text = "150 минут";
            // 
            // минутToolStripMenuItem5
            // 
            this.минутToolStripMenuItem5.Name = "минутToolStripMenuItem5";
            this.минутToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.минутToolStripMenuItem5.Text = "180 минут";
            // 
            // минутToolStripMenuItem6
            // 
            this.минутToolStripMenuItem6.Name = "минутToolStripMenuItem6";
            this.минутToolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.минутToolStripMenuItem6.Text = "210 минут";
            // 
            // минутToolStripMenuItem7
            // 
            this.минутToolStripMenuItem7.Name = "минутToolStripMenuItem7";
            this.минутToolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.минутToolStripMenuItem7.Text = "240 минут";
            // 
            // минутToolStripMenuItem8
            // 
            this.минутToolStripMenuItem8.Name = "минутToolStripMenuItem8";
            this.минутToolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
            this.минутToolStripMenuItem8.Text = "270 минут";
            // 
            // минутToolStripMenuItem9
            // 
            this.минутToolStripMenuItem9.Name = "минутToolStripMenuItem9";
            this.минутToolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
            this.минутToolStripMenuItem9.Text = "300 минут";
            // 
            // перезагрузкаToolStripMenuItem
            // 
            this.перезагрузкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сейчасToolStripMenuItem,
            this.минутToolStripMenuItem14,
            this.минутToolStripMenuItem15,
            this.минутToolStripMenuItem16,
            this.минутToolStripMenuItem17});
            this.перезагрузкаToolStripMenuItem.Name = "перезагрузкаToolStripMenuItem";
            this.перезагрузкаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.перезагрузкаToolStripMenuItem.Text = "Перезагрузка";
            // 
            // сейчасToolStripMenuItem
            // 
            this.сейчасToolStripMenuItem.Name = "сейчасToolStripMenuItem";
            this.сейчасToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сейчасToolStripMenuItem.Text = "Сейчас";
            this.сейчасToolStripMenuItem.Click += new System.EventHandler(this.сейчасToolStripMenuItem_Click);
            // 
            // минутToolStripMenuItem14
            // 
            this.минутToolStripMenuItem14.Name = "минутToolStripMenuItem14";
            this.минутToolStripMenuItem14.Size = new System.Drawing.Size(180, 22);
            this.минутToolStripMenuItem14.Text = "30 минут";
            // 
            // минутToolStripMenuItem15
            // 
            this.минутToolStripMenuItem15.Name = "минутToolStripMenuItem15";
            this.минутToolStripMenuItem15.Size = new System.Drawing.Size(180, 22);
            this.минутToolStripMenuItem15.Text = "60 минут";
            // 
            // минутToolStripMenuItem16
            // 
            this.минутToolStripMenuItem16.Name = "минутToolStripMenuItem16";
            this.минутToolStripMenuItem16.Size = new System.Drawing.Size(180, 22);
            this.минутToolStripMenuItem16.Text = "90 минут";
            // 
            // минутToolStripMenuItem17
            // 
            this.минутToolStripMenuItem17.Name = "минутToolStripMenuItem17";
            this.минутToolStripMenuItem17.Size = new System.Drawing.Size(180, 22);
            this.минутToolStripMenuItem17.Text = "120 минут";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 150);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem компьютерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перезагрузкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem минутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem минутToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem минутToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem минутToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem минутToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem минутToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem минутToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem минутToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem минутToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem минутToolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem сейчасToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem минутToolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem минутToolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem минутToolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem минутToolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сейчасToolStripMenuItem2;
    }
}

