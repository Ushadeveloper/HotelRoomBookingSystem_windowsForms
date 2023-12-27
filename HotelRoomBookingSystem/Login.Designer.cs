
namespace HotelRoomBookingSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Hotellbl = new System.Windows.Forms.Label();
            this.txtboxusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.log_in = new System.Windows.Forms.Button();
            this.pb_username = new System.Windows.Forms.PictureBox();
            this.pb_pass = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hotellbl
            // 
            this.Hotellbl.AutoSize = true;
            this.Hotellbl.BackColor = System.Drawing.Color.Transparent;
            this.Hotellbl.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hotellbl.ForeColor = System.Drawing.Color.Black;
            this.Hotellbl.Location = new System.Drawing.Point(133, 9);
            this.Hotellbl.Name = "Hotellbl";
            this.Hotellbl.Size = new System.Drawing.Size(83, 34);
            this.Hotellbl.TabIndex = 0;
            this.Hotellbl.Text = "Login";
            this.Hotellbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxusername
            // 
            this.txtboxusername.BackColor = System.Drawing.Color.White;
            this.txtboxusername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtboxusername.Location = new System.Drawing.Point(117, 205);
            this.txtboxusername.Name = "txtboxusername";
            this.txtboxusername.Size = new System.Drawing.Size(153, 26);
            this.txtboxusername.TabIndex = 1;
            this.txtboxusername.Text = "usama";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(117, 281);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(153, 26);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.Text = "1234";
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.DarkBlue;
            this.log_in.FlatAppearance.BorderSize = 0;
            this.log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_in.ForeColor = System.Drawing.Color.White;
            this.log_in.Location = new System.Drawing.Point(139, 373);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(77, 37);
            this.log_in.TabIndex = 2;
            this.log_in.Text = "Login";
            this.log_in.UseVisualStyleBackColor = false;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // pb_username
            // 
            this.pb_username.BackColor = System.Drawing.Color.Transparent;
            this.pb_username.Image = ((System.Drawing.Image)(resources.GetObject("pb_username.Image")));
            this.pb_username.Location = new System.Drawing.Point(49, 205);
            this.pb_username.Name = "pb_username";
            this.pb_username.Size = new System.Drawing.Size(52, 26);
            this.pb_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_username.TabIndex = 3;
            this.pb_username.TabStop = false;
            // 
            // pb_pass
            // 
            this.pb_pass.Image = ((System.Drawing.Image)(resources.GetObject("pb_pass.Image")));
            this.pb_pass.Location = new System.Drawing.Point(49, 281);
            this.pb_pass.Name = "pb_pass";
            this.pb_pass.Size = new System.Drawing.Size(52, 26);
            this.pb_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_pass.TabIndex = 3;
            this.pb_pass.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_pass);
            this.Controls.Add(this.pb_username);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtboxusername);
            this.Controls.Add(this.Hotellbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pb_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hotellbl;
        private System.Windows.Forms.TextBox txtboxusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.PictureBox pb_username;
        private System.Windows.Forms.PictureBox pb_pass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}