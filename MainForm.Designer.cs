namespace ClockCheker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStartTImer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStopTImer = new System.Windows.Forms.Button();
            this.LargeNameApp = new System.Windows.Forms.Label();
            this.LargeTime = new System.Windows.Forms.Label();
            this.cb_CityList = new System.Windows.Forms.ComboBox();
            this.btn_AddCity = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnStartTImer
            // 
            resources.ApplyResources(this.btnStartTImer, "btnStartTImer");
            this.btnStartTImer.Name = "btnStartTImer";
            this.btnStartTImer.UseVisualStyleBackColor = true;
            this.btnStartTImer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnStopTImer
            // 
            resources.ApplyResources(this.btnStopTImer, "btnStopTImer");
            this.btnStopTImer.Name = "btnStopTImer";
            this.btnStopTImer.UseVisualStyleBackColor = true;
            this.btnStopTImer.Click += new System.EventHandler(this.btnStopTimer_click);
            // 
            // LargeNameApp
            // 
            resources.ApplyResources(this.LargeNameApp, "LargeNameApp");
            this.LargeNameApp.Name = "LargeNameApp";
            // 
            // LargeTime
            // 
            resources.ApplyResources(this.LargeTime, "LargeTime");
            this.LargeTime.Name = "LargeTime";
            // 
            // cb_CityList
            // 
            resources.ApplyResources(this.cb_CityList, "cb_CityList");
            this.cb_CityList.FormattingEnabled = true;
            this.cb_CityList.Name = "cb_CityList";
            this.cb_CityList.SelectedIndexChanged += new System.EventHandler(this.cb_CityList_SelectedIndexChanged);
            // 
            // btn_AddCity
            // 
            resources.ApplyResources(this.btn_AddCity, "btn_AddCity");
            this.btn_AddCity.Name = "btn_AddCity";
            this.btn_AddCity.UseVisualStyleBackColor = true;
            this.btn_AddCity.Click += new System.EventHandler(this.btn_AddCity_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_AddCity);
            this.Controls.Add(this.cb_CityList);
            this.Controls.Add(this.LargeTime);
            this.Controls.Add(this.LargeNameApp);
            this.Controls.Add(this.btnStopTImer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStartTImer);
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStartTImer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStopTImer;
        private System.Windows.Forms.Label LargeNameApp;
        private System.Windows.Forms.Label LargeTime;
        private System.Windows.Forms.ComboBox cb_CityList;
        private System.Windows.Forms.Button btn_AddCity;
    }
}

