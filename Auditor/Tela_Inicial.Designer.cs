namespace Auditor
{
    partial class Tela_Inicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditorDePastasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.auditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarFotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditorDeImagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.auditorDePastasToolStripMenuItem1,
            this.localizarFotosToolStripMenuItem,
            this.comparativoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // auditorDePastasToolStripMenuItem1
            // 
            this.auditorDePastasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auditorToolStripMenuItem});
            this.auditorDePastasToolStripMenuItem1.Name = "auditorDePastasToolStripMenuItem1";
            this.auditorDePastasToolStripMenuItem1.Size = new System.Drawing.Size(111, 20);
            this.auditorDePastasToolStripMenuItem1.Text = "Auditor de pastas";
            // 
            // auditorToolStripMenuItem
            // 
            this.auditorToolStripMenuItem.Name = "auditorToolStripMenuItem";
            this.auditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.auditorToolStripMenuItem.Text = "Auditor";
            // 
            // localizarFotosToolStripMenuItem
            // 
            this.localizarFotosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscadorToolStripMenuItem});
            this.localizarFotosToolStripMenuItem.Name = "localizarFotosToolStripMenuItem";
            this.localizarFotosToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.localizarFotosToolStripMenuItem.Text = "Localizar Fotos";
            // 
            // buscadorToolStripMenuItem
            // 
            this.buscadorToolStripMenuItem.Name = "buscadorToolStripMenuItem";
            this.buscadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscadorToolStripMenuItem.Text = "Buscador";
            this.buscadorToolStripMenuItem.Click += new System.EventHandler(this.buscadorToolStripMenuItem_Click);
            // 
            // comparativoToolStripMenuItem
            // 
            this.comparativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auditorDeImagensToolStripMenuItem});
            this.comparativoToolStripMenuItem.Name = "comparativoToolStripMenuItem";
            this.comparativoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.comparativoToolStripMenuItem.Text = "Comparativo ";
            // 
            // auditorDeImagensToolStripMenuItem
            // 
            this.auditorDeImagensToolStripMenuItem.Name = "auditorDeImagensToolStripMenuItem";
            this.auditorDeImagensToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.auditorDeImagensToolStripMenuItem.Text = "Auditor de Imagens";
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 587);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Tela_Inicial";
            this.Text = "Tela_Inicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditorDePastasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem auditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarFotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditorDeImagensToolStripMenuItem;
    }
}