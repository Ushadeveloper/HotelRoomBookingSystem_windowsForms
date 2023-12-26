
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
            this.Hotellbl = new System.Windows.Forms.Label();
            this.txtboxusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.log_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hotellbl
            // 
            this.Hotellbl.AutoSize = true;
            this.Hotellbl.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hotellbl.Location = new System.Drawing.Point(133, 21);
            this.Hotellbl.Name = "Hotellbl";
            this.Hotellbl.Size = new System.Drawing.Size(83, 34);
            this.Hotellbl.TabIndex = 0;
            this.Hotellbl.Text = "Login";
            this.Hotellbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxusername
            // 
            this.txtboxusername.Location = new System.Drawing.Point(107, 219);
            this.txtboxusername.Name = "txtboxusername";
            this.txtboxusername.Size = new System.Drawing.Size(140, 26);
            this.txtboxusername.TabIndex = 1;
            this.txtboxusername.Text = "usama";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(107, 276);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(140, 26);
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
            this.log_in.Location = new System.Drawing.Point(139, 368);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(77, 37);
            this.log_in.TabIndex = 2;
            this.log_in.Text = "Login";
            this.log_in.UseVisualStyleBackColor = false;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtboxusername);
            this.Controls.Add(this.Hotellbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hotellbl;
        private System.Windows.Forms.TextBox txtboxusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button log_in;
    }
}