using System;

namespace hello
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
            this.greetingbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clearbutton = new System.Windows.Forms.Button();
            this.morbus_check = new System.Windows.Forms.CheckBox();
            this.morbusNotifier = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // greetingbutton
            // 
            this.greetingbutton.Location = new System.Drawing.Point(12, 128);
            this.greetingbutton.Name = "greetingbutton";
            this.greetingbutton.Size = new System.Drawing.Size(259, 23);
            this.greetingbutton.TabIndex = 0;
            this.greetingbutton.Text = "Greeting";
            this.greetingbutton.UseVisualStyleBackColor = true;
            this.greetingbutton.Click += new System.EventHandler(this.Greetings_ButtonClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 1;
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(529, 128);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(259, 23);
            this.clearbutton.TabIndex = 2;
            this.clearbutton.Text = "Clear Form";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // morbus_check
            // 
            this.morbus_check.AutoSize = true;
            this.morbus_check.Location = new System.Drawing.Point(301, 133);
            this.morbus_check.Name = "morbus_check";
            this.morbus_check.Size = new System.Drawing.Size(101, 17);
            this.morbus_check.TabIndex = 3;
            this.morbus_check.Text = "Enable Borbus?";
            this.morbus_check.UseVisualStyleBackColor = true;
            this.morbus_check.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
           
            // 
            // morbusNotifier
            // 
            this.morbusNotifier.Location = new System.Drawing.Point(13, 181);
            this.morbusNotifier.Name = "morbusNotifier";
            this.morbusNotifier.Size = new System.Drawing.Size(258, 20);
            this.morbusNotifier.TabIndex = 4;
            this.morbusNotifier.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.morbusNotifier);
            this.Controls.Add(this.morbus_check);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.greetingbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            if (morbus_check.Checked is true)
            {
                morbus_check.Checked = false;
                morbusNotifier.Clear();
                textBox1.Clear();
                morbusNotifier.Text = "ATTENTION ! Morbus DISABLED and Cleared! ";
            }
            else
            {
                textBox1.Clear();
                morbusNotifier.Text = "ATTENTION ! Morbus DISABLED and Cleared! ";

            }
        }

        #endregion

        private System.Windows.Forms.Button greetingbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.CheckBox morbus_check;
        private System.Windows.Forms.TextBox morbusNotifier;
    }
}

