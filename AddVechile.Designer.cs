namespace lab_13
{
    partial class AddVechile
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.butOK = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.butAddHorse = new System.Windows.Forms.Button();
            this.tbStamina = new System.Windows.Forms.TextBox();
            this.tbMass = new System.Windows.Forms.TextBox();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.tbFuel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblStamina = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(429, 199);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(6, 405);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(101, 37);
            this.butOK.TabIndex = 1;
            this.butOK.Text = "Готово";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(130, 405);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(104, 37);
            this.butCancel.TabIndex = 2;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butAddHorse
            // 
            this.butAddHorse.Location = new System.Drawing.Point(282, 358);
            this.butAddHorse.Name = "butAddHorse";
            this.butAddHorse.Size = new System.Drawing.Size(94, 42);
            this.butAddHorse.TabIndex = 3;
            this.butAddHorse.Text = "Добавить лошадь";
            this.butAddHorse.UseVisualStyleBackColor = true;
            this.butAddHorse.Click += new System.EventHandler(this.butAddHorse_Click);
            // 
            // tbStamina
            // 
            this.tbStamina.Location = new System.Drawing.Point(235, 332);
            this.tbStamina.Name = "tbStamina";
            this.tbStamina.Size = new System.Drawing.Size(186, 20);
            this.tbStamina.TabIndex = 4;
            // 
            // tbMass
            // 
            this.tbMass.Location = new System.Drawing.Point(5, 263);
            this.tbMass.Name = "tbMass";
            this.tbMass.Size = new System.Drawing.Size(187, 20);
            this.tbMass.TabIndex = 5;
            this.tbMass.TextChanged += new System.EventHandler(this.tbMass_TextChanged);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(6, 332);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(186, 20);
            this.tbSpeed.TabIndex = 6;
            this.tbSpeed.TextChanged += new System.EventHandler(this.tbSpeed_TextChanged);
            // 
            // tbFuel
            // 
            this.tbFuel.Location = new System.Drawing.Point(234, 263);
            this.tbFuel.Name = "tbFuel";
            this.tbFuel.Size = new System.Drawing.Size(187, 20);
            this.tbFuel.TabIndex = 7;
            this.tbFuel.TextChanged += new System.EventHandler(this.tbFuel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Масса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Скорость";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(228, 247);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(214, 13);
            this.lblFuel.TabIndex = 10;
            this.lblFuel.Text = "Потребление топлива на единицу массы";
            // 
            // lblStamina
            // 
            this.lblStamina.AutoSize = true;
            this.lblStamina.Location = new System.Drawing.Point(228, 316);
            this.lblStamina.Name = "lblStamina";
            this.lblStamina.Size = new System.Drawing.Size(199, 13);
            this.lblStamina.TabIndex = 11;
            this.lblStamina.Text = "Потребление выносливости лошадью";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(180, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(73, 17);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Машина ";
            // 
            // AddVechile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStamina);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFuel);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.tbMass);
            this.Controls.Add(this.tbStamina);
            this.Controls.Add(this.butAddHorse);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.richTextBox1);
            this.Name = "AddVechile";
            this.Text = "Добавление машины";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butAddHorse;
        private System.Windows.Forms.TextBox tbStamina;
        private System.Windows.Forms.TextBox tbMass;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.TextBox tbFuel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblStamina;
        private System.Windows.Forms.Label lblTitle;
    }
}