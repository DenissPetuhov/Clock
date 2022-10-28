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
            this.btnStopTImer = new System.Windows.Forms.Button();
            this.LargeNameApp = new System.Windows.Forms.Label();
            this.LargeTime = new System.Windows.Forms.Label();
            this.cb_CityList = new System.Windows.Forms.ComboBox();
            this.btn_AddCity = new System.Windows.Forms.Button();
            this.cb_SetHours = new System.Windows.Forms.ComboBox();
            this.lab_Hours = new System.Windows.Forms.Label();
            this.lab_enterTime = new System.Windows.Forms.Label();
            this.lab_enterCity = new System.Windows.Forms.Label();
            this.tb_CityName = new System.Windows.Forms.TextBox();
            this.btn_Complet = new System.Windows.Forms.Button();
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
            // cb_SetHours
            // 
            resources.ApplyResources(this.cb_SetHours, "cb_SetHours");
            this.cb_SetHours.FormattingEnabled = true;
            this.cb_SetHours.Items.AddRange(new object[] {
            resources.GetString("cb_SetHours.Items"),
            resources.GetString("cb_SetHours.Items1"),
            resources.GetString("cb_SetHours.Items2"),
            resources.GetString("cb_SetHours.Items3"),
            resources.GetString("cb_SetHours.Items4"),
            resources.GetString("cb_SetHours.Items5"),
            resources.GetString("cb_SetHours.Items6"),
            resources.GetString("cb_SetHours.Items7"),
            resources.GetString("cb_SetHours.Items8"),
            resources.GetString("cb_SetHours.Items9"),
            resources.GetString("cb_SetHours.Items10"),
            resources.GetString("cb_SetHours.Items11"),
            resources.GetString("cb_SetHours.Items12"),
            resources.GetString("cb_SetHours.Items13"),
            resources.GetString("cb_SetHours.Items14"),
            resources.GetString("cb_SetHours.Items15"),
            resources.GetString("cb_SetHours.Items16"),
            resources.GetString("cb_SetHours.Items17"),
            resources.GetString("cb_SetHours.Items18"),
            resources.GetString("cb_SetHours.Items19"),
            resources.GetString("cb_SetHours.Items20"),
            resources.GetString("cb_SetHours.Items21"),
            resources.GetString("cb_SetHours.Items22"),
            resources.GetString("cb_SetHours.Items23")});
            this.cb_SetHours.Name = "cb_SetHours";
            this.cb_SetHours.SelectedIndexChanged += new System.EventHandler(this.cb_SetHours_SelectedIndexChanged);
            // 
            // lab_Hours
            // 
            resources.ApplyResources(this.lab_Hours, "lab_Hours");
            this.lab_Hours.Name = "lab_Hours";
            // 
            // lab_enterTime
            // 
            resources.ApplyResources(this.lab_enterTime, "lab_enterTime");
            this.lab_enterTime.Name = "lab_enterTime";
            // 
            // lab_enterCity
            // 
            resources.ApplyResources(this.lab_enterCity, "lab_enterCity");
            this.lab_enterCity.Name = "lab_enterCity";
            // 
            // tb_CityName
            // 
            resources.ApplyResources(this.tb_CityName, "tb_CityName");
            this.tb_CityName.Name = "tb_CityName";
            // 
            // btn_Complet
            // 
            resources.ApplyResources(this.btn_Complet, "btn_Complet");
            this.btn_Complet.Name = "btn_Complet";
            this.btn_Complet.UseVisualStyleBackColor = true;
            this.btn_Complet.Click += new System.EventHandler(this.btn_Complet_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Complet);
            this.Controls.Add(this.cb_SetHours);
            this.Controls.Add(this.lab_Hours);
            this.Controls.Add(this.lab_enterTime);
            this.Controls.Add(this.lab_enterCity);
            this.Controls.Add(this.tb_CityName);
            this.Controls.Add(this.btn_AddCity);
            this.Controls.Add(this.cb_CityList);
            this.Controls.Add(this.LargeTime);
            this.Controls.Add(this.LargeNameApp);
            this.Controls.Add(this.btnStopTImer);
            this.Controls.Add(this.btnStartTImer);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStartTImer;
        private System.Windows.Forms.Button btnStopTImer;
        private System.Windows.Forms.Label LargeNameApp;
        private System.Windows.Forms.Label LargeTime;
        private System.Windows.Forms.ComboBox cb_CityList;
        private System.Windows.Forms.Button btn_AddCity;
        private System.Windows.Forms.ComboBox cb_SetHours;
        private System.Windows.Forms.Label lab_Hours;
        private System.Windows.Forms.Label lab_enterTime;
        private System.Windows.Forms.Label lab_enterCity;
        private System.Windows.Forms.TextBox tb_CityName;
        private System.Windows.Forms.Button btn_Complet;
    }
}

