namespace Barley_Break
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.solve = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.steps = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // solve
            // 
            this.solve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.solve.BackColor = System.Drawing.Color.Maroon;
            this.solve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solve.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.solve.FlatAppearance.BorderSize = 2;
            this.solve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.solve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solve.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solve.ForeColor = System.Drawing.Color.Yellow;
            this.solve.Location = new System.Drawing.Point(145, 406);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(113, 41);
            this.solve.TabIndex = 1;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = false;
            this.solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(399, 38);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "gameMenu";
            // 
            // gameMenu
            // 
            this.gameMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMenuStrip,
            this.exitMenuStrip});
            this.gameMenu.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameMenu.ForeColor = System.Drawing.Color.Yellow;
            this.gameMenu.Name = "gameMenu";
            this.gameMenu.Size = new System.Drawing.Size(90, 34);
            this.gameMenu.Text = "Game";
            // 
            // newGameMenuStrip
            // 
            this.newGameMenuStrip.BackColor = System.Drawing.Color.Moccasin;
            this.newGameMenuStrip.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameMenuStrip.ForeColor = System.Drawing.Color.Maroon;
            this.newGameMenuStrip.Name = "newGameMenuStrip";
            this.newGameMenuStrip.Size = new System.Drawing.Size(149, 22);
            this.newGameMenuStrip.Text = "New Game";
            this.newGameMenuStrip.Click += new System.EventHandler(this.NewGameMenuStrip_Click);
            // 
            // exitMenuStrip
            // 
            this.exitMenuStrip.BackColor = System.Drawing.Color.Moccasin;
            this.exitMenuStrip.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMenuStrip.ForeColor = System.Drawing.Color.Maroon;
            this.exitMenuStrip.Name = "exitMenuStrip";
            this.exitMenuStrip.Size = new System.Drawing.Size(149, 22);
            this.exitMenuStrip.Text = "Exit";
            this.exitMenuStrip.Click += new System.EventHandler(this.ExitMenuStrip_Click);
            // 
            // steps
            // 
            this.steps.AutoSize = true;
            this.steps.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.steps.Location = new System.Drawing.Point(12, 48);
            this.steps.Name = "steps";
            this.steps.Size = new System.Drawing.Size(90, 23);
            this.steps.TabIndex = 3;
            this.steps.Text = "Steps: 0";
            this.steps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.time.Location = new System.Drawing.Point(291, 48);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(84, 23);
            this.time.TabIndex = 4;
            this.time.Text = "Time: 0";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.time);
            this.Controls.Add(this.steps);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "GameField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barley-Break";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameMenu;
        private System.Windows.Forms.Label steps;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.ToolStripMenuItem newGameMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitMenuStrip;
    }
}
