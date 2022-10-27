namespace ClockCheker
{
    partial class AddCityForm
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
            this.tb_CityName = new System.Windows.Forms.TextBox();
            this.lab_enterCity = new System.Windows.Forms.Label();
            this.lab_enterTime = new System.Windows.Forms.Label();
            this.lab_Hours = new System.Windows.Forms.Label();
            this.LargeNameApp = new System.Windows.Forms.Label();
            this.btn_Complet = new System.Windows.Forms.Button();
            this.cb_SetHours = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_CityName
            // 
            this.tb_CityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_CityName.Location = new System.Drawing.Point(174, 81);
            this.tb_CityName.Name = "tb_CityName";
            this.tb_CityName.Size = new System.Drawing.Size(153, 29);
            this.tb_CityName.TabIndex = 0;
            // 
            // lab_enterCity
            // 
            this.lab_enterCity.AutoSize = true;
            this.lab_enterCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_enterCity.Location = new System.Drawing.Point(16, 84);
            this.lab_enterCity.Name = "lab_enterCity";
            this.lab_enterCity.Size = new System.Drawing.Size(152, 24);
            this.lab_enterCity.TabIndex = 2;
            this.lab_enterCity.Text = "Введите город:";
            // 
            // lab_enterTime
            // 
            this.lab_enterTime.AutoSize = true;
            this.lab_enterTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_enterTime.Location = new System.Drawing.Point(16, 140);
            this.lab_enterTime.Name = "lab_enterTime";
            this.lab_enterTime.Size = new System.Drawing.Size(203, 24);
            this.lab_enterTime.TabIndex = 3;
            this.lab_enterTime.Text = "Часов в этом городе:";
            // 
            // lab_Hours
            // 
            this.lab_Hours.AutoSize = true;
            this.lab_Hours.Location = new System.Drawing.Point(226, 124);
            this.lab_Hours.Name = "lab_Hours";
            this.lab_Hours.Size = new System.Drawing.Size(39, 13);
            this.lab_Hours.TabIndex = 4;
            this.lab_Hours.Text = "Часов";
            // 
            // LargeNameApp
            // 
            this.LargeNameApp.AutoSize = true;
            this.LargeNameApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.LargeNameApp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LargeNameApp.Location = new System.Drawing.Point(64, 4);
            this.LargeNameApp.Name = "LargeNameApp";
            this.LargeNameApp.Size = new System.Drawing.Size(254, 36);
            this.LargeNameApp.TabIndex = 8;
            this.LargeNameApp.Text = "Мировое время";
            // 
            // btn_Complet
            // 
            this.btn_Complet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Complet.Location = new System.Drawing.Point(124, 196);
            this.btn_Complet.Name = "btn_Complet";
            this.btn_Complet.Size = new System.Drawing.Size(123, 39);
            this.btn_Complet.TabIndex = 9;
            this.btn_Complet.Text = "Готово";
            this.btn_Complet.UseVisualStyleBackColor = true;
            this.btn_Complet.Click += new System.EventHandler(this.btn_Complet_Click);
            // 
            // cb_SetHours
            // 
            this.cb_SetHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_SetHours.FormattingEnabled = true;
            this.cb_SetHours.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00"});
            this.cb_SetHours.Location = new System.Drawing.Point(225, 140);
            this.cb_SetHours.Name = "cb_SetHours";
            this.cb_SetHours.Size = new System.Drawing.Size(40, 33);
            this.cb_SetHours.TabIndex = 10;
            this.cb_SetHours.SelectedIndexChanged += new System.EventHandler(this.cb_SetHours_SelectedIndexChanged);
            // 
            // AddCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.cb_SetHours);
            this.Controls.Add(this.btn_Complet);
            this.Controls.Add(this.LargeNameApp);
            this.Controls.Add(this.lab_Hours);
            this.Controls.Add(this.lab_enterTime);
            this.Controls.Add(this.lab_enterCity);
            this.Controls.Add(this.tb_CityName);
            this.Name = "AddCityForm";
            this.Text = "Добавить город";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_CityName;
        private System.Windows.Forms.Label lab_enterCity;
        private System.Windows.Forms.Label lab_enterTime;
        private System.Windows.Forms.Label lab_Hours;
        private System.Windows.Forms.Label LargeNameApp;
        private System.Windows.Forms.Button btn_Complet;
        private System.Windows.Forms.ComboBox cb_SetHours;
    }
}