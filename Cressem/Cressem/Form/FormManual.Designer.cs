namespace Cressem
{
    partial class FormManual
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridManual = new System.Windows.Forms.DataGridView();
            this.No1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.No2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.checkBoxModify = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxChannel = new System.Windows.Forms.ComboBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridManual)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 992);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1710, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 992);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1700, 10);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 982);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1700, 10);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel4.Controls.Add(this.gridManual);
            this.panel4.Controls.Add(this.checkBoxModify);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.comboBoxChannel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1700, 972);
            this.panel4.TabIndex = 4;
            // 
            // gridManual
            // 
            this.gridManual.AllowUserToAddRows = false;
            this.gridManual.AllowUserToDeleteRows = false;
            this.gridManual.AllowUserToResizeColumns = false;
            this.gridManual.AllowUserToResizeRows = false;
            this.gridManual.BackgroundColor = System.Drawing.Color.White;
            this.gridManual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridManual.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridManual.ColumnHeadersHeight = 30;
            this.gridManual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridManual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No1,
            this.Description1,
            this.No2,
            this.Description2});
            this.gridManual.GridColor = System.Drawing.Color.LightGray;
            this.gridManual.Location = new System.Drawing.Point(11, 70);
            this.gridManual.Margin = new System.Windows.Forms.Padding(2);
            this.gridManual.MultiSelect = false;
            this.gridManual.Name = "gridManual";
            this.gridManual.RowHeadersVisible = false;
            this.gridManual.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gridManual.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridManual.RowTemplate.Height = 23;
            this.gridManual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridManual.Size = new System.Drawing.Size(1680, 832);
            this.gridManual.TabIndex = 4;
            this.gridManual.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridManual_CellClick);
            this.gridManual.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Descrip_CellValueChanged);
            // 
            // No1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No1.DefaultCellStyle = dataGridViewCellStyle1;
            this.No1.HeaderText = "No.";
            this.No1.Name = "No1";
            this.No1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.No1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Description1
            // 
            this.Description1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Description1.HeaderText = "Description";
            this.Description1.Name = "Description1";
            this.Description1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // No2
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No2.DefaultCellStyle = dataGridViewCellStyle3;
            this.No2.HeaderText = "No.";
            this.No2.Name = "No2";
            this.No2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.No2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Description2
            // 
            this.Description2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Description2.HeaderText = "Description";
            this.Description2.Name = "Description2";
            this.Description2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // checkBoxModify
            // 
            this.checkBoxModify.AutoSize = true;
            this.checkBoxModify.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxModify.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxModify.Location = new System.Drawing.Point(1554, 36);
            this.checkBoxModify.Name = "checkBoxModify";
            this.checkBoxModify.Size = new System.Drawing.Size(140, 29);
            this.checkBoxModify.TabIndex = 3;
            this.checkBoxModify.Text = "Edit Name";
            this.checkBoxModify.UseVisualStyleBackColor = true;
            this.checkBoxModify.CheckedChanged += new System.EventHandler(this.checkBoxModify_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "CH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxChannel
            // 
            this.comboBoxChannel.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChannel.FormattingEnabled = true;
            this.comboBoxChannel.Location = new System.Drawing.Point(80, 5);
            this.comboBoxChannel.Name = "comboBoxChannel";
            this.comboBoxChannel.Size = new System.Drawing.Size(225, 50);
            this.comboBoxChannel.TabIndex = 0;
            this.comboBoxChannel.SelectedIndexChanged += new System.EventHandler(this.comboBoxChannel_SelectedIndexChanged);
            // 
            // FormManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1720, 992);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManual";
            this.Text = "FormManual";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridManual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxChannel;
        private System.Windows.Forms.CheckBox checkBoxModify;
        private System.Windows.Forms.DataGridView gridManual;
        private System.Windows.Forms.DataGridViewTextBoxColumn No1;
        private System.Windows.Forms.DataGridViewButtonColumn Description1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No2;
        private System.Windows.Forms.DataGridViewButtonColumn Description2;
    }
}