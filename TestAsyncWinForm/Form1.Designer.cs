namespace TestAsyncWinForm
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
            this.btGetData = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btGetHttpDataAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGetData
            // 
            this.btGetData.Location = new System.Drawing.Point(12, 599);
            this.btGetData.Name = "btGetData";
            this.btGetData.Size = new System.Drawing.Size(181, 23);
            this.btGetData.TabIndex = 0;
            this.btGetData.Text = "GetHttpDataSync";
            this.btGetData.UseVisualStyleBackColor = true;
            this.btGetData.Click += new System.EventHandler(this.btGetData_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1018, 581);
            this.webBrowser1.TabIndex = 1;
            // 
            // btGetHttpDataAsync
            // 
            this.btGetHttpDataAsync.Location = new System.Drawing.Point(232, 599);
            this.btGetHttpDataAsync.Name = "btGetHttpDataAsync";
            this.btGetHttpDataAsync.Size = new System.Drawing.Size(167, 23);
            this.btGetHttpDataAsync.TabIndex = 2;
            this.btGetHttpDataAsync.Text = "GetHttpDataAsync";
            this.btGetHttpDataAsync.UseVisualStyleBackColor = true;
            this.btGetHttpDataAsync.Click += new System.EventHandler(this.btGetHttpDataAsync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 634);
            this.Controls.Add(this.btGetHttpDataAsync);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btGetData);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Демонстрация асинхронности";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGetData;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btGetHttpDataAsync;
    }
}

