namespace testGitHub3
{
    partial class frmTest
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
            this.btnTest = new System.Windows.Forms.Button();
            this.btnTestAPI_Win = new System.Windows.Forms.Button();
            this.btnTest2API_Win = new System.Windows.Forms.Button();
            this.btn3API_Win = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
<<<<<<< Updated upstream
            this.btnTest.Location = new System.Drawing.Point(39, 35);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(163, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "btnTest";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
=======
            this.button1.Location = new System.Drawing.Point(91, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn3API_Win_Click);
>>>>>>> Stashed changes
            // 
            // btnTestAPI_Win
            // 
            this.btnTestAPI_Win.Location = new System.Drawing.Point(39, 80);
            this.btnTestAPI_Win.Name = "btnTestAPI_Win";
            this.btnTestAPI_Win.Size = new System.Drawing.Size(163, 23);
            this.btnTestAPI_Win.TabIndex = 1;
            this.btnTestAPI_Win.Text = "btnTestAPI_Win";
            this.btnTestAPI_Win.UseVisualStyleBackColor = true;
            this.btnTestAPI_Win.Click += new System.EventHandler(this.btnTestAPI_Win_Click);
            // 
            // btnTest2API_Win
            // 
            this.btnTest2API_Win.Location = new System.Drawing.Point(39, 128);
            this.btnTest2API_Win.Name = "btnTest2API_Win";
            this.btnTest2API_Win.Size = new System.Drawing.Size(163, 23);
            this.btnTest2API_Win.TabIndex = 2;
            this.btnTest2API_Win.Text = "btnTest 2 API_Win";
            this.btnTest2API_Win.UseVisualStyleBackColor = true;
            this.btnTest2API_Win.Click += new System.EventHandler(this.btnTest2API_Win_Click);
            // 
            // btn3API_Win
            // 
            this.btn3API_Win.Location = new System.Drawing.Point(45, 182);
            this.btn3API_Win.Name = "btn3API_Win";
            this.btn3API_Win.Size = new System.Drawing.Size(157, 23);
            this.btn3API_Win.TabIndex = 3;
            this.btn3API_Win.Text = "btn3API_Win";
            this.btn3API_Win.UseVisualStyleBackColor = true;
            this.btn3API_Win.Click += new System.EventHandler(this.btn3API_Win_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 251);
            this.Controls.Add(this.btn3API_Win);
            this.Controls.Add(this.btnTest2API_Win);
            this.Controls.Add(this.btnTestAPI_Win);
            this.Controls.Add(this.btnTest);
            this.Name = "frmTest";
            this.Text = "Test API windows";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnTestAPI_Win;
        private System.Windows.Forms.Button btnTest2API_Win;
        private System.Windows.Forms.Button btn3API_Win;
    }
}

