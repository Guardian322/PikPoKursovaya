
namespace PIKPO_KURSACH
{
    partial class AdminPanel
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
            this.sell_catalog = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            this.lbl_sell = new System.Windows.Forms.Label();
            this.lbl_sells = new System.Windows.Forms.Label();
            this.count1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.count2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sell_catalog
            // 
            this.sell_catalog.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sell_catalog.Location = new System.Drawing.Point(12, 12);
            this.sell_catalog.Name = "sell_catalog";
            this.sell_catalog.Size = new System.Drawing.Size(270, 53);
            this.sell_catalog.TabIndex = 1;
            this.sell_catalog.Text = "Редактор Каталога";
            this.sell_catalog.UseVisualStyleBackColor = true;
            this.sell_catalog.Click += new System.EventHandler(this.sell_catalog_Click);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count.Location = new System.Drawing.Point(502, 24);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(24, 30);
            this.count.TabIndex = 2;
            this.count.Text = "0";
            // 
            // lbl_sell
            // 
            this.lbl_sell.AutoSize = true;
            this.lbl_sell.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sell.Location = new System.Drawing.Point(309, 24);
            this.lbl_sell.Name = "lbl_sell";
            this.lbl_sell.Size = new System.Drawing.Size(151, 30);
            this.lbl_sell.TabIndex = 3;
            this.lbl_sell.Text = "Всего продаж:";
            // 
            // lbl_sells
            // 
            this.lbl_sells.AutoSize = true;
            this.lbl_sells.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sells.Location = new System.Drawing.Point(309, 85);
            this.lbl_sells.Name = "lbl_sells";
            this.lbl_sells.Size = new System.Drawing.Size(176, 30);
            this.lbl_sells.TabIndex = 4;
            this.lbl_sells.Text = "Всего ед. товара:";
            // 
            // count1
            // 
            this.count1.AutoSize = true;
            this.count1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count1.Location = new System.Drawing.Point(502, 85);
            this.count1.Name = "count1";
            this.count1.Size = new System.Drawing.Size(24, 30);
            this.count1.TabIndex = 5;
            this.count1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(309, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Всего тонн:";
            // 
            // count2
            // 
            this.count2.AutoSize = true;
            this.count2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count2.Location = new System.Drawing.Point(502, 146);
            this.count2.Name = "count2";
            this.count2.Size = new System.Drawing.Size(24, 30);
            this.count2.TabIndex = 7;
            this.count2.Text = "0";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PIKPO_KURSACH.Properties.Resources._1643229413_66_phonoteka_org_p_belii_zadnii_fon_69;
            this.ClientSize = new System.Drawing.Size(623, 303);
            this.Controls.Add(this.count2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.count1);
            this.Controls.Add(this.lbl_sells);
            this.Controls.Add(this.lbl_sell);
            this.Controls.Add(this.count);
            this.Controls.Add(this.sell_catalog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sell_catalog;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label lbl_sell;
        private System.Windows.Forms.Label lbl_sells;
        private System.Windows.Forms.Label count1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label count2;
    }
}