
namespace HotelRoomBookingSystem
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.panel_guest = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.PictureBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_roominfo = new System.Windows.Forms.Label();
            this.gpbox_staff = new System.Windows.Forms.GroupBox();
            this.rb_busy = new System.Windows.Forms.RadioButton();
            this.rb_free = new System.Windows.Forms.RadioButton();
            this.pic_datareset = new System.Windows.Forms.PictureBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_free = new System.Windows.Forms.Label();
            this.lbl_busy = new System.Windows.Forms.Label();
            this.lbl_st = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pc_reset = new System.Windows.Forms.PictureBox();
            this.btn_searchname = new System.Windows.Forms.Button();
            this.txt_searchname = new System.Windows.Forms.TextBox();
            this.lbl_name_search = new System.Windows.Forms.Label();
            this.DataGridRoom = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_guest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.gpbox_staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_datareset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_guest
            // 
            this.panel_guest.BackColor = System.Drawing.Color.DarkCyan;
            this.panel_guest.Controls.Add(this.Back);
            this.panel_guest.Controls.Add(this.lbl_date);
            this.panel_guest.Controls.Add(this.lbl_roominfo);
            this.panel_guest.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_guest.Location = new System.Drawing.Point(0, 0);
            this.panel_guest.Name = "panel_guest";
            this.panel_guest.Size = new System.Drawing.Size(1291, 107);
            this.panel_guest.TabIndex = 2;
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(33, 22);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(76, 61);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 25;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_date.Location = new System.Drawing.Point(1053, 49);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(77, 34);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Date";
            // 
            // lbl_roominfo
            // 
            this.lbl_roominfo.AutoSize = true;
            this.lbl_roominfo.Font = new System.Drawing.Font("Gadugi", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roominfo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_roominfo.Location = new System.Drawing.Point(459, 20);
            this.lbl_roominfo.Name = "lbl_roominfo";
            this.lbl_roominfo.Size = new System.Drawing.Size(481, 63);
            this.lbl_roominfo.TabIndex = 0;
            this.lbl_roominfo.Text = "Room Information";
            // 
            // gpbox_staff
            // 
            this.gpbox_staff.BackColor = System.Drawing.Color.Gainsboro;
            this.gpbox_staff.Controls.Add(this.rb_busy);
            this.gpbox_staff.Controls.Add(this.rb_free);
            this.gpbox_staff.Controls.Add(this.pic_datareset);
            this.gpbox_staff.Controls.Add(this.lbl_id);
            this.gpbox_staff.Controls.Add(this.btn_edit);
            this.gpbox_staff.Controls.Add(this.lbl_phone);
            this.gpbox_staff.Controls.Add(this.btn_delete);
            this.gpbox_staff.Controls.Add(this.lbl_free);
            this.gpbox_staff.Controls.Add(this.lbl_busy);
            this.gpbox_staff.Controls.Add(this.lbl_st);
            this.gpbox_staff.Controls.Add(this.btn_add);
            this.gpbox_staff.Controls.Add(this.txt_phone);
            this.gpbox_staff.Controls.Add(this.txt_id);
            this.gpbox_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbox_staff.Location = new System.Drawing.Point(0, 108);
            this.gpbox_staff.Name = "gpbox_staff";
            this.gpbox_staff.Size = new System.Drawing.Size(470, 630);
            this.gpbox_staff.TabIndex = 9;
            this.gpbox_staff.TabStop = false;
            // 
            // rb_busy
            // 
            this.rb_busy.AutoSize = true;
            this.rb_busy.ForeColor = System.Drawing.Color.MediumBlue;
            this.rb_busy.Location = new System.Drawing.Point(405, 275);
            this.rb_busy.Name = "rb_busy";
            this.rb_busy.Size = new System.Drawing.Size(21, 20);
            this.rb_busy.TabIndex = 9;
            this.rb_busy.TabStop = true;
            this.rb_busy.UseVisualStyleBackColor = true;
            // 
            // rb_free
            // 
            this.rb_free.AutoSize = true;
            this.rb_free.ForeColor = System.Drawing.Color.MediumBlue;
            this.rb_free.Location = new System.Drawing.Point(269, 278);
            this.rb_free.Name = "rb_free";
            this.rb_free.Size = new System.Drawing.Size(21, 20);
            this.rb_free.TabIndex = 9;
            this.rb_free.TabStop = true;
            this.rb_free.UseVisualStyleBackColor = true;
            // 
            // pic_datareset
            // 
            this.pic_datareset.Image = ((System.Drawing.Image)(resources.GetObject("pic_datareset.Image")));
            this.pic_datareset.Location = new System.Drawing.Point(322, 108);
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
            this.lbl_id.Size = new System.Drawing.Size(87, 23);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "Room ID";
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
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.Color.Black;
            this.lbl_phone.Location = new System.Drawing.Point(29, 204);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(118, 23);
            this.lbl_phone.TabIndex = 1;
            this.lbl_phone.Text = "Room Phone";
            this.lbl_phone.Click += new System.EventHandler(this.lbl_fname_Click);
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
            // lbl_free
            // 
            this.lbl_free.AutoSize = true;
            this.lbl_free.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_free.Location = new System.Drawing.Point(206, 275);
            this.lbl_free.Name = "lbl_free";
            this.lbl_free.Size = new System.Drawing.Size(48, 23);
            this.lbl_free.TabIndex = 1;
            this.lbl_free.Text = "Free";
            // 
            // lbl_busy
            // 
            this.lbl_busy.AutoSize = true;
            this.lbl_busy.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busy.Location = new System.Drawing.Point(328, 275);
            this.lbl_busy.Name = "lbl_busy";
            this.lbl_busy.Size = new System.Drawing.Size(52, 23);
            this.lbl_busy.TabIndex = 1;
            this.lbl_busy.Text = "Busy";
            // 
            // lbl_st
            // 
            this.lbl_st.AutoSize = true;
            this.lbl_st.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_st.Location = new System.Drawing.Point(29, 275);
            this.lbl_st.Name = "lbl_st";
            this.lbl_st.Size = new System.Drawing.Size(116, 23);
            this.lbl_st.TabIndex = 1;
            this.lbl_st.Text = "Room Status";
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
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(210, 197);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(216, 30);
            this.txt_phone.TabIndex = 2;
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
            this.pc_reset.Location = new System.Drawing.Point(984, 129);
            this.pc_reset.Name = "pc_reset";
            this.pc_reset.Size = new System.Drawing.Size(80, 41);
            this.pc_reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_reset.TabIndex = 18;
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
            this.btn_searchname.Location = new System.Drawing.Point(890, 131);
            this.btn_searchname.Name = "btn_searchname";
            this.btn_searchname.Size = new System.Drawing.Size(96, 41);
            this.btn_searchname.TabIndex = 17;
            this.btn_searchname.Text = "Search";
            this.btn_searchname.UseVisualStyleBackColor = false;
            this.btn_searchname.Click += new System.EventHandler(this.btn_searchname_Click);
            // 
            // txt_searchname
            // 
            this.txt_searchname.Location = new System.Drawing.Point(681, 140);
            this.txt_searchname.Name = "txt_searchname";
            this.txt_searchname.Size = new System.Drawing.Size(203, 26);
            this.txt_searchname.TabIndex = 16;
            // 
            // lbl_name_search
            // 
            this.lbl_name_search.AutoSize = true;
            this.lbl_name_search.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_search.Location = new System.Drawing.Point(555, 135);
            this.lbl_name_search.Name = "lbl_name_search";
            this.lbl_name_search.Size = new System.Drawing.Size(120, 43);
            this.lbl_name_search.TabIndex = 15;
            this.lbl_name_search.Text = "Room ID";
            // 
            // DataGridRoom
            // 
            this.DataGridRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridRoom.Location = new System.Drawing.Point(476, 206);
            this.DataGridRoom.Name = "DataGridRoom";
            this.DataGridRoom.RowHeadersWidth = 62;
            this.DataGridRoom.RowTemplate.Height = 28;
            this.DataGridRoom.Size = new System.Drawing.Size(805, 532);
            this.DataGridRoom.TabIndex = 14;
            this.DataGridRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridRoom_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 768);
            this.Controls.Add(this.pc_reset);
            this.Controls.Add(this.btn_searchname);
            this.Controls.Add(this.txt_searchname);
            this.Controls.Add(this.lbl_name_search);
            this.Controls.Add(this.DataGridRoom);
            this.Controls.Add(this.gpbox_staff);
            this.Controls.Add(this.panel_guest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            this.panel_guest.ResumeLayout(false);
            this.panel_guest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.gpbox_staff.ResumeLayout(false);
            this.gpbox_staff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_datareset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_guest;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_roominfo;
        private System.Windows.Forms.GroupBox gpbox_staff;
        private System.Windows.Forms.PictureBox pic_datareset;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_st;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.PictureBox pc_reset;
        private System.Windows.Forms.Button btn_searchname;
        private System.Windows.Forms.TextBox txt_searchname;
        private System.Windows.Forms.Label lbl_name_search;
        private System.Windows.Forms.DataGridView DataGridRoom;
        private System.Windows.Forms.RadioButton rb_busy;
        private System.Windows.Forms.RadioButton rb_free;
        private System.Windows.Forms.Label lbl_free;
        private System.Windows.Forms.Label lbl_busy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Back;
    }
}