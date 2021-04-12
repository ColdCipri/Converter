namespace Calculator
{
    partial class Main
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
            this.Label_titlu = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.comboBox_valuta = new System.Windows.Forms.ComboBox();
            this.button_Eng = new System.Windows.Forms.Button();
            this.button_Ro = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_titlu
            // 
            this.Label_titlu.AutoSize = true;
            this.Label_titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_titlu.Location = new System.Drawing.Point(84, 55);
            this.Label_titlu.Name = "Label_titlu";
            this.Label_titlu.Size = new System.Drawing.Size(488, 51);
            this.Label_titlu.TabIndex = 0;
            this.Label_titlu.Text = "Vă rog introduceți suma:";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.comboBox_valuta);
            this.panel.Controls.Add(this.button_Eng);
            this.panel.Controls.Add(this.button_Ro);
            this.panel.Controls.Add(this.numericUpDown);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(691, 449);
            this.panel.TabIndex = 1;
            // 
            // comboBox_valuta
            // 
            this.comboBox_valuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_valuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_valuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_valuta.FormattingEnabled = true;
            this.comboBox_valuta.Items.AddRange(new object[] {
            "Lei",
            "Euro"});
            this.comboBox_valuta.Location = new System.Drawing.Point(388, 162);
            this.comboBox_valuta.Name = "comboBox_valuta";
            this.comboBox_valuta.Size = new System.Drawing.Size(121, 44);
            this.comboBox_valuta.TabIndex = 2;
            // 
            // button_Eng
            // 
            this.button_Eng.BackColor = System.Drawing.Color.Bisque;
            this.button_Eng.FlatAppearance.BorderSize = 0;
            this.button_Eng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Eng.Location = new System.Drawing.Point(375, 280);
            this.button_Eng.Name = "button_Eng";
            this.button_Eng.Size = new System.Drawing.Size(134, 46);
            this.button_Eng.TabIndex = 3;
            this.button_Eng.Text = "Engleză";
            this.button_Eng.UseVisualStyleBackColor = false;
            this.button_Eng.Click += new System.EventHandler(this.button_Eng_Click);
            // 
            // button_Ro
            // 
            this.button_Ro.BackColor = System.Drawing.Color.Bisque;
            this.button_Ro.FlatAppearance.BorderSize = 0;
            this.button_Ro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ro.Location = new System.Drawing.Point(130, 280);
            this.button_Ro.Name = "button_Ro";
            this.button_Ro.Size = new System.Drawing.Size(134, 46);
            this.button_Ro.TabIndex = 1;
            this.button_Ro.Text = "Română";
            this.button_Ro.UseVisualStyleBackColor = false;
            this.button_Ro.Click += new System.EventHandler(this.button_Ro_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.BackColor = System.Drawing.Color.OldLace;
            this.numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown.DecimalPlaces = 2;
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(122, 162);
            this.numericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(260, 41);
            this.numericUpDown.TabIndex = 1;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(688, 446);
            this.Controls.Add(this.Label_titlu);
            this.Controls.Add(this.panel);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_titlu;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button button_Eng;
        private System.Windows.Forms.Button button_Ro;
        private System.Windows.Forms.ComboBox comboBox_valuta;
    }
}

