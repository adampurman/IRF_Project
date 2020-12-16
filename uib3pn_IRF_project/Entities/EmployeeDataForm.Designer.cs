namespace uib3pn_IRF_project.Entities
{
    partial class EmployeeDataForm
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
            this.nametxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.countrytxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.malepanel = new System.Windows.Forms.Panel();
            this.femalepanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(92, 51);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 20);
            this.nametxt.TabIndex = 0;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(92, 103);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(100, 20);
            this.emailtxt.TabIndex = 1;
            // 
            // countrytxt
            // 
            this.countrytxt.Location = new System.Drawing.Point(92, 77);
            this.countrytxt.Name = "countrytxt";
            this.countrytxt.Size = new System.Drawing.Size(100, 20);
            this.countrytxt.TabIndex = 2;
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(293, 77);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(100, 20);
            this.phonetxt.TabIndex = 3;
            // 
            // genderCombo
            // 
            this.genderCombo.FormattingEnabled = true;
            this.genderCombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCombo.Location = new System.Drawing.Point(293, 49);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(121, 21);
            this.genderCombo.TabIndex = 4;
            this.genderCombo.SelectedIndexChanged += new System.EventHandler(this.genderCombo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // malepanel
            // 
            this.malepanel.Location = new System.Drawing.Point(481, 32);
            this.malepanel.Name = "malepanel";
            this.malepanel.Size = new System.Drawing.Size(200, 100);
            this.malepanel.TabIndex = 6;
            // 
            // femalepanel
            // 
            this.femalepanel.Location = new System.Drawing.Point(481, 154);
            this.femalepanel.Name = "femalepanel";
            this.femalepanel.Size = new System.Drawing.Size(200, 100);
            this.femalepanel.TabIndex = 7;
            // 
            // EmployeeDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 287);
            this.Controls.Add(this.femalepanel);
            this.Controls.Add(this.malepanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.genderCombo);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.countrytxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.nametxt);
            this.Name = "EmployeeDataForm";
            this.Text = "EmployeeDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox countrytxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.ComboBox genderCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel malepanel;
        private System.Windows.Forms.Panel femalepanel;
    }
}