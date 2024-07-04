using System.Drawing;
using System.Drawing.Text;

namespace viborita
{
    partial class frmGameScreen
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.tmrJugando = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxGameScreen = new System.Windows.Forms.PictureBox();
            this.lblMaxScore = new System.Windows.Forms.Label();
            this.lblLastScore = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boxGameScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.Location = new System.Drawing.Point(319, 24);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(46, 23);
            this.lblPuntaje.TabIndex = 2;
            this.lblPuntaje.Text = "000";
            // 
            // tmrJugando
            // 
            this.tmrJugando.Tick += new System.EventHandler(this.tmrJugando_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Score:";
            // 
            // boxGameScreen
            // 
            this.boxGameScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.boxGameScreen.Location = new System.Drawing.Point(100, 50);
            this.boxGameScreen.Name = "boxGameScreen";
            this.boxGameScreen.Size = new System.Drawing.Size(400, 400);
            this.boxGameScreen.TabIndex = 0;
            this.boxGameScreen.TabStop = false;
            this.boxGameScreen.Visible = false;
            this.boxGameScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.boxGameScreen_Paint);
            // 
            // lblMaxScore
            // 
            this.lblMaxScore.AutoSize = true;
            this.lblMaxScore.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxScore.Location = new System.Drawing.Point(630, 87);
            this.lblMaxScore.Name = "lblMaxScore";
            this.lblMaxScore.Size = new System.Drawing.Size(39, 19);
            this.lblMaxScore.TabIndex = 5;
            this.lblMaxScore.Text = "000";
            // 
            // lblLastScore
            // 
            this.lblLastScore.AutoSize = true;
            this.lblLastScore.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastScore.Location = new System.Drawing.Point(631, 122);
            this.lblLastScore.Name = "lblLastScore";
            this.lblLastScore.Size = new System.Drawing.Size(35, 18);
            this.lblLastScore.TabIndex = 6;
            this.lblLastScore.Text = "000";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblStart.Location = new System.Drawing.Point(47, 215);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(622, 23);
            this.lblStart.TabIndex = 7;
            this.lblStart.Tag = "";
            this.lblStart.Text = "Presiona el espacio para comenzar una nueva partida";
            // 
            // frmGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(707, 461);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblLastScore);
            this.Controls.Add(this.lblMaxScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxGameScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGameScreen";
            this.Text = "Jugando";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGameScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.boxGameScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Timer tmrJugando;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox boxGameScreen;
        private System.Windows.Forms.Label lblMaxScore;
        private System.Windows.Forms.Label lblLastScore;
        private System.Windows.Forms.Label lblStart;
    }
}

