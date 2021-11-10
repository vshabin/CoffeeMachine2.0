
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
            this.cost = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boolSugar = new System.Windows.Forms.CheckBox();
            this.boolTemperature = new System.Windows.Forms.CheckBox();
            this.SaveEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbStrenght)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListOfDrinks
            // 
            this.ListOfDrinks.FormattingEnabled = true;
            this.ListOfDrinks.Location = new System.Drawing.Point(468, 39);
            this.ListOfDrinks.Name = "ListOfDrinks";
            this.ListOfDrinks.Size = new System.Drawing.Size(320, 355);
            this.ListOfDrinks.TabIndex = 0;
            // 
            // EditDrink
            // 
            this.EditDrink.Location = new System.Drawing.Point(495, 418);
            this.EditDrink.Name = "EditDrink";
            this.EditDrink.Size = new System.Drawing.Size(121, 23);
            this.EditDrink.TabIndex = 1;
            this.EditDrink.Text = "Редактировать";
            this.EditDrink.UseVisualStyleBackColor = true;
            this.EditDrink.Click += new System.EventHandler(this.EditDrink_Click);
            // 
            // DeleteDrink
            // 
            this.DeleteDrink.Location = new System.Drawing.Point(640, 418);
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
            this.label1.Location = new System.Drawing.Point(109, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добавить напиток";
            // 
            // AddDrink
            // 
            this.AddDrink.Location = new System.Drawing.Point(113, 400);
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
            this.label3.Location = new System.Drawing.Point(123, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Изображение:";
            // 
            // uploadImage
            // 
            this.uploadImage.Location = new System.Drawing.Point(126, 258);
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
            this.label5.Location = new System.Drawing.Point(20, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 41);
            this.label5.TabIndex = 6;
            this.label5.Text = "Настраивать у этого напитка температуру?";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 41);
            this.label6.TabIndex = 9;
            this.label6.Text = "Настраивать у этого напитка сахар?";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 41);
            this.label9.TabIndex = 17;
            this.label9.Text = "Стандартная крепость";
            // 
            // tbStrenght
            // 
            this.tbStrenght.Location = new System.Drawing.Point(126, 179);
            this.tbStrenght.Name = "tbStrenght";
            this.tbStrenght.Size = new System.Drawing.Size(181, 45);
            this.tbStrenght.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
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
            this.panel1.Size = new System.Drawing.Size(375, 355);
            this.panel1.TabIndex = 3;
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = global::CoffeeMachine2._0.Properties.Resources.DefaultIcon;
            this.pictureBox1.Image = global::CoffeeMachine2._0.Properties.Resources.DefaultIcon;
            this.pictureBox1.InitialImage = global::CoffeeMachine2._0.Properties.Resources.DefaultIcon;
            this.pictureBox1.Location = new System.Drawing.Point(19, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // boolSugar
            // 
            this.boolSugar.AutoSize = true;
            this.boolSugar.Location = new System.Drawing.Point(126, 142);
            this.boolSugar.Name = "boolSugar";
            this.boolSugar.Size = new System.Drawing.Size(15, 14);
            this.boolSugar.TabIndex = 20;
            this.boolSugar.UseVisualStyleBackColor = true;
            // 
            // boolTemperature
            // 
            this.boolTemperature.AutoSize = true;
            this.boolTemperature.Location = new System.Drawing.Point(126, 95);
            this.boolTemperature.Name = "boolTemperature";
            this.boolTemperature.Size = new System.Drawing.Size(15, 14);
            this.boolTemperature.TabIndex = 19;
            this.boolTemperature.UseVisualStyleBackColor = true;
            // 
            // SaveEdit
            // 
            this.SaveEdit.Location = new System.Drawing.Point(113, 400);
            this.SaveEdit.Name = "SaveEdit";
            this.SaveEdit.Size = new System.Drawing.Size(177, 23);
            this.SaveEdit.TabIndex = 6;
            this.SaveEdit.Text = "Сохранить изменения";
            this.SaveEdit.UseVisualStyleBackColor = true;
            this.SaveEdit.Visible = false;
            this.SaveEdit.Click += new System.EventHandler(this.SaveEdit_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveEdit);
            this.Controls.Add(this.AddDrink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteDrink);
            this.Controls.Add(this.EditDrink);
            this.Controls.Add(this.ListOfDrinks);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbStrenght)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
    }
}