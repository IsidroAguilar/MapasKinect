﻿namespace MapKinectApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgMapa = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblShoulderPosition = new System.Windows.Forms.Label();
            this.lblShoulder = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            ((System.ComponentModel.ISupportInitialize)(this.imgMapa)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMapa
            // 
            this.imgMapa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgMapa.BackgroundImage")));
            this.imgMapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgMapa.Location = new System.Drawing.Point(123, 0);
            this.imgMapa.Name = "imgMapa";
            this.imgMapa.Size = new System.Drawing.Size(634, 339);
            this.imgMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMapa.TabIndex = 0;
            this.imgMapa.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(12, 258);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(74, 30);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "label1";
            // 
            // lblShoulderPosition
            // 
            this.lblShoulderPosition.AutoSize = true;
            this.lblShoulderPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblShoulderPosition.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoulderPosition.Location = new System.Drawing.Point(12, 223);
            this.lblShoulderPosition.Name = "lblShoulderPosition";
            this.lblShoulderPosition.Size = new System.Drawing.Size(74, 30);
            this.lblShoulderPosition.TabIndex = 5;
            this.lblShoulderPosition.Text = "label1";
            // 
            // lblShoulder
            // 
            this.lblShoulder.AutoSize = true;
            this.lblShoulder.BackColor = System.Drawing.Color.Transparent;
            this.lblShoulder.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoulder.Location = new System.Drawing.Point(12, 185);
            this.lblShoulder.Name = "lblShoulder";
            this.lblShoulder.Size = new System.Drawing.Size(74, 30);
            this.lblShoulder.TabIndex = 4;
            this.lblShoulder.Text = "label1";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(757, 339);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblShoulderPosition);
            this.Controls.Add(this.lblShoulder);
            this.Controls.Add(this.imgMapa);
            this.Name = "Form1";
            this.Text = "Manipulación de Mapas con Kinect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMapa;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblShoulderPosition;
        private System.Windows.Forms.Label lblShoulder;
        private System.Diagnostics.Process process1;
    }
}

