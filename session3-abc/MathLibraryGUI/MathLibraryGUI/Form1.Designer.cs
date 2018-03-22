namespace MathLibraryGUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.nombre1TextBox = new System.Windows.Forms.TextBox();
            this.nombre2TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultEndpoint1Text = new System.Windows.Forms.Label();
            this.resultEndpoint2Text = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultEndpoint3Text = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre 2";
            // 
            // nombre1TextBox
            // 
            this.nombre1TextBox.Location = new System.Drawing.Point(188, 42);
            this.nombre1TextBox.Name = "nombre1TextBox";
            this.nombre1TextBox.Size = new System.Drawing.Size(100, 22);
            this.nombre1TextBox.TabIndex = 4;
            // 
            // nombre2TextBox
            // 
            this.nombre2TextBox.Location = new System.Drawing.Point(188, 85);
            this.nombre2TextBox.Name = "nombre2TextBox";
            this.nombre2TextBox.Size = new System.Drawing.Size(100, 22);
            this.nombre2TextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Addition";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Multiplication";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resultat";
            // 
            // resultEndpoint1Text
            // 
            this.resultEndpoint1Text.AutoSize = true;
            this.resultEndpoint1Text.Location = new System.Drawing.Point(173, 205);
            this.resultEndpoint1Text.Name = "resultEndpoint1Text";
            this.resultEndpoint1Text.Size = new System.Drawing.Size(0, 17);
            this.resultEndpoint1Text.TabIndex = 9;
            // 
            // resultEndpoint2Text
            // 
            this.resultEndpoint2Text.AutoSize = true;
            this.resultEndpoint2Text.Location = new System.Drawing.Point(173, 246);
            this.resultEndpoint2Text.Name = "resultEndpoint2Text";
            this.resultEndpoint2Text.Size = new System.Drawing.Size(0, 17);
            this.resultEndpoint2Text.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resultat";
            // 
            // resultEndpoint3Text
            // 
            this.resultEndpoint3Text.AutoSize = true;
            this.resultEndpoint3Text.Location = new System.Drawing.Point(173, 287);
            this.resultEndpoint3Text.Name = "resultEndpoint3Text";
            this.resultEndpoint3Text.Size = new System.Drawing.Size(0, 17);
            this.resultEndpoint3Text.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Resultat";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 31);
            this.button3.TabIndex = 14;
            this.button3.Text = "Division";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 342);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.resultEndpoint3Text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultEndpoint2Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultEndpoint1Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nombre2TextBox);
            this.Controls.Add(this.nombre1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre1TextBox;
        private System.Windows.Forms.TextBox nombre2TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultEndpoint1Text;
        private System.Windows.Forms.Label resultEndpoint2Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultEndpoint3Text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
    }
}

