
namespace HotelRoomBookingSystem
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.panel_guest = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_staffinfo = new System.Windows.Forms.Label();
            this.gpbox_staff = new System.Windows.Forms.GroupBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.pic_datareset = new System.Windows.Forms.PictureBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.DataGridStaff = new System.Windows.Forms.DataGridView();
            this.pc_reset = new System.Windows.Forms.PictureBox();
            this.btn_searchname = new System.Windows.Forms.Button();
            this.txt_searchname = new System.Windows.Forms.TextBox();
            this.lbl_name_search = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Back = new System.Windows.Forms.PictureBox();
            this.panel_guest.SuspendLayout();
            this.gpbox_staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_datareset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_guest
            // 
            this.panel_guest.BackColor = System.Drawing.Color.DarkCyan;
            this.panel_guest.Controls.Add(this.Back);
            this.panel_guest.Controls.Add(this.lbl_date);
            this.panel_guest.Controls.Add(this.lbl_staffinfo);
            this.panel_guest.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_guest.Location = new System.Drawing.Point(0, 0);
            this.panel_guest.Name = "panel_guest";
            this.panel_guest.Size = new System.Drawing.Size(1291, 107);
            this.panel_guest.TabIndex = 1;
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
            // lbl_staffinfo
            // 
            this.lbl_staffinfo.AutoSize = true;
            this.lbl_staffinfo.Font = new System.Drawing.Font("Gadugi", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staffinfo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_staffinfo.Location = new System.Drawing.Point(459, 20);
            this.lbl_staffinfo.Name = "lbl_staffinfo";
            this.lbl_staffinfo.Size = new System.Drawing.Size(452, 63);
            this.lbl_staffinfo.TabIndex = 0;
            this.lbl_staffinfo.Text = "Staff Information";
            // 
            // gpbox_staff
            // 
            this.gpbox_staff.BackColor = System.Drawing.Color.Gainsboro;
            this.gpbox_staff.Controls.Add(this.comboBox_gender);
            this.gpbox_staff.Controls.Add(this.pic_datareset);
            this.gpbox_staff.Controls.Add(this.lbl_id);
            this.gpbox_staff.Controls.Add(this.btn_edit);
            this.gpbox_staff.Controls.Add(this.lbl_fname);
            this.gpbox_staff.Controls.Add(this.btn_delete);
            this.gpbox_staff.Controls.Add(this.lbl_lname);
            this.gpbox_staff.Controls.Add(this.btn_add);
            this.gpbox_staff.Controls.Add(this.lbl_address);
            this.gpbox_staff.Controls.Add(this.lbl_dob);
            this.gpbox_staff.Controls.Add(this.txt_name);
            this.gpbox_staff.Controls.Add(this.txt_id);
            this.gpbox_staff.Controls.Add(this.txt_phone);
            this.gpbox_staff.Controls.Add(this.txt_pass);
            this.gpbox_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbox_staff.Location = new System.Drawing.Point(0, 106);
            this.gpbox_staff.Name = "gpbox_staff";
            this.gpbox_staff.Size = new System.Drawing.Size(470, 639);
            this.gpbox_staff.TabIndex = 8;
            this.gpbox_staff.TabStop = false;
            this.gpbox_staff.Enter += new System.EventHandler(this.gpbox_staff_Enter);
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_gender.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_gender.Location = new System.Drawing.Point(210, 381);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(216, 33);
            this.comboBox_gender.TabIndex = 8;
            this.comboBox_gender.Text = "   Gender";
            // 
            // pic_datareset
            // 
            this.pic_datareset.Image = ((System.Drawing.Image)(resources.GetObject("pic_datareset.Image")));
            this.pic_datareset.Location = new System.Drawing.Point(301, 52);
            this.pic_datareset.Name = "pic_datareset";
            this.pic_datareset.Size = new System.Drawing.Size(115, 78);
            this.pic_datareset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_datareset.TabIndex = 7;
            this.pic_datareset.TabStop = false;
            this.pic_datareset.Click += new System.EventHandler(this.pic_datareset_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(29, 93);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(75, 23);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "Satff ID";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.Location = new System.Drawing.Point(188, 554);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(86, 58);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.ForeColor = System.Drawing.Color.Black;
            this.lbl_fname.Location = new System.Drawing.Point(29, 159);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(101, 23);
            this.lbl_fname.TabIndex = 1;
            this.lbl_fname.Text = "Staff Name";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(332, 554);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(93, 58);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lname.Location = new System.Drawing.Point(29, 230);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(91, 23);
            this.lbl_lname.TabIndex = 1;
            this.lbl_lname.Text = "Staff Pass";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DimGray;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(33, 554);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 58);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(29, 308);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(106, 23);
            this.lbl_address.TabIndex = 1;
            this.lbl_address.Text = "Staff Phone";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Font = new System.Drawing.Font("Bodoni MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.Location = new System.Drawing.Point(29, 387);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(113, 23);
            this.lbl_dob.TabIndex = 1;
            this.lbl_dob.Text = "Staff Gender";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(210, 152);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(216, 30);
            this.txt_name.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_id.Location = new System.Drawing.Point(210, 86);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(42, 30);
            this.txt_id.TabIndex = 2;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(210, 301);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(216, 30);
            this.txt_phone.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(210, 223);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(216, 30);
            this.txt_pass.TabIndex = 2;
            // 
            // DataGridStaff
            // 
            this.DataGridStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridStaff.Location = new System.Drawing.Point(476, 199);
            this.DataGridStaff.Name = "DataGridStaff";
            this.DataGridStaff.RowHeadersWidth = 62;
            this.DataGridStaff.RowTemplate.Height = 28;
            this.DataGridStaff.Size = new System.Drawing.Size(805, 546);
            this.DataGridStaff.TabIndex = 9;
            this.DataGridStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridStaff_CellContentClick);
            // 
            // pc_reset
            // 
            this.pc_reset.Image = ((System.Drawing.Image)(resources.GetObject("pc_reset.Image")));
            this.pc_reset.Location = new System.Drawing.Point(995, 134);
            this.pc_reset.Name = "pc_reset";
            this.pc_reset.Size = new System.Drawing.Size(81, 43);
            this.pc_reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_reset.TabIndex = 13;
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
            this.btn_searchname.Location = new System.Drawing.Point(892, 133);
            this.btn_searchname.Name = "btn_searchname";
            this.btn_searchname.Size = new System.Drawing.Size(97, 43);
            this.btn_searchname.TabIndex = 12;
            this.btn_searchname.Text = "Search";
            this.btn_searchname.UseVisualStyleBackColor = false;
            this.btn_searchname.Click += new System.EventHandler(this.btn_searchname_Click);
            // 
            // txt_searchname
            // 
            this.txt_searchname.Location = new System.Drawing.Point(692, 145);
            this.txt_searchname.Name = "txt_searchname";
            this.txt_searchname.Size = new System.Drawing.Size(204, 26);
            this.txt_searchname.TabIndex = 11;
            // 
            // lbl_name_search
            // 
            this.lbl_name_search.AutoSize = true;
            this.lbl_name_search.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_search.Location = new System.Drawing.Point(600, 139);
            this.lbl_name_search.Name = "lbl_name_search";
            this.lbl_name_search.Size = new System.Drawing.Size(86, 43);
            this.lbl_name_search.TabIndex = 10;
            this.lbl_name_search.Text = "Name";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(33, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(76, 61);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 25;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 768);
            this.Controls.Add(this.pc_reset);
            this.Controls.Add(this.btn_searchname);
            this.Controls.Add(this.txt_searchname);
            this.Controls.Add(this.lbl_name_search);
            this.Controls.Add(this.DataGridStaff);
            this.Controls.Add(this.gpbox_staff);
            this.Controls.Add(this.panel_guest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel_guest.ResumeLayout(false);
            this.panel_guest.PerformLayout();
            this.gpbox_staff.ResumeLayout(false);
            this.gpbox_staff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_datareset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_guest;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_staffinfo;
        private System.Windows.Forms.GroupBox gpbox_staff;
        private System.Windows.Forms.PictureBox pic_datareset;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.DataGridView DataGridStaff;
        private System.Windows.Forms.PictureBox pc_reset;
        private System.Windows.Forms.Button btn_searchname;
        private System.Windows.Forms.TextBox txt_searchname;
        private System.Windows.Forms.Label lbl_name_search;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox Back;
    }
}