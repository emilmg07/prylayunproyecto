
namespace prylayunproyecto
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            lblBienvenidos = new Label();
            Pick1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pick1).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenidos
            // 
            lblBienvenidos.AutoSize = true;
            lblBienvenidos.Font = new Font("Arial Narrow", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenidos.Location = new Point(211, 44);
            lblBienvenidos.Name = "lblBienvenidos";
            lblBienvenidos.Size = new Size(360, 75);
            lblBienvenidos.TabIndex = 0;
            lblBienvenidos.Text = "bienvenido !!!!";
            lblBienvenidos.Click += label1_Click;
            // 
            // Pick1
            // 
            Pick1.Image = (Image)resources.GetObject("Pick1.Image");
            Pick1.Location = new Point(59, 122);
            Pick1.Name = "Pick1";
            Pick1.Size = new Size(660, 316);
            Pick1.SizeMode = PictureBoxSizeMode.Zoom;
            Pick1.TabIndex = 1;
            Pick1.TabStop = false;
            Pick1.Click += pictureBox1_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Pick1);
            Controls.Add(lblBienvenidos);
            Name = "FrmPrincipal";
            Text = "Bienvenido";
            ((System.ComponentModel.ISupportInitialize)Pick1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblBienvenidos;
        private PictureBox Pick1;
    }
}
