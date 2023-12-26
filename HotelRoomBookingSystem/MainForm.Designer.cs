
namespace HotelRoomBookingSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblhotel = new System.Windows.Forms.Label();
            this.pic_guest = new System.Windows.Forms.PictureBox();
            this.pic_Res = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picimage = new System.Windows.Forms.PictureBox();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.lbl_room = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.lbl_guest = new System.Windows.Forms.Label();
            this.pic_exit = new System.Windows.Forms.PictureBox();
            this.Exit_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_guest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Res)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhotel
            // 
            this.lblhotel.BackColor = System.Drawing.Color.Transparent;
            this.lblhotel.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhotel.Location = new System.Drawing.Point(126, 20);
            this.lblhotel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.lblhotel.Name = "lblhotel";
            this.lblhotel.Size = new System.Drawing.Size(486, 69);
            this.lblhotel.TabIndex = 0;
            this.lblhotel.Text = "Hotal Room Reservation";
            this.lblhotel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pic_guest
            // 
            this.pic_guest.BackColor = System.Drawing.Color.Transparent;
            this.pic_guest.Image = ((System.Drawing.Image)(resources.GetObject("pic_guest.Image")));
            this.pic_guest.Location = new System.Drawing.Point(115, 332);
            this.pic_guest.Name = "pic_guest";
            this.pic_guest.Size = new System.Drawing.Size(109, 102);
            this.pic_guest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_guest.TabIndex = 1;
            this.pic_guest.TabStop = false;
            this.pic_guest.Click += new System.EventHandler(this.pic_guest_Click);
            // 
            // pic_Res
            // 
            this.pic_Res.BackColor = System.Drawing.Color.Transparent;
            this.pic_Res.Image = ((System.Drawing.Image)(resources.GetObject("pic_Res.Image")));
            this.pic_Res.Location = new System.Drawing.Point(458, 332);
            this.pic_Res.Name = "pic_Res";
            this.pic_Res.Size = new System.Drawing.Size(109, 102);
            this.pic_Res.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Res.TabIndex = 1;
            this.pic_Res.TabStop = false;
            this.pic_Res.Click += new System.EventHandler(this.pic_Res_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(115, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pic_admin_Click);
            // 
            // picimage
            // 
            this.picimage.BackColor = System.Drawing.Color.Transparent;
            this.picimage.Image = ((System.Drawing.Image)(resources.GetObject("picimage.Image")));
            this.picimage.Location = new System.Drawing.Point(458, 113);
            this.picimage.Name = "picimage";
            this.picimage.Size = new System.Drawing.Size(109, 102);
            this.picimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picimage.TabIndex = 1;
            this.picimage.TabStop = false;
            this.picimage.Click += new System.EventHandler(this.picimage_Click);
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_admin.Font = new System.Drawing.Font("Forte", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_admin.Location = new System.Drawing.Point(142, 236);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(71, 22);
            this.lbl_admin.TabIndex = 2;
            this.lbl_admin.Text = "Admin";
            // 
            // lbl_room
            // 
            this.lbl_room.AutoSize = true;
            this.lbl_room.BackColor = System.Drawing.Color.Transparent;
            this.lbl_room.Font = new System.Drawing.Font("Forte", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_room.Location = new System.Drawing.Point(478, 236);
            this.lbl_room.Name = "lbl_room";
            this.lbl_room.Size = new System.Drawing.Size(64, 22);
            this.lbl_room.TabIndex = 2;
            this.lbl_room.Text = "Room";
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.BackColor = System.Drawing.Color.Transparent;
            this.lbl_res.Font = new System.Drawing.Font("Forte", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_res.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_res.Location = new System.Drawing.Point(460, 464);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(120, 22);
            this.lbl_res.TabIndex = 2;
            this.lbl_res.Text = "Reservation";
            // 
            // lbl_guest
            // 
            this.lbl_guest.AutoSize = true;
            this.lbl_guest.BackColor = System.Drawing.Color.Transparent;
            this.lbl_guest.Font = new System.Drawing.Font("Forte", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guest.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_guest.Location = new System.Drawing.Point(130, 464);
            this.lbl_guest.Name = "lbl_guest";
            this.lbl_guest.Size = new System.Drawing.Size(64, 22);
            this.lbl_guest.TabIndex = 2;
            this.lbl_guest.Text = "Guest";
            // 
            // pic_exit
            // 
            this.pic_exit.BackColor = System.Drawing.Color.Transparent;
            this.pic_exit.Image = ((System.Drawing.Image)(resources.GetObject("pic_exit.Image")));
            this.pic_exit.Location = new System.Drawing.Point(291, 496);
            this.pic_exit.Name = "pic_exit";
            this.pic_exit.Size = new System.Drawing.Size(79, 71);
            this.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_exit.TabIndex = 1;
            this.pic_exit.TabStop = false;
            this.pic_exit.Click += new System.EventHandler(this.pic_exit_Click);
            // 
            // Exit_pic
            // 
            this.Exit_pic.BackColor = System.Drawing.Color.Transparent;
            this.Exit_pic.Image = ((System.Drawing.Image)(resources.GetObject("Exit_pic.Image")));
            this.Exit_pic.Location = new System.Drawing.Point(646, 20);
            this.Exit_pic.Name = "Exit_pic";
            this.Exit_pic.Size = new System.Drawing.Size(64, 54);
            this.Exit_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit_pic.TabIndex = 1;
            this.Exit_pic.TabStop = false;
            this.Exit_pic.Click += new System.EventHandler(this.Exit_pic_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(732, 598);
            this.Controls.Add(this.lbl_guest);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.lbl_room);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.picimage);
            this.Controls.Add(this.pic_Res);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Exit_pic);
            this.Controls.Add(this.pic_exit);
            this.Controls.Add(this.pic_guest);
            this.Controls.Add(this.lblhotel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_guest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Res)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhotel;
        private System.Windows.Forms.PictureBox pic_guest;
        private System.Windows.Forms.PictureBox pic_Res;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picimage;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label lbl_room;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Label lbl_guest;
        private System.Windows.Forms.PictureBox pic_exit;
        private System.Windows.Forms.PictureBox Exit_pic;
    }
}