namespace lmitp
{
    partial class employeeform
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
            this.label1 = new System.Windows.Forms.Label();
            this.salmaMarie = new System.Windows.Forms.Button();
            this.arthurGichuki = new System.Windows.Forms.Button();
            this.rehemaOgana = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Data";
            // 
            // salmaMarie
            // 
            this.salmaMarie.BackColor = System.Drawing.Color.DimGray;
            this.salmaMarie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salmaMarie.FlatAppearance.BorderSize = 0;
            this.salmaMarie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salmaMarie.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salmaMarie.ForeColor = System.Drawing.Color.White;
            this.salmaMarie.Image = global::lmitp.Properties.Resources.user_24px;
            this.salmaMarie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salmaMarie.Location = new System.Drawing.Point(17, 61);
            this.salmaMarie.Name = "salmaMarie";
            this.salmaMarie.Size = new System.Drawing.Size(205, 40);
            this.salmaMarie.TabIndex = 2;
            this.salmaMarie.Text = "SALMA MARIE";
            this.salmaMarie.UseVisualStyleBackColor = false;
            this.salmaMarie.Click += new System.EventHandler(this.btndashbaord_Click);
            // 
            // arthurGichuki
            // 
            this.arthurGichuki.BackColor = System.Drawing.Color.DimGray;
            this.arthurGichuki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.arthurGichuki.FlatAppearance.BorderSize = 0;
            this.arthurGichuki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arthurGichuki.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arthurGichuki.ForeColor = System.Drawing.Color.White;
            this.arthurGichuki.Image = global::lmitp.Properties.Resources.user_24px;
            this.arthurGichuki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.arthurGichuki.Location = new System.Drawing.Point(17, 191);
            this.arthurGichuki.Name = "arthurGichuki";
            this.arthurGichuki.Size = new System.Drawing.Size(205, 40);
            this.arthurGichuki.TabIndex = 3;
            this.arthurGichuki.Text = "ARTHUR GICHUKI";
            this.arthurGichuki.UseVisualStyleBackColor = false;
            this.arthurGichuki.Click += new System.EventHandler(this.arthurGichuki_Click);
            // 
            // rehemaOgana
            // 
            this.rehemaOgana.BackColor = System.Drawing.Color.DimGray;
            this.rehemaOgana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rehemaOgana.FlatAppearance.BorderSize = 0;
            this.rehemaOgana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rehemaOgana.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rehemaOgana.ForeColor = System.Drawing.Color.White;
            this.rehemaOgana.Image = global::lmitp.Properties.Resources.user_24px;
            this.rehemaOgana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rehemaOgana.Location = new System.Drawing.Point(17, 123);
            this.rehemaOgana.Name = "rehemaOgana";
            this.rehemaOgana.Size = new System.Drawing.Size(205, 40);
            this.rehemaOgana.TabIndex = 4;
            this.rehemaOgana.Text = "REHEMA OGANA";
            this.rehemaOgana.UseVisualStyleBackColor = false;
            this.rehemaOgana.Click += new System.EventHandler(this.rehemaOgana_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 19.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::lmitp.Properties.Resources.back_arrow_icon_icons_com_72866;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(537, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "BACK TO HOME";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // employeeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rehemaOgana);
            this.Controls.Add(this.arthurGichuki);
            this.Controls.Add(this.salmaMarie);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employeeform";
            this.Text = "employeeform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salmaMarie;
        private System.Windows.Forms.Button arthurGichuki;
        private System.Windows.Forms.Button rehemaOgana;
        private System.Windows.Forms.Button button1;
    }
}