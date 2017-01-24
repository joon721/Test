namespace Cressem
{
    partial class FormDevice
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxModify = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(820, 409);
            this.button1.TabIndex = 0;
            this.button1.Text = "device";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBoxModify
            // 
            this.checkBoxModify.AutoSize = true;
            this.checkBoxModify.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxModify.Location = new System.Drawing.Point(12, 12);
            this.checkBoxModify.Name = "checkBoxModify";
            this.checkBoxModify.Size = new System.Drawing.Size(71, 29);
            this.checkBoxModify.TabIndex = 5;
            this.checkBoxModify.Text = "Edit";
            this.checkBoxModify.UseVisualStyleBackColor = true;
            this.checkBoxModify.CheckedChanged += new System.EventHandler(this.checkBoxModify_CheckedChanged);
            // 
            // FormDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 992);
            this.Controls.Add(this.checkBoxModify);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDevice";
            this.Text = "FormDevice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxModify;
    }
}