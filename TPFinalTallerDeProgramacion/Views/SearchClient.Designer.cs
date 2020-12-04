namespace TPFinalTallerDeProgramacion.Vista
{
    partial class SearchClient
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelDNI = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.labelPIN = new System.Windows.Forms.Label();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.groupBoxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSearch.Location = new System.Drawing.Point(223, 182);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.search);
            // 
            // buttonCancel
            // 
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(99, 182);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            this.buttonCancel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancel);
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDNI.Location = new System.Drawing.Point(26, 31);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 2;
            this.labelDNI.Text = "DNI";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(86, 28);
            this.textBoxDNI.Mask = "99999999";
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(56, 20);
            this.textBoxDNI.TabIndex = 3;
            this.textBoxDNI.ValidatingType = typeof(int);
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Location = new System.Drawing.Point(86, 77);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.Size = new System.Drawing.Size(56, 20);
            this.textBoxPIN.TabIndex = 4;
            // 
            // labelPIN
            // 
            this.labelPIN.AutoSize = true;
            this.labelPIN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPIN.Location = new System.Drawing.Point(27, 80);
            this.labelPIN.Name = "labelPIN";
            this.labelPIN.Size = new System.Drawing.Size(25, 13);
            this.labelPIN.TabIndex = 5;
            this.labelPIN.Text = "PIN";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.labelPIN);
            this.groupBoxCliente.Controls.Add(this.textBoxDNI);
            this.groupBoxCliente.Controls.Add(this.labelDNI);
            this.groupBoxCliente.Controls.Add(this.textBoxPIN);
            this.groupBoxCliente.Location = new System.Drawing.Point(105, 25);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(183, 125);
            this.groupBoxCliente.TabIndex = 6;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Datos";
            // 
            // SearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 240);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBoxCliente);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "SearchClient";
            this.Text = "SearchClient";
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.MaskedTextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.GroupBox groupBoxCliente;
    }
}