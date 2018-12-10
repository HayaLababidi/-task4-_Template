namespace InventorySimulation
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GrdView_LeadTime = new System.Windows.Forms.DataGridView();
            this.GrdView_Demand = new System.Windows.Forms.DataGridView();
            this.btn_start = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grad_output = new System.Windows.Forms.DataGridView();
            this.lbl_shortageQuantityAvg = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_endingInventoryavg = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_OrderUpTo = new System.Windows.Forms.Label();
            this.lbl_NumberOfDays = new System.Windows.Forms.Label();
            this.lbl_StartOrderQuantity = new System.Windows.Forms.Label();
            this.lbl_StartLeadDays = new System.Windows.Forms.Label();
            this.lbl_StartInventoryQuantity = new System.Windows.Forms.Label();
            this.lbl_ReviewPeriod = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_LeadTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_Demand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grad_output)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1013, 563);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_ReviewPeriod);
            this.tabPage1.Controls.Add(this.lbl_StartInventoryQuantity);
            this.tabPage1.Controls.Add(this.lbl_StartLeadDays);
            this.tabPage1.Controls.Add(this.lbl_StartOrderQuantity);
            this.tabPage1.Controls.Add(this.lbl_NumberOfDays);
            this.tabPage1.Controls.Add(this.lbl_OrderUpTo);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.GrdView_LeadTime);
            this.tabPage1.Controls.Add(this.GrdView_Demand);
            this.tabPage1.Controls.Add(this.btn_start);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1005, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input Tab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.lbl_endingInventoryavg);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lbl_shortageQuantityAvg);
            this.tabPage2.Controls.Add(this.grad_output);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(948, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output Tab";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // GrdView_LeadTime
            // 
            this.GrdView_LeadTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdView_LeadTime.Location = new System.Drawing.Point(377, 312);
            this.GrdView_LeadTime.Name = "GrdView_LeadTime";
            this.GrdView_LeadTime.RowTemplate.Height = 26;
            this.GrdView_LeadTime.Size = new System.Drawing.Size(622, 216);
            this.GrdView_LeadTime.TabIndex = 19;
            // 
            // GrdView_Demand
            // 
            this.GrdView_Demand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdView_Demand.Location = new System.Drawing.Point(377, 41);
            this.GrdView_Demand.Name = "GrdView_Demand";
            this.GrdView_Demand.RowTemplate.Height = 26;
            this.GrdView_Demand.Size = new System.Drawing.Size(622, 232);
            this.GrdView_Demand.TabIndex = 18;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_start.Location = new System.Drawing.Point(156, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(106, 53);
            this.btn_start.TabIndex = 17;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Test case 1 ",
            "Test case 2 ",
            "Test case 3 ",
            "Test case 4"});
            this.comboBox1.Location = new System.Drawing.Point(11, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(11, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "NumberOfDays";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(11, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "StartOrderQuantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(11, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "StartLeadDays";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(11, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "StartInventoryQuantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(11, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "ReviewPeriod";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(11, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "OrderUpTo";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(373, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Lead Days Distribution";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(373, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Demand Distribution";
            // 
            // grad_output
            // 
            this.grad_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grad_output.Location = new System.Drawing.Point(7, 56);
            this.grad_output.Name = "grad_output";
            this.grad_output.RowTemplate.Height = 26;
            this.grad_output.Size = new System.Drawing.Size(935, 472);
            this.grad_output.TabIndex = 0;
            // 
            // lbl_shortageQuantityAvg
            // 
            this.lbl_shortageQuantityAvg.AutoSize = true;
            this.lbl_shortageQuantityAvg.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_shortageQuantityAvg.Location = new System.Drawing.Point(745, 17);
            this.lbl_shortageQuantityAvg.Name = "lbl_shortageQuantityAvg";
            this.lbl_shortageQuantityAvg.Size = new System.Drawing.Size(0, 24);
            this.lbl_shortageQuantityAvg.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(481, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(264, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Shortage Quantity Average: ";
            // 
            // lbl_endingInventoryavg
            // 
            this.lbl_endingInventoryavg.AutoSize = true;
            this.lbl_endingInventoryavg.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_endingInventoryavg.Location = new System.Drawing.Point(262, 17);
            this.lbl_endingInventoryavg.Name = "lbl_endingInventoryavg";
            this.lbl_endingInventoryavg.Size = new System.Drawing.Size(0, 24);
            this.lbl_endingInventoryavg.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(6, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(259, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "Ending Inventory Average:  ";
            // 
            // lbl_OrderUpTo
            // 
            this.lbl_OrderUpTo.AutoSize = true;
            this.lbl_OrderUpTo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_OrderUpTo.Location = new System.Drawing.Point(275, 107);
            this.lbl_OrderUpTo.Name = "lbl_OrderUpTo";
            this.lbl_OrderUpTo.Size = new System.Drawing.Size(0, 21);
            this.lbl_OrderUpTo.TabIndex = 22;
            // 
            // lbl_NumberOfDays
            // 
            this.lbl_NumberOfDays.AutoSize = true;
            this.lbl_NumberOfDays.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_NumberOfDays.Location = new System.Drawing.Point(275, 312);
            this.lbl_NumberOfDays.Name = "lbl_NumberOfDays";
            this.lbl_NumberOfDays.Size = new System.Drawing.Size(0, 21);
            this.lbl_NumberOfDays.TabIndex = 23;
            // 
            // lbl_StartOrderQuantity
            // 
            this.lbl_StartOrderQuantity.AutoSize = true;
            this.lbl_StartOrderQuantity.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_StartOrderQuantity.Location = new System.Drawing.Point(275, 273);
            this.lbl_StartOrderQuantity.Name = "lbl_StartOrderQuantity";
            this.lbl_StartOrderQuantity.Size = new System.Drawing.Size(0, 21);
            this.lbl_StartOrderQuantity.TabIndex = 24;
            // 
            // lbl_StartLeadDays
            // 
            this.lbl_StartLeadDays.AutoSize = true;
            this.lbl_StartLeadDays.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_StartLeadDays.Location = new System.Drawing.Point(275, 231);
            this.lbl_StartLeadDays.Name = "lbl_StartLeadDays";
            this.lbl_StartLeadDays.Size = new System.Drawing.Size(0, 21);
            this.lbl_StartLeadDays.TabIndex = 25;
            // 
            // lbl_StartInventoryQuantity
            // 
            this.lbl_StartInventoryQuantity.AutoSize = true;
            this.lbl_StartInventoryQuantity.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_StartInventoryQuantity.Location = new System.Drawing.Point(275, 191);
            this.lbl_StartInventoryQuantity.Name = "lbl_StartInventoryQuantity";
            this.lbl_StartInventoryQuantity.Size = new System.Drawing.Size(0, 21);
            this.lbl_StartInventoryQuantity.TabIndex = 26;
            // 
            // lbl_ReviewPeriod
            // 
            this.lbl_ReviewPeriod.AutoSize = true;
            this.lbl_ReviewPeriod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_ReviewPeriod.Location = new System.Drawing.Point(275, 149);
            this.lbl_ReviewPeriod.Name = "lbl_ReviewPeriod";
            this.lbl_ReviewPeriod.Size = new System.Drawing.Size(15, 21);
            this.lbl_ReviewPeriod.TabIndex = 27;
            this.lbl_ReviewPeriod.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 567);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Inventory System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_LeadTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_Demand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grad_output)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView GrdView_LeadTime;
        private System.Windows.Forms.DataGridView GrdView_Demand;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView grad_output;
        private System.Windows.Forms.Label lbl_ReviewPeriod;
        private System.Windows.Forms.Label lbl_StartInventoryQuantity;
        private System.Windows.Forms.Label lbl_StartLeadDays;
        private System.Windows.Forms.Label lbl_StartOrderQuantity;
        private System.Windows.Forms.Label lbl_NumberOfDays;
        private System.Windows.Forms.Label lbl_OrderUpTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_endingInventoryavg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_shortageQuantityAvg;

    }
}