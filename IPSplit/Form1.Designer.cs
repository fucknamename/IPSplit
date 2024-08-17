
namespace IPSplit
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtsource = new System.Windows.Forms.TextBox();
            this.btnsplit = new System.Windows.Forms.Button();
            this.txtiplist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtsource
            // 
            this.txtsource.Location = new System.Drawing.Point(12, 12);
            this.txtsource.MaxLength = 0;
            this.txtsource.Multiline = true;
            this.txtsource.Name = "txtsource";
            this.txtsource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtsource.Size = new System.Drawing.Size(327, 218);
            this.txtsource.TabIndex = 0;
            // 
            // btnsplit
            // 
            this.btnsplit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsplit.ForeColor = System.Drawing.Color.Teal;
            this.btnsplit.Location = new System.Drawing.Point(355, 102);
            this.btnsplit.Name = "btnsplit";
            this.btnsplit.Size = new System.Drawing.Size(108, 38);
            this.btnsplit.TabIndex = 1;
            this.btnsplit.Text = "分割 =>";
            this.btnsplit.UseVisualStyleBackColor = true;
            this.btnsplit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtiplist
            // 
            this.txtiplist.Location = new System.Drawing.Point(481, 12);
            this.txtiplist.MaxLength = 0;
            this.txtiplist.Multiline = true;
            this.txtiplist.Name = "txtiplist";
            this.txtiplist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtiplist.Size = new System.Drawing.Size(327, 218);
            this.txtiplist.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 242);
            this.Controls.Add(this.btnsplit);
            this.Controls.Add(this.txtiplist);
            this.Controls.Add(this.txtsource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP分割器 - V1.1 - tony";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsource;
        private System.Windows.Forms.Button btnsplit;
        private System.Windows.Forms.TextBox txtiplist;
    }
}

