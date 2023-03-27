namespace Bestaurants
{
    partial class starRating
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picStar1 = new System.Windows.Forms.PictureBox();
            this.picGrayStar = new System.Windows.Forms.PictureBox();
            this.picStar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrayStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).BeginInit();
            this.SuspendLayout();
            // 
            // picStar1
            // 
            this.picStar1.Image = global::Bestaurants.Properties.Resources.star;
            this.picStar1.Location = new System.Drawing.Point(3, 4);
            this.picStar1.Name = "picStar1";
            this.picStar1.Size = new System.Drawing.Size(16, 16);
            this.picStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picStar1.TabIndex = 38;
            this.picStar1.TabStop = false;
            this.picStar1.Visible = false;
            // 
            // picGrayStar
            // 
            this.picGrayStar.Image = global::Bestaurants.Properties.Resources.gray_star;
            this.picGrayStar.Location = new System.Drawing.Point(34, 105);
            this.picGrayStar.Name = "picGrayStar";
            this.picGrayStar.Size = new System.Drawing.Size(16, 16);
            this.picGrayStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGrayStar.TabIndex = 37;
            this.picGrayStar.TabStop = false;
            this.picGrayStar.Visible = false;
            // 
            // picStar
            // 
            this.picStar.Image = global::Bestaurants.Properties.Resources.star;
            this.picStar.Location = new System.Drawing.Point(12, 105);
            this.picStar.Name = "picStar";
            this.picStar.Size = new System.Drawing.Size(16, 16);
            this.picStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picStar.TabIndex = 36;
            this.picStar.TabStop = false;
            this.picStar.Visible = false;
            // 
            // starRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picStar1);
            this.Controls.Add(this.picGrayStar);
            this.Controls.Add(this.picStar);
            this.Name = "starRating";
            this.Size = new System.Drawing.Size(145, 219);
            this.Load += new System.EventHandler(this.starRating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrayStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGrayStar;
        private System.Windows.Forms.PictureBox picStar;
        private System.Windows.Forms.PictureBox picStar1;
    }
}
