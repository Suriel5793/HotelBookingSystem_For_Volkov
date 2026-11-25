namespace Diplom.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem модельMmcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчётПоказателейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеНомерамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бронированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеБронированиямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аналитикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прогнозыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рекомендацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem внешниеФакторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеФакторамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеПользователямиToolStripMenuItem;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.модельMmcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчётПоказателейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеНомерамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бронированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеБронированиямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналитикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прогнозыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рекомендацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.внешниеФакторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеФакторамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеПользователямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(245, 222, 179);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.модельMmcToolStripMenuItem, this.номераToolStripMenuItem, this.бронированияToolStripMenuItem,
                this.аналитикаToolStripMenuItem, this.прогнозыToolStripMenuItem, this.внешниеФакторыToolStripMenuItem,
                this.справкаToolStripMenuItem, this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);

            this.модельMmcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.расчётПоказателейToolStripMenuItem });
            this.модельMmcToolStripMenuItem.Text = "Модель M/M/c";
            this.расчётПоказателейToolStripMenuItem.Text = "Расчёт показателей";
            this.расчётПоказателейToolStripMenuItem.Click += new System.EventHandler(this.расчётПоказателейToolStripMenuItem_Click);

            this.номераToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.управлениеНомерамиToolStripMenuItem });
            this.номераToolStripMenuItem.Text = "Номера";
            this.управлениеНомерамиToolStripMenuItem.Text = "Управление";
            this.управлениеНомерамиToolStripMenuItem.Click += new System.EventHandler(this.управлениеНомерамиToolStripMenuItem_Click);

            this.бронированияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.управлениеБронированиямиToolStripMenuItem });
            this.бронированияToolStripMenuItem.Text = "Бронирования";
            this.управлениеБронированиямиToolStripMenuItem.Text = "Управление";
            this.управлениеБронированиямиToolStripMenuItem.Click += new System.EventHandler(this.управлениеБронированиямиToolStripMenuItem_Click);

            this.аналитикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.графикиToolStripMenuItem });
            this.аналитикаToolStripMenuItem.Text = "Аналитика";
            this.графикиToolStripMenuItem.Text = "Графики";
            this.графикиToolStripMenuItem.Click += new System.EventHandler(this.графикиToolStripMenuItem_Click);

            this.прогнозыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.рекомендацииToolStripMenuItem });
            this.прогнозыToolStripMenuItem.Text = "Прогнозы";
            this.рекомендацииToolStripMenuItem.Text = "Рекомендации";
            this.рекомендацииToolStripMenuItem.Click += new System.EventHandler(this.рекомендацииToolStripMenuItem_Click);

            this.внешниеФакторыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.управлениеФакторамиToolStripMenuItem });
            this.внешниеФакторыToolStripMenuItem.Text = "Внешние факторы";
            this.управлениеФакторамиToolStripMenuItem.Text = "Управление";
            this.управлениеФакторамиToolStripMenuItem.Click += new System.EventHandler(this.управлениеФакторамиToolStripMenuItem_Click);

            this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.выходИзПрограммыToolStripMenuItem });
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходИзПрограммыToolStripMenuItem.Text = "Выход";
            this.выходИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.выходИзПрограммыToolStripMenuItem_Click);

            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.оПрограммеToolStripMenuItem, this.управлениеПользователямиToolStripMenuItem, this.сменитьПользователяToolStripMenuItem });
            this.справкаToolStripMenuItem.Text = "Справка";
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            this.управлениеПользователямиToolStripMenuItem.Text = "Управление пользователями";
            this.управлениеПользователямиToolStripMenuItem.Click += new System.EventHandler(this.управлениеПользователямиToolStripMenuItem_Click);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);

            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 24);
            this.pnlHeader.Size = new System.Drawing.Size(800, 70);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "Система управления бронированием отеля";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(92, 64, 51);
            this.lblSubtitle.Location = new System.Drawing.Point(22, 45);
            this.lblSubtitle.Text = "Оптимизация загрузки на основе модели M/M/c";

            this.BackColor = System.Drawing.Color.FromArgb(253, 245, 230);
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отель: Система управления";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}