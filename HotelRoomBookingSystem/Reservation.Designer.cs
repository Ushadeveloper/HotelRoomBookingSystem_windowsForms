
namespace HotelRoomBookingSystem
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.panel_res = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.PictureBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_resinfo = new System.Windows.Forms.Label();
            this.gpbox_res = new System.Windows.Forms.GroupBox();
            this.cb_roomid = new System.Windows.Forms.ComboBox();
            this.cb_guestname = new System.Windows.Forms.ComboBox();
            this.dtp_checkout = new System.Windows.Forms.DateTimePicker();
            this.dtp_checkin = new System.Windows.Forms.DateTimePicker();
            this.pic_datareset = new System.Windows.Forms.PictureBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_checkin = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_checkout = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_rmid = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pc_reset = new System.Windows.Forms.PictureBox();
            this.btn_searchname = new System.Windows.Forms.Button();
            this.txt_searchname = new System.Windows.Forms.TextBox();
            this.lbl_name_search = new System.Windows.Forms.Label();
            this.DataGridRes = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_res.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.gpbox_res.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_datareset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_res
            // 
            this.panel_res.BackColor = System.Drawing.Color.DarkCyan;
            this.panel_res.Controls.Add(this.Back);
            this.panel_res.Controls.Add(this.lbl_date);
            this.panel_res.Controls.Add(this.lbl_resinfo);
            this.panel_res.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_res.Location = new System.Drawing.Point(0, -2);
            this.panel_res.Name = "panel_res";
            this.panel_res.Size = new System.Drawing.Size(1291, 110);
            this.panel_res.TabIndex = 3;
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(33, 24);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(76, 61);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 24;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_date.Location = new System.Drawing.Point(1079, 51);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(77, 34);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Date";
            // 
            // lbl_resinfo
            // 
            this.lbl_resinfo.AutoSize = true;
            this.lbl_resinfo.Font = new System.Drawing.Font("Gadugi", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resinfo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_resinfo.Location = new System.Drawing.Point(345, 22);
            this.lbl_resinfo.Name = "lbl_resinfo";
            this.lbl_resinfo.Size = new System.Drawing.Size(623, 63);
            this.lbl_resinfo.TabIndex = 0;
            this.lbl_resinfo.Text = "Reservation Information";
            // 
            // gpbox_res
            // 
            this.gpbox_res.BackColor = System.Drawing.Color.Gainsboro;
            this.gpbox_res.Controls.Add(this.cb_roomid);
            this.gpbox_res.Controls.Add(this.cb_guestname);
            this.gpbox_res.Controls.Add(this.dtp_checkout);
            this.gpbox_res.Controls.Add(this.dtp_checkin);
            this.gpbox_res.Controls.Add(this.pic_datareset);
            this.gpbox_res.Controls.Add(this.lbl_id);
            this.gpbox_res.Controls.Add(this.btn_edit);
            this.gpbox_res.Controls.Add(this.lbl_checkin);
            this.gpbox_res.Controls.Add(this.lbl_name);
            this.gpbox_res.Controls.Add(this.lbl_checkout);
            this.gpbox_res.Controls.Add(this.btn_delete);
            this.gpbox_res.Controls.Add(this.lbl_rmid);
            this.gpbox_res.Controls.Add(this.btn_add);
            this.gpbox_res.Controls.Add(this.txt_id);
            this.gpbox_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbox_res.Location = new System.Drawing.Point(0, 109);
            this.gpbox_res.Name = "gpbox_res";
            this.gpbox_res.Size = new System.Drawing.Size(470, 623);
            this.gpbox_res.TabIndex = 10;
            this.gpbox_res.TabStop = false;
            // 
            // cb_roomid
            // 
            this.cb_roomid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_roomid.FormattingEnabled = true;
            this.cb_roomid.Location = new System.Drawing.Point(209, 265);
            this.cb_roomid.Name = "cb_roomid";
            this.cb_roomid.Size = new System.Drawing.Size(216, 33);
            this.cb_roomid.TabIndex = 9;
            this.cb_roomid.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_guestname
            // 
            this.cb_guestname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_guestname.FormattingEnabled = true;
            this.cb_guestname.Location = new System.Drawing.Point(209, 194);
            this.cb_guestname.Name = "cb_guestname";
            this.cb_guestname.Size = new System.Drawing.Size(216, 33);
            this.cb_guestname.TabIndex = 9;
            this.cb_guestname.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtp_checkout
            // 
            this.dtp_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_checkout.Location = new System.Drawing.Point(210, 418);
            this.dtp_checkout.Name = "dtp_checkout";
            this.dtp_checkout.Size = new System.Drawing.Size(215, 30);
            this.dtp_checkout.TabIndex = 8;
            this.dtp_checkout.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtp_checkin
            // 
            this.dtp_checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_checkin.Location = new System.Drawing.Point(210, 338);
            this.dtp_checkin.Name = "dtp_checkin";
            this.dtp_checkin.Size = new System.Drawing.Size(215, 30);
            this.dtp_checkin.TabIndex = 8;
            this.dtp_checkin.ValueChanged += new System.EventHandler(this.dtp_checkin_ValueChanged);
            // 
            // pic_datareset
            // 
            this.pic_datareset.Image = ((System.Drawing.Image)(resources.GetObject("pic_datareset.Image")));
            this.pic_datareset.Location = new System.Drawing.Point(322, 97);
            this.pic_datareset.Name = "pic_datareset";
            this.pic_datareset.Size = new System.Drawing.Size(103, 64);
            this.pic_datareset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_datareset.TabIndex = 7;
            this.pic_datareset.TabStop = false;
            this.pic_datareset.Click += new System.EventHandler(this.pic_datareset_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(29, 138);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(136, 23);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "Reservation ID";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.Location = new System.Drawing.Point(185, 528);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(86, 58);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lbl_checkin
            // 
            this.lbl_checkin.AutoSize = true;
            this.lbl_checkin.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkin.ForeColor = System.Drawing.Color.Black;
            this.lbl_checkin.Location = new System.Drawing.Point(29, 345);
            this.lbl_checkin.Name = "lbl_checkin";
            this.lbl_checkin.Size = new System.Drawing.Size(80, 23);
            this.lbl_checkin.TabIndex = 1;
            this.lbl_checkin.Text = "CheckIn";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(29, 204);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(110, 23);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Guest Name";
            // 
            // lbl_checkout
            // 
            this.lbl_checkout.AutoSize = true;
            this.lbl_checkout.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkout.Location = new System.Drawing.Point(29, 425);
            this.lbl_checkout.Name = "lbl_checkout";
            this.lbl_checkout.Size = new System.Drawing.Size(91, 23);
            this.lbl_checkout.TabIndex = 1;
            this.lbl_checkout.Text = "CheckOut";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(333, 528);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(93, 58);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_rmid
            // 
            this.lbl_rmid.AutoSize = true;
            this.lbl_rmid.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rmid.Location = new System.Drawing.Point(29, 275);
            this.lbl_rmid.Name = "lbl_rmid";
            this.lbl_rmid.Size = new System.Drawing.Size(87, 23);
            this.lbl_rmid.TabIndex = 1;
            this.lbl_rmid.Text = "Room ID";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DimGray;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(33, 528);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 58);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_id.Location = new System.Drawing.Point(210, 131);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(42, 30);
            this.txt_id.TabIndex = 2;
            // 
            // pc_reset
            // 
            this.pc_reset.Image = ((System.Drawing.Image)(resources.GetObject("pc_reset.Image")));
            this.pc_reset.Location = new System.Drawing.Point(1003, 124);
            this.pc_reset.Name = "pc_reset";
            this.pc_reset.Size = new System.Drawing.Size(80, 41);
            this.pc_reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_reset.TabIndex = 23;
            this.pc_reset.TabStop = false;
            this.pc_reset.Click += new System.EventHandler(this.pc_reset_Click);
            // 
            // btn_searchname
            // 
            this.btn_searchname.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_searchname.FlatAppearance.BorderSize = 0;
            this.btn_searchname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchname.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_searchname.Location = new System.Drawing.Point(890, 124);
            this.btn_searchname.Name = "btn_searchname";
            this.btn_searchname.Size = new System.Drawing.Size(96, 41);
            this.btn_searchname.TabIndex = 22;
            this.btn_searchname.Text = "Search";
            this.btn_searchname.UseVisualStyleBackColor = false;
            this.btn_searchname.Click += new System.EventHandler(this.btn_searchname_Click);
            // 
            // txt_searchname
            // 
            this.txt_searchname.Location = new System.Drawing.Point(681, 134);
            this.txt_searchname.Name = "txt_searchname";
            this.txt_searchname.Size = new System.Drawing.Size(203, 26);
            this.txt_searchname.TabIndex = 21;
            // 
            // lbl_name_search
            // 
            this.lbl_name_search.AutoSize = true;
            this.lbl_name_search.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_search.Location = new System.Drawing.Point(576, 132);
            this.lbl_name_search.Name = "lbl_name_search";
            this.lbl_name_search.Size = new System.Drawing.Size(61, 28);
            this.lbl_name_search.TabIndex = 20;
            this.lbl_name_search.Text = "Res ID";
            // 
            // DataGridRes
            // 
            this.DataGridRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridRes.Location = new System.Drawing.Point(476, 200);
            this.DataGridRes.Name = "DataGridRes";
            this.DataGridRes.RowHeadersWidth = 62;
            this.DataGridRes.RowTemplate.Height = 28;
            this.DataGridRes.Size = new System.Drawing.Size(805, 532);
            this.DataGridRes.TabIndex = 19;
            this.DataGridRes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridRes_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 768);
            this.Controls.Add(this.pc_reset);
            this.Controls.Add(this.btn_searchname);
            this.Controls.Add(this.txt_searchname);
            this.Controls.Add(this.lbl_name_search);
            this.Controls.Add(this.DataGridRes);
            this.Controls.Add(this.gpbox_res);
            this.Controls.Add(this.panel_res);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.panel_res.ResumeLayout(false);
            this.panel_res.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.gpbox_res.ResumeLayout(false);
            this.gpbox_res.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_datareset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_res;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_resinfo;
        private System.Windows.Forms.GroupBox gpbox_res;
        private System.Windows.Forms.PictureBox pic_datareset;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_rmid;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DateTimePicker dtp_checkout;
        private System.Windows.Forms.DateTimePicker dtp_checkin;
        private System.Windows.Forms.Label lbl_checkin;
        private System.Windows.Forms.Label lbl_checkout;
        private System.Windows.Forms.PictureBox pc_reset;
        private System.Windows.Forms.Button btn_searchname;
        private System.Windows.Forms.TextBox txt_searchname;
        private System.Windows.Forms.Label lbl_name_search;
        private System.Windows.Forms.DataGridView DataGridRes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cb_guestname;
        private System.Windows.Forms.ComboBox cb_roomid;
        private System.Windows.Forms.PictureBox Back;
    }
}