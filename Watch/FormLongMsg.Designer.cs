namespace Watch
{
    partial class FormLongMsg
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
            this.txtTimeTable = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTimeParagraph = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimeTable
            // 
            this.txtTimeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeTable.Location = new System.Drawing.Point(3, 3);
            this.txtTimeTable.Multiline = true;
            this.txtTimeTable.Name = "txtTimeTable";
            this.txtTimeTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTimeTable.Size = new System.Drawing.Size(301, 326);
            this.txtTimeTable.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(315, 358);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtTimeTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(307, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "时刻表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTimeParagraph);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(307, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "时间片";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTimeParagraph
            // 
            this.txtTimeParagraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeParagraph.Location = new System.Drawing.Point(3, 3);
            this.txtTimeParagraph.Multiline = true;
            this.txtTimeParagraph.Name = "txtTimeParagraph";
            this.txtTimeParagraph.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTimeParagraph.Size = new System.Drawing.Size(301, 326);
            this.txtTimeParagraph.TabIndex = 1;
            // 
            // FormLongMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 358);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormLongMsg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "显示报告";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLongMsg_FormClosed);
            this.Load += new System.EventHandler(this.FormLongMsg_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txtTimeTable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TextBox txtTimeParagraph;
    }
}