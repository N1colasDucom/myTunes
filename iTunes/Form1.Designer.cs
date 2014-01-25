namespace iTunes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Mes Musiques", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Mes Playlists", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bibliothèque"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDeLectureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterLeFichierÀLaBibliothèqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterLeDossierÀLaBibliothèqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.présentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrôlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pistesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new iTunes.DataSet1();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBarPlay = new System.Windows.Forms.TrackBar();
            this.trackBarVol = new System.Windows.Forms.TrackBar();
            this.checkBoxPlay = new System.Windows.Forms.CheckBox();
            this.BtnStop = new System.Windows.Forms.Button();
            this.labelAvt = new System.Windows.Forms.Label();
            this.labelAprs = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterDansPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.editerLesInformationsDeLaPisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clicDroit_effacer = new System.Windows.Forms.ToolStripMenuItem();
            this.effacerLeMorceauEtLeMettreDansLaCorbeilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.v_lbl_Titre = new System.Windows.Forms.Label();
            this.v_lbl_ArtisteEtAlbum = new System.Windows.Forms.Label();
            this.v_lbl_NomApp = new System.Windows.Forms.Label();
            this.v_Pochette_Ombre = new System.Windows.Forms.PictureBox();
            this.listView_MenusLateraux = new System.Windows.Forms.ListView();
            this.Menus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnSuiv = new System.Windows.Forms.Button();
            this.BtnPrec = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelRecherche = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LabelArtiste = new System.Windows.Forms.Label();
            this.LabelAlbum = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.titreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artisteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duréeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classementDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheminDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checksumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pistesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trackBarAlbums = new System.Windows.Forms.TrackBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pistesLectureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OpenBrowserButton = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerLaPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duréeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checksumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAjout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDerniereLecture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbLecture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Pochette_Ombre)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistesLectureBindingSource)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.présentationToolStripMenuItem,
            this.contrôlesToolStripMenuItem,
            this.storeToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1209, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ajouterLeFichierÀLaBibliothèqueToolStripMenuItem,
            this.ajouterLeDossierÀLaBibliothèqueToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDeLectureToolStripMenuItem});
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            // 
            // listeDeLectureToolStripMenuItem
            // 
            this.listeDeLectureToolStripMenuItem.Name = "listeDeLectureToolStripMenuItem";
            this.listeDeLectureToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.listeDeLectureToolStripMenuItem.Text = "Liste de lecture";
            // 
            // ajouterLeFichierÀLaBibliothèqueToolStripMenuItem
            // 
            this.ajouterLeFichierÀLaBibliothèqueToolStripMenuItem.Name = "ajouterLeFichierÀLaBibliothèqueToolStripMenuItem";
            this.ajouterLeFichierÀLaBibliothèqueToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.ajouterLeFichierÀLaBibliothèqueToolStripMenuItem.Text = "Ajouter le fichier à la bibliothèque...";
            this.ajouterLeFichierÀLaBibliothèqueToolStripMenuItem.Click += new System.EventHandler(this.ajouterLeFichierÀLaBibliothèqueToolStripMenuItem_Click);
            // 
            // ajouterLeDossierÀLaBibliothèqueToolStripMenuItem
            // 
            this.ajouterLeDossierÀLaBibliothèqueToolStripMenuItem.Name = "ajouterLeDossierÀLaBibliothèqueToolStripMenuItem";
            this.ajouterLeDossierÀLaBibliothèqueToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.ajouterLeDossierÀLaBibliothèqueToolStripMenuItem.Text = "Ajouter le dossier à la bibliothèque...";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // présentationToolStripMenuItem
            // 
            this.présentationToolStripMenuItem.Name = "présentationToolStripMenuItem";
            this.présentationToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.présentationToolStripMenuItem.Text = "Présentation";
            // 
            // contrôlesToolStripMenuItem
            // 
            this.contrôlesToolStripMenuItem.Name = "contrôlesToolStripMenuItem";
            this.contrôlesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.contrôlesToolStripMenuItem.Text = "Contrôles";
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.storeToolStripMenuItem.Text = "Store";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "(inconnu)";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titreDataGridViewTextBoxColumn,
            this.artisteDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.duréeDataGridViewTextBoxColumn,
            this.classementDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.cheminDataGridViewTextBoxColumn,
            this.checksumDataGridViewTextBoxColumn,
            this.Id,
            this.DateAjout,
            this.DateDerniereLecture,
            this.NbLecture});
            this.dataGridView1.DataSource = this.pistesBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(161, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 593);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // pistesBindingSource
            // 
            this.pistesBindingSource.DataMember = "Pistes";
            this.pistesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBarPlay
            // 
            this.trackBarPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBarPlay.AutoSize = false;
            this.trackBarPlay.BackColor = System.Drawing.Color.GhostWhite;
            this.trackBarPlay.Location = new System.Drawing.Point(429, 75);
            this.trackBarPlay.Name = "trackBarPlay";
            this.trackBarPlay.Size = new System.Drawing.Size(350, 25);
            this.trackBarPlay.TabIndex = 3;
            this.trackBarPlay.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPlay.Visible = false;
            this.trackBarPlay.Scroll += new System.EventHandler(this.trackBarPlay_Scroll);
            this.trackBarPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBarPlay_MouseDown);
            this.trackBarPlay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarPlay_MouseUp);
            // 
            // trackBarVol
            // 
            this.trackBarVol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBarVol.AutoSize = false;
            this.trackBarVol.BackColor = System.Drawing.Color.GhostWhite;
            this.trackBarVol.Location = new System.Drawing.Point(880, 36);
            this.trackBarVol.Maximum = 100;
            this.trackBarVol.Name = "trackBarVol";
            this.trackBarVol.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVol.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarVol.RightToLeftLayout = true;
            this.trackBarVol.Size = new System.Drawing.Size(25, 64);
            this.trackBarVol.TabIndex = 4;
            this.trackBarVol.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVol.Value = 20;
            this.trackBarVol.Visible = false;
            // 
            // checkBoxPlay
            // 
            this.checkBoxPlay.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPlay.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPlay.Enabled = false;
            this.checkBoxPlay.FlatAppearance.BorderSize = 0;
            this.checkBoxPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPlay.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxPlay.Image")));
            this.checkBoxPlay.Location = new System.Drawing.Point(77, 43);
            this.checkBoxPlay.Name = "checkBoxPlay";
            this.checkBoxPlay.Size = new System.Drawing.Size(50, 50);
            this.checkBoxPlay.TabIndex = 5;
            this.checkBoxPlay.UseVisualStyleBackColor = false;
            this.checkBoxPlay.CheckedChanged += new System.EventHandler(this.checkBoxPlay_CheckedChanged);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.Transparent;
            this.BtnStop.Enabled = false;
            this.BtnStop.FlatAppearance.BorderSize = 0;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.Image = ((System.Drawing.Image)(resources.GetObject("BtnStop.Image")));
            this.BtnStop.Location = new System.Drawing.Point(146, 43);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(50, 50);
            this.BtnStop.TabIndex = 6;
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // labelAvt
            // 
            this.labelAvt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAvt.AutoSize = true;
            this.labelAvt.BackColor = System.Drawing.Color.GhostWhite;
            this.labelAvt.Location = new System.Drawing.Point(389, 78);
            this.labelAvt.Name = "labelAvt";
            this.labelAvt.Size = new System.Drawing.Size(34, 13);
            this.labelAvt.TabIndex = 7;
            this.labelAvt.Text = "00:00";
            this.labelAvt.Visible = false;
            // 
            // labelAprs
            // 
            this.labelAprs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAprs.AutoSize = true;
            this.labelAprs.BackColor = System.Drawing.Color.GhostWhite;
            this.labelAprs.Location = new System.Drawing.Point(785, 78);
            this.labelAprs.Name = "labelAprs";
            this.labelAprs.Size = new System.Drawing.Size(34, 13);
            this.labelAprs.TabIndex = 8;
            this.labelAprs.Text = "00:00";
            this.labelAprs.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(310, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterDansPlaylist,
            this.editerLesInformationsDeLaPisteToolStripMenuItem,
            this.toolStripSeparator1,
            this.clicDroit_effacer,
            this.effacerLeMorceauEtLeMettreDansLaCorbeilleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(326, 98);
            // 
            // ajouterDansPlaylist
            // 
            this.ajouterDansPlaylist.Name = "ajouterDansPlaylist";
            this.ajouterDansPlaylist.Size = new System.Drawing.Size(325, 22);
            this.ajouterDansPlaylist.Text = "Ajouter dans une Playlist";
            this.ajouterDansPlaylist.Click += new System.EventHandler(this.ajouterDansPlaylist_Click);
            // 
            // editerLesInformationsDeLaPisteToolStripMenuItem
            // 
            this.editerLesInformationsDeLaPisteToolStripMenuItem.Name = "editerLesInformationsDeLaPisteToolStripMenuItem";
            this.editerLesInformationsDeLaPisteToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.editerLesInformationsDeLaPisteToolStripMenuItem.Text = "Editer les informations de la piste";
            this.editerLesInformationsDeLaPisteToolStripMenuItem.Click += new System.EventHandler(this.editerLesInformationsDeLaPisteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(322, 6);
            // 
            // clicDroit_effacer
            // 
            this.clicDroit_effacer.Name = "clicDroit_effacer";
            this.clicDroit_effacer.Size = new System.Drawing.Size(325, 22);
            this.clicDroit_effacer.Text = "Effacer le morceau de la bibliothèque";
            this.clicDroit_effacer.Click += new System.EventHandler(this.clicDroit_effacer_Click);
            // 
            // effacerLeMorceauEtLeMettreDansLaCorbeilleToolStripMenuItem
            // 
            this.effacerLeMorceauEtLeMettreDansLaCorbeilleToolStripMenuItem.Name = "effacerLeMorceauEtLeMettreDansLaCorbeilleToolStripMenuItem";
            this.effacerLeMorceauEtLeMettreDansLaCorbeilleToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.effacerLeMorceauEtLeMettreDansLaCorbeilleToolStripMenuItem.Text = "Effacer le morceau et le mettre dans la Corbeille";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(287, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(634, 90);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // v_lbl_Titre
            // 
            this.v_lbl_Titre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.v_lbl_Titre.BackColor = System.Drawing.Color.GhostWhite;
            this.v_lbl_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_lbl_Titre.Location = new System.Drawing.Point(404, 40);
            this.v_lbl_Titre.Name = "v_lbl_Titre";
            this.v_lbl_Titre.Size = new System.Drawing.Size(400, 18);
            this.v_lbl_Titre.TabIndex = 15;
            this.v_lbl_Titre.Text = "Titre";
            this.v_lbl_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.v_lbl_Titre.Visible = false;
            // 
            // v_lbl_ArtisteEtAlbum
            // 
            this.v_lbl_ArtisteEtAlbum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.v_lbl_ArtisteEtAlbum.BackColor = System.Drawing.Color.GhostWhite;
            this.v_lbl_ArtisteEtAlbum.Location = new System.Drawing.Point(404, 60);
            this.v_lbl_ArtisteEtAlbum.Name = "v_lbl_ArtisteEtAlbum";
            this.v_lbl_ArtisteEtAlbum.Size = new System.Drawing.Size(400, 16);
            this.v_lbl_ArtisteEtAlbum.TabIndex = 16;
            this.v_lbl_ArtisteEtAlbum.Text = "Artiste - Album";
            this.v_lbl_ArtisteEtAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.v_lbl_ArtisteEtAlbum.Visible = false;
            // 
            // v_lbl_NomApp
            // 
            this.v_lbl_NomApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.v_lbl_NomApp.AutoSize = true;
            this.v_lbl_NomApp.BackColor = System.Drawing.Color.GhostWhite;
            this.v_lbl_NomApp.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_lbl_NomApp.Location = new System.Drawing.Point(519, 42);
            this.v_lbl_NomApp.Name = "v_lbl_NomApp";
            this.v_lbl_NomApp.Size = new System.Drawing.Size(0, 49);
            this.v_lbl_NomApp.TabIndex = 17;
            this.v_lbl_NomApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // v_Pochette_Ombre
            // 
            this.v_Pochette_Ombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.v_Pochette_Ombre.BackColor = System.Drawing.Color.GhostWhite;
            this.v_Pochette_Ombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("v_Pochette_Ombre.BackgroundImage")));
            this.v_Pochette_Ombre.Location = new System.Drawing.Point(304, 36);
            this.v_Pochette_Ombre.Name = "v_Pochette_Ombre";
            this.v_Pochette_Ombre.Size = new System.Drawing.Size(70, 64);
            this.v_Pochette_Ombre.TabIndex = 18;
            this.v_Pochette_Ombre.TabStop = false;
            this.v_Pochette_Ombre.Visible = false;
            // 
            // listView_MenusLateraux
            // 
            this.listView_MenusLateraux.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_MenusLateraux.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_MenusLateraux.BackColor = System.Drawing.SystemColors.Control;
            this.listView_MenusLateraux.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_MenusLateraux.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Menus});
            this.listView_MenusLateraux.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listView_MenusLateraux.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_MenusLateraux.FullRowSelect = true;
            listViewGroup1.Header = "Mes Musiques";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "Mes Playlists";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup2.Tag = "";
            this.listView_MenusLateraux.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView_MenusLateraux.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem1.Group = listViewGroup1;
            listViewItem1.IndentCount = 1;
            listViewItem1.Tag = "bibliotheque";
            this.listView_MenusLateraux.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView_MenusLateraux.Location = new System.Drawing.Point(-4, 0);
            this.listView_MenusLateraux.MultiSelect = false;
            this.listView_MenusLateraux.Name = "listView_MenusLateraux";
            this.listView_MenusLateraux.Size = new System.Drawing.Size(170, 1124);
            this.listView_MenusLateraux.TabIndex = 19;
            this.listView_MenusLateraux.UseCompatibleStateImageBehavior = false;
            this.listView_MenusLateraux.View = System.Windows.Forms.View.Details;
            this.listView_MenusLateraux.ItemActivate += new System.EventHandler(this.listView_MenusLateraux_ItemActivate);
            this.listView_MenusLateraux.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MenusLateraux_MouseClick);
            // 
            // Menus
            // 
            this.Menus.Text = "Menus";
            this.Menus.Width = 177;
            // 
            // BtnSuiv
            // 
            this.BtnSuiv.BackColor = System.Drawing.Color.Transparent;
            this.BtnSuiv.Enabled = false;
            this.BtnSuiv.FlatAppearance.BorderSize = 0;
            this.BtnSuiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSuiv.Image = ((System.Drawing.Image)(resources.GetObject("BtnSuiv.Image")));
            this.BtnSuiv.Location = new System.Drawing.Point(212, 43);
            this.BtnSuiv.Name = "BtnSuiv";
            this.BtnSuiv.Size = new System.Drawing.Size(50, 50);
            this.BtnSuiv.TabIndex = 21;
            this.BtnSuiv.UseVisualStyleBackColor = false;
            this.BtnSuiv.Click += new System.EventHandler(this.BtnSuiv_Click);
            // 
            // BtnPrec
            // 
            this.BtnPrec.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrec.Enabled = false;
            this.BtnPrec.FlatAppearance.BorderSize = 0;
            this.BtnPrec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrec.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrec.Image")));
            this.BtnPrec.Location = new System.Drawing.Point(12, 43);
            this.BtnPrec.Name = "BtnPrec";
            this.BtnPrec.Size = new System.Drawing.Size(50, 50);
            this.BtnPrec.TabIndex = 22;
            this.BtnPrec.UseVisualStyleBackColor = false;
            this.BtnPrec.Click += new System.EventHandler(this.BtnPrec_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(1005, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelRecherche
            // 
            this.labelRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecherche.AutoSize = true;
            this.labelRecherche.BackColor = System.Drawing.Color.Transparent;
            this.labelRecherche.Location = new System.Drawing.Point(936, 62);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(63, 13);
            this.labelRecherche.TabIndex = 27;
            this.labelRecherche.Text = "Recherche:";
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 114);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1209, 615);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.listView_MenusLateraux);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1201, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Normal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.LabelArtiste);
            this.tabPage2.Controls.Add(this.LabelAlbum);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.trackBarAlbums);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1201, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Par Album";
            // 
            // LabelArtiste
            // 
            this.LabelArtiste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelArtiste.AutoSize = true;
            this.LabelArtiste.BackColor = System.Drawing.Color.Transparent;
            this.LabelArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelArtiste.Location = new System.Drawing.Point(711, 96);
            this.LabelArtiste.Name = "LabelArtiste";
            this.LabelArtiste.Size = new System.Drawing.Size(67, 20);
            this.LabelArtiste.TabIndex = 31;
            this.LabelArtiste.Text = "Artiste:";
            this.LabelArtiste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAlbum
            // 
            this.LabelAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelAlbum.AutoSize = true;
            this.LabelAlbum.BackColor = System.Drawing.Color.Transparent;
            this.LabelAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlbum.Location = new System.Drawing.Point(711, 56);
            this.LabelAlbum.Name = "LabelAlbum";
            this.LabelAlbum.Size = new System.Drawing.Size(64, 20);
            this.LabelAlbum.TabIndex = 30;
            this.LabelAlbum.Text = "Album:";
            this.LabelAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dataGridView2.AllowDrop = true;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = "(inconnu)";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titreDataGridViewTextBoxColumn1,
            this.artisteDataGridViewTextBoxColumn1,
            this.albumDataGridViewTextBoxColumn1,
            this.duréeDataGridViewTextBoxColumn1,
            this.classementDataGridViewTextBoxColumn1,
            this.genreDataGridViewTextBoxColumn1,
            this.cheminDataGridViewTextBoxColumn1,
            this.checksumDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.pistesBindingSource1;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(8, 247);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1193, 342);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            this.dataGridView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            // 
            // titreDataGridViewTextBoxColumn1
            // 
            this.titreDataGridViewTextBoxColumn1.DataPropertyName = "Titre";
            this.titreDataGridViewTextBoxColumn1.HeaderText = "Titre";
            this.titreDataGridViewTextBoxColumn1.Name = "titreDataGridViewTextBoxColumn1";
            this.titreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // artisteDataGridViewTextBoxColumn1
            // 
            this.artisteDataGridViewTextBoxColumn1.DataPropertyName = "Artiste";
            this.artisteDataGridViewTextBoxColumn1.HeaderText = "Artiste";
            this.artisteDataGridViewTextBoxColumn1.Name = "artisteDataGridViewTextBoxColumn1";
            this.artisteDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // albumDataGridViewTextBoxColumn1
            // 
            this.albumDataGridViewTextBoxColumn1.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn1.HeaderText = "Album";
            this.albumDataGridViewTextBoxColumn1.Name = "albumDataGridViewTextBoxColumn1";
            this.albumDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // duréeDataGridViewTextBoxColumn1
            // 
            this.duréeDataGridViewTextBoxColumn1.DataPropertyName = "Durée";
            this.duréeDataGridViewTextBoxColumn1.HeaderText = "Durée";
            this.duréeDataGridViewTextBoxColumn1.Name = "duréeDataGridViewTextBoxColumn1";
            this.duréeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // classementDataGridViewTextBoxColumn1
            // 
            this.classementDataGridViewTextBoxColumn1.DataPropertyName = "Classement";
            this.classementDataGridViewTextBoxColumn1.HeaderText = "Classement";
            this.classementDataGridViewTextBoxColumn1.Name = "classementDataGridViewTextBoxColumn1";
            this.classementDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn1
            // 
            this.genreDataGridViewTextBoxColumn1.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn1.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn1.Name = "genreDataGridViewTextBoxColumn1";
            this.genreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cheminDataGridViewTextBoxColumn1
            // 
            this.cheminDataGridViewTextBoxColumn1.DataPropertyName = "Chemin";
            this.cheminDataGridViewTextBoxColumn1.HeaderText = "Chemin";
            this.cheminDataGridViewTextBoxColumn1.Name = "cheminDataGridViewTextBoxColumn1";
            this.cheminDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cheminDataGridViewTextBoxColumn1.Visible = false;
            // 
            // checksumDataGridViewTextBoxColumn1
            // 
            this.checksumDataGridViewTextBoxColumn1.DataPropertyName = "Checksum";
            this.checksumDataGridViewTextBoxColumn1.HeaderText = "Checksum";
            this.checksumDataGridViewTextBoxColumn1.Name = "checksumDataGridViewTextBoxColumn1";
            this.checksumDataGridViewTextBoxColumn1.ReadOnly = true;
            this.checksumDataGridViewTextBoxColumn1.Visible = false;
            // 
            // pistesBindingSource1
            // 
            this.pistesBindingSource1.DataMember = "Pistes";
            this.pistesBindingSource1.DataSource = this.dataSet1;
            this.pistesBindingSource1.Filter = "";
            // 
            // trackBarAlbums
            // 
            this.trackBarAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarAlbums.Location = new System.Drawing.Point(-4, 196);
            this.trackBarAlbums.Maximum = 1;
            this.trackBarAlbums.Name = "trackBarAlbums";
            this.trackBarAlbums.Size = new System.Drawing.Size(1201, 45);
            this.trackBarAlbums.TabIndex = 3;
            this.trackBarAlbums.Scroll += new System.EventHandler(this.trackBarAlbums_Scroll);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Location = new System.Drawing.Point(519, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(163, 163);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 163);
            this.panel1.TabIndex = 32;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel2_DragEnter);
            // 
            // pistesLectureBindingSource
            // 
            this.pistesLectureBindingSource.DataMember = "PistesLecture";
            this.pistesLectureBindingSource.DataSource = this.dataSet1;
            // 
            // OpenBrowserButton
            // 
            this.OpenBrowserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenBrowserButton.Location = new System.Drawing.Point(1005, 27);
            this.OpenBrowserButton.Name = "OpenBrowserButton";
            this.OpenBrowserButton.Size = new System.Drawing.Size(100, 23);
            this.OpenBrowserButton.TabIndex = 31;
            this.OpenBrowserButton.Text = "Browser";
            this.OpenBrowserButton.UseVisualStyleBackColor = true;
            this.OpenBrowserButton.Click += new System.EventHandler(this.OpenBrowserButton_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerLaPlaylistToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(191, 26);
            // 
            // supprimerLaPlaylistToolStripMenuItem
            // 
            this.supprimerLaPlaylistToolStripMenuItem.Name = "supprimerLaPlaylistToolStripMenuItem";
            this.supprimerLaPlaylistToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.supprimerLaPlaylistToolStripMenuItem.Text = "Supprimer la Playlist...";
            this.supprimerLaPlaylistToolStripMenuItem.Click += new System.EventHandler(this.supprimerLaPlaylistToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(936, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 32;
            // 
            // titreDataGridViewTextBoxColumn
            // 
            this.titreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titreDataGridViewTextBoxColumn.DataPropertyName = "Titre";
            this.titreDataGridViewTextBoxColumn.HeaderText = "Titre";
            this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            this.titreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artisteDataGridViewTextBoxColumn
            // 
            this.artisteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.artisteDataGridViewTextBoxColumn.DataPropertyName = "Artiste";
            this.artisteDataGridViewTextBoxColumn.HeaderText = "Artiste";
            this.artisteDataGridViewTextBoxColumn.Name = "artisteDataGridViewTextBoxColumn";
            this.artisteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn.HeaderText = "Album";
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            this.albumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duréeDataGridViewTextBoxColumn
            // 
            this.duréeDataGridViewTextBoxColumn.DataPropertyName = "Durée";
            this.duréeDataGridViewTextBoxColumn.HeaderText = "Durée";
            this.duréeDataGridViewTextBoxColumn.Name = "duréeDataGridViewTextBoxColumn";
            this.duréeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classementDataGridViewTextBoxColumn
            // 
            this.classementDataGridViewTextBoxColumn.DataPropertyName = "Classement";
            this.classementDataGridViewTextBoxColumn.DropDownWidth = 5;
            this.classementDataGridViewTextBoxColumn.HeaderText = "Classement";
            this.classementDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.classementDataGridViewTextBoxColumn.Name = "classementDataGridViewTextBoxColumn";
            this.classementDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.classementDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cheminDataGridViewTextBoxColumn
            // 
            this.cheminDataGridViewTextBoxColumn.DataPropertyName = "Chemin";
            this.cheminDataGridViewTextBoxColumn.HeaderText = "Chemin";
            this.cheminDataGridViewTextBoxColumn.Name = "cheminDataGridViewTextBoxColumn";
            this.cheminDataGridViewTextBoxColumn.Visible = false;
            // 
            // checksumDataGridViewTextBoxColumn
            // 
            this.checksumDataGridViewTextBoxColumn.DataPropertyName = "Checksum";
            this.checksumDataGridViewTextBoxColumn.HeaderText = "Checksum";
            this.checksumDataGridViewTextBoxColumn.Name = "checksumDataGridViewTextBoxColumn";
            this.checksumDataGridViewTextBoxColumn.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // DateAjout
            // 
            this.DateAjout.DataPropertyName = "DateAjout";
            this.DateAjout.HeaderText = "Date d\'ajout";
            this.DateAjout.Name = "DateAjout";
            this.DateAjout.ReadOnly = true;
            this.DateAjout.Width = 150;
            // 
            // DateDerniereLecture
            // 
            this.DateDerniereLecture.DataPropertyName = "DateDerniereLecture";
            this.DateDerniereLecture.HeaderText = "Date de Dernière lecture";
            this.DateDerniereLecture.Name = "DateDerniereLecture";
            this.DateDerniereLecture.ReadOnly = true;
            this.DateDerniereLecture.Width = 150;
            // 
            // NbLecture
            // 
            this.NbLecture.DataPropertyName = "NbLecture";
            this.NbLecture.HeaderText = "Lecture(s)";
            this.NbLecture.Name = "NbLecture";
            this.NbLecture.ReadOnly = true;
            this.NbLecture.ToolTipText = "Affiche le nombre de lecture(s) du morceau.";
            this.NbLecture.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1209, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenBrowserButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelRecherche);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnPrec);
            this.Controls.Add(this.BtnSuiv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.v_Pochette_Ombre);
            this.Controls.Add(this.v_lbl_NomApp);
            this.Controls.Add(this.v_lbl_ArtisteEtAlbum);
            this.Controls.Add(this.v_lbl_Titre);
            this.Controls.Add(this.trackBarPlay);
            this.Controls.Add(this.labelAprs);
            this.Controls.Add(this.labelAvt);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.checkBoxPlay);
            this.Controls.Add(this.trackBarVol);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.Text = "MyTunes";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Pochette_Ombre)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistesLectureBindingSource)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDeLectureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterLeFichierÀLaBibliothèqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterLeDossierÀLaBibliothèqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem présentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrôlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pistesBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBarPlay;
        private System.Windows.Forms.TrackBar trackBarVol;
        private System.Windows.Forms.CheckBox checkBoxPlay;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Label labelAvt;
        private System.Windows.Forms.Label labelAprs;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clicDroit_effacer;
        private System.Windows.Forms.ToolStripMenuItem effacerLeMorceauEtLeMettreDansLaCorbeilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerLesInformationsDeLaPisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label v_lbl_Titre;
        private System.Windows.Forms.Label v_lbl_ArtisteEtAlbum;
        private System.Windows.Forms.Label v_lbl_NomApp;
        private System.Windows.Forms.PictureBox v_Pochette_Ombre;
        private System.Windows.Forms.ListView listView_MenusLateraux;
        private System.Windows.Forms.ColumnHeader Menus;
        private System.Windows.Forms.Button BtnSuiv;
        private System.Windows.Forms.Button BtnPrec;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelRecherche;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TrackBar trackBarAlbums;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label LabelAlbum;
        private System.Windows.Forms.BindingSource pistesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artisteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn duréeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classementDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheminDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn checksumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem ajouterDansPlaylist;
        private System.Windows.Forms.BindingSource pistesLectureBindingSource;
        private System.Windows.Forms.Button OpenBrowserButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem supprimerLaPlaylistToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelArtiste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duréeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn classementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checksumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAjout;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDerniereLecture;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbLecture;
    }
}

