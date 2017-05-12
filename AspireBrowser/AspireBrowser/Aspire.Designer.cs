namespace AspireBrowser
{
    partial class Aspires
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aspires));
            this.menus = new System.Windows.Forms.MenuStrip();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Play = new System.Windows.Forms.ToolStripMenuItem();
            this.Image = new System.Windows.Forms.ToolStripMenuItem();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Download = new System.Windows.Forms.ToolStripMenuItem();
            this.Parameter = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleFenetreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleFenetrePriveeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telechargementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plusdoutilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menus
            // 
            this.menus.Dock = System.Windows.Forms.DockStyle.Left;
            this.menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Play,
            this.Image,
            this.File,
            this.Download,
            this.Parameter});
            this.menus.Location = new System.Drawing.Point(0, 0);
            this.menus.Name = "menus";
            this.menus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menus.Size = new System.Drawing.Size(98, 436);
            this.menus.TabIndex = 0;
            this.menus.Text = "📷";
            this.menus.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(85, 19);
            this.New.Text = "➕";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Play
            // 
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(85, 19);
            this.Play.Text = "▶";
            // 
            // Image
            // 
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(85, 19);
            this.Image.Text = "📷";
            // 
            // File
            // 
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(85, 19);
            this.File.Text = "🌅";
            // 
            // Download
            // 
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(85, 19);
            this.Download.Text = "📥";
            // 
            // Parameter
            // 
            this.Parameter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercherToolStripMenuItem,
            this.imprimerToolStripMenuItem,
            this.nouvelleFenetreToolStripMenuItem,
            this.nouvelleFenetrePriveeToolStripMenuItem,
            this.historiqueToolStripMenuItem,
            this.telechargementToolStripMenuItem,
            this.plusdoutilsToolStripMenuItem,
            this.parametresToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.Parameter.Margin = new System.Windows.Forms.Padding(0, 315, 0, 0);
            this.Parameter.Name = "Parameter";
            this.Parameter.Size = new System.Drawing.Size(85, 19);
            this.Parameter.Text = "🔧";
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.rechercherToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            this.rechercherToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.rechercherToolStripMenuItem.Click += new System.EventHandler(this.rechercherToolStripMenuItem_Click);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.imprimerToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            // 
            // nouvelleFenetreToolStripMenuItem
            // 
            this.nouvelleFenetreToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.nouvelleFenetreToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nouvelleFenetreToolStripMenuItem.Name = "nouvelleFenetreToolStripMenuItem";
            this.nouvelleFenetreToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.nouvelleFenetreToolStripMenuItem.Text = "Nouvelle Fenêtre";
            // 
            // nouvelleFenetrePriveeToolStripMenuItem
            // 
            this.nouvelleFenetrePriveeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.nouvelleFenetrePriveeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nouvelleFenetrePriveeToolStripMenuItem.Name = "nouvelleFenetrePriveeToolStripMenuItem";
            this.nouvelleFenetrePriveeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.nouvelleFenetrePriveeToolStripMenuItem.Text = "Nouvelle Fenêtre Privée";
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.historiqueToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.historiqueToolStripMenuItem.Text = "Historique";
            // 
            // telechargementToolStripMenuItem
            // 
            this.telechargementToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.telechargementToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.telechargementToolStripMenuItem.Name = "telechargementToolStripMenuItem";
            this.telechargementToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.telechargementToolStripMenuItem.Text = "Téléchargement";
            // 
            // plusdoutilsToolStripMenuItem
            // 
            this.plusdoutilsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.plusdoutilsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.plusdoutilsToolStripMenuItem.Name = "plusdoutilsToolStripMenuItem";
            this.plusdoutilsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.plusdoutilsToolStripMenuItem.Text = "Plus d\'outils";
            // 
            // parametresToolStripMenuItem
            // 
            this.parametresToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.parametresToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.parametresToolStripMenuItem.Name = "parametresToolStripMenuItem";
            this.parametresToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.parametresToolStripMenuItem.Text = "Paramètres";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.quitterToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.quitterToolStripMenuItem.Text = "Quiter";
            // 
            // Aspires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(842, 436);
            this.Controls.Add(this.menus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menus;
            this.Name = "Aspires";
            this.Text = "AspireBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menus.ResumeLayout(false);
            this.menus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menus;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Play;
        private System.Windows.Forms.ToolStripMenuItem Image;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Download;
        private System.Windows.Forms.ToolStripMenuItem Parameter;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleFenetreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleFenetrePriveeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telechargementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plusdoutilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

