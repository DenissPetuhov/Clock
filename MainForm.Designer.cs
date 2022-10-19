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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStartTImer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStopTImer = new System.Windows.Forms.Button();
            this.LargeNameApp = new System.Windows.Forms.Label();
            this.LargeTime = new System.Windows.Forms.Label();
            this.MainNameCity = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.LableVladivostorTIme = new System.Windows.Forms.Label();
            this.VladivostorTimeLebel = new System.Windows.Forms.Label();
            this.LondontTmelabel = new System.Windows.Forms.Label();
            this.lableLondonTime = new System.Windows.Forms.Label();
            this.Caliningrad = new System.Windows.Forms.Label();
            this.CaliningradLable = new System.Windows.Forms.Label();
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
            this.btnStartTImer.Click += new System.EventHandler(this.btnStartTImer_Click);
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
            this.btnStopTImer.Click += new System.EventHandler(this.btnStopTImer_click);
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
            // MainNameCity
            // 
            resources.ApplyResources(this.MainNameCity, "MainNameCity");
            this.MainNameCity.Name = "MainNameCity";
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // LableVladivostorTIme
            // 
            resources.ApplyResources(this.LableVladivostorTIme, "LableVladivostorTIme");
            this.LableVladivostorTIme.Name = "LableVladivostorTIme";
            // 
            // VladivostorTimeLebel
            // 
            resources.ApplyResources(this.VladivostorTimeLebel, "VladivostorTimeLebel");
            this.VladivostorTimeLebel.Name = "VladivostorTimeLebel";
            // 
            // LondontTmelabel
            // 
            resources.ApplyResources(this.LondontTmelabel, "LondontTmelabel");
            this.LondontTmelabel.Name = "LondontTmelabel";
            // 
            // lableLondonTime
            // 
            resources.ApplyResources(this.lableLondonTime, "lableLondonTime");
            this.lableLondonTime.Name = "lableLondonTime";
            // 
            // Caliningrad
            // 
            resources.ApplyResources(this.Caliningrad, "Caliningrad");
            this.Caliningrad.Name = "Caliningrad";
            // 
            // CaliningradLable
            // 
            resources.ApplyResources(this.CaliningradLable, "CaliningradLable");
            this.CaliningradLable.Name = "CaliningradLable";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CaliningradLable);
            this.Controls.Add(this.Caliningrad);
            this.Controls.Add(this.lableLondonTime);
            this.Controls.Add(this.LondontTmelabel);
            this.Controls.Add(this.VladivostorTimeLebel);
            this.Controls.Add(this.LableVladivostorTIme);
            this.Controls.Add(this.MainNameCity);
            this.Controls.Add(this.LargeTime);
            this.Controls.Add(this.LargeNameApp);
            this.Controls.Add(this.btnStopTImer);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStopTImer;
        private System.Windows.Forms.Label LargeNameApp;
        private System.Windows.Forms.Label LargeTime;
        private System.Windows.Forms.Label MainNameCity;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label LableVladivostorTIme;
        private System.Windows.Forms.Label VladivostorTimeLebel;
        private System.Windows.Forms.Label LondontTmelabel;
        private System.Windows.Forms.Label lableLondonTime;
        private System.Windows.Forms.Label Caliningrad;
        private System.Windows.Forms.Label CaliningradLable;
    }
}

