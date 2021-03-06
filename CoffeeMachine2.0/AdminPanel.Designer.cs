
namespace CoffeeMachine2._0
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
            this.ListOfDrinks = new System.Windows.Forms.ListBox();
            this.EditDrink = new System.Windows.Forms.Button();
            this.DeleteDrink = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDrink = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uploadImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbStrenght = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeToCook = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbTea = new System.Windows.Forms.RadioButton();
            this.rbCoffee = new System.Windows.Forms.RadioButton();
            this.rbWater = new System.Windows.Forms.RadioButton();
            this.cost = new System.Windows.Forms.NumericUpDown();
            this.boolSugar = new System.Windows.Forms.CheckBox();
            this.boolTemperature = new System.Windows.Forms.CheckBox();
            this.SaveEdit = new System.Windows.Forms.Button();
            this.lNotice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbStrenght)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeToCook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ListOfDrinks
            // 
            this.ListOfDrinks.FormattingEnabled = true;
            this.ListOfDrinks.Location = new System.Drawing.Point(468, 39);
            this.ListOfDrinks.Name = "ListOfDrinks";
            this.ListOfDrinks.Size = new System.Drawing.Size(320, 563);
            this.ListOfDrinks.TabIndex = 0;
            // 
            // EditDrink
            // 
            this.EditDrink.Location = new System.Drawing.Point(494, 630);
            this.EditDrink.Name = "EditDrink";
            this.EditDrink.Size = new System.Drawing.Size(121, 23);
            this.EditDrink.TabIndex = 1;
            this.EditDrink.Text = "Редактировать";
            this.EditDrink.UseVisualStyleBackColor = true;
            this.EditDrink.Click += new System.EventHandler(this.EditDrink_Click);
            // 
            // DeleteDrink
            // 
            this.DeleteDrink.Location = new System.Drawing.Point(638, 630);
            this.DeleteDrink.Name = "DeleteDrink";
            this.DeleteDrink.Size = new System.Drawing.Size(121, 23);
            this.DeleteDrink.TabIndex = 2;
            this.DeleteDrink.Text = "Удалить";
            this.DeleteDrink.UseVisualStyleBackColor = true;
            this.DeleteDrink.Click += new System.EventHandler(this.DeleteDrink_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добавить напиток";
            // 
            // AddDrink
            // 
            this.AddDrink.Location = new System.Drawing.Point(116, 630);
            this.AddDrink.Name = "AddDrink";
            this.AddDrink.Size = new System.Drawing.Size(177, 23);
            this.AddDrink.TabIndex = 5;
            this.AddDrink.Text = "Добавить напиток";
            this.AddDrink.UseVisualStyleBackColor = true;
            this.AddDrink.Click += new System.EventHandler(this.AddDrink_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название напитка:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(127, 17);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(215, 20);
            this.name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Изображение:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // uploadImage
            // 
            this.uploadImage.Location = new System.Drawing.Point(126, 401);
            this.uploadImage.Name = "uploadImage";
            this.uploadImage.Size = new System.Drawing.Size(154, 23);
            this.uploadImage.TabIndex = 3;
            this.uploadImage.Text = "Загрузить изображение";
            this.uploadImage.UseVisualStyleBackColor = true;
            this.uploadImage.Click += new System.EventHandler(this.uploadImage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 41);
            this.label5.TabIndex = 6;
            this.label5.Text = "Настраивать у этого напитка температуру?";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 41);
            this.label6.TabIndex = 9;
            this.label6.Text = "Настраивать у этого напитка сахар?";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 41);
            this.label9.TabIndex = 17;
            this.label9.Text = "Стандартная крепость";
            // 
            // tbStrenght
            // 
            this.tbStrenght.Location = new System.Drawing.Point(126, 253);
            this.tbStrenght.Name = "tbStrenght";
            this.tbStrenght.Size = new System.Drawing.Size(181, 45);
            this.tbStrenght.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.TimeToCook);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rbCustom);
            this.panel1.Controls.Add(this.rbTea);
            this.panel1.Controls.Add(this.rbCoffee);
            this.panel1.Controls.Add(this.rbWater);
            this.panel1.Controls.Add(this.cost);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.boolSugar);
            this.panel1.Controls.Add(this.boolTemperature);
            this.panel1.Controls.Add(this.tbStrenght);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.uploadImage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 585);
            this.panel1.TabIndex = 3;
            // 
            // TimeToCook
            // 
            this.TimeToCook.Location = new System.Drawing.Point(127, 304);
            this.TimeToCook.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.TimeToCook.Name = "TimeToCook";
            this.TimeToCook.Size = new System.Drawing.Size(120, 20);
            this.TimeToCook.TabIndex = 28;
            this.TimeToCook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TimeToCook_KeyUp);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 41);
            this.label7.TabIndex = 27;
            this.label7.Text = "Сколько секунд будет готовиться ваш напиток?";
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(141, 123);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(94, 17);
            this.rbCustom.TabIndex = 26;
            this.rbCustom.TabStop = true;
            this.rbCustom.Text = "Свой напиток";
            this.rbCustom.UseVisualStyleBackColor = true;
            // 
            // rbTea
            // 
            this.rbTea.AutoSize = true;
            this.rbTea.Location = new System.Drawing.Point(141, 89);
            this.rbTea.Name = "rbTea";
            this.rbTea.Size = new System.Drawing.Size(45, 17);
            this.rbTea.TabIndex = 25;
            this.rbTea.TabStop = true;
            this.rbTea.Text = "Чай";
            this.rbTea.UseVisualStyleBackColor = true;
            this.rbTea.CheckedChanged += new System.EventHandler(this.rbTea_CheckedChanged);
            // 
            // rbCoffee
            // 
            this.rbCoffee.AutoSize = true;
            this.rbCoffee.Location = new System.Drawing.Point(23, 123);
            this.rbCoffee.Name = "rbCoffee";
            this.rbCoffee.Size = new System.Drawing.Size(52, 17);
            this.rbCoffee.TabIndex = 24;
            this.rbCoffee.TabStop = true;
            this.rbCoffee.Text = "Кофе";
            this.rbCoffee.UseVisualStyleBackColor = true;
            this.rbCoffee.CheckedChanged += new System.EventHandler(this.rbCoffee_CheckedChanged);
            // 
            // rbWater
            // 
            this.rbWater.AutoSize = true;
            this.rbWater.Location = new System.Drawing.Point(23, 89);
            this.rbWater.Name = "rbWater";
            this.rbWater.Size = new System.Drawing.Size(50, 17);
            this.rbWater.TabIndex = 23;
            this.rbWater.TabStop = true;
            this.rbWater.Text = "Вода";
            this.rbWater.UseVisualStyleBackColor = true;
            this.rbWater.CheckedChanged += new System.EventHandler(this.rbWater_CheckedChanged);
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(126, 54);
            this.cost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(120, 20);
            this.cost.TabIndex = 22;
            this.cost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cost_KeyUp);
            // 
            // boolSugar
            // 
            this.boolSugar.AutoSize = true;
            this.boolSugar.Location = new System.Drawing.Point(126, 216);
            this.boolSugar.Name = "boolSugar";
            this.boolSugar.Size = new System.Drawing.Size(15, 14);
            this.boolSugar.TabIndex = 20;
            this.boolSugar.UseVisualStyleBackColor = true;
            // 
            // boolTemperature
            // 
            this.boolTemperature.AutoSize = true;
            this.boolTemperature.Location = new System.Drawing.Point(126, 169);
            this.boolTemperature.Name = "boolTemperature";
            this.boolTemperature.Size = new System.Drawing.Size(15, 14);
            this.boolTemperature.TabIndex = 19;
            this.boolTemperature.UseVisualStyleBackColor = true;
            // 
            // SaveEdit
            // 
            this.SaveEdit.Location = new System.Drawing.Point(116, 630);
            this.SaveEdit.Name = "SaveEdit";
            this.SaveEdit.Size = new System.Drawing.Size(177, 23);
            this.SaveEdit.TabIndex = 6;
            this.SaveEdit.Text = "Сохранить изменения";
            this.SaveEdit.UseVisualStyleBackColor = true;
            this.SaveEdit.Visible = false;
            this.SaveEdit.Click += new System.EventHandler(this.SaveEdit_Click);
            // 
            // lNotice
            // 
            this.lNotice.AutoSize = true;
            this.lNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNotice.ForeColor = System.Drawing.Color.Red;
            this.lNotice.Location = new System.Drawing.Point(451, 602);
            this.lNotice.Name = "lNotice";
            this.lNotice.Size = new System.Drawing.Size(348, 25);
            this.lNotice.TabIndex = 8;
            this.lNotice.Text = "Вы достигли максимум напитков.";
            this.lNotice.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = global::CoffeeMachine2._0.Properties.Resources.DefaultIcon;
            this.pictureBox1.Image = global::CoffeeMachine2._0.Properties.Resources.DefaultIcon;
            this.pictureBox1.InitialImage = global::CoffeeMachine2._0.Properties.Resources.DefaultIcon;
            this.pictureBox1.Location = new System.Drawing.Point(19, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.ErrorImage = global::CoffeeMachine2._0.Properties.Resources.default_animation;
            this.pictureBox2.Image = global::CoffeeMachine2._0.Properties.Resources.default_animation;
            this.pictureBox2.InitialImage = global::CoffeeMachine2._0.Properties.Resources.default_animation;
            this.pictureBox2.Location = new System.Drawing.Point(19, 468);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Загрузить анимацию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Анимация:";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.lNotice);
            this.Controls.Add(this.SaveEdit);
            this.Controls.Add(this.AddDrink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteDrink);
            this.Controls.Add(this.EditDrink);
            this.Controls.Add(this.ListOfDrinks);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbStrenght)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeToCook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListOfDrinks;
        private System.Windows.Forms.Button EditDrink;
        private System.Windows.Forms.Button DeleteDrink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddDrink;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uploadImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tbStrenght;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox boolSugar;
        private System.Windows.Forms.CheckBox boolTemperature;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown cost;
        private System.Windows.Forms.Button SaveEdit;
        private System.Windows.Forms.RadioButton rbTea;
        private System.Windows.Forms.RadioButton rbCoffee;
        private System.Windows.Forms.RadioButton rbWater;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown TimeToCook;
        private System.Windows.Forms.Label lNotice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}