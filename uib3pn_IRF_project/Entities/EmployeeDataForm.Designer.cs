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
            this.genderCombo.Location = new System.Drawing.Point(293, 49);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(121, 21);
            this.genderCombo.TabIndex = 4;
            // 
            // EmployeeDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}