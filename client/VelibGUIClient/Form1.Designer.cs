﻿namespace VelibGUIClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.nomDeStationLabel = new System.Windows.Forms.Label();
            this.stationNameText = new System.Windows.Forms.Label();
            this.availableBikesLabel = new System.Windows.Forms.Label();
            this.availableBikesText = new System.Windows.Forms.Label();
            this.adressStationLabel = new System.Windows.Forms.Label();
            this.adressStationText = new System.Windows.Forms.Label();
            this.terminalPaymentLabel = new System.Windows.Forms.Label();
            this.terminalPaiementText = new System.Windows.Forms.Label();
            this.nbPointAttacheLabel = new System.Windows.Forms.Label();
            this.nbPointAttacheText = new System.Windows.Forms.Label();
            this.nbPointAttacheDispoLabel = new System.Windows.Forms.Label();
            this.nbPointsAttachesDispoText = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.stationCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "récupérer les informations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.makeRequest);
            // 
            // nomDeStationLabel
            // 
            this.nomDeStationLabel.AutoSize = true;
            this.nomDeStationLabel.Location = new System.Drawing.Point(65, 293);
            this.nomDeStationLabel.Name = "nomDeStationLabel";
            this.nomDeStationLabel.Size = new System.Drawing.Size(103, 17);
            this.nomDeStationLabel.TabIndex = 2;
            this.nomDeStationLabel.Text = "Nom de station";
            // 
            // stationNameText
            // 
            this.stationNameText.AutoSize = true;
            this.stationNameText.Location = new System.Drawing.Point(202, 293);
            this.stationNameText.Name = "stationNameText";
            this.stationNameText.Size = new System.Drawing.Size(0, 17);
            this.stationNameText.TabIndex = 3;
            // 
            // availableBikesLabel
            // 
            this.availableBikesLabel.AutoSize = true;
            this.availableBikesLabel.Location = new System.Drawing.Point(65, 410);
            this.availableBikesLabel.Name = "availableBikesLabel";
            this.availableBikesLabel.Size = new System.Drawing.Size(176, 17);
            this.availableBikesLabel.TabIndex = 4;
            this.availableBikesLabel.Text = "Nombre de vélo disponible";
            // 
            // availableBikesText
            // 
            this.availableBikesText.AutoSize = true;
            this.availableBikesText.Location = new System.Drawing.Point(264, 410);
            this.availableBikesText.Name = "availableBikesText";
            this.availableBikesText.Size = new System.Drawing.Size(0, 17);
            this.availableBikesText.TabIndex = 5;
            // 
            // adressStationLabel
            // 
            this.adressStationLabel.AutoSize = true;
            this.adressStationLabel.Location = new System.Drawing.Point(65, 330);
            this.adressStationLabel.Name = "adressStationLabel";
            this.adressStationLabel.Size = new System.Drawing.Size(60, 17);
            this.adressStationLabel.TabIndex = 6;
            this.adressStationLabel.Text = "Adresse";
            // 
            // adressStationText
            // 
            this.adressStationText.AutoSize = true;
            this.adressStationText.Location = new System.Drawing.Point(161, 330);
            this.adressStationText.Name = "adressStationText";
            this.adressStationText.Size = new System.Drawing.Size(0, 17);
            this.adressStationText.TabIndex = 7;
            // 
            // terminalPaymentLabel
            // 
            this.terminalPaymentLabel.AutoSize = true;
            this.terminalPaymentLabel.Location = new System.Drawing.Point(65, 371);
            this.terminalPaymentLabel.Name = "terminalPaymentLabel";
            this.terminalPaymentLabel.Size = new System.Drawing.Size(145, 17);
            this.terminalPaymentLabel.TabIndex = 8;
            this.terminalPaymentLabel.Text = "Terminal de paiement";
            // 
            // terminalPaiementText
            // 
            this.terminalPaiementText.AutoSize = true;
            this.terminalPaiementText.Location = new System.Drawing.Point(264, 371);
            this.terminalPaiementText.Name = "terminalPaiementText";
            this.terminalPaiementText.Size = new System.Drawing.Size(0, 17);
            this.terminalPaiementText.TabIndex = 9;
            // 
            // nbPointAttacheLabel
            // 
            this.nbPointAttacheLabel.AutoSize = true;
            this.nbPointAttacheLabel.Location = new System.Drawing.Point(65, 444);
            this.nbPointAttacheLabel.Name = "nbPointAttacheLabel";
            this.nbPointAttacheLabel.Size = new System.Drawing.Size(189, 17);
            this.nbPointAttacheLabel.TabIndex = 10;
            this.nbPointAttacheLabel.Text = "Nombre de points d\'attaches";
            // 
            // nbPointAttacheText
            // 
            this.nbPointAttacheText.AutoSize = true;
            this.nbPointAttacheText.Location = new System.Drawing.Point(276, 443);
            this.nbPointAttacheText.Name = "nbPointAttacheText";
            this.nbPointAttacheText.Size = new System.Drawing.Size(0, 17);
            this.nbPointAttacheText.TabIndex = 11;
            // 
            // nbPointAttacheDispoLabel
            // 
            this.nbPointAttacheDispoLabel.AutoSize = true;
            this.nbPointAttacheDispoLabel.Location = new System.Drawing.Point(65, 477);
            this.nbPointAttacheDispoLabel.Name = "nbPointAttacheDispoLabel";
            this.nbPointAttacheDispoLabel.Size = new System.Drawing.Size(264, 17);
            this.nbPointAttacheDispoLabel.TabIndex = 12;
            this.nbPointAttacheDispoLabel.Text = "Nombre de points d\'attaches disponibles";
            // 
            // nbPointsAttachesDispoText
            // 
            this.nbPointsAttachesDispoText.AutoSize = true;
            this.nbPointsAttachesDispoText.Location = new System.Drawing.Point(351, 476);
            this.nbPointsAttachesDispoText.Name = "nbPointsAttachesDispoText";
            this.nbPointsAttachesDispoText.Size = new System.Drawing.Size(0, 17);
            this.nbPointsAttachesDispoText.TabIndex = 13;
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Toulouse",
            "Brisbane",
            "Bruxelles-Capitale",
            "Namur",
            "Santander",
            "Seville",
            "Valence",
            "Amiens",
            "Besancon",
            "Cergy-Pontoise",
            "Creteil",
            "Lyon",
            "Marseille"});
            this.cityComboBox.Location = new System.Drawing.Point(237, 67);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(121, 24);
            this.cityComboBox.TabIndex = 14;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityChanged);
            // 
            // stationCombobox
            // 
            this.stationCombobox.FormattingEnabled = true;
            this.stationCombobox.Location = new System.Drawing.Point(489, 67);
            this.stationCombobox.Name = "stationCombobox";
            this.stationCombobox.Size = new System.Drawing.Size(312, 24);
            this.stationCombobox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Station";
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(567, 212);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(474, 301);
            this.gmap.TabIndex = 18;
            this.gmap.Zoom = 13D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 632);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stationCombobox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.nbPointsAttachesDispoText);
            this.Controls.Add(this.nbPointAttacheDispoLabel);
            this.Controls.Add(this.nbPointAttacheText);
            this.Controls.Add(this.nbPointAttacheLabel);
            this.Controls.Add(this.terminalPaiementText);
            this.Controls.Add(this.terminalPaymentLabel);
            this.Controls.Add(this.adressStationText);
            this.Controls.Add(this.adressStationLabel);
            this.Controls.Add(this.availableBikesText);
            this.Controls.Add(this.availableBikesLabel);
            this.Controls.Add(this.stationNameText);
            this.Controls.Add(this.nomDeStationLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nomDeStationLabel;
        private System.Windows.Forms.Label stationNameText;
        private System.Windows.Forms.Label availableBikesLabel;
        private System.Windows.Forms.Label availableBikesText;
        private System.Windows.Forms.Label adressStationLabel;
        private System.Windows.Forms.Label adressStationText;
        private System.Windows.Forms.Label terminalPaymentLabel;
        private System.Windows.Forms.Label terminalPaiementText;
        private System.Windows.Forms.Label nbPointAttacheLabel;
        private System.Windows.Forms.Label nbPointAttacheText;
        private System.Windows.Forms.Label nbPointAttacheDispoLabel;
        private System.Windows.Forms.Label nbPointsAttachesDispoText;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox stationCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private GMap.NET.WindowsForms.GMapControl gmap;
    }
}

