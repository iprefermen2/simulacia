namespace Mar17Delo
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
            this.components = new System.ComponentModel.Container();
            this.pbTeren = new System.Windows.Forms.PictureBox();
            this.btnVrh = new System.Windows.Forms.Button();
            this.spustac = new System.Windows.Forms.Timer(this.components);
            this.btnPruzina = new System.Windows.Forms.Button();
            this.btnMagnet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeren)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTeren
            // 
            this.pbTeren.BackColor = System.Drawing.Color.White;
            this.pbTeren.Location = new System.Drawing.Point(46, 36);
            this.pbTeren.Name = "pbTeren";
            this.pbTeren.Size = new System.Drawing.Size(500, 400);
            this.pbTeren.TabIndex = 0;
            this.pbTeren.TabStop = false;
            // 
            // btnVrh
            // 
            this.btnVrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVrh.Location = new System.Drawing.Point(586, 36);
            this.btnVrh.Name = "btnVrh";
            this.btnVrh.Size = new System.Drawing.Size(128, 82);
            this.btnVrh.TabIndex = 1;
            this.btnVrh.Text = "vrh";
            this.btnVrh.UseVisualStyleBackColor = true;
            this.btnVrh.Click += new System.EventHandler(this.btnVrh_Click);
            // 
            // spustac
            // 
            this.spustac.Interval = 10;
            this.spustac.Tick += new System.EventHandler(this.spustac_Tick);
            // 
            // btnPruzina
            // 
            this.btnPruzina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPruzina.Location = new System.Drawing.Point(589, 160);
            this.btnPruzina.Name = "btnPruzina";
            this.btnPruzina.Size = new System.Drawing.Size(124, 69);
            this.btnPruzina.TabIndex = 2;
            this.btnPruzina.Text = "pruzina";
            this.btnPruzina.UseVisualStyleBackColor = true;
            this.btnPruzina.Click += new System.EventHandler(this.btnPruzina_Click);
            // 
            // btnMagnet
            // 
            this.btnMagnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMagnet.Location = new System.Drawing.Point(589, 266);
            this.btnMagnet.Name = "btnMagnet";
            this.btnMagnet.Size = new System.Drawing.Size(124, 65);
            this.btnMagnet.TabIndex = 3;
            this.btnMagnet.Text = "magnet";
            this.btnMagnet.UseVisualStyleBackColor = true;
            this.btnMagnet.Click += new System.EventHandler(this.btnMagnet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 443);
            this.Controls.Add(this.btnMagnet);
            this.Controls.Add(this.btnPruzina);
            this.Controls.Add(this.btnVrh);
            this.Controls.Add(this.pbTeren);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbTeren)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTeren;
        private System.Windows.Forms.Button btnVrh;
        private System.Windows.Forms.Timer spustac;
        private System.Windows.Forms.Button btnPruzina;
        private System.Windows.Forms.Button btnMagnet;
    }
}

