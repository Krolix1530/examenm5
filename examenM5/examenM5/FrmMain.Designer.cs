namespace examenM5
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.animalBtn = new System.Windows.Forms.Button();
            this.viatgeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animalBtn
            // 
            this.animalBtn.Location = new System.Drawing.Point(228, 225);
            this.animalBtn.Name = "animalBtn";
            this.animalBtn.Size = new System.Drawing.Size(94, 29);
            this.animalBtn.TabIndex = 0;
            this.animalBtn.Text = "Animal";
            this.animalBtn.UseVisualStyleBackColor = true;
            // 
            // viatgeBtn
            // 
            this.viatgeBtn.Location = new System.Drawing.Point(462, 225);
            this.viatgeBtn.Name = "viatgeBtn";
            this.viatgeBtn.Size = new System.Drawing.Size(94, 29);
            this.viatgeBtn.TabIndex = 1;
            this.viatgeBtn.Text = "Viatge";
            this.viatgeBtn.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viatgeBtn);
            this.Controls.Add(this.animalBtn);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button animalBtn;
        private Button viatgeBtn;
    }
}