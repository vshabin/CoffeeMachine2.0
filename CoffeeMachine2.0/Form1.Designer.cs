
namespace CoffeeMachine2._0
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelCookStage = new System.Windows.Forms.Label();
            this.butCook = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDrink = new System.Windows.Forms.Label();
            this.tbSugarProp = new System.Windows.Forms.TrackBar();
            this.labelAmountOfSugar = new System.Windows.Forms.Label();
            this.tbTemperatureProp = new System.Windows.Forms.TrackBar();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelUserTemperature = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbSugarProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTemperatureProp)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCookStage
            // 
            this.labelCookStage.AutoSize = true;
            this.labelCookStage.Location = new System.Drawing.Point(80, 59);
            this.labelCookStage.Name = "labelCookStage";
            this.labelCookStage.Size = new System.Drawing.Size(91, 13);
            this.labelCookStage.TabIndex = 0;
            this.labelCookStage.Text = "Ожидаю заказ...";
            // 
            // butCook
            // 
            this.butCook.Location = new System.Drawing.Point(82, 126);
            this.butCook.Name = "butCook";
            this.butCook.Size = new System.Drawing.Size(75, 23);
            this.butCook.TabIndex = 1;
            this.butCook.Text = "Готовить";
            this.butCook.UseVisualStyleBackColor = true;
            this.butCook.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(79, 43);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(94, 13);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Сумма к оплате: ";
            // 
            // labelDrink
            // 
            this.labelDrink.AutoSize = true;
            this.labelDrink.Location = new System.Drawing.Point(79, 27);
            this.labelDrink.Name = "labelDrink";
            this.labelDrink.Size = new System.Drawing.Size(56, 13);
            this.labelDrink.TabIndex = 3;
            this.labelDrink.Text = "Напиток: ";
            // 
            // tbSugarProp
            // 
            this.tbSugarProp.Location = new System.Drawing.Point(82, 189);
            this.tbSugarProp.Maximum = 4;
            this.tbSugarProp.Name = "tbSugarProp";
            this.tbSugarProp.Size = new System.Drawing.Size(104, 45);
            this.tbSugarProp.TabIndex = 1;
            this.tbSugarProp.ValueChanged += new System.EventHandler(this.tbSugarProp_ValueChanged);
            // 
            // labelAmountOfSugar
            // 
            this.labelAmountOfSugar.AutoSize = true;
            this.labelAmountOfSugar.Location = new System.Drawing.Point(79, 173);
            this.labelAmountOfSugar.Name = "labelAmountOfSugar";
            this.labelAmountOfSugar.Size = new System.Drawing.Size(183, 13);
            this.labelAmountOfSugar.TabIndex = 4;
            this.labelAmountOfSugar.Text = "Количество сахара(в пакетиках): 0";
            // 
            // tbTemperatureProp
            // 
            this.tbTemperatureProp.Location = new System.Drawing.Point(112, 279);
            this.tbTemperatureProp.Maximum = 3;
            this.tbTemperatureProp.Name = "tbTemperatureProp";
            this.tbTemperatureProp.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbTemperatureProp.Size = new System.Drawing.Size(45, 104);
            this.tbTemperatureProp.TabIndex = 5;
            this.tbTemperatureProp.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbTemperatureProp.ValueChanged += new System.EventHandler(this.tbTemperatureProp_ValueChanged);
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(82, 260);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(80, 13);
            this.labelTemperature.TabIndex = 6;
            this.labelTemperature.Text = "Температура: ";
            // 
            // labelUserTemperature
            // 
            this.labelUserTemperature.AutoSize = true;
            this.labelUserTemperature.Location = new System.Drawing.Point(158, 260);
            this.labelUserTemperature.Name = "labelUserTemperature";
            this.labelUserTemperature.Size = new System.Drawing.Size(58, 13);
            this.labelUserTemperature.TabIndex = 7;
            this.labelUserTemperature.Text = "Холодный";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackgroundImage = global::CoffeeMachine2._0.Properties.Resources.GetMoneyIcon;
            this.panel1.Location = new System.Drawing.Point(576, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 104);
            this.panel1.TabIndex = 9;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.DragLeave += new System.EventHandler(this.panel1_DragLeave);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(888, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 100);
            this.panel2.TabIndex = 10;
            this.panel2.Tag = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelUserTemperature);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.tbTemperatureProp);
            this.Controls.Add(this.labelAmountOfSugar);
            this.Controls.Add(this.tbSugarProp);
            this.Controls.Add(this.labelDrink);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.butCook);
            this.Controls.Add(this.labelCookStage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbSugarProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTemperatureProp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label labelCookStage;
        private System.Windows.Forms.Button butCook;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDrink;
        private System.Windows.Forms.TrackBar tbSugarProp;
        private System.Windows.Forms.Label labelAmountOfSugar;
        private System.Windows.Forms.TrackBar tbTemperatureProp;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelUserTemperature;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}

