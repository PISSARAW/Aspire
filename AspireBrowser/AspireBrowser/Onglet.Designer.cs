namespace AspireBrowser
{
    partial class Onglet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Onglet));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.retourButton = new System.Windows.Forms.Button();
            this.suivantButton = new System.Windows.Forms.Button();
            this.barredeRecherche = new System.Windows.Forms.TextBox();
            this.rafraichirButton = new System.Windows.Forms.Button();
            this.TheAspireBrowser = new System.Windows.Forms.WebBrowser();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel1.Controls.Add(this.retourButton);
            this.flowLayoutPanel1.Controls.Add(this.suivantButton);
            this.flowLayoutPanel1.Controls.Add(this.barredeRecherche);
            this.flowLayoutPanel1.Controls.Add(this.rafraichirButton);
            this.flowLayoutPanel1.Controls.Add(this.TheAspireBrowser);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1362, 741);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // retourButton
            // 
            this.retourButton.BackColor = System.Drawing.SystemColors.Window;
            this.retourButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.retourButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.retourButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.retourButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.retourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retourButton.Location = new System.Drawing.Point(3, 3);
            this.retourButton.Name = "retourButton";
            this.retourButton.Size = new System.Drawing.Size(21, 23);
            this.retourButton.TabIndex = 0;
            this.retourButton.Text = "⬅";
            this.retourButton.UseVisualStyleBackColor = false;
            this.retourButton.Click += new System.EventHandler(this.retourButton_Click);
            // 
            // suivantButton
            // 
            this.suivantButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.suivantButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.suivantButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.suivantButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.suivantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suivantButton.Location = new System.Drawing.Point(30, 3);
            this.suivantButton.Name = "suivantButton";
            this.suivantButton.Size = new System.Drawing.Size(32, 23);
            this.suivantButton.TabIndex = 1;
            this.suivantButton.Text = "➡";
            this.suivantButton.UseVisualStyleBackColor = true;
            // 
            // barredeRecherche
            // 
            this.barredeRecherche.Dock = System.Windows.Forms.DockStyle.Top;
            this.barredeRecherche.Location = new System.Drawing.Point(68, 3);
            this.barredeRecherche.Name = "barredeRecherche";
            this.barredeRecherche.Size = new System.Drawing.Size(1228, 20);
            this.barredeRecherche.TabIndex = 2;
            this.barredeRecherche.TextChanged += new System.EventHandler(this.barredeRecherche_TextChanged);
            this.barredeRecherche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barreDeRecherche_keydown);
            // 
            // rafraichirButton
            // 
            this.rafraichirButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.rafraichirButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rafraichirButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.rafraichirButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.rafraichirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rafraichirButton.Location = new System.Drawing.Point(1302, 3);
            this.rafraichirButton.Name = "rafraichirButton";
            this.rafraichirButton.Size = new System.Drawing.Size(34, 23);
            this.rafraichirButton.TabIndex = 3;
            this.rafraichirButton.Text = "🔄";
            this.rafraichirButton.UseVisualStyleBackColor = true;
            this.rafraichirButton.Click += new System.EventHandler(this.rafraichirButton_Click);
            // 
            // TheAspireBrowser
            // 
            this.TheAspireBrowser.Location = new System.Drawing.Point(3, 32);
            this.TheAspireBrowser.Name = "TheAspireBrowser";
            this.TheAspireBrowser.Size = new System.Drawing.Size(1347, 697);
            this.TheAspireBrowser.TabIndex = 4;
            this.TheAspireBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.TheAspireBrowser_DocumentCompleted);
            // 
            // Onglet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Onglet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button retourButton;
        private System.Windows.Forms.Button suivantButton;
        private System.Windows.Forms.TextBox barredeRecherche;
        private System.Windows.Forms.Button rafraichirButton;
        private System.Windows.Forms.WebBrowser TheAspireBrowser;
    }
}