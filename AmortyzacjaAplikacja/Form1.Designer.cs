
namespace AmortyzacjaAplikacja
{
    partial class Amortyzacja
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxLiniowa = new System.Windows.Forms.CheckBox();
            this.checkBoxDegresywna = new System.Windows.Forms.CheckBox();
            this.wartoscPoczatkowaTV = new System.Windows.Forms.TextBox();
            this.stawkaAmortyzacjiTV = new System.Windows.Forms.TextBox();
            this.wspPodwyzszajacyTV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewWynik = new System.Windows.Forms.ListView();
            this.warningLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxLiniowa
            // 
            this.checkBoxLiniowa.AutoSize = true;
            this.checkBoxLiniowa.Location = new System.Drawing.Point(410, 137);
            this.checkBoxLiniowa.Name = "checkBoxLiniowa";
            this.checkBoxLiniowa.Size = new System.Drawing.Size(72, 21);
            this.checkBoxLiniowa.TabIndex = 1;
            this.checkBoxLiniowa.Text = "liniowa";
            this.checkBoxLiniowa.UseVisualStyleBackColor = true;
            // 
            // checkBoxDegresywna
            // 
            this.checkBoxDegresywna.AutoSize = true;
            this.checkBoxDegresywna.Location = new System.Drawing.Point(509, 137);
            this.checkBoxDegresywna.Name = "checkBoxDegresywna";
            this.checkBoxDegresywna.Size = new System.Drawing.Size(106, 21);
            this.checkBoxDegresywna.TabIndex = 2;
            this.checkBoxDegresywna.Text = "degresywna";
            this.checkBoxDegresywna.UseVisualStyleBackColor = true;
            // 
            // wartoscPoczatkowaTV
            // 
            this.wartoscPoczatkowaTV.Location = new System.Drawing.Point(196, 84);
            this.wartoscPoczatkowaTV.Name = "wartoscPoczatkowaTV";
            this.wartoscPoczatkowaTV.Size = new System.Drawing.Size(100, 22);
            this.wartoscPoczatkowaTV.TabIndex = 3;
            // 
            // stawkaAmortyzacjiTV
            // 
            this.stawkaAmortyzacjiTV.Location = new System.Drawing.Point(196, 135);
            this.stawkaAmortyzacjiTV.Name = "stawkaAmortyzacjiTV";
            this.stawkaAmortyzacjiTV.Size = new System.Drawing.Size(100, 22);
            this.stawkaAmortyzacjiTV.TabIndex = 4;
            // 
            // wspPodwyzszajacyTV
            // 
            this.wspPodwyzszajacyTV.Location = new System.Drawing.Point(515, 81);
            this.wspPodwyzszajacyTV.Name = "wspPodwyzszajacyTV";
            this.wspPodwyzszajacyTV.Size = new System.Drawing.Size(100, 22);
            this.wspPodwyzszajacyTV.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amortyzacja środka trwałego";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wartosc początkowa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stawka amortyzacji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wsp. podwyższający";
            // 
            // listViewWynik
            // 
            this.listViewWynik.HideSelection = false;
            this.listViewWynik.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.listViewWynik.Location = new System.Drawing.Point(154, 266);
            this.listViewWynik.Name = "listViewWynik";
            this.listViewWynik.Size = new System.Drawing.Size(434, 241);
            this.listViewWynik.TabIndex = 10;
            this.listViewWynik.UseCompatibleStateImageBehavior = false;
            // 
            // warningLb
            // 
            this.warningLb.AutoSize = true;
            this.warningLb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.warningLb.ForeColor = System.Drawing.Color.Red;
            this.warningLb.Location = new System.Drawing.Point(274, 171);
            this.warningLb.Name = "warningLb";
            this.warningLb.Size = new System.Drawing.Size(0, 17);
            this.warningLb.TabIndex = 11;
            // 
            // Amortyzacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.warningLb);
            this.Controls.Add(this.listViewWynik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wspPodwyzszajacyTV);
            this.Controls.Add(this.stawkaAmortyzacjiTV);
            this.Controls.Add(this.wartoscPoczatkowaTV);
            this.Controls.Add(this.checkBoxDegresywna);
            this.Controls.Add(this.checkBoxLiniowa);
            this.Controls.Add(this.button1);
            this.Name = "Amortyzacja";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxLiniowa;
        private System.Windows.Forms.CheckBox checkBoxDegresywna;
        private System.Windows.Forms.TextBox wartoscPoczatkowaTV;
        private System.Windows.Forms.TextBox stawkaAmortyzacjiTV;
        private System.Windows.Forms.TextBox wspPodwyzszajacyTV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewWynik;
        private System.Windows.Forms.Label warningLb;
    }
}

