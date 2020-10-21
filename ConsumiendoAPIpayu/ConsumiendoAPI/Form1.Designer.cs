namespace ConsumiendoAPI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombreEnviar = new System.Windows.Forms.TextBox();
            this.correoEnviar = new System.Windows.Forms.TextBox();
            this.nombreRecibir = new System.Windows.Forms.TextBox();
            this.correoRecibir = new System.Windows.Forms.TextBox();
            this.idRecibir = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // nombreEnviar
            // 
            this.nombreEnviar.Location = new System.Drawing.Point(232, 23);
            this.nombreEnviar.Name = "nombreEnviar";
            this.nombreEnviar.Size = new System.Drawing.Size(100, 20);
            this.nombreEnviar.TabIndex = 5;
            // 
            // correoEnviar
            // 
            this.correoEnviar.Location = new System.Drawing.Point(232, 83);
            this.correoEnviar.Name = "correoEnviar";
            this.correoEnviar.Size = new System.Drawing.Size(100, 20);
            this.correoEnviar.TabIndex = 6;
            // 
            // nombreRecibir
            // 
            this.nombreRecibir.Location = new System.Drawing.Point(232, 230);
            this.nombreRecibir.Name = "nombreRecibir";
            this.nombreRecibir.Size = new System.Drawing.Size(100, 20);
            this.nombreRecibir.TabIndex = 7;
            // 
            // correoRecibir
            // 
            this.correoRecibir.Location = new System.Drawing.Point(232, 270);
            this.correoRecibir.Name = "correoRecibir";
            this.correoRecibir.Size = new System.Drawing.Size(100, 20);
            this.correoRecibir.TabIndex = 8;
            // 
            // idRecibir
            // 
            this.idRecibir.Location = new System.Drawing.Point(232, 326);
            this.idRecibir.Name = "idRecibir";
            this.idRecibir.Size = new System.Drawing.Size(100, 20);
            this.idRecibir.TabIndex = 9;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(175, 157);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 11;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(332, 157);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 12;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.idRecibir);
            this.Controls.Add(this.correoRecibir);
            this.Controls.Add(this.nombreRecibir);
            this.Controls.Add(this.correoEnviar);
            this.Controls.Add(this.nombreEnviar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombreEnviar;
        private System.Windows.Forms.TextBox correoEnviar;
        private System.Windows.Forms.TextBox nombreRecibir;
        private System.Windows.Forms.TextBox correoRecibir;
        private System.Windows.Forms.TextBox idRecibir;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnPost;
    }
}

