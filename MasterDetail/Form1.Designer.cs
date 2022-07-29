
namespace MasterDetail
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.pLinqInstantFeedbackSource1 = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coladr_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_IdObiektu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_TypAdresu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_Nazwa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_NazwaPelna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_Faks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_Ulica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_NrDomu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_NrLokalu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_Adres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_Kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_Miejscowosc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_IdWojewodztwo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_IdPanstwo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_NIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_Poczta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_Gmina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_Powiat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_Skrytka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_Symbol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_IdGminy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_IdWersja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_IdZmienil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_DataZmiany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_NrUrzeduSkarbowego = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_NrEORI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdrEmails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardView1
            // 
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.pLinqInstantFeedbackSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            gridLevelNode1.LevelTemplate = this.cardView1;
            gridLevelNode1.RelationName = "FK_adr_Email_adr__Ewid";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 403);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.cardView1});
            // 
            // pLinqInstantFeedbackSource1
            // 
            this.pLinqInstantFeedbackSource1.DefaultSorting = "adr_Id ASC";
            this.pLinqInstantFeedbackSource1.DesignTimeElementType = typeof(MasterDetail.Folder.AdrEwid);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coladr_Id,
            this.coladr_IdObiektu,
            this.coladr_TypAdresu,
            this.coladr_Nazwa,
            this.coladr_NazwaPelna,
            this.coladr_Telefon,
            this.coladr_Faks,
            this.coladr_Ulica,
            this.coladr_NrDomu,
            this.coladr_NrLokalu,
            this.coladr_Adres,
            this.coladr_Kod,
            this.coladr_Miejscowosc,
            this.coladr_IdWojewodztwo,
            this.coladr_IdPanstwo,
            this.coladr_NIP,
            this.coladr_Poczta,
            this.coladr_Gmina,
            this.coladr_Powiat,
            this.coladr_Skrytka,
            this.coladr_Symbol,
            this.coladr_IdGminy,
            this.coladr_IdWersja,
            this.coladr_IdZmienil,
            this.coladr_DataZmiany,
            this.coladr_NrUrzeduSkarbowego,
            this.coladr_NrEORI,
            this.colAdrEmails});
            this.gridView1.DefaultRelationIndex = 2;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
            // 
            // coladr_Id
            // 
            this.coladr_Id.FieldName = "adr_Id";
            this.coladr_Id.MinWidth = 25;
            this.coladr_Id.Name = "coladr_Id";
            this.coladr_Id.Visible = true;
            this.coladr_Id.VisibleIndex = 0;
            this.coladr_Id.Width = 94;
            // 
            // coladr_IdObiektu
            // 
            this.coladr_IdObiektu.FieldName = "adr_IdObiektu";
            this.coladr_IdObiektu.MinWidth = 25;
            this.coladr_IdObiektu.Name = "coladr_IdObiektu";
            this.coladr_IdObiektu.Visible = true;
            this.coladr_IdObiektu.VisibleIndex = 1;
            this.coladr_IdObiektu.Width = 94;
            // 
            // coladr_TypAdresu
            // 
            this.coladr_TypAdresu.FieldName = "adr_TypAdresu";
            this.coladr_TypAdresu.MinWidth = 25;
            this.coladr_TypAdresu.Name = "coladr_TypAdresu";
            this.coladr_TypAdresu.Visible = true;
            this.coladr_TypAdresu.VisibleIndex = 2;
            this.coladr_TypAdresu.Width = 94;
            // 
            // coladr_Nazwa
            // 
            this.coladr_Nazwa.FieldName = "adr_Nazwa";
            this.coladr_Nazwa.MinWidth = 25;
            this.coladr_Nazwa.Name = "coladr_Nazwa";
            this.coladr_Nazwa.Visible = true;
            this.coladr_Nazwa.VisibleIndex = 3;
            this.coladr_Nazwa.Width = 94;
            // 
            // coladr_NazwaPelna
            // 
            this.coladr_NazwaPelna.FieldName = "adr_NazwaPelna";
            this.coladr_NazwaPelna.MinWidth = 25;
            this.coladr_NazwaPelna.Name = "coladr_NazwaPelna";
            this.coladr_NazwaPelna.Visible = true;
            this.coladr_NazwaPelna.VisibleIndex = 4;
            this.coladr_NazwaPelna.Width = 94;
            // 
            // coladr_Telefon
            // 
            this.coladr_Telefon.FieldName = "adr_Telefon";
            this.coladr_Telefon.MinWidth = 25;
            this.coladr_Telefon.Name = "coladr_Telefon";
            this.coladr_Telefon.Visible = true;
            this.coladr_Telefon.VisibleIndex = 5;
            this.coladr_Telefon.Width = 94;
            // 
            // coladr_Faks
            // 
            this.coladr_Faks.FieldName = "adr_Faks";
            this.coladr_Faks.MinWidth = 25;
            this.coladr_Faks.Name = "coladr_Faks";
            this.coladr_Faks.Visible = true;
            this.coladr_Faks.VisibleIndex = 6;
            this.coladr_Faks.Width = 94;
            // 
            // coladr_Ulica
            // 
            this.coladr_Ulica.FieldName = "adr_Ulica";
            this.coladr_Ulica.MinWidth = 25;
            this.coladr_Ulica.Name = "coladr_Ulica";
            this.coladr_Ulica.Visible = true;
            this.coladr_Ulica.VisibleIndex = 7;
            this.coladr_Ulica.Width = 94;
            // 
            // coladr_NrDomu
            // 
            this.coladr_NrDomu.FieldName = "adr_NrDomu";
            this.coladr_NrDomu.MinWidth = 25;
            this.coladr_NrDomu.Name = "coladr_NrDomu";
            this.coladr_NrDomu.Visible = true;
            this.coladr_NrDomu.VisibleIndex = 8;
            this.coladr_NrDomu.Width = 94;
            // 
            // coladr_NrLokalu
            // 
            this.coladr_NrLokalu.FieldName = "adr_NrLokalu";
            this.coladr_NrLokalu.MinWidth = 25;
            this.coladr_NrLokalu.Name = "coladr_NrLokalu";
            this.coladr_NrLokalu.Visible = true;
            this.coladr_NrLokalu.VisibleIndex = 9;
            this.coladr_NrLokalu.Width = 94;
            // 
            // coladr_Adres
            // 
            this.coladr_Adres.FieldName = "adr_Adres";
            this.coladr_Adres.MinWidth = 25;
            this.coladr_Adres.Name = "coladr_Adres";
            this.coladr_Adres.Visible = true;
            this.coladr_Adres.VisibleIndex = 10;
            this.coladr_Adres.Width = 94;
            // 
            // coladr_Kod
            // 
            this.coladr_Kod.FieldName = "adr_Kod";
            this.coladr_Kod.MinWidth = 25;
            this.coladr_Kod.Name = "coladr_Kod";
            this.coladr_Kod.Visible = true;
            this.coladr_Kod.VisibleIndex = 11;
            this.coladr_Kod.Width = 94;
            // 
            // coladr_Miejscowosc
            // 
            this.coladr_Miejscowosc.FieldName = "adr_Miejscowosc";
            this.coladr_Miejscowosc.MinWidth = 25;
            this.coladr_Miejscowosc.Name = "coladr_Miejscowosc";
            this.coladr_Miejscowosc.Visible = true;
            this.coladr_Miejscowosc.VisibleIndex = 12;
            this.coladr_Miejscowosc.Width = 94;
            // 
            // coladr_IdWojewodztwo
            // 
            this.coladr_IdWojewodztwo.FieldName = "adr_IdWojewodztwo";
            this.coladr_IdWojewodztwo.MinWidth = 25;
            this.coladr_IdWojewodztwo.Name = "coladr_IdWojewodztwo";
            this.coladr_IdWojewodztwo.Visible = true;
            this.coladr_IdWojewodztwo.VisibleIndex = 13;
            this.coladr_IdWojewodztwo.Width = 94;
            // 
            // coladr_IdPanstwo
            // 
            this.coladr_IdPanstwo.FieldName = "adr_IdPanstwo";
            this.coladr_IdPanstwo.MinWidth = 25;
            this.coladr_IdPanstwo.Name = "coladr_IdPanstwo";
            this.coladr_IdPanstwo.Visible = true;
            this.coladr_IdPanstwo.VisibleIndex = 14;
            this.coladr_IdPanstwo.Width = 94;
            // 
            // coladr_NIP
            // 
            this.coladr_NIP.FieldName = "adr_NIP";
            this.coladr_NIP.MinWidth = 25;
            this.coladr_NIP.Name = "coladr_NIP";
            this.coladr_NIP.Visible = true;
            this.coladr_NIP.VisibleIndex = 15;
            this.coladr_NIP.Width = 94;
            // 
            // coladr_Poczta
            // 
            this.coladr_Poczta.FieldName = "adr_Poczta";
            this.coladr_Poczta.MinWidth = 25;
            this.coladr_Poczta.Name = "coladr_Poczta";
            this.coladr_Poczta.Visible = true;
            this.coladr_Poczta.VisibleIndex = 16;
            this.coladr_Poczta.Width = 94;
            // 
            // coladr_Gmina
            // 
            this.coladr_Gmina.FieldName = "adr_Gmina";
            this.coladr_Gmina.MinWidth = 25;
            this.coladr_Gmina.Name = "coladr_Gmina";
            this.coladr_Gmina.Visible = true;
            this.coladr_Gmina.VisibleIndex = 17;
            this.coladr_Gmina.Width = 94;
            // 
            // coladr_Powiat
            // 
            this.coladr_Powiat.FieldName = "adr_Powiat";
            this.coladr_Powiat.MinWidth = 25;
            this.coladr_Powiat.Name = "coladr_Powiat";
            this.coladr_Powiat.Visible = true;
            this.coladr_Powiat.VisibleIndex = 18;
            this.coladr_Powiat.Width = 94;
            // 
            // coladr_Skrytka
            // 
            this.coladr_Skrytka.FieldName = "adr_Skrytka";
            this.coladr_Skrytka.MinWidth = 25;
            this.coladr_Skrytka.Name = "coladr_Skrytka";
            this.coladr_Skrytka.Visible = true;
            this.coladr_Skrytka.VisibleIndex = 19;
            this.coladr_Skrytka.Width = 94;
            // 
            // coladr_Symbol
            // 
            this.coladr_Symbol.FieldName = "adr_Symbol";
            this.coladr_Symbol.MinWidth = 25;
            this.coladr_Symbol.Name = "coladr_Symbol";
            this.coladr_Symbol.Visible = true;
            this.coladr_Symbol.VisibleIndex = 20;
            this.coladr_Symbol.Width = 94;
            // 
            // coladr_IdGminy
            // 
            this.coladr_IdGminy.FieldName = "adr_IdGminy";
            this.coladr_IdGminy.MinWidth = 25;
            this.coladr_IdGminy.Name = "coladr_IdGminy";
            this.coladr_IdGminy.Visible = true;
            this.coladr_IdGminy.VisibleIndex = 21;
            this.coladr_IdGminy.Width = 94;
            // 
            // coladr_IdWersja
            // 
            this.coladr_IdWersja.FieldName = "adr_IdWersja";
            this.coladr_IdWersja.MinWidth = 25;
            this.coladr_IdWersja.Name = "coladr_IdWersja";
            this.coladr_IdWersja.Visible = true;
            this.coladr_IdWersja.VisibleIndex = 22;
            this.coladr_IdWersja.Width = 94;
            // 
            // coladr_IdZmienil
            // 
            this.coladr_IdZmienil.FieldName = "adr_IdZmienil";
            this.coladr_IdZmienil.MinWidth = 25;
            this.coladr_IdZmienil.Name = "coladr_IdZmienil";
            this.coladr_IdZmienil.Visible = true;
            this.coladr_IdZmienil.VisibleIndex = 23;
            this.coladr_IdZmienil.Width = 94;
            // 
            // coladr_DataZmiany
            // 
            this.coladr_DataZmiany.FieldName = "adr_DataZmiany";
            this.coladr_DataZmiany.MinWidth = 25;
            this.coladr_DataZmiany.Name = "coladr_DataZmiany";
            this.coladr_DataZmiany.Visible = true;
            this.coladr_DataZmiany.VisibleIndex = 24;
            this.coladr_DataZmiany.Width = 94;
            // 
            // coladr_NrUrzeduSkarbowego
            // 
            this.coladr_NrUrzeduSkarbowego.FieldName = "adr_NrUrzeduSkarbowego";
            this.coladr_NrUrzeduSkarbowego.MinWidth = 25;
            this.coladr_NrUrzeduSkarbowego.Name = "coladr_NrUrzeduSkarbowego";
            this.coladr_NrUrzeduSkarbowego.Visible = true;
            this.coladr_NrUrzeduSkarbowego.VisibleIndex = 25;
            this.coladr_NrUrzeduSkarbowego.Width = 94;
            // 
            // coladr_NrEORI
            // 
            this.coladr_NrEORI.FieldName = "adr_NrEORI";
            this.coladr_NrEORI.MinWidth = 25;
            this.coladr_NrEORI.Name = "coladr_NrEORI";
            this.coladr_NrEORI.Visible = true;
            this.coladr_NrEORI.VisibleIndex = 26;
            this.coladr_NrEORI.Width = 94;
            // 
            // colAdrEmails
            // 
            this.colAdrEmails.FieldName = "AdrEmails";
            this.colAdrEmails.MinWidth = 25;
            this.colAdrEmails.Name = "colAdrEmails";
            this.colAdrEmails.Visible = true;
            this.colAdrEmails.VisibleIndex = 27;
            this.colAdrEmails.Width = 94;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.simpleButton1);
            this.stackPanel1.Controls.Add(this.simpleButton2);
            this.stackPanel1.Controls.Add(this.simpleButton3);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel1.Location = new System.Drawing.Point(0, 409);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(800, 41);
            this.stackPanel1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(3, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Towar";
            this.simpleButton1.Click += new System.EventHandler(this.Towar_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(103, 6);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 29);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Kontrahent";
            this.simpleButton2.Click += new System.EventHandler(this.Kontrahent_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(203, 6);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(94, 29);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Dokument";
            this.simpleButton3.Click += new System.EventHandler(this.Dokument_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource1;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_Id;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_IdObiektu;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_TypAdresu;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_Nazwa;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_NazwaPelna;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_Telefon;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_Faks;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_Ulica;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_NrDomu;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_NrLokalu;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_Adres;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_Kod;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_Miejscowosc;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_IdWojewodztwo;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_IdPanstwo;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_NIP;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_Poczta;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_Gmina;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_Powiat;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_Skrytka;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_Symbol;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_IdGminy;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_IdWersja;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_IdZmienil;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_DataZmiany;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_NrUrzeduSkarbowego;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_NrEORI;
        private DevExpress.XtraGrid.Columns.GridColumn colAdrEmails;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
    }
}

