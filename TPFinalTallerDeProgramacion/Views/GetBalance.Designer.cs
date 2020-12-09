namespace TPFinalTallerDeProgramacion.Views
{
    partial class GetBalance
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
            this.buttonGetBalance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGetBalance
            // 
            this.buttonGetBalance.Location = new System.Drawing.Point(142, 180);
            this.buttonGetBalance.Name = "buttonGetBalance";
            this.buttonGetBalance.Size = new System.Drawing.Size(95, 36);
            this.buttonGetBalance.TabIndex = 0;
            this.buttonGetBalance.Text = "ObtenerBalance";
            this.buttonGetBalance.UseVisualStyleBackColor = true;
            this.buttonGetBalance.Click += new System.EventHandler(this.getBalance);
            // 
            // GetBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 301);
            this.Controls.Add(this.buttonGetBalance);
            this.Name = "GetBalance";
            this.Text = "GetBalance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetBalance;
    }
}