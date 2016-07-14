namespace MonsterTools
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_hp = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_attack = new System.Windows.Forms.TextBox();
            this.txt_def = new System.Windows.Forms.TextBox();
            this.txt_specatt = new System.Windows.Forms.TextBox();
            this.txt_specdef = new System.Windows.Forms.TextBox();
            this.txt_speed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Attack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Defence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Special Attack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Special Defence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Speed";
            // 
            // txt_hp
            // 
            this.txt_hp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Health", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.txt_hp.Location = new System.Drawing.Point(98, 30);
            this.txt_hp.Name = "txt_hp";
            this.txt_hp.Size = new System.Drawing.Size(100, 20);
            this.txt_hp.TabIndex = 6;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(MonsterLibraries.Monster);
            // 
            // txt_attack
            // 
            this.txt_attack.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Attack", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.txt_attack.Location = new System.Drawing.Point(98, 51);
            this.txt_attack.Name = "txt_attack";
            this.txt_attack.Size = new System.Drawing.Size(100, 20);
            this.txt_attack.TabIndex = 7;
            // 
            // txt_def
            // 
            this.txt_def.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Defense", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.txt_def.Location = new System.Drawing.Point(98, 72);
            this.txt_def.Name = "txt_def";
            this.txt_def.Size = new System.Drawing.Size(100, 20);
            this.txt_def.TabIndex = 8;
            // 
            // txt_specatt
            // 
            this.txt_specatt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "SpecialAttack", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.txt_specatt.Location = new System.Drawing.Point(98, 93);
            this.txt_specatt.Name = "txt_specatt";
            this.txt_specatt.Size = new System.Drawing.Size(100, 20);
            this.txt_specatt.TabIndex = 9;
            // 
            // txt_specdef
            // 
            this.txt_specdef.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "SpecialDef", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.txt_specdef.Location = new System.Drawing.Point(98, 115);
            this.txt_specdef.Name = "txt_specdef";
            this.txt_specdef.Size = new System.Drawing.Size(100, 20);
            this.txt_specdef.TabIndex = 10;
            // 
            // txt_speed
            // 
            this.txt_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Speed", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.txt_speed.Location = new System.Drawing.Point(98, 136);
            this.txt_speed.Name = "txt_speed";
            this.txt_speed.Size = new System.Drawing.Size(100, 20);
            this.txt_speed.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Name", true));
            this.txt_Name.Location = new System.Drawing.Point(98, 8);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Save All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(191, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Next";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "New";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 256);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_speed);
            this.Controls.Add(this.txt_specdef);
            this.Controls.Add(this.txt_specatt);
            this.Controls.Add(this.txt_def);
            this.Controls.Add(this.txt_attack);
            this.Controls.Add(this.txt_hp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_hp;
        private System.Windows.Forms.TextBox txt_attack;
        private System.Windows.Forms.TextBox txt_def;
        private System.Windows.Forms.TextBox txt_specatt;
        private System.Windows.Forms.TextBox txt_specdef;
        private System.Windows.Forms.TextBox txt_speed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button5;
    }
}

