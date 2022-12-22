
namespace EkzmenApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FiltrComboBox = new System.Windows.Forms.ComboBox();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.MainFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NavigationButton_4 = new System.Windows.Forms.LinkLabel();
            this.RightnavigationButton = new System.Windows.Forms.LinkLabel();
            this.LeftNavigationButton = new System.Windows.Forms.LinkLabel();
            this.NavigationButton_1 = new System.Windows.Forms.LinkLabel();
            this.NavigationButton_2 = new System.Windows.Forms.LinkLabel();
            this.NavigationButton_3 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.FiltrComboBox);
            this.panel1.Controls.Add(this.SortComboBox);
            this.panel1.Controls.Add(this.SearchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 51);
            this.panel1.TabIndex = 0;
            // 
            // FiltrComboBox
            // 
            this.FiltrComboBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiltrComboBox.FormattingEnabled = true;
            this.FiltrComboBox.Items.AddRange(new object[] {
            "ВСЕ",
            "M1",
            "M2",
            "M3"});
            this.FiltrComboBox.Location = new System.Drawing.Point(523, 5);
            this.FiltrComboBox.Name = "FiltrComboBox";
            this.FiltrComboBox.Size = new System.Drawing.Size(200, 41);
            this.FiltrComboBox.TabIndex = 1;
            this.FiltrComboBox.Text = "Фильтрация";
            this.FiltrComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrComboBox_SelectedIndexChanged);
            // 
            // SortComboBox
            // 
            this.SortComboBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.SortComboBox.Location = new System.Drawing.Point(320, 6);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(187, 41);
            this.SortComboBox.TabIndex = 1;
            this.SortComboBox.Text = "Сортировка";
            this.SortComboBox.SelectedIndexChanged += new System.EventHandler(this.SortComboBox_SelectedIndexChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(3, 6);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(293, 41);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.Text = "Введите для поиска";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // MainFlow
            // 
            this.MainFlow.AutoScroll = true;
            this.MainFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MainFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFlow.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainFlow.Location = new System.Drawing.Point(0, 51);
            this.MainFlow.Name = "MainFlow";
            this.MainFlow.Size = new System.Drawing.Size(727, 360);
            this.MainFlow.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.NavigationButton_4);
            this.panel2.Controls.Add(this.RightnavigationButton);
            this.panel2.Controls.Add(this.LeftNavigationButton);
            this.panel2.Controls.Add(this.NavigationButton_1);
            this.panel2.Controls.Add(this.NavigationButton_2);
            this.panel2.Controls.Add(this.NavigationButton_3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 39);
            this.panel2.TabIndex = 2;
            // 
            // NavigationButton_4
            // 
            this.NavigationButton_4.AutoSize = true;
            this.NavigationButton_4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NavigationButton_4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.NavigationButton_4.Location = new System.Drawing.Point(657, -1);
            this.NavigationButton_4.Name = "NavigationButton_4";
            this.NavigationButton_4.Size = new System.Drawing.Size(30, 33);
            this.NavigationButton_4.TabIndex = 0;
            this.NavigationButton_4.TabStop = true;
            this.NavigationButton_4.Text = "4";
            this.NavigationButton_4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NavigationButton_1_LinkClicked);
            // 
            // RightnavigationButton
            // 
            this.RightnavigationButton.AutoSize = true;
            this.RightnavigationButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightnavigationButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.RightnavigationButton.Location = new System.Drawing.Point(693, -1);
            this.RightnavigationButton.Name = "RightnavigationButton";
            this.RightnavigationButton.Size = new System.Drawing.Size(25, 33);
            this.RightnavigationButton.TabIndex = 0;
            this.RightnavigationButton.TabStop = true;
            this.RightnavigationButton.Text = ">";
            this.RightnavigationButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NavigationButton_1_LinkClicked);
            // 
            // LeftNavigationButton
            // 
            this.LeftNavigationButton.AutoSize = true;
            this.LeftNavigationButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftNavigationButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.LeftNavigationButton.Location = new System.Drawing.Point(513, -1);
            this.LeftNavigationButton.Name = "LeftNavigationButton";
            this.LeftNavigationButton.Size = new System.Drawing.Size(24, 33);
            this.LeftNavigationButton.TabIndex = 0;
            this.LeftNavigationButton.TabStop = true;
            this.LeftNavigationButton.Text = "<";
            this.LeftNavigationButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NavigationButton_1_LinkClicked);
            // 
            // NavigationButton_1
            // 
            this.NavigationButton_1.AutoSize = true;
            this.NavigationButton_1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NavigationButton_1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.NavigationButton_1.Location = new System.Drawing.Point(549, -1);
            this.NavigationButton_1.Name = "NavigationButton_1";
            this.NavigationButton_1.Size = new System.Drawing.Size(26, 33);
            this.NavigationButton_1.TabIndex = 0;
            this.NavigationButton_1.TabStop = true;
            this.NavigationButton_1.Text = "1";
            this.NavigationButton_1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NavigationButton_1_LinkClicked);
            // 
            // NavigationButton_2
            // 
            this.NavigationButton_2.AutoSize = true;
            this.NavigationButton_2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NavigationButton_2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.NavigationButton_2.Location = new System.Drawing.Point(585, -1);
            this.NavigationButton_2.Name = "NavigationButton_2";
            this.NavigationButton_2.Size = new System.Drawing.Size(30, 33);
            this.NavigationButton_2.TabIndex = 0;
            this.NavigationButton_2.TabStop = true;
            this.NavigationButton_2.Text = "2";
            this.NavigationButton_2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NavigationButton_1_LinkClicked);
            // 
            // NavigationButton_3
            // 
            this.NavigationButton_3.AutoSize = true;
            this.NavigationButton_3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NavigationButton_3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.NavigationButton_3.Location = new System.Drawing.Point(621, -1);
            this.NavigationButton_3.Name = "NavigationButton_3";
            this.NavigationButton_3.Size = new System.Drawing.Size(30, 33);
            this.NavigationButton_3.TabIndex = 0;
            this.NavigationButton_3.TabStop = true;
            this.NavigationButton_3.Text = "3";
            this.NavigationButton_3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NavigationButton_1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.MainFlow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox FiltrComboBox;
        private System.Windows.Forms.ComboBox SortComboBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.FlowLayoutPanel MainFlow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel NavigationButton_4;
        private System.Windows.Forms.LinkLabel RightnavigationButton;
        private System.Windows.Forms.LinkLabel LeftNavigationButton;
        private System.Windows.Forms.LinkLabel NavigationButton_1;
        private System.Windows.Forms.LinkLabel NavigationButton_2;
        private System.Windows.Forms.LinkLabel NavigationButton_3;
    }
}

