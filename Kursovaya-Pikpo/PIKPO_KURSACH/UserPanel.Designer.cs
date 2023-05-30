
namespace PIKPO_KURSACH
{
    partial class UserPanel
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
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.search_textBox1 = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.button_profile = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewer
            // 
            this.dgvViewer.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Location = new System.Drawing.Point(2, 38);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.RowTemplate.Height = 25;
            this.dgvViewer.Size = new System.Drawing.Size(797, 411);
            this.dgvViewer.TabIndex = 0;
            this.dgvViewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewer_CellContentClick);
            // 
            // search_textBox1
            // 
            this.search_textBox1.Location = new System.Drawing.Point(13, 9);
            this.search_textBox1.Name = "search_textBox1";
            this.search_textBox1.Size = new System.Drawing.Size(127, 23);
            this.search_textBox1.TabIndex = 1;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(146, 9);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Поиск";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // button_profile
            // 
            this.button_profile.Location = new System.Drawing.Point(713, 9);
            this.button_profile.Name = "button_profile";
            this.button_profile.Size = new System.Drawing.Size(75, 23);
            this.button_profile.TabIndex = 3;
            this.button_profile.Text = "Профиль";
            this.button_profile.UseVisualStyleBackColor = true;
            this.button_profile.Click += new System.EventHandler(this.button_profile_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(712, 456);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PIKPO_KURSACH.Properties.Resources._1643229413_66_phonoteka_org_p_belii_zadnii_fon_69;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_profile);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_textBox1);
            this.Controls.Add(this.dgvViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.TextBox search_textBox1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button button_profile;
        private System.Windows.Forms.Button button_exit;
    }
}