namespace RISCO_E_RABISCO
{
    partial class MenuFun
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.ImageProdução = new System.Windows.Forms.PictureBox();
            this.ImageProdutos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProdução)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(287, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu Funcionário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RISCO_E_RABISCO.Properties.Resources.risco2;
            this.pictureBox1.Location = new System.Drawing.Point(258, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::RISCO_E_RABISCO.Properties.Resources.risco;
            this.pictureBox7.Location = new System.Drawing.Point(395, 350);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(406, 100);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // ImageProdução
            // 
            this.ImageProdução.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageProdução.Image = global::RISCO_E_RABISCO.Properties.Resources.Produção;
            this.ImageProdução.Location = new System.Drawing.Point(420, 181);
            this.ImageProdução.Name = "ImageProdução";
            this.ImageProdução.Size = new System.Drawing.Size(125, 140);
            this.ImageProdução.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageProdução.TabIndex = 11;
            this.ImageProdução.TabStop = false;
            this.ImageProdução.Click += new System.EventHandler(this.ImageProdução_Click);
            // 
            // ImageProdutos
            // 
            this.ImageProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageProdutos.Image = global::RISCO_E_RABISCO.Properties.Resources.Produtos;
            this.ImageProdutos.Location = new System.Drawing.Point(267, 181);
            this.ImageProdutos.Name = "ImageProdutos";
            this.ImageProdutos.Size = new System.Drawing.Size(125, 140);
            this.ImageProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageProdutos.TabIndex = 10;
            this.ImageProdutos.TabStop = false;
            this.ImageProdutos.Click += new System.EventHandler(this.ImageProdutos_Click);
            // 
            // MenuFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImageProdução);
            this.Controls.Add(this.ImageProdutos);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuFun";
            this.Text = "MenuFun";
            this.Load += new System.EventHandler(this.MenuFun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProdução)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox ImageProdução;
        private System.Windows.Forms.PictureBox ImageProdutos;
    }
}