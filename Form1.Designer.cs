namespace Reauto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvGames = new System.Windows.Forms.ListView();
            this.GameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GameDir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPlay = new System.Windows.Forms.Button();
            this.lvGameExe = new System.Windows.Forms.ListView();
            this.GameExeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GameExeNamePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GameExeIcon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvGames
            // 
            this.lvGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvGames.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvGames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GameName,
            this.GameDir});
            this.lvGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGames.ForeColor = System.Drawing.Color.MediumPurple;
            this.lvGames.FullRowSelect = true;
            this.lvGames.HideSelection = false;
            this.lvGames.Location = new System.Drawing.Point(12, 12);
            this.lvGames.Name = "lvGames";
            this.lvGames.Size = new System.Drawing.Size(738, 419);
            this.lvGames.TabIndex = 0;
            this.lvGames.UseCompatibleStateImageBehavior = false;
            this.lvGames.View = System.Windows.Forms.View.Details;
            this.lvGames.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvGames_MouseClick);
            // 
            // GameName
            // 
            this.GameName.Text = "Name";
            this.GameName.Width = 308;
            // 
            // GameDir
            // 
            this.GameDir.Text = "Directory";
            this.GameDir.Width = 418;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackColor = System.Drawing.Color.LightGreen;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlay.Location = new System.Drawing.Point(622, 437);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(128, 116);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Jouer";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lvGameExe
            // 
            this.lvGameExe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvGameExe.BackColor = System.Drawing.Color.Black;
            this.lvGameExe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvGameExe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GameExeIcon,
            this.GameExeName,
            this.GameExeNamePath});
            this.lvGameExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGameExe.ForeColor = System.Drawing.Color.LightCoral;
            this.lvGameExe.FullRowSelect = true;
            this.lvGameExe.HideSelection = false;
            this.lvGameExe.Location = new System.Drawing.Point(12, 437);
            this.lvGameExe.Name = "lvGameExe";
            this.lvGameExe.Size = new System.Drawing.Size(604, 116);
            this.lvGameExe.TabIndex = 2;
            this.lvGameExe.UseCompatibleStateImageBehavior = false;
            this.lvGameExe.View = System.Windows.Forms.View.Details;
            // 
            // GameExeName
            // 
            this.GameExeName.Text = "ExeName";
            this.GameExeName.Width = 300;
            // 
            // GameExeNamePath
            // 
            this.GameExeNamePath.Text = "Exe Path";
            this.GameExeNamePath.Width = 300;
            // 
            // GameExeIcon
            // 
            this.GameExeIcon.Text = "Pic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(762, 565);
            this.Controls.Add(this.lvGameExe);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lvGames);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nucleon - simple games launcher by Adriraxor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvGames;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ColumnHeader GameName;
        private System.Windows.Forms.ColumnHeader GameDir;
        private System.Windows.Forms.ListView lvGameExe;
        private System.Windows.Forms.ColumnHeader GameExeName;
        private System.Windows.Forms.ColumnHeader GameExeNamePath;
        private System.Windows.Forms.ColumnHeader GameExeIcon;
    }
}

