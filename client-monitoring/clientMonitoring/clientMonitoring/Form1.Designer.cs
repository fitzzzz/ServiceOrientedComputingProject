using System.Windows.Forms;

namespace clientMonitoring
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfRequestText = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfClientsText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfRequestToAPIText = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "nombre de requêtes";
            // 
            // numberOfRequestText
            // 
            this.numberOfRequestText.AutoSize = true;
            this.numberOfRequestText.Location = new System.Drawing.Point(288, 181);
            this.numberOfRequestText.Name = "numberOfRequestText";
            this.numberOfRequestText.Size = new System.Drawing.Size(0, 17);
            this.numberOfRequestText.TabIndex = 1;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(523, 91);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(87, 33);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Actualiser";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "nombre de clients";
            // 
            // numberOfClientsText
            // 
            this.numberOfClientsText.AutoSize = true;
            this.numberOfClientsText.Location = new System.Drawing.Point(291, 224);
            this.numberOfClientsText.Name = "numberOfClientsText";
            this.numberOfClientsText.Size = new System.Drawing.Size(0, 17);
            this.numberOfClientsText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "nombre de reqête à JCDecaux";
            // 
            // numberOfRequestToAPIText
            // 
            this.numberOfRequestToAPIText.AutoSize = true;
            this.numberOfRequestToAPIText.Location = new System.Drawing.Point(342, 251);
            this.numberOfRequestToAPIText.Name = "numberOfRequestToAPIText";
            this.numberOfRequestToAPIText.Size = new System.Drawing.Size(0, 17);
            this.numberOfRequestToAPIText.TabIndex = 6;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(432, 39);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 22);
            this.endDate.TabIndex = 7;
            this.endDate.Format = DateTimePickerFormat.Custom;
            this.endDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(166, 39);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 22);
            this.startDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "au";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Du";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 328);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.numberOfRequestToAPIText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberOfClientsText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.numberOfRequestText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberOfRequestText;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberOfClientsText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numberOfRequestToAPIText;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

