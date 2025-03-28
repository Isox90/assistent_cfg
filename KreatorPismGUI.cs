namespace KreatorPismGUI
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCreator = new System.Windows.Forms.TabPage();
            this.tabPageScheme = new System.Windows.Forms.TabPage();
            this.dataGridViewL1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewR1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBoxL1 = new System.Windows.Forms.TextBox();
            this.searchBoxR1 = new System.Windows.Forms.TextBox();
            this.tabPageComponent = new System.Windows.Forms.TabPage();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonGenerateFull = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tresc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelName1 = new System.Windows.Forms.Label();
            this.labelVersion1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchBoxL2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewL2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBoxL3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewL3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.axAcroPDF2 = new AxAcroPDFLib.AxAcroPDF();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonLoadView1 = new System.Windows.Forms.Button();
            this.labelVersion2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonLoadView2 = new System.Windows.Forms.Button();
            this.labelVersion3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelName3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonCreateVersionComp = new System.Windows.Forms.Button();
            this.buttonCreateComp = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageCreator.SuspendLayout();
            this.tabPageScheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR1)).BeginInit();
            this.tabPageComponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageCreator);
            this.tabControl.Controls.Add(this.tabPageScheme);
            this.tabControl.Controls.Add(this.tabPageComponent);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1240, 657);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageCreator
            // 
            this.tabPageCreator.Controls.Add(this.buttonSettings);
            this.tabPageCreator.Controls.Add(this.labelVersion1);
            this.tabPageCreator.Controls.Add(this.label6);
            this.tabPageCreator.Controls.Add(this.labelName1);
            this.tabPageCreator.Controls.Add(this.label3);
            this.tabPageCreator.Controls.Add(this.buttonDown);
            this.tabPageCreator.Controls.Add(this.buttonUp);
            this.tabPageCreator.Controls.Add(this.buttonGenerateFull);
            this.tabPageCreator.Controls.Add(this.buttonGenerate);
            this.tabPageCreator.Controls.Add(this.buttonSave);
            this.tabPageCreator.Controls.Add(this.buttonLoad);
            this.tabPageCreator.Controls.Add(this.searchBoxR1);
            this.tabPageCreator.Controls.Add(this.searchBoxL1);
            this.tabPageCreator.Controls.Add(this.label2);
            this.tabPageCreator.Controls.Add(this.label1);
            this.tabPageCreator.Controls.Add(this.buttonRemove);
            this.tabPageCreator.Controls.Add(this.buttonAdd);
            this.tabPageCreator.Controls.Add(this.dataGridViewR1);
            this.tabPageCreator.Controls.Add(this.dataGridViewL1);
            this.tabPageCreator.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreator.Name = "tabPageCreator";
            this.tabPageCreator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreator.Size = new System.Drawing.Size(1232, 631);
            this.tabPageCreator.TabIndex = 0;
            this.tabPageCreator.Text = "Kreator";
            this.tabPageCreator.UseVisualStyleBackColor = true;
            // 
            // tabPageScheme
            // 
            this.tabPageScheme.Controls.Add(this.buttonLoadView1);
            this.tabPageScheme.Controls.Add(this.labelVersion2);
            this.tabPageScheme.Controls.Add(this.label12);
            this.tabPageScheme.Controls.Add(this.labelName2);
            this.tabPageScheme.Controls.Add(this.label14);
            this.tabPageScheme.Controls.Add(this.label9);
            this.tabPageScheme.Controls.Add(this.axAcroPDF1);
            this.tabPageScheme.Controls.Add(this.searchBoxL2);
            this.tabPageScheme.Controls.Add(this.label7);
            this.tabPageScheme.Controls.Add(this.dataGridViewL2);
            this.tabPageScheme.Location = new System.Drawing.Point(4, 22);
            this.tabPageScheme.Name = "tabPageScheme";
            this.tabPageScheme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScheme.Size = new System.Drawing.Size(1232, 631);
            this.tabPageScheme.TabIndex = 1;
            this.tabPageScheme.Text = "Szablony";
            this.tabPageScheme.UseVisualStyleBackColor = true;
            // 
            // dataGridViewL1
            // 
            this.dataGridViewL1.AllowUserToAddRows = false;
            this.dataGridViewL1.AllowUserToDeleteRows = false;
            this.dataGridViewL1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewL1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.Opis,
            this.Tresc});
            this.dataGridViewL1.Location = new System.Drawing.Point(6, 28);
            this.dataGridViewL1.Name = "dataGridViewL1";
            this.dataGridViewL1.ReadOnly = true;
            this.dataGridViewL1.Size = new System.Drawing.Size(520, 597);
            this.dataGridViewL1.TabIndex = 0;
            // 
            // dataGridViewR1
            // 
            this.dataGridViewR1.AllowUserToAddRows = false;
            this.dataGridViewR1.AllowUserToDeleteRows = false;
            this.dataGridViewR1.AllowUserToOrderColumns = true;
            this.dataGridViewR1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewR1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewR1.Location = new System.Drawing.Point(706, 28);
            this.dataGridViewR1.Name = "dataGridViewR1";
            this.dataGridViewR1.ReadOnly = true;
            this.dataGridViewR1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewR1.Size = new System.Drawing.Size(520, 597);
            this.dataGridViewR1.TabIndex = 1;
            this.dataGridViewR1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(553, 150);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "<----- Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(553, 179);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(126, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Usuń ----->";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nowy szablon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Komponenty";
            // 
            // searchBoxL1
            // 
            this.searchBoxL1.Location = new System.Drawing.Point(149, 6);
            this.searchBoxL1.Name = "searchBoxL1";
            this.searchBoxL1.Size = new System.Drawing.Size(377, 20);
            this.searchBoxL1.TabIndex = 6;
            // 
            // searchBoxR1
            // 
            this.searchBoxR1.Location = new System.Drawing.Point(849, 6);
            this.searchBoxR1.Name = "searchBoxR1";
            this.searchBoxR1.Size = new System.Drawing.Size(377, 20);
            this.searchBoxR1.TabIndex = 7;
            // 
            // tabPageComponent
            // 
            this.tabPageComponent.Controls.Add(this.buttonCreateVersionComp);
            this.tabPageComponent.Controls.Add(this.buttonCreateComp);
            this.tabPageComponent.Controls.Add(this.buttonLoadView2);
            this.tabPageComponent.Controls.Add(this.labelVersion3);
            this.tabPageComponent.Controls.Add(this.label16);
            this.tabPageComponent.Controls.Add(this.labelName3);
            this.tabPageComponent.Controls.Add(this.label18);
            this.tabPageComponent.Controls.Add(this.label10);
            this.tabPageComponent.Controls.Add(this.axAcroPDF2);
            this.tabPageComponent.Controls.Add(this.searchBoxL3);
            this.tabPageComponent.Controls.Add(this.label8);
            this.tabPageComponent.Controls.Add(this.dataGridViewL3);
            this.tabPageComponent.Location = new System.Drawing.Point(4, 22);
            this.tabPageComponent.Name = "tabPageComponent";
            this.tabPageComponent.Size = new System.Drawing.Size(1232, 631);
            this.tabPageComponent.TabIndex = 2;
            this.tabPageComponent.Text = "Komponenty";
            this.tabPageComponent.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(553, 500);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(126, 23);
            this.buttonLoad.TabIndex = 8;
            this.buttonLoad.Text = "Wczytaj szablon";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(553, 529);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(126, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Zapisz szablon";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(553, 558);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(126, 23);
            this.buttonGenerate.TabIndex = 10;
            this.buttonGenerate.Text = "Wygeneruj podgląd";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateFull
            // 
            this.buttonGenerateFull.Location = new System.Drawing.Point(553, 587);
            this.buttonGenerateFull.Name = "buttonGenerateFull";
            this.buttonGenerateFull.Size = new System.Drawing.Size(126, 23);
            this.buttonGenerateFull.TabIndex = 11;
            this.buttonGenerateFull.Text = "Wygeneruj pisma";
            this.buttonGenerateFull.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Treść";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 235;
            // 
            // Nazwa
            // 
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 140;
            // 
            // Tresc
            // 
            this.Tresc.HeaderText = "Treść";
            this.Tresc.Name = "Tresc";
            this.Tresc.ReadOnly = true;
            this.Tresc.Width = 235;
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(553, 254);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(126, 23);
            this.buttonDown.TabIndex = 13;
            this.buttonDown.Text = "▼     Przesuń w dół";
            this.buttonDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDown.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(553, 225);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(126, 23);
            this.buttonUp.TabIndex = 12;
            this.buttonUp.Text = "▲    Przesuń w górę";
            this.buttonUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nazwa:";
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Location = new System.Drawing.Point(557, 363);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(73, 13);
            this.labelName1.TabIndex = 15;
            this.labelName1.Text = "Nowy szablon";
            // 
            // labelVersion1
            // 
            this.labelVersion1.AutoSize = true;
            this.labelVersion1.Location = new System.Drawing.Point(557, 410);
            this.labelVersion1.Name = "labelVersion1";
            this.labelVersion1.Size = new System.Drawing.Size(68, 13);
            this.labelVersion1.TabIndex = 17;
            this.labelVersion1.Text = "Nowa wersja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Wersja:";
            // 
            // searchBoxL2
            // 
            this.searchBoxL2.Location = new System.Drawing.Point(149, 6);
            this.searchBoxL2.Name = "searchBoxL2";
            this.searchBoxL2.Size = new System.Drawing.Size(377, 20);
            this.searchBoxL2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Szablony";
            // 
            // dataGridViewL2
            // 
            this.dataGridViewL2.AllowUserToAddRows = false;
            this.dataGridViewL2.AllowUserToDeleteRows = false;
            this.dataGridViewL2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewL2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewL2.Location = new System.Drawing.Point(6, 28);
            this.dataGridViewL2.Name = "dataGridViewL2";
            this.dataGridViewL2.ReadOnly = true;
            this.dataGridViewL2.Size = new System.Drawing.Size(520, 597);
            this.dataGridViewL2.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Treść";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 235;
            // 
            // searchBoxL3
            // 
            this.searchBoxL3.Location = new System.Drawing.Point(149, 6);
            this.searchBoxL3.Name = "searchBoxL3";
            this.searchBoxL3.Size = new System.Drawing.Size(377, 20);
            this.searchBoxL3.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Komponenty";
            // 
            // dataGridViewL3
            // 
            this.dataGridViewL3.AllowUserToAddRows = false;
            this.dataGridViewL3.AllowUserToDeleteRows = false;
            this.dataGridViewL3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewL3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridViewL3.Location = new System.Drawing.Point(6, 28);
            this.dataGridViewL3.Name = "dataGridViewL3";
            this.dataGridViewL3.ReadOnly = true;
            this.dataGridViewL3.Size = new System.Drawing.Size(520, 597);
            this.dataGridViewL3.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 140;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Treść";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 235;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(706, 28);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(520, 597);
            this.axAcroPDF1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(706, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Podgląd";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(706, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Podgląd";
            // 
            // axAcroPDF2
            // 
            this.axAcroPDF2.Enabled = true;
            this.axAcroPDF2.Location = new System.Drawing.Point(706, 28);
            this.axAcroPDF2.Name = "axAcroPDF2";
            this.axAcroPDF2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF2.OcxState")));
            this.axAcroPDF2.Size = new System.Drawing.Size(520, 597);
            this.axAcroPDF2.TabIndex = 12;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(553, 297);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(126, 23);
            this.buttonSettings.TabIndex = 18;
            this.buttonSettings.Text = "Ustawienia elementu";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonLoadView1
            // 
            this.buttonLoadView1.Location = new System.Drawing.Point(553, 297);
            this.buttonLoadView1.Name = "buttonLoadView1";
            this.buttonLoadView1.Size = new System.Drawing.Size(126, 23);
            this.buttonLoadView1.TabIndex = 23;
            this.buttonLoadView1.Text = "Wczytaj podgląd";
            this.buttonLoadView1.UseVisualStyleBackColor = true;
            // 
            // labelVersion2
            // 
            this.labelVersion2.AutoSize = true;
            this.labelVersion2.Location = new System.Drawing.Point(557, 410);
            this.labelVersion2.Name = "labelVersion2";
            this.labelVersion2.Size = new System.Drawing.Size(68, 13);
            this.labelVersion2.TabIndex = 22;
            this.labelVersion2.Text = "Nowa wersja";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(557, 391);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Wersja:";
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Location = new System.Drawing.Point(557, 363);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(73, 13);
            this.labelName2.TabIndex = 20;
            this.labelName2.Text = "Nowy szablon";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(557, 344);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Nazwa:";
            // 
            // buttonLoadView2
            // 
            this.buttonLoadView2.Location = new System.Drawing.Point(553, 297);
            this.buttonLoadView2.Name = "buttonLoadView2";
            this.buttonLoadView2.Size = new System.Drawing.Size(126, 23);
            this.buttonLoadView2.TabIndex = 28;
            this.buttonLoadView2.Text = "Wczytaj podgląd";
            this.buttonLoadView2.UseVisualStyleBackColor = true;
            // 
            // labelVersion3
            // 
            this.labelVersion3.AutoSize = true;
            this.labelVersion3.Location = new System.Drawing.Point(557, 410);
            this.labelVersion3.Name = "labelVersion3";
            this.labelVersion3.Size = new System.Drawing.Size(68, 13);
            this.labelVersion3.TabIndex = 27;
            this.labelVersion3.Text = "Nowa wersja";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(557, 391);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Wersja:";
            // 
            // labelName3
            // 
            this.labelName3.AutoSize = true;
            this.labelName3.Location = new System.Drawing.Point(557, 363);
            this.labelName3.Name = "labelName3";
            this.labelName3.Size = new System.Drawing.Size(73, 13);
            this.labelName3.TabIndex = 25;
            this.labelName3.Text = "Nowy szablon";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(557, 344);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Nazwa:";
            // 
            // buttonCreateVersionComp
            // 
            this.buttonCreateVersionComp.Location = new System.Drawing.Point(553, 587);
            this.buttonCreateVersionComp.Name = "buttonCreateVersionComp";
            this.buttonCreateVersionComp.Size = new System.Drawing.Size(126, 23);
            this.buttonCreateVersionComp.TabIndex = 30;
            this.buttonCreateVersionComp.Text = "Stwórz nową wersję";
            this.buttonCreateVersionComp.UseVisualStyleBackColor = true;
            // 
            // buttonCreateComp
            // 
            this.buttonCreateComp.Location = new System.Drawing.Point(553, 558);
            this.buttonCreateComp.Name = "buttonCreateComp";
            this.buttonCreateComp.Size = new System.Drawing.Size(126, 23);
            this.buttonCreateComp.TabIndex = 29;
            this.buttonCreateComp.Text = "Stwórz komponent";
            this.buttonCreateComp.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl);
            this.Name = "FormMain";
            this.Text = "Kreator pism";
            this.tabControl.ResumeLayout(false);
            this.tabPageCreator.ResumeLayout(false);
            this.tabPageCreator.PerformLayout();
            this.tabPageScheme.ResumeLayout(false);
            this.tabPageScheme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR1)).EndInit();
            this.tabPageComponent.ResumeLayout(false);
            this.tabPageComponent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCreator;
        private System.Windows.Forms.TabPage tabPageScheme;
        private System.Windows.Forms.DataGridView dataGridViewL1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewR1;
        private System.Windows.Forms.TextBox searchBoxR1;
        private System.Windows.Forms.TextBox searchBoxL1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageComponent;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonGenerateFull;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tresc;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Label labelVersion1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBoxL2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewL2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox searchBoxL3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewL3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label9;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Label label10;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF2;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonLoadView1;
        private System.Windows.Forms.Label labelVersion2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonLoadView2;
        private System.Windows.Forms.Label labelVersion3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelName3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonCreateVersionComp;
        private System.Windows.Forms.Button buttonCreateComp;
    }
}

