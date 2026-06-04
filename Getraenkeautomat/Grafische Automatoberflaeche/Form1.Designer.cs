
namespace Grafische_Automatoberflaeche
{
    partial class Getraenkautomat
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Getraenkautomat));
            this.Cola = new System.Windows.Forms.Button();
            this.geldeingabe = new System.Windows.Forms.TextBox();
            this.Fanta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.RichTextBox();
            this.TXZweiEuro = new System.Windows.Forms.TextBox();
            this.TXEinEuro = new System.Windows.Forms.TextBox();
            this.TXFuenfzigCent = new System.Windows.Forms.TextBox();
            this.TXZwanzigCent = new System.Windows.Forms.TextBox();
            this.TXZehnCent = new System.Windows.Forms.TextBox();
            this.TXFuenfCent = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Nachfuellen = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.TxFuenfEuro = new System.Windows.Forms.TextBox();
            this.TxZehnEuro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cola
            // 
            this.Cola.BackColor = System.Drawing.Color.Red;
            this.Cola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cola.BackgroundImage")));
            this.Cola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cola.Font = new System.Drawing.Font("Impact", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cola.Location = new System.Drawing.Point(12, 154);
            this.Cola.Name = "Cola";
            this.Cola.Size = new System.Drawing.Size(90, 54);
            this.Cola.TabIndex = 0;
            this.Cola.UseVisualStyleBackColor = false;
            this.Cola.Click += new System.EventHandler(this.Cola_Click);
            // 
            // geldeingabe
            // 
            this.geldeingabe.BackColor = System.Drawing.Color.YellowGreen;
            this.geldeingabe.Location = new System.Drawing.Point(314, 159);
            this.geldeingabe.Name = "geldeingabe";
            this.geldeingabe.Size = new System.Drawing.Size(100, 20);
            this.geldeingabe.TabIndex = 1;
            this.geldeingabe.TextChanged += new System.EventHandler(this.geldeingabe_TextChanged_1);
            this.geldeingabe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEnter);
            this.geldeingabe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.geldeingabe_KeyPress);
            // 
            // Fanta
            // 
            this.Fanta.BackColor = System.Drawing.Color.Orange;
            this.Fanta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fanta.BackgroundImage")));
            this.Fanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fanta.Font = new System.Drawing.Font("Javanese Text", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fanta.Location = new System.Drawing.Point(12, 214);
            this.Fanta.Name = "Fanta";
            this.Fanta.Size = new System.Drawing.Size(90, 54);
            this.Fanta.TabIndex = 0;
            this.Fanta.UseVisualStyleBackColor = false;
            this.Fanta.Click += new System.EventHandler(this.Fanta_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Olive;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("MV Boli", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(108, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 54);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Eis_Tee_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(108, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 54);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Cola_Zero_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.BlueViolet;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Segoe UI Black", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 54);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.RedBull_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCyan;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(108, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 54);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Wasser_Click);
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.IndianRed;
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(217, 154);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(90, 54);
            this.Enter.TabIndex = 0;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(12, 26);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(402, 122);
            this.status.TabIndex = 3;
            this.status.Text = "Bitte waehlen Sie ein Getaenk aus!\n";
            this.status.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // TXZweiEuro
            // 
            this.TXZweiEuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TXZweiEuro.Location = new System.Drawing.Point(217, 253);
            this.TXZweiEuro.Name = "TXZweiEuro";
            this.TXZweiEuro.Size = new System.Drawing.Size(90, 20);
            this.TXZweiEuro.TabIndex = 4;
            this.TXZweiEuro.Text = "2 Euro ";
            // 
            // TXEinEuro
            // 
            this.TXEinEuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TXEinEuro.Location = new System.Drawing.Point(315, 253);
            this.TXEinEuro.Name = "TXEinEuro";
            this.TXEinEuro.Size = new System.Drawing.Size(100, 20);
            this.TXEinEuro.TabIndex = 5;
            this.TXEinEuro.Text = "1 Euro";
            this.TXEinEuro.TextChanged += new System.EventHandler(this.TXEinEuro_TextChanged);
            // 
            // TXFuenfzigCent
            // 
            this.TXFuenfzigCent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TXFuenfzigCent.Location = new System.Drawing.Point(217, 279);
            this.TXFuenfzigCent.Name = "TXFuenfzigCent";
            this.TXFuenfzigCent.Size = new System.Drawing.Size(90, 20);
            this.TXFuenfzigCent.TabIndex = 6;
            this.TXFuenfzigCent.Text = "50 Cent ";
            // 
            // TXZwanzigCent
            // 
            this.TXZwanzigCent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TXZwanzigCent.Location = new System.Drawing.Point(315, 279);
            this.TXZwanzigCent.Name = "TXZwanzigCent";
            this.TXZwanzigCent.Size = new System.Drawing.Size(100, 20);
            this.TXZwanzigCent.TabIndex = 7;
            this.TXZwanzigCent.Text = "20 Cent ";
            // 
            // TXZehnCent
            // 
            this.TXZehnCent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TXZehnCent.Location = new System.Drawing.Point(217, 306);
            this.TXZehnCent.Name = "TXZehnCent";
            this.TXZehnCent.Size = new System.Drawing.Size(90, 20);
            this.TXZehnCent.TabIndex = 8;
            this.TXZehnCent.Text = "10 Cent ";
            // 
            // TXFuenfCent
            // 
            this.TXFuenfCent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TXFuenfCent.Location = new System.Drawing.Point(315, 306);
            this.TXFuenfCent.Name = "TXFuenfCent";
            this.TXFuenfCent.Size = new System.Drawing.Size(100, 20);
            this.TXFuenfCent.TabIndex = 9;
            this.TXFuenfCent.Text = "5 Cent ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(219, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nachfuellen
            // 
            this.Nachfuellen.BackColor = System.Drawing.Color.Red;
            this.Nachfuellen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nachfuellen.Location = new System.Drawing.Point(314, 220);
            this.Nachfuellen.Name = "Nachfuellen";
            this.Nachfuellen.Size = new System.Drawing.Size(101, 25);
            this.Nachfuellen.TabIndex = 11;
            this.Nachfuellen.Text = "Nachfüllen";
            this.Nachfuellen.UseVisualStyleBackColor = false;
            this.Nachfuellen.Click += new System.EventHandler(this.Nachfuellen_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(324, 187);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 29);
            this.button6.TabIndex = 12;
            this.button6.Text = "Umsatz";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TxFuenfEuro
            // 
            this.TxFuenfEuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TxFuenfEuro.Location = new System.Drawing.Point(217, 332);
            this.TxFuenfEuro.Name = "TxFuenfEuro";
            this.TxFuenfEuro.Size = new System.Drawing.Size(90, 20);
            this.TxFuenfEuro.TabIndex = 8;
            this.TxFuenfEuro.Text = "5 Euro";
            // 
            // TxZehnEuro
            // 
            this.TxZehnEuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TxZehnEuro.Location = new System.Drawing.Point(314, 332);
            this.TxZehnEuro.Name = "TxZehnEuro";
            this.TxZehnEuro.Size = new System.Drawing.Size(100, 20);
            this.TxZehnEuro.TabIndex = 8;
            this.TxZehnEuro.Text = "10 Euro";
            // 
            // Getraenkautomat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(427, 369);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Nachfuellen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXFuenfCent);
            this.Controls.Add(this.TxZehnEuro);
            this.Controls.Add(this.TxFuenfEuro);
            this.Controls.Add(this.TXZehnCent);
            this.Controls.Add(this.TXZwanzigCent);
            this.Controls.Add(this.TXFuenfzigCent);
            this.Controls.Add(this.TXEinEuro);
            this.Controls.Add(this.TXZweiEuro);
            this.Controls.Add(this.status);
            this.Controls.Add(this.geldeingabe);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Fanta);
            this.Controls.Add(this.Cola);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Getraenkautomat";
            this.Text = "Getraenkautomat ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cola;
        private System.Windows.Forms.TextBox geldeingabe;
        private System.Windows.Forms.Button Fanta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.RichTextBox status;
        private System.Windows.Forms.TextBox TXZweiEuro;
        private System.Windows.Forms.TextBox TXEinEuro;
        private System.Windows.Forms.TextBox TXFuenfzigCent;
        private System.Windows.Forms.TextBox TXZwanzigCent;
        private System.Windows.Forms.TextBox TXZehnCent;
        private System.Windows.Forms.TextBox TXFuenfCent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Nachfuellen;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox TxFuenfEuro;
        private System.Windows.Forms.TextBox TxZehnEuro;
    }
}

