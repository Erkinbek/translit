namespace Imlo
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.faylToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yangiHosilQilishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saqlashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mavjudFaylniOchishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiqishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tahrirlashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nusxalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joylashtirtirishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shriftFormatlashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dasturHaqidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yangilanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(419, 386);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Кирил алифбосидаги матнни шу ерга киритинг";
            this.richTextBox1.Click += new System.EventHandler(this.clearText1);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(485, 58);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(419, 386);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "Lotin alifbosidagi matnni shu yerga kiriting";
            this.richTextBox2.Click += new System.EventHandler(this.clearText2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lotinga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(829, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kirilga o\'tkazish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faylToolStripMenuItem,
            this.tahrirlashToolStripMenuItem,
            this.dasturHaqidaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // faylToolStripMenuItem
            // 
            this.faylToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yangiHosilQilishToolStripMenuItem,
            this.saqlashToolStripMenuItem,
            this.mavjudFaylniOchishToolStripMenuItem,
            this.chiqishToolStripMenuItem});
            this.faylToolStripMenuItem.Name = "faylToolStripMenuItem";
            this.faylToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.faylToolStripMenuItem.Text = "Fayl";
            // 
            // yangiHosilQilishToolStripMenuItem
            // 
            this.yangiHosilQilishToolStripMenuItem.Name = "yangiHosilQilishToolStripMenuItem";
            this.yangiHosilQilishToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.yangiHosilQilishToolStripMenuItem.Text = "Yangi hosil qilish";
            // 
            // saqlashToolStripMenuItem
            // 
            this.saqlashToolStripMenuItem.Name = "saqlashToolStripMenuItem";
            this.saqlashToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.saqlashToolStripMenuItem.Text = "Saqlash";
            // 
            // mavjudFaylniOchishToolStripMenuItem
            // 
            this.mavjudFaylniOchishToolStripMenuItem.Name = "mavjudFaylniOchishToolStripMenuItem";
            this.mavjudFaylniOchishToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.mavjudFaylniOchishToolStripMenuItem.Text = "Mavjud faylni tarjima qilish";
            this.mavjudFaylniOchishToolStripMenuItem.Click += new System.EventHandler(this.mavjudFaylniOchishToolStripMenuItem_Click);
            // 
            // chiqishToolStripMenuItem
            // 
            this.chiqishToolStripMenuItem.Name = "chiqishToolStripMenuItem";
            this.chiqishToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.chiqishToolStripMenuItem.Text = "Chiqish";
            // 
            // tahrirlashToolStripMenuItem
            // 
            this.tahrirlashToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nusxalarToolStripMenuItem,
            this.kesishToolStripMenuItem,
            this.joylashtirtirishToolStripMenuItem,
            this.shriftFormatlashToolStripMenuItem});
            this.tahrirlashToolStripMenuItem.Name = "tahrirlashToolStripMenuItem";
            this.tahrirlashToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.tahrirlashToolStripMenuItem.Text = "Tahrirlash";
            // 
            // nusxalarToolStripMenuItem
            // 
            this.nusxalarToolStripMenuItem.Name = "nusxalarToolStripMenuItem";
            this.nusxalarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.nusxalarToolStripMenuItem.Text = "Nusxalar";
            // 
            // kesishToolStripMenuItem
            // 
            this.kesishToolStripMenuItem.Name = "kesishToolStripMenuItem";
            this.kesishToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.kesishToolStripMenuItem.Text = "Kesish";
            // 
            // joylashtirtirishToolStripMenuItem
            // 
            this.joylashtirtirishToolStripMenuItem.Name = "joylashtirtirishToolStripMenuItem";
            this.joylashtirtirishToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.joylashtirtirishToolStripMenuItem.Text = "Joylashtirtirish";
            // 
            // shriftFormatlashToolStripMenuItem
            // 
            this.shriftFormatlashToolStripMenuItem.Name = "shriftFormatlashToolStripMenuItem";
            this.shriftFormatlashToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.shriftFormatlashToolStripMenuItem.Text = "Shrift formatlash";
            // 
            // dasturHaqidaToolStripMenuItem
            // 
            this.dasturHaqidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.yangilanishToolStripMenuItem});
            this.dasturHaqidaToolStripMenuItem.Name = "dasturHaqidaToolStripMenuItem";
            this.dasturHaqidaToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.dasturHaqidaToolStripMenuItem.Text = "Dastur haqida";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // yangilanishToolStripMenuItem
            // 
            this.yangilanishToolStripMenuItem.Name = "yangilanishToolStripMenuItem";
            this.yangilanishToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.yangilanishToolStripMenuItem.Text = "Yangilanish";
            this.yangilanishToolStripMenuItem.Click += new System.EventHandler(this.yangilanishToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Janubiy Transliterator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem faylToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yangiHosilQilishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saqlashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mavjudFaylniOchishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tahrirlashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nusxalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joylashtirtirishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shriftFormatlashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dasturHaqidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiqishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yangilanishToolStripMenuItem;
    }
}

