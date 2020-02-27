namespace Ejercicio_3
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
            this.cbTodos = new System.Windows.Forms.ComboBox();
            this.cbMultiplos4 = new System.Windows.Forms.ComboBox();
            this.cbMultiplos10 = new System.Windows.Forms.ComboBox();
            this.cbMultiplos3 = new System.Windows.Forms.ComboBox();
            this.cbImpares = new System.Windows.Forms.ComboBox();
            this.btnCargarInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTodos
            // 
            this.cbTodos.FormattingEnabled = true;
            this.cbTodos.Location = new System.Drawing.Point(133, 42);
            this.cbTodos.Name = "cbTodos";
            this.cbTodos.Size = new System.Drawing.Size(121, 29);
            this.cbTodos.TabIndex = 0;
            // 
            // cbMultiplos4
            // 
            this.cbMultiplos4.FormattingEnabled = true;
            this.cbMultiplos4.Location = new System.Drawing.Point(133, 77);
            this.cbMultiplos4.Name = "cbMultiplos4";
            this.cbMultiplos4.Size = new System.Drawing.Size(121, 29);
            this.cbMultiplos4.TabIndex = 1;
            // 
            // cbMultiplos10
            // 
            this.cbMultiplos10.FormattingEnabled = true;
            this.cbMultiplos10.Location = new System.Drawing.Point(133, 112);
            this.cbMultiplos10.Name = "cbMultiplos10";
            this.cbMultiplos10.Size = new System.Drawing.Size(121, 29);
            this.cbMultiplos10.TabIndex = 2;
            // 
            // cbMultiplos3
            // 
            this.cbMultiplos3.FormattingEnabled = true;
            this.cbMultiplos3.Location = new System.Drawing.Point(133, 148);
            this.cbMultiplos3.Name = "cbMultiplos3";
            this.cbMultiplos3.Size = new System.Drawing.Size(121, 29);
            this.cbMultiplos3.TabIndex = 3;
            // 
            // cbImpares
            // 
            this.cbImpares.FormattingEnabled = true;
            this.cbImpares.Location = new System.Drawing.Point(133, 183);
            this.cbImpares.Name = "cbImpares";
            this.cbImpares.Size = new System.Drawing.Size(121, 29);
            this.cbImpares.TabIndex = 4;
            // 
            // btnCargarInfo
            // 
            this.btnCargarInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCargarInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCargarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarInfo.Location = new System.Drawing.Point(277, 95);
            this.btnCargarInfo.Name = "btnCargarInfo";
            this.btnCargarInfo.Size = new System.Drawing.Size(129, 65);
            this.btnCargarInfo.TabIndex = 5;
            this.btnCargarInfo.Text = "Cargar Información";
            this.btnCargarInfo.UseVisualStyleBackColor = false;
            this.btnCargarInfo.Click += new System.EventHandler(this.btnCargarInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Todos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Múltiplos 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Múltiplos 10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Múltiplos 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Impares";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(434, 254);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarInfo);
            this.Controls.Add(this.cbImpares);
            this.Controls.Add(this.cbMultiplos3);
            this.Controls.Add(this.cbMultiplos10);
            this.Controls.Add(this.cbMultiplos4);
            this.Controls.Add(this.cbTodos);
            this.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTodos;
        private System.Windows.Forms.ComboBox cbMultiplos4;
        private System.Windows.Forms.ComboBox cbMultiplos10;
        private System.Windows.Forms.ComboBox cbMultiplos3;
        private System.Windows.Forms.ComboBox cbImpares;
        private System.Windows.Forms.Button btnCargarInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

