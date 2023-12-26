
namespace HotelRoomBookingSystem
{
    partial class Guest_tbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest_tbl));
            this.panel_guest = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_dob = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.DataGridGuest = new System.Windows.Forms.DataGridView();
            this.lbl_name_search = new System.Windows.Forms.Label();
            this.txt_searchname = new System.Windows.Forms.TextBox();
            this.btn_searchname = new System.Windows.Forms.Button();
            this.pc_reset = new System.Windows.Forms.PictureBox();
            this.btn_addGuest = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.gpbox_guest = new System.Windows.Forms.GroupBox();
            this.pic_datareset = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            this.panel_guest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_reset)).BeginInit();
            this.gpbox_guest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_datareset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_guest
            // 
            this.panel_guest.BackColor = System.Drawing.Color.DarkCyan;
            this.panel_guest.Controls.Add(this.Back);
            this.panel_guest.Controls.Add(this.lbl_date);
            this.panel_guest.Controls.Add(this.label1);
            this.panel_guest.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_guest.Location = new System.Drawing.Point(-2, -1);
            this.panel_guest.Name = "panel_guest";
            this.panel_guest.Size = new System.Drawing.Size(1317, 107);
            this.panel_guest.TabIndex = 0;
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
            this.lbl_date.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(459, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guest Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.ForeColor = System.Drawing.Color.Black;
            this.lbl_fname.Location = new System.Drawing.Point(25, 99);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(102, 23);
            this.lbl_fname.TabIndex = 1;
            this.lbl_fname.Text = "First Name";
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(206, 92);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(216, 30);
            this.txt_fname.TabIndex = 2;
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lname.Location = new System.Drawing.Point(25, 170);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(99, 23);
            this.lbl_lname.TabIndex = 1;
            this.lbl_lname.Text = "Last Name";
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(206, 163);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(216, 30);
            this.txt_lname.TabIndex = 2;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(25, 248);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(77, 23);
            this.lbl_address.TabIndex = 1;
            this.lbl_address.Text = "Address";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.Location = new System.Drawing.Point(25, 327);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(118, 23);
            this.lbl_dob.TabIndex = 1;
            this.lbl_dob.Text = "Date of Birth";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(206, 241);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(216, 30);
            this.txt_address.TabIndex = 2;
            // 
            // txt_dob
            // 
            this.txt_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dob.Location = new System.Drawing.Point(206, 320);
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(216, 30);
            this.txt_dob.TabIndex = 2;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(25, 486);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(59, 23);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email";
            this.lbl_email.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(206, 486);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(216, 30);
            this.txt_email.TabIndex = 2;
            this.txt_email.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(25, 407);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(63, 23);
            this.lbl_phone.TabIndex = 1;
            this.lbl_phone.Text = "Phone";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(206, 400);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(216, 30);
            this.txt_phone.TabIndex = 2;
            // 
            // DataGridGuest
            // 
            this.DataGridGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridGuest.Location = new System.Drawing.Point(484, 191);
            this.DataGridGuest.Name = "DataGridGuest";
            this.DataGridGuest.RowHeadersWidth = 62;
            this.DataGridGuest.RowTemplate.Height = 28;
            this.DataGridGuest.Size = new System.Drawing.Size(805, 557);
            this.DataGridGuest.TabIndex = 3;
            this.DataGridGuest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridGuest_CellContentClick);
            // 
            // lbl_name_search
            // 
            this.lbl_name_search.AutoSize = true;
            this.lbl_name_search.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_search.Location = new System.Drawing.Point(635, 132);
            this.lbl_name_search.Name = "lbl_name_search";
            this.lbl_name_search.Size = new System.Drawing.Size(86, 43);
            this.lbl_name_search.TabIndex = 1;
            this.lbl_name_search.Text = "Name";
            // 
            // txt_searchname
            // 
            this.txt_searchname.Location = new System.Drawing.Point(727, 138);
            this.txt_searchname.Name = "txt_searchname";
            this.txt_searchname.Size = new System.Drawing.Size(204, 26);
            this.txt_searchname.TabIndex = 2;
            // 
            // btn_searchname
            // 
            this.btn_searchname.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_searchname.FlatAppearance.BorderSize = 0;
            this.btn_searchname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchname.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_searchname.Location = new System.Drawing.Point(927, 126);
            this.btn_searchname.Name = "btn_searchname";
            this.btn_searchname.Size = new System.Drawing.Size(97, 43);
            this.btn_searchname.TabIndex = 4;
            this.btn_searchname.Text = "Search";
            this.btn_searchname.UseVisualStyleBackColor = false;
            this.btn_searchname.Click += new System.EventHandler(this.btn_searchname_Click);
            // 
            // pc_reset
            // 
            this.pc_reset.Image = ((System.Drawing.Image)(resources.GetObject("pc_reset.Image")));
            this.pc_reset.Location = new System.Drawing.Point(1030, 127);
            this.pc_reset.Name = "pc_reset";
            this.pc_reset.Size = new System.Drawing.Size(81, 43);
            this.pc_reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_reset.TabIndex = 5;
            this.pc_reset.TabStop = false;
            this.pc_reset.Click += new System.EventHandler(this.pc_reset_Click);
            // 
            // btn_addGuest
            // 
            this.btn_addGuest.BackColor = System.Drawing.Color.DimGray;
            this.btn_addGuest.FlatAppearance.BorderSize = 0;
            this.btn_addGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addGuest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addGuest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addGuest.Location = new System.Drawing.Point(33, 565);
            this.btn_addGuest.Name = "btn_addGuest";
            this.btn_addGuest.Size = new System.Drawing.Size(86, 58);
            this.btn_addGuest.TabIndex = 6;
            this.btn_addGuest.Text = "ADD";
            this.btn_addGuest.UseVisualStyleBackColor = false;
            this.btn_addGuest.Click += new System.EventHandler(this.btn_addGuest_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(329, 565);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(93, 58);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.Location = new System.Drawing.Point(181, 565);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(86, 58);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(25, 33);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(84, 23);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "Guest ID";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_id.Location = new System.Drawing.Point(206, 26);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(42, 30);
            this.txt_id.TabIndex = 2;
            // 
            // gpbox_guest
            // 
            this.gpbox_guest.BackColor = System.Drawing.Color.Gainsboro;
            this.gpbox_guest.Controls.Add(this.pic_datareset);
            this.gpbox_guest.Controls.Add(this.lbl_id);
            this.gpbox_guest.Controls.Add(this.btn_edit);
            this.gpbox_guest.Controls.Add(this.lbl_fname);
            this.gpbox_guest.Controls.Add(this.btn_delete);
            this.gpbox_guest.Controls.Add(this.lbl_lname);
            this.gpbox_guest.Controls.Add(this.btn_addGuest);
            this.gpbox_guest.Controls.Add(this.lbl_address);
            this.gpbox_guest.Controls.Add(this.lbl_dob);
            this.gpbox_guest.Controls.Add(this.lbl_phone);
            this.gpbox_guest.Controls.Add(this.lbl_email);
            this.gpbox_guest.Controls.Add(this.txt_email);
            this.gpbox_guest.Controls.Add(this.txt_fname);
            this.gpbox_guest.Controls.Add(this.txt_phone);
            this.gpbox_guest.Controls.Add(this.txt_id);
            this.gpbox_guest.Controls.Add(this.txt_dob);
            this.gpbox_guest.Controls.Add(this.txt_address);
            this.gpbox_guest.Controls.Add(this.txt_lname);
            this.gpbox_guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbox_guest.Location = new System.Drawing.Point(-2, 105);
            this.gpbox_guest.Name = "gpbox_guest";
            this.gpbox_guest.Size = new System.Drawing.Size(470, 643);
            this.gpbox_guest.TabIndex = 7;
            this.gpbox_guest.TabStop = false;
            // 
            // pic_datareset
            // 
            this.pic_datareset.Image = ((System.Drawing.Image)(resources.GetObject("pic_datareset.Image")));
            this.pic_datareset.Location = new System.Drawing.Point(297, -8);
            this.pic_datareset.Name = "pic_datareset";
            this.pic_datareset.Size = new System.Drawing.Size(115, 78);
            this.pic_datareset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_datareset.TabIndex = 7;
            this.pic_datareset.TabStop = false;
            this.pic_datareset.Click += new System.EventHandler(this.pic_datareset_Click);
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(33, 20);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(81, 70);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 7;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Guest_tbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 760);
            this.Controls.Add(this.gpbox_guest);
            this.Controls.Add(this.pc_reset);
            this.Controls.Add(this.btn_searchname);
            this.Controls.Add(this.DataGridGuest);
            this.Controls.Add(this.txt_searchname);
            this.Controls.Add(this.lbl_name_search);
            this.Controls.Add(this.panel_guest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Guest_tbl";
            this.Text = "Guest";
            this.Load += new System.EventHandler(this.Guest_tbl_Load);
            this.panel_guest.ResumeLayout(false);
            this.panel_guest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_reset)).EndInit();
            this.gpbox_guest.ResumeLayout(false);
            this.gpbox_guest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_datareset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_guest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_dob;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.DataGridView DataGridGuest;
        private System.Windows.Forms.Label lbl_name_search;
        private System.Windows.Forms.TextBox txt_searchname;
        private System.Windows.Forms.Button btn_searchname;
        private System.Windows.Forms.PictureBox pc_reset;
        private System.Windows.Forms.Button btn_addGuest;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.GroupBox gpbox_guest;
        private System.Windows.Forms.PictureBox pic_datareset;
        private System.Windows.Forms.PictureBox Back;
    }
}