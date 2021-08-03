
namespace ReproductorVideoDCU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbruta = new System.Windows.Forms.Label();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btReproducir = new System.Windows.Forms.Button();
            this.btPausar = new System.Windows.Forms.Button();
            this.btDetener = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(530, 362);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // lbruta
            // 
            this.lbruta.AutoSize = true;
            this.lbruta.Location = new System.Drawing.Point(12, 377);
            this.lbruta.Name = "lbruta";
            this.lbruta.Size = new System.Drawing.Size(0, 13);
            this.lbruta.TabIndex = 1;
            this.lbruta.Click += new System.EventHandler(this.lbruta_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAgregar.Location = new System.Drawing.Point(550, 82);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(80, 30);
            this.btAgregar.TabIndex = 2;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btReproducir
            // 
            this.btReproducir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btReproducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReproducir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btReproducir.Location = new System.Drawing.Point(550, 133);
            this.btReproducir.Name = "btReproducir";
            this.btReproducir.Size = new System.Drawing.Size(80, 30);
            this.btReproducir.TabIndex = 3;
            this.btReproducir.Text = "Reproducir";
            this.btReproducir.UseVisualStyleBackColor = false;
            this.btReproducir.Click += new System.EventHandler(this.btReproducir_Click);
            // 
            // btPausar
            // 
            this.btPausar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btPausar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPausar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btPausar.Location = new System.Drawing.Point(550, 189);
            this.btPausar.Name = "btPausar";
            this.btPausar.Size = new System.Drawing.Size(80, 30);
            this.btPausar.TabIndex = 4;
            this.btPausar.Text = "Pausar";
            this.btPausar.UseVisualStyleBackColor = false;
            this.btPausar.Click += new System.EventHandler(this.btPausar_Click);
            // 
            // btDetener
            // 
            this.btDetener.BackColor = System.Drawing.Color.RoyalBlue;
            this.btDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDetener.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btDetener.Location = new System.Drawing.Point(550, 249);
            this.btDetener.Name = "btDetener";
            this.btDetener.Size = new System.Drawing.Size(80, 30);
            this.btDetener.TabIndex = 5;
            this.btDetener.Text = "Detener";
            this.btDetener.UseVisualStyleBackColor = false;
            this.btDetener.Click += new System.EventHandler(this.btDetener_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(638, 398);
            this.Controls.Add(this.btDetener);
            this.Controls.Add(this.btPausar);
            this.Controls.Add(this.btReproducir);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.lbruta);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VIDEO, MUSIC & MORE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lbruta;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btReproducir;
        private System.Windows.Forms.Button btPausar;
        private System.Windows.Forms.Button btDetener;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

