
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
            this.openAdminPanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openAdminPanel
            // 
            this.openAdminPanel.Location = new System.Drawing.Point(1, 1);
            this.openAdminPanel.Name = "openAdminPanel";
            this.openAdminPanel.Size = new System.Drawing.Size(75, 23);
            this.openAdminPanel.TabIndex = 0;
            this.openAdminPanel.Text = "Настроить";
            this.openAdminPanel.UseVisualStyleBackColor = true;
            this.openAdminPanel.Click += new System.EventHandler(this.openAdminPanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openAdminPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openAdminPanel;
    }
}

