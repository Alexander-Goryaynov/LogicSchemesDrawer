namespace LogicSchemesDrawer
{
    partial class FormScheme
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
            this.picBoxScheme = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ChangeDesignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSchemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonStart = new System.Windows.Forms.Button();
            this.ConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxScheme)).BeginInit();
            this.panel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxScheme
            // 
            this.picBoxScheme.Location = new System.Drawing.Point(3, -13);
            this.picBoxScheme.Name = "picBoxScheme";
            this.picBoxScheme.Size = new System.Drawing.Size(812, 900);
            this.picBoxScheme.TabIndex = 3;
            this.picBoxScheme.TabStop = false;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.picBoxScheme);
            this.panel.Location = new System.Drawing.Point(12, 42);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(846, 629);
            this.panel.TabIndex = 4;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeDesignToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.SaveSchemeToolStripMenuItem,
            this.ConverterToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1290, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ChangeDesignToolStripMenuItem
            // 
            this.ChangeDesignToolStripMenuItem.Name = "ChangeDesignToolStripMenuItem";
            this.ChangeDesignToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.ChangeDesignToolStripMenuItem.Text = "Сменить оформление";
            this.ChangeDesignToolStripMenuItem.Click += new System.EventHandler(this.ChangeDesignToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.HelpToolStripMenuItem.Text = "Помощь";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // SaveSchemeToolStripMenuItem
            // 
            this.SaveSchemeToolStripMenuItem.Name = "SaveSchemeToolStripMenuItem";
            this.SaveSchemeToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.SaveSchemeToolStripMenuItem.Text = "Сохранить схему в файл";
            this.SaveSchemeToolStripMenuItem.Click += new System.EventHandler(this.SaveSchemeToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.Z,
            this.W});
            this.dataGridView.Location = new System.Drawing.Point(882, 144);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(360, 375);
            this.dataGridView.TabIndex = 6;
            dataGridView.RowCount = 16;
            // 
            // X
            // 
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.Name = "Y";
            // 
            // Z
            // 
            this.Z.Name = "Z";
            // 
            // W
            // 
            this.W.Name = "W";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonStart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(882, 550);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(360, 46);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Построить схему";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ConverterToolStripMenuItem
            // 
            this.ConverterToolStripMenuItem.Name = "ConverterToolStripMenuItem";
            this.ConverterToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.ConverterToolStripMenuItem.Text = "Конвертер";
            this.ConverterToolStripMenuItem.Click += new System.EventHandler(this.ConverterToolStripMenuItem_Click);
            // 
            // FormScheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1290, 683);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormScheme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Логическая схема МДНФ на базисе И-НЕ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picBoxScheme)).EndInit();
            this.panel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoxScheme;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ChangeDesignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnW;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.DataGridViewTextBoxColumn W;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ToolStripMenuItem SaveSchemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConverterToolStripMenuItem;
    }
}