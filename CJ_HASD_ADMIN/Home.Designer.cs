
namespace CJ_HASD_ADMIN
{
    partial class Home
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
            this.lblTimeTable = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblTheater = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picPre = new System.Windows.Forms.PictureBox();
            this.picList = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimeTable
            // 
            this.lblTimeTable.AutoSize = true;
            this.lblTimeTable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTable.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblTimeTable.Location = new System.Drawing.Point(295, 174);
            this.lblTimeTable.Name = "lblTimeTable";
            this.lblTimeTable.Size = new System.Drawing.Size(118, 24);
            this.lblTimeTable.TabIndex = 14;
            this.lblTimeTable.Text = "TIME TABLE";
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblMovie.Location = new System.Drawing.Point(510, 174);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(80, 24);
            this.lblMovie.TabIndex = 13;
            this.lblMovie.Text = "MOVIES";
            // 
            // lblTheater
            // 
            this.lblTheater.AutoSize = true;
            this.lblTheater.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheater.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblTheater.Location = new System.Drawing.Point(101, 174);
            this.lblTheater.Name = "lblTheater";
            this.lblTheater.Size = new System.Drawing.Size(94, 24);
            this.lblTheater.TabIndex = 12;
            this.lblTheater.Text = "THEATER";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(55, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(596, 2);
            this.label2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(55, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 2);
            this.label1.TabIndex = 10;
            // 
            // picNext
            // 
            this.picNext.Image = global::CJ_HASD_ADMIN.Properties.Resources.Pasted_20230623_235306_pixian1;
            this.picNext.Location = new System.Drawing.Point(583, 400);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(68, 63);
            this.picNext.TabIndex = 17;
            this.picNext.TabStop = false;
            // 
            // picPre
            // 
            this.picPre.Image = global::CJ_HASD_ADMIN.Properties.Resources.Pasted_20230623_235239_pixian;
            this.picPre.Location = new System.Drawing.Point(55, 400);
            this.picPre.Name = "picPre";
            this.picPre.Size = new System.Drawing.Size(68, 63);
            this.picPre.TabIndex = 16;
            this.picPre.TabStop = false;
            // 
            // picList
            // 
            this.picList.Image = global::CJ_HASD_ADMIN.Properties.Resources.BADGIRL;
            this.picList.Location = new System.Drawing.Point(200, 240);
            this.picList.Name = "picList";
            this.picList.Size = new System.Drawing.Size(302, 374);
            this.picList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picList.TabIndex = 15;
            this.picList.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CJ_HASD_ADMIN.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(173, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 646);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picPre);
            this.Controls.Add(this.picList);
            this.Controls.Add(this.lblTimeTable);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.lblTheater);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picPre;
        private System.Windows.Forms.PictureBox picList;
        private System.Windows.Forms.Label lblTimeTable;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblTheater;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}