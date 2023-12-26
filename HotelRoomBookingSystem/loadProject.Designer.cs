
namespace HotelRoomBookingSystem
{
    partial class loadProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadProject));
            this.panel_guest = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_loadpro = new System.Windows.Forms.Label();
            this.pgbar = new System.Windows.Forms.ProgressBar();
            this.lbl_load = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_guest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_guest
            // 
            this.panel_guest.BackColor = System.Drawing.Color.DarkCyan;
            this.panel_guest.Controls.Add(this.pictureBox1);
            this.panel_guest.Controls.Add(this.pgbar);
            this.panel_guest.Controls.Add(this.lbl_date);
            this.panel_guest.Controls.Add(this.lbl_load);
            this.panel_guest.Controls.Add(this.lbl_loadpro);
            this.panel_guest.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_guest.Location = new System.Drawing.Point(-3, -2);
            this.panel_guest.Name = "panel_guest";
            this.panel_guest.Size = new System.Drawing.Size(848, 466);
            this.panel_guest.TabIndex = 2;
            this.panel_guest.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_guest_Paint);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_date.Location = new System.Drawing.Point(1151, 60);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(77, 34);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Date";
            // 
            // lbl_loadpro
            // 
            this.lbl_loadpro.AutoSize = true;
            this.lbl_loadpro.Font = new System.Drawing.Font("Gadugi", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loadpro.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_loadpro.Location = new System.Drawing.Point(115, 22);
            this.lbl_loadpro.Name = "lbl_loadpro";
            this.lbl_loadpro.Size = new System.Drawing.Size(624, 63);
            this.lbl_loadpro.TabIndex = 0;
            this.lbl_loadpro.Text = "Hotel Room Reservation";
            // 
            // pgbar
            // 
            this.pgbar.BackColor = System.Drawing.Color.Green;
            this.pgbar.Location = new System.Drawing.Point(15, 389);
            this.pgbar.Name = "pgbar";
            this.pgbar.Size = new System.Drawing.Size(819, 48);
            this.pgbar.TabIndex = 3;
            this.pgbar.Click += new System.EventHandler(this.pgbar_Click);
            // 
            // lbl_load
            // 
            this.lbl_load.AutoSize = true;
            this.lbl_load.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_load.ForeColor = System.Drawing.Color.Turquoise;
            this.lbl_load.Location = new System.Drawing.Point(199, 330);
            this.lbl_load.Name = "lbl_load";
            this.lbl_load.Size = new System.Drawing.Size(485, 44);
            this.lbl_load.TabIndex = 0;
            this.lbl_load.Text = "Application Loading ....";
            this.lbl_load.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // loadProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 464);
            this.Controls.Add(this.panel_guest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loadProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loadProject";
            this.panel_guest.ResumeLayout(false);
            this.panel_guest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_guest;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_loadpro;
        private System.Windows.Forms.ProgressBar pgbar;
        private System.Windows.Forms.Label lbl_load;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}