namespace lab_13
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.butCar = new System.Windows.Forms.Button();
            this.butCarriage = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.butLoad = new System.Windows.Forms.Button();
            this.butStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butCar
            // 
            this.butCar.Location = new System.Drawing.Point(498, 30);
            this.butCar.Name = "butCar";
            this.butCar.Size = new System.Drawing.Size(117, 34);
            this.butCar.TabIndex = 0;
            this.butCar.Text = "Добавить машину";
            this.butCar.UseVisualStyleBackColor = true;
            this.butCar.Click += new System.EventHandler(this.butCar_Click);
            // 
            // butCarriage
            // 
            this.butCarriage.Location = new System.Drawing.Point(498, 70);
            this.butCarriage.Name = "butCarriage";
            this.butCarriage.Size = new System.Drawing.Size(117, 33);
            this.butCarriage.TabIndex = 1;
            this.butCarriage.Text = "Добавить повозку";
            this.butCarriage.UseVisualStyleBackColor = true;
            this.butCarriage.Click += new System.EventHandler(this.butCarriage_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(498, 109);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(117, 33);
            this.butDelete.TabIndex = 2;
            this.butDelete.Text = "Удалить участника";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(496, 197);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(116, 44);
            this.butSave.TabIndex = 4;
            this.butSave.Text = "Сохранить список в файл";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butLoad
            // 
            this.butLoad.Location = new System.Drawing.Point(496, 247);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(116, 42);
            this.butLoad.TabIndex = 5;
            this.butLoad.Text = "Загрузить список из файла";
            this.butLoad.UseVisualStyleBackColor = true;
            this.butLoad.Click += new System.EventHandler(this.butLoad_Click);
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(498, 311);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(112, 55);
            this.butStart.TabIndex = 6;
            this.butStart.Text = "Начать гонку";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Список участников гонки";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(471, 407);
            this.listBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "расстояние гонки";
            // 
            // tbDist
            // 
            this.tbDist.Location = new System.Drawing.Point(499, 395);
            this.tbDist.Name = "tbDist";
            this.tbDist.Size = new System.Drawing.Size(110, 20);
            this.tbDist.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.tbDist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.butLoad);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butCarriage);
            this.Controls.Add(this.butCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "lab 13";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCar;
        private System.Windows.Forms.Button butCarriage;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butLoad;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDist;
    }
}

