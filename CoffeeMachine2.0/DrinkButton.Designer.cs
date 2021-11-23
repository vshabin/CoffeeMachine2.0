
namespace CoffeeMachine2._0
{
    partial class DrinkButton
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInfoAboutDrinkDB = new System.Windows.Forms.Label();
            this.pbDrinkButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrinkButton)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfoAboutDrinkDB
            // 
            this.labelInfoAboutDrinkDB.AutoSize = true;
            this.labelInfoAboutDrinkDB.Location = new System.Drawing.Point(4, 16);
            this.labelInfoAboutDrinkDB.Name = "labelInfoAboutDrinkDB";
            this.labelInfoAboutDrinkDB.Size = new System.Drawing.Size(35, 13);
            this.labelInfoAboutDrinkDB.TabIndex = 0;
            this.labelInfoAboutDrinkDB.Text = "label1";
            // 
            // pbDrinkButton
            // 
            this.pbDrinkButton.Location = new System.Drawing.Point(155, 0);
            this.pbDrinkButton.Name = "pbDrinkButton";
            this.pbDrinkButton.Size = new System.Drawing.Size(74, 60);
            this.pbDrinkButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrinkButton.TabIndex = 1;
            this.pbDrinkButton.TabStop = false;
            // 
            // DrinkButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbDrinkButton);
            this.Controls.Add(this.labelInfoAboutDrinkDB);
            this.Name = "DrinkButton";
            this.Size = new System.Drawing.Size(232, 63);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrinkButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoAboutDrinkDB;
        private System.Windows.Forms.PictureBox pbDrinkButton;
    }
}
