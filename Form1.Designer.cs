namespace AtelierPro2CNED
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
            this.PANEL_MainInterface = new System.Windows.Forms.Panel();
            this.PANEL_AjoutPersonnel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_TelPersonnel = new System.Windows.Forms.TextBox();
            this.TB_mailPersonnel = new System.Windows.Forms.TextBox();
            this.TB_PrenomPersonnel = new System.Windows.Forms.TextBox();
            this.TB_NomPersonnel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Personnels = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_AjouterPersonnel = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_modifierPersonnel = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_SupprimerPersonnel = new System.Windows.Forms.ToolStripMenuItem();
            this.absenceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_AfficherAbsence = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_AjouterAbsence = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_ModifierAbsence = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_SupprimerAbsence = new System.Windows.Forms.ToolStripMenuItem();
            this.PANEL_Connexion = new System.Windows.Forms.Panel();
            this.TB_pass = new System.Windows.Forms.TextBox();
            this.TB_user = new System.Windows.Forms.TextBox();
            this.LBL_pass = new System.Windows.Forms.Label();
            this.LBL_user = new System.Windows.Forms.Label();
            this.BTN_Connect = new System.Windows.Forms.Button();
            this.BTN_AjoutPersonnel = new System.Windows.Forms.Button();
            this.BTN_CancelAjoutPersonnel = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.PANEL_Absence = new System.Windows.Forms.Panel();
            this.DATE_Deb = new System.Windows.Forms.DateTimePicker();
            this.DATE_End = new System.Windows.Forms.DateTimePicker();
            this.BTN_AjoutAbsence = new System.Windows.Forms.Button();
            this.CB_Motif = new System.Windows.Forms.ComboBox();
            this.BTN_cancelAjoutAbsence = new System.Windows.Forms.Button();
            this.BTN_ModifierAbsence = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PANEL_MainInterface.SuspendLayout();
            this.PANEL_AjoutPersonnel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.PANEL_Connexion.SuspendLayout();
            this.PANEL_Absence.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_MainInterface
            // 
            this.PANEL_MainInterface.Controls.Add(this.PANEL_Absence);
            this.PANEL_MainInterface.Controls.Add(this.PANEL_AjoutPersonnel);
            this.PANEL_MainInterface.Controls.Add(this.label1);
            this.PANEL_MainInterface.Controls.Add(this.LB_Personnels);
            this.PANEL_MainInterface.Controls.Add(this.menuStrip1);
            this.PANEL_MainInterface.Location = new System.Drawing.Point(13, 1);
            this.PANEL_MainInterface.Name = "PANEL_MainInterface";
            this.PANEL_MainInterface.Size = new System.Drawing.Size(444, 575);
            this.PANEL_MainInterface.TabIndex = 0;
            // 
            // PANEL_AjoutPersonnel
            // 
            this.PANEL_AjoutPersonnel.Controls.Add(this.BTN_Modifier);
            this.PANEL_AjoutPersonnel.Controls.Add(this.BTN_CancelAjoutPersonnel);
            this.PANEL_AjoutPersonnel.Controls.Add(this.BTN_AjoutPersonnel);
            this.PANEL_AjoutPersonnel.Controls.Add(this.label5);
            this.PANEL_AjoutPersonnel.Controls.Add(this.label4);
            this.PANEL_AjoutPersonnel.Controls.Add(this.label3);
            this.PANEL_AjoutPersonnel.Controls.Add(this.label2);
            this.PANEL_AjoutPersonnel.Controls.Add(this.TB_TelPersonnel);
            this.PANEL_AjoutPersonnel.Controls.Add(this.TB_mailPersonnel);
            this.PANEL_AjoutPersonnel.Controls.Add(this.TB_PrenomPersonnel);
            this.PANEL_AjoutPersonnel.Controls.Add(this.TB_NomPersonnel);
            this.PANEL_AjoutPersonnel.Location = new System.Drawing.Point(214, 56);
            this.PANEL_AjoutPersonnel.Name = "PANEL_AjoutPersonnel";
            this.PANEL_AjoutPersonnel.Size = new System.Drawing.Size(219, 200);
            this.PANEL_AjoutPersonnel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // TB_TelPersonnel
            // 
            this.TB_TelPersonnel.Location = new System.Drawing.Point(67, 90);
            this.TB_TelPersonnel.Name = "TB_TelPersonnel";
            this.TB_TelPersonnel.Size = new System.Drawing.Size(100, 20);
            this.TB_TelPersonnel.TabIndex = 3;
            // 
            // TB_mailPersonnel
            // 
            this.TB_mailPersonnel.Location = new System.Drawing.Point(67, 64);
            this.TB_mailPersonnel.Name = "TB_mailPersonnel";
            this.TB_mailPersonnel.Size = new System.Drawing.Size(100, 20);
            this.TB_mailPersonnel.TabIndex = 2;
            // 
            // TB_PrenomPersonnel
            // 
            this.TB_PrenomPersonnel.Location = new System.Drawing.Point(67, 38);
            this.TB_PrenomPersonnel.Name = "TB_PrenomPersonnel";
            this.TB_PrenomPersonnel.Size = new System.Drawing.Size(100, 20);
            this.TB_PrenomPersonnel.TabIndex = 1;
            // 
            // TB_NomPersonnel
            // 
            this.TB_NomPersonnel.Location = new System.Drawing.Point(67, 12);
            this.TB_NomPersonnel.Name = "TB_NomPersonnel";
            this.TB_NomPersonnel.Size = new System.Drawing.Size(100, 20);
            this.TB_NomPersonnel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personnels";
            // 
            // LB_Personnels
            // 
            this.LB_Personnels.FormattingEnabled = true;
            this.LB_Personnels.Items.AddRange(new object[] {
            "Personnel1",
            "Personnel2",
            "Personnel3",
            "Personnel4",
            "Personnel5",
            "Personnel6",
            "Personnel7",
            "Personnel8",
            "Personnel8",
            "Personnel10"});
            this.LB_Personnels.Location = new System.Drawing.Point(4, 56);
            this.LB_Personnels.Name = "LB_Personnels";
            this.LB_Personnels.Size = new System.Drawing.Size(203, 498);
            this.LB_Personnels.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnelToolStripMenuItem,
            this.absenceToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personnelToolStripMenuItem
            // 
            this.personnelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_AjouterPersonnel,
            this.TSM_modifierPersonnel,
            this.TSM_SupprimerPersonnel});
            this.personnelToolStripMenuItem.Name = "personnelToolStripMenuItem";
            this.personnelToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.personnelToolStripMenuItem.Text = "Personnel";
            // 
            // TSM_AjouterPersonnel
            // 
            this.TSM_AjouterPersonnel.Name = "TSM_AjouterPersonnel";
            this.TSM_AjouterPersonnel.Size = new System.Drawing.Size(180, 22);
            this.TSM_AjouterPersonnel.Text = "Ajouter";
            this.TSM_AjouterPersonnel.Click += new System.EventHandler(this.TSM_AjouterPersonnel_Click);
            // 
            // TSM_modifierPersonnel
            // 
            this.TSM_modifierPersonnel.Name = "TSM_modifierPersonnel";
            this.TSM_modifierPersonnel.Size = new System.Drawing.Size(180, 22);
            this.TSM_modifierPersonnel.Text = "Modifier";
            this.TSM_modifierPersonnel.Click += new System.EventHandler(this.TSM_modifierPersonnel_Click);
            // 
            // TSM_SupprimerPersonnel
            // 
            this.TSM_SupprimerPersonnel.Name = "TSM_SupprimerPersonnel";
            this.TSM_SupprimerPersonnel.Size = new System.Drawing.Size(180, 22);
            this.TSM_SupprimerPersonnel.Text = "Supprimer";
            this.TSM_SupprimerPersonnel.Click += new System.EventHandler(this.TSM_SupprimerPersonnel_Click);
            // 
            // absenceToolStripMenuItem1
            // 
            this.absenceToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_AfficherAbsence,
            this.TSM_AjouterAbsence,
            this.TSM_ModifierAbsence,
            this.TSM_SupprimerAbsence});
            this.absenceToolStripMenuItem1.Name = "absenceToolStripMenuItem1";
            this.absenceToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.absenceToolStripMenuItem1.Text = "Absence";
            // 
            // TSM_AfficherAbsence
            // 
            this.TSM_AfficherAbsence.Name = "TSM_AfficherAbsence";
            this.TSM_AfficherAbsence.Size = new System.Drawing.Size(180, 22);
            this.TSM_AfficherAbsence.Text = "Afficher";
            this.TSM_AfficherAbsence.Click += new System.EventHandler(this.TSM_AfficherAbsence_Click);
            // 
            // TSM_AjouterAbsence
            // 
            this.TSM_AjouterAbsence.Name = "TSM_AjouterAbsence";
            this.TSM_AjouterAbsence.Size = new System.Drawing.Size(180, 22);
            this.TSM_AjouterAbsence.Text = "Ajouter";
            this.TSM_AjouterAbsence.Click += new System.EventHandler(this.TSM_AjouterAbsence_Click);
            // 
            // TSM_ModifierAbsence
            // 
            this.TSM_ModifierAbsence.Name = "TSM_ModifierAbsence";
            this.TSM_ModifierAbsence.Size = new System.Drawing.Size(180, 22);
            this.TSM_ModifierAbsence.Text = "Modifier";
            this.TSM_ModifierAbsence.Click += new System.EventHandler(this.TSM_ModifierAbsence_Click);
            // 
            // TSM_SupprimerAbsence
            // 
            this.TSM_SupprimerAbsence.Name = "TSM_SupprimerAbsence";
            this.TSM_SupprimerAbsence.Size = new System.Drawing.Size(180, 22);
            this.TSM_SupprimerAbsence.Text = "Supprimer";
            this.TSM_SupprimerAbsence.Click += new System.EventHandler(this.TSM_SupprimerAbsence_Click);
            // 
            // PANEL_Connexion
            // 
            this.PANEL_Connexion.Controls.Add(this.TB_pass);
            this.PANEL_Connexion.Controls.Add(this.TB_user);
            this.PANEL_Connexion.Controls.Add(this.LBL_pass);
            this.PANEL_Connexion.Controls.Add(this.LBL_user);
            this.PANEL_Connexion.Controls.Add(this.BTN_Connect);
            this.PANEL_Connexion.Location = new System.Drawing.Point(1, 1);
            this.PANEL_Connexion.Name = "PANEL_Connexion";
            this.PANEL_Connexion.Size = new System.Drawing.Size(219, 192);
            this.PANEL_Connexion.TabIndex = 1;
            // 
            // TB_pass
            // 
            this.TB_pass.Location = new System.Drawing.Point(55, 68);
            this.TB_pass.Name = "TB_pass";
            this.TB_pass.PasswordChar = '*';
            this.TB_pass.Size = new System.Drawing.Size(100, 20);
            this.TB_pass.TabIndex = 4;
            // 
            // TB_user
            // 
            this.TB_user.Location = new System.Drawing.Point(55, 28);
            this.TB_user.Name = "TB_user";
            this.TB_user.Size = new System.Drawing.Size(100, 20);
            this.TB_user.TabIndex = 3;
            // 
            // LBL_pass
            // 
            this.LBL_pass.AutoSize = true;
            this.LBL_pass.Location = new System.Drawing.Point(52, 51);
            this.LBL_pass.Name = "LBL_pass";
            this.LBL_pass.Size = new System.Drawing.Size(53, 13);
            this.LBL_pass.TabIndex = 2;
            this.LBL_pass.Text = "Password";
            // 
            // LBL_user
            // 
            this.LBL_user.AutoSize = true;
            this.LBL_user.Location = new System.Drawing.Point(52, 12);
            this.LBL_user.Name = "LBL_user";
            this.LBL_user.Size = new System.Drawing.Size(55, 13);
            this.LBL_user.TabIndex = 1;
            this.LBL_user.Text = "Username";
            // 
            // BTN_Connect
            // 
            this.BTN_Connect.Location = new System.Drawing.Point(55, 124);
            this.BTN_Connect.Name = "BTN_Connect";
            this.BTN_Connect.Size = new System.Drawing.Size(93, 23);
            this.BTN_Connect.TabIndex = 0;
            this.BTN_Connect.Text = "Se Connecter";
            this.BTN_Connect.UseVisualStyleBackColor = true;
            this.BTN_Connect.Click += new System.EventHandler(this.BTN_Connect_Click_1);
            // 
            // BTN_AjoutPersonnel
            // 
            this.BTN_AjoutPersonnel.Location = new System.Drawing.Point(3, 174);
            this.BTN_AjoutPersonnel.Name = "BTN_AjoutPersonnel";
            this.BTN_AjoutPersonnel.Size = new System.Drawing.Size(91, 23);
            this.BTN_AjoutPersonnel.TabIndex = 8;
            this.BTN_AjoutPersonnel.Text = "Ajouter";
            this.BTN_AjoutPersonnel.UseVisualStyleBackColor = true;
            this.BTN_AjoutPersonnel.Click += new System.EventHandler(this.BTN_AjoutPersonnel_Click);
            // 
            // BTN_CancelAjoutPersonnel
            // 
            this.BTN_CancelAjoutPersonnel.Location = new System.Drawing.Point(141, 174);
            this.BTN_CancelAjoutPersonnel.Name = "BTN_CancelAjoutPersonnel";
            this.BTN_CancelAjoutPersonnel.Size = new System.Drawing.Size(75, 23);
            this.BTN_CancelAjoutPersonnel.TabIndex = 9;
            this.BTN_CancelAjoutPersonnel.Text = "Annuler";
            this.BTN_CancelAjoutPersonnel.UseVisualStyleBackColor = true;
            this.BTN_CancelAjoutPersonnel.Click += new System.EventHandler(this.BTN_CancelAjoutPersonnel_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(3, 174);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(91, 23);
            this.BTN_Modifier.TabIndex = 10;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // PANEL_Absence
            // 
            this.PANEL_Absence.Controls.Add(this.label8);
            this.PANEL_Absence.Controls.Add(this.label7);
            this.PANEL_Absence.Controls.Add(this.label6);
            this.PANEL_Absence.Controls.Add(this.BTN_ModifierAbsence);
            this.PANEL_Absence.Controls.Add(this.BTN_cancelAjoutAbsence);
            this.PANEL_Absence.Controls.Add(this.CB_Motif);
            this.PANEL_Absence.Controls.Add(this.BTN_AjoutAbsence);
            this.PANEL_Absence.Controls.Add(this.DATE_End);
            this.PANEL_Absence.Controls.Add(this.DATE_Deb);
            this.PANEL_Absence.Location = new System.Drawing.Point(214, 276);
            this.PANEL_Absence.Name = "PANEL_Absence";
            this.PANEL_Absence.Size = new System.Drawing.Size(216, 188);
            this.PANEL_Absence.TabIndex = 4;
            // 
            // DATE_Deb
            // 
            this.DATE_Deb.Location = new System.Drawing.Point(47, 3);
            this.DATE_Deb.Name = "DATE_Deb";
            this.DATE_Deb.Size = new System.Drawing.Size(166, 20);
            this.DATE_Deb.TabIndex = 0;
            // 
            // DATE_End
            // 
            this.DATE_End.Location = new System.Drawing.Point(47, 29);
            this.DATE_End.Name = "DATE_End";
            this.DATE_End.Size = new System.Drawing.Size(166, 20);
            this.DATE_End.TabIndex = 1;
            // 
            // BTN_AjoutAbsence
            // 
            this.BTN_AjoutAbsence.Location = new System.Drawing.Point(3, 162);
            this.BTN_AjoutAbsence.Name = "BTN_AjoutAbsence";
            this.BTN_AjoutAbsence.Size = new System.Drawing.Size(75, 23);
            this.BTN_AjoutAbsence.TabIndex = 2;
            this.BTN_AjoutAbsence.Text = "Ajouter";
            this.BTN_AjoutAbsence.UseVisualStyleBackColor = true;
            this.BTN_AjoutAbsence.Click += new System.EventHandler(this.BTN_AjoutAbsence_Click);
            // 
            // CB_Motif
            // 
            this.CB_Motif.FormattingEnabled = true;
            this.CB_Motif.Items.AddRange(new object[] {
            "vacances",
            "maladie",
            "motif familial",
            "congé parental"});
            this.CB_Motif.Location = new System.Drawing.Point(47, 55);
            this.CB_Motif.Name = "CB_Motif";
            this.CB_Motif.Size = new System.Drawing.Size(166, 21);
            this.CB_Motif.TabIndex = 3;
            // 
            // BTN_cancelAjoutAbsence
            // 
            this.BTN_cancelAjoutAbsence.Location = new System.Drawing.Point(138, 162);
            this.BTN_cancelAjoutAbsence.Name = "BTN_cancelAjoutAbsence";
            this.BTN_cancelAjoutAbsence.Size = new System.Drawing.Size(75, 23);
            this.BTN_cancelAjoutAbsence.TabIndex = 4;
            this.BTN_cancelAjoutAbsence.Text = "Annuler";
            this.BTN_cancelAjoutAbsence.UseVisualStyleBackColor = true;
            this.BTN_cancelAjoutAbsence.Click += new System.EventHandler(this.BTN_cancelAjoutAbsence_Click);
            // 
            // BTN_ModifierAbsence
            // 
            this.BTN_ModifierAbsence.Location = new System.Drawing.Point(3, 162);
            this.BTN_ModifierAbsence.Name = "BTN_ModifierAbsence";
            this.BTN_ModifierAbsence.Size = new System.Drawing.Size(75, 23);
            this.BTN_ModifierAbsence.TabIndex = 5;
            this.BTN_ModifierAbsence.Text = "Modifier";
            this.BTN_ModifierAbsence.UseVisualStyleBackColor = true;
            this.BTN_ModifierAbsence.Click += new System.EventHandler(this.BTN_ModifierAbsence_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Début";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Motif";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 588);
            this.Controls.Add(this.PANEL_MainInterface);
            this.Controls.Add(this.PANEL_Connexion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PANEL_MainInterface.ResumeLayout(false);
            this.PANEL_MainInterface.PerformLayout();
            this.PANEL_AjoutPersonnel.ResumeLayout(false);
            this.PANEL_AjoutPersonnel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PANEL_Connexion.ResumeLayout(false);
            this.PANEL_Connexion.PerformLayout();
            this.PANEL_Absence.ResumeLayout(false);
            this.PANEL_Absence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_MainInterface;
        private System.Windows.Forms.Panel PANEL_Connexion;
        private System.Windows.Forms.TextBox TB_pass;
        private System.Windows.Forms.TextBox TB_user;
        private System.Windows.Forms.Label LBL_pass;
        private System.Windows.Forms.Label LBL_user;
        private System.Windows.Forms.Button BTN_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_Personnels;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSM_AjouterPersonnel;
        private System.Windows.Forms.ToolStripMenuItem TSM_modifierPersonnel;
        private System.Windows.Forms.ToolStripMenuItem TSM_SupprimerPersonnel;
        private System.Windows.Forms.ToolStripMenuItem absenceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TSM_AfficherAbsence;
        private System.Windows.Forms.ToolStripMenuItem TSM_AjouterAbsence;
        private System.Windows.Forms.ToolStripMenuItem TSM_ModifierAbsence;
        private System.Windows.Forms.ToolStripMenuItem TSM_SupprimerAbsence;
        private System.Windows.Forms.Panel PANEL_AjoutPersonnel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_TelPersonnel;
        private System.Windows.Forms.TextBox TB_mailPersonnel;
        private System.Windows.Forms.TextBox TB_PrenomPersonnel;
        private System.Windows.Forms.TextBox TB_NomPersonnel;
        private System.Windows.Forms.Button BTN_AjoutPersonnel;
        private System.Windows.Forms.Button BTN_CancelAjoutPersonnel;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Panel PANEL_Absence;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_ModifierAbsence;
        private System.Windows.Forms.Button BTN_cancelAjoutAbsence;
        private System.Windows.Forms.ComboBox CB_Motif;
        private System.Windows.Forms.Button BTN_AjoutAbsence;
        private System.Windows.Forms.DateTimePicker DATE_End;
        private System.Windows.Forms.DateTimePicker DATE_Deb;
    }
}

