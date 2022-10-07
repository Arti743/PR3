
namespace PR3
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBan = new System.Windows.Forms.Button();
            this.buttonPlayer = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonBan);
            this.panel1.Controls.Add(this.buttonPlayer);
            this.panel1.Controls.Add(this.buttonAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выйти из аккаунта";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBan
            // 
            this.buttonBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBan.Location = new System.Drawing.Point(0, 64);
            this.buttonBan.Name = "buttonBan";
            this.buttonBan.Size = new System.Drawing.Size(219, 32);
            this.buttonBan.TabIndex = 2;
            this.buttonBan.Text = "Ban list";
            this.buttonBan.UseVisualStyleBackColor = false;
            this.buttonBan.Click += new System.EventHandler(this.buttonBan_Click);
            // 
            // buttonPlayer
            // 
            this.buttonPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayer.Location = new System.Drawing.Point(0, 32);
            this.buttonPlayer.Name = "buttonPlayer";
            this.buttonPlayer.Size = new System.Drawing.Size(219, 32);
            this.buttonPlayer.TabIndex = 1;
            this.buttonPlayer.Text = "Players";
            this.buttonPlayer.UseVisualStyleBackColor = false;
            this.buttonPlayer.Click += new System.EventHandler(this.buttonPlayer_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Location = new System.Drawing.Point(0, 0);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(219, 32);
            this.buttonAdmin.TabIndex = 0;
            this.buttonAdmin.Text = "Administrators";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(223, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 450);
            this.panel2.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBan;
        private System.Windows.Forms.Button buttonPlayer;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}