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
            this.btnStart = new System.Windows.Forms.Button();
            this.spustac = new System.Windows.Forms.Timer(this.components);
            this.btnZrychli = new System.Windows.Forms.Button();
            this.btnSpomal = new System.Windows.Forms.Button();
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
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(586, 36);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 82);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Prepni";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // spustac
            // 
            this.spustac.Interval = 10;
            this.spustac.Tick += new System.EventHandler(this.spustac_Tick);
            // 
            // btnZrychli
            // 
            this.btnZrychli.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZrychli.Location = new System.Drawing.Point(589, 160);
            this.btnZrychli.Name = "btnZrychli";
            this.btnZrychli.Size = new System.Drawing.Size(124, 69);
            this.btnZrychli.TabIndex = 2;
            this.btnZrychli.Text = "Zrychli";
            this.btnZrychli.UseVisualStyleBackColor = true;
            this.btnZrychli.Click += new System.EventHandler(this.btnZrychli_Click);
            // 
            // btnSpomal
            // 
            this.btnSpomal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpomal.Location = new System.Drawing.Point(589, 266);
            this.btnSpomal.Name = "btnSpomal";
            this.btnSpomal.Size = new System.Drawing.Size(124, 65);
            this.btnSpomal.TabIndex = 3;
            this.btnSpomal.Text = "Spomal";
            this.btnSpomal.UseVisualStyleBackColor = true;
            this.btnSpomal.Click += new System.EventHandler(this.btnSpomal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 443);
            this.Controls.Add(this.btnSpomal);
            this.Controls.Add(this.btnZrychli);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbTeren);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbTeren)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTeren;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer spustac;
        private System.Windows.Forms.Button btnZrychli;
        private System.Windows.Forms.Button btnSpomal;
    }
}

