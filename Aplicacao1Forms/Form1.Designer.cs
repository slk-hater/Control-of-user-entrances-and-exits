
namespace Aplicacao1Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.localeBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sexBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.submeterBtn = new System.Windows.Forms.Button();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.clearSelectedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomeLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.Location = new System.Drawing.Point(46, 25);
            this.nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(58, 22);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.Black;
            this.nameBox.Location = new System.Drawing.Point(112, 23);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.MaxLength = 30;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(229, 24);
            this.nameBox.TabIndex = 1;
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameBox.ForeColor = System.Drawing.Color.Black;
            this.surnameBox.Location = new System.Drawing.Point(112, 67);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameBox.MaxLength = 20;
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(229, 24);
            this.surnameBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apelido";
            // 
            // localeBox
            // 
            this.localeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localeBox.ForeColor = System.Drawing.Color.Black;
            this.localeBox.Location = new System.Drawing.Point(112, 108);
            this.localeBox.Margin = new System.Windows.Forms.Padding(4);
            this.localeBox.MaxLength = 25;
            this.localeBox.Name = "localeBox";
            this.localeBox.Size = new System.Drawing.Size(229, 24);
            this.localeBox.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(7, 110);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(97, 22);
            this.label.TabIndex = 4;
            this.label.Text = "Localidade";
            // 
            // ageBox
            // 
            this.ageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBox.ForeColor = System.Drawing.Color.Black;
            this.ageBox.Location = new System.Drawing.Point(112, 145);
            this.ageBox.Margin = new System.Windows.Forms.Padding(4);
            this.ageBox.MaxLength = 2;
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(48, 24);
            this.ageBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Idade";
            // 
            // sexBox
            // 
            this.sexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexBox.ForeColor = System.Drawing.Color.Black;
            this.sexBox.Location = new System.Drawing.Point(112, 179);
            this.sexBox.Margin = new System.Windows.Forms.Padding(4);
            this.sexBox.MaxLength = 1;
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(48, 24);
            this.sexBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sexo";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(349, 23);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(518, 244);
            this.listBox1.TabIndex = 10;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // submeterBtn
            // 
            this.submeterBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.submeterBtn.FlatAppearance.BorderSize = 0;
            this.submeterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submeterBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submeterBtn.Location = new System.Drawing.Point(112, 211);
            this.submeterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.submeterBtn.Name = "submeterBtn";
            this.submeterBtn.Size = new System.Drawing.Size(229, 53);
            this.submeterBtn.TabIndex = 11;
            this.submeterBtn.TabStop = false;
            this.submeterBtn.Text = "Entrada utente";
            this.submeterBtn.UseVisualStyleBackColor = false;
            this.submeterBtn.Click += new System.EventHandler(this.submeterBtn_Click);
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearAllBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearAllBtn.FlatAppearance.BorderSize = 0;
            this.clearAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllBtn.Location = new System.Drawing.Point(614, 269);
            this.clearAllBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(243, 53);
            this.clearAllBtn.TabIndex = 13;
            this.clearAllBtn.TabStop = false;
            this.clearAllBtn.Text = "Limpar todos";
            this.clearAllBtn.UseVisualStyleBackColor = false;
            this.clearAllBtn.Click += new System.EventHandler(this.clearAllBtn_Click);
            // 
            // clearSelectedBtn
            // 
            this.clearSelectedBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearSelectedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearSelectedBtn.FlatAppearance.BorderSize = 0;
            this.clearSelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSelectedBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSelectedBtn.Location = new System.Drawing.Point(363, 269);
            this.clearSelectedBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearSelectedBtn.Name = "clearSelectedBtn";
            this.clearSelectedBtn.Size = new System.Drawing.Size(243, 53);
            this.clearSelectedBtn.TabIndex = 12;
            this.clearSelectedBtn.TabStop = false;
            this.clearSelectedBtn.Text = "Saída utente";
            this.clearSelectedBtn.UseVisualStyleBackColor = false;
            this.clearSelectedBtn.Click += new System.EventHandler(this.clearSelectedBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(887, 349);
            this.Controls.Add(this.clearAllBtn);
            this.Controls.Add(this.clearSelectedBtn);
            this.Controls.Add(this.submeterBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sexBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.localeBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nomeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Controle de entradas e saídas de utentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox localeBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sexBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button submeterBtn;
        private System.Windows.Forms.Button clearAllBtn;
        private System.Windows.Forms.Button clearSelectedBtn;
    }
}

