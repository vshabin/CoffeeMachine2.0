
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
            this.butCook = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbSugarProp = new System.Windows.Forms.TrackBar();
            this.labelAmountOfSugar = new System.Windows.Forms.Label();
            this.tbTemperatureProp = new System.Windows.Forms.TrackBar();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelUserTemperature = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelCookStage = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDrink = new System.Windows.Forms.Label();
            this.panelCoinOne = new System.Windows.Forms.Panel();
            this.panelCoinAcceptor = new System.Windows.Forms.Panel();
            this.butСancellation = new System.Windows.Forms.Button();
            this.drinkButton5 = new CoffeeMachine2._0.DrinkButton();
            this.drinkButton6 = new CoffeeMachine2._0.DrinkButton();
            this.drinkButton7 = new CoffeeMachine2._0.DrinkButton();
            this.drinkButton8 = new CoffeeMachine2._0.DrinkButton();
            this.drinkButton4 = new CoffeeMachine2._0.DrinkButton();
            this.drinkButton3 = new CoffeeMachine2._0.DrinkButton();
            this.drinkButton2 = new CoffeeMachine2._0.DrinkButton();
            this.drinkButton1 = new CoffeeMachine2._0.DrinkButton();
            this.butChangeNDrink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbSugarProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTemperatureProp)).BeginInit();
            this.panelDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // butCook
            // 
            this.butCook.Location = new System.Drawing.Point(333, 229);
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
            // tbSugarProp
            // 
            this.tbSugarProp.Location = new System.Drawing.Point(12, 58);
            this.tbSugarProp.Maximum = 4;
            this.tbSugarProp.Name = "tbSugarProp";
            this.tbSugarProp.Size = new System.Drawing.Size(104, 45);
            this.tbSugarProp.TabIndex = 1;
            this.tbSugarProp.ValueChanged += new System.EventHandler(this.tbSugarProp_ValueChanged);
            // 
            // labelAmountOfSugar
            // 
            this.labelAmountOfSugar.AutoSize = true;
            this.labelAmountOfSugar.Location = new System.Drawing.Point(9, 42);
            this.labelAmountOfSugar.Name = "labelAmountOfSugar";
            this.labelAmountOfSugar.Size = new System.Drawing.Size(183, 13);
            this.labelAmountOfSugar.TabIndex = 4;
            this.labelAmountOfSugar.Text = "Количество сахара(в пакетиках): 0";
            // 
            // tbTemperatureProp
            // 
            this.tbTemperatureProp.Location = new System.Drawing.Point(43, 131);
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
            this.labelTemperature.Location = new System.Drawing.Point(13, 112);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(80, 13);
            this.labelTemperature.TabIndex = 6;
            this.labelTemperature.Text = "Температура: ";
            // 
            // labelUserTemperature
            // 
            this.labelUserTemperature.AutoSize = true;
            this.labelUserTemperature.Location = new System.Drawing.Point(89, 112);
            this.labelUserTemperature.Name = "labelUserTemperature";
            this.labelUserTemperature.Size = new System.Drawing.Size(58, 13);
            this.labelUserTemperature.TabIndex = 7;
            this.labelUserTemperature.Text = "Холодный";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.Navy;
            this.panelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDisplay.Controls.Add(this.labelBalance);
            this.panelDisplay.Controls.Add(this.labelCookStage);
            this.panelDisplay.Controls.Add(this.labelAmount);
            this.panelDisplay.Controls.Add(this.labelDrink);
            this.panelDisplay.Location = new System.Drawing.Point(197, 25);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(294, 88);
            this.panelDisplay.TabIndex = 14;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBalance.ForeColor = System.Drawing.Color.White;
            this.labelBalance.Location = new System.Drawing.Point(15, 48);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(56, 13);
            this.labelBalance.TabIndex = 11;
            this.labelBalance.Text = "Внесено: ";
            // 
            // labelCookStage
            // 
            this.labelCookStage.AutoSize = true;
            this.labelCookStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCookStage.ForeColor = System.Drawing.Color.White;
            this.labelCookStage.Location = new System.Drawing.Point(16, 64);
            this.labelCookStage.Name = "labelCookStage";
            this.labelCookStage.Size = new System.Drawing.Size(91, 13);
            this.labelCookStage.TabIndex = 0;
            this.labelCookStage.Text = "Ожидаю заказ...";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.ForeColor = System.Drawing.Color.White;
            this.labelAmount.Location = new System.Drawing.Point(15, 31);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(94, 13);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Сумма к оплате: ";
            // 
            // labelDrink
            // 
            this.labelDrink.AutoSize = true;
            this.labelDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrink.ForeColor = System.Drawing.Color.White;
            this.labelDrink.Location = new System.Drawing.Point(15, 15);
            this.labelDrink.Name = "labelDrink";
            this.labelDrink.Size = new System.Drawing.Size(56, 13);
            this.labelDrink.TabIndex = 3;
            this.labelDrink.Text = "Напиток: ";
            // 
            // panelCoinOne
            // 
            this.panelCoinOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCoinOne.BackgroundImage")));
            this.panelCoinOne.Location = new System.Drawing.Point(527, 25);
            this.panelCoinOne.Name = "panelCoinOne";
            this.panelCoinOne.Size = new System.Drawing.Size(100, 100);
            this.panelCoinOne.TabIndex = 10;
            this.panelCoinOne.Tag = "1";
            this.panelCoinOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCoinOne_MouseDown);
            // 
            // panelCoinAcceptor
            // 
            this.panelCoinAcceptor.AllowDrop = true;
            this.panelCoinAcceptor.BackgroundImage = global::CoffeeMachine2._0.Properties.Resources.GetMoneyIcon;
            this.panelCoinAcceptor.Location = new System.Drawing.Point(197, 119);
            this.panelCoinAcceptor.Name = "panelCoinAcceptor";
            this.panelCoinAcceptor.Size = new System.Drawing.Size(294, 104);
            this.panelCoinAcceptor.TabIndex = 9;
            this.panelCoinAcceptor.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCoinAcceptor_DragDrop);
            this.panelCoinAcceptor.DragOver += new System.Windows.Forms.DragEventHandler(this.panelCoinAcceptor_DragOver);
            // 
            // butСancellation
            // 
            this.butСancellation.Location = new System.Drawing.Point(252, 229);
            this.butСancellation.Name = "butСancellation";
            this.butСancellation.Size = new System.Drawing.Size(75, 23);
            this.butСancellation.TabIndex = 23;
            this.butСancellation.Text = "Отмена";
            this.butСancellation.UseVisualStyleBackColor = true;
            this.butСancellation.Click += new System.EventHandler(this.butСancellation_Click);
            // 
            // drinkButton5
            // 
            this.drinkButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.drinkButton5.Location = new System.Drawing.Point(16, 618);
            this.drinkButton5.Name = "drinkButton5";
            this.drinkButton5.Size = new System.Drawing.Size(232, 63);
            this.drinkButton5.TabIndex = 22;
            this.drinkButton5.Click += new System.EventHandler(this.drinkButton1_Click);
            // 
            // drinkButton6
            // 
            this.drinkButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.drinkButton6.Location = new System.Drawing.Point(16, 549);
            this.drinkButton6.Name = "drinkButton6";
            this.drinkButton6.Size = new System.Drawing.Size(232, 63);
            this.drinkButton6.TabIndex = 21;
            this.drinkButton6.Click += new System.EventHandler(this.drinkButton1_Click);
            // 
            // drinkButton7
            // 
            this.drinkButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.drinkButton7.Location = new System.Drawing.Point(16, 480);
            this.drinkButton7.Name = "drinkButton7";
            this.drinkButton7.Size = new System.Drawing.Size(232, 63);
            this.drinkButton7.TabIndex = 20;
            this.drinkButton7.Click += new System.EventHandler(this.drinkButton1_Click);
            // 
            // drinkButton8
            // 
            this.drinkButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.drinkButton8.Location = new System.Drawing.Point(16, 411);
            this.drinkButton8.Name = "drinkButton8";
            this.drinkButton8.Size = new System.Drawing.Size(232, 63);
            this.drinkButton8.TabIndex = 19;
            this.drinkButton8.Click += new System.EventHandler(this.drinkButton1_Click);
            // 
            // drinkButton4
            // 
            this.drinkButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.drinkButton4.Location = new System.Drawing.Point(278, 480);
            this.drinkButton4.Name = "drinkButton4";
            this.drinkButton4.Size = new System.Drawing.Size(232, 63);
            this.drinkButton4.TabIndex = 18;
            this.drinkButton4.Click += new System.EventHandler(this.drinkButton1_Click);
            // 
            // drinkButton3
            // 
            this.drinkButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.drinkButton3.Location = new System.Drawing.Point(278, 411);
            this.drinkButton3.Name = "drinkButton3";
            this.drinkButton3.Size = new System.Drawing.Size(232, 63);
            this.drinkButton3.TabIndex = 17;
            this.drinkButton3.Click += new System.EventHandler(this.drinkButton1_Click);
            // 
            // drinkButton2
            // 
            this.drinkButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.drinkButton2.Location = new System.Drawing.Point(278, 549);
            this.drinkButton2.Name = "drinkButton2";
            this.drinkButton2.Size = new System.Drawing.Size(232, 63);
            this.drinkButton2.TabIndex = 16;
            this.drinkButton2.Click += new System.EventHandler(this.drinkButton1_Click);
            // 
            // drinkButton1
            // 
            this.drinkButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.drinkButton1.Location = new System.Drawing.Point(278, 618);
            this.drinkButton1.Name = "drinkButton1";
            this.drinkButton1.Size = new System.Drawing.Size(232, 63);
            this.drinkButton1.TabIndex = 15;
            this.drinkButton1.Click += new System.EventHandler(this.drinkButton1_Click);
            // 
            // butChangeNDrink
            // 
            this.butChangeNDrink.Location = new System.Drawing.Point(415, 230);
            this.butChangeNDrink.Name = "butChangeNDrink";
            this.butChangeNDrink.Size = new System.Drawing.Size(75, 23);
            this.butChangeNDrink.TabIndex = 24;
            this.butChangeNDrink.Text = "Сдача";
            this.butChangeNDrink.UseVisualStyleBackColor = true;
            this.butChangeNDrink.Click += new System.EventHandler(this.butChangeNDrink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 742);
            this.Controls.Add(this.butChangeNDrink);
            this.Controls.Add(this.butСancellation);
            this.Controls.Add(this.drinkButton5);
            this.Controls.Add(this.drinkButton6);
            this.Controls.Add(this.drinkButton7);
            this.Controls.Add(this.drinkButton8);
            this.Controls.Add(this.drinkButton4);
            this.Controls.Add(this.drinkButton3);
            this.Controls.Add(this.drinkButton2);
            this.Controls.Add(this.drinkButton1);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelCoinOne);
            this.Controls.Add(this.panelCoinAcceptor);
            this.Controls.Add(this.labelUserTemperature);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.tbTemperatureProp);
            this.Controls.Add(this.labelAmountOfSugar);
            this.Controls.Add(this.tbSugarProp);
            this.Controls.Add(this.butCook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.tbSugarProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTemperatureProp)).EndInit();
            this.panelDisplay.ResumeLayout(false);
            this.panelDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCook;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbSugarProp;
        private System.Windows.Forms.Label labelAmountOfSugar;
        private System.Windows.Forms.TrackBar tbTemperatureProp;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelUserTemperature;
        private System.Windows.Forms.Panel panelCoinAcceptor;
        private System.Windows.Forms.Panel panelCoinOne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelCookStage;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDrink;
        private DrinkButton drinkButton1;
        private DrinkButton drinkButton2;
        private DrinkButton drinkButton3;
        private DrinkButton drinkButton4;
        private DrinkButton drinkButton5;
        private DrinkButton drinkButton6;
        private DrinkButton drinkButton7;
        private DrinkButton drinkButton8;
        private System.Windows.Forms.Button butСancellation;
        private System.Windows.Forms.Button butChangeNDrink;
    }
}

