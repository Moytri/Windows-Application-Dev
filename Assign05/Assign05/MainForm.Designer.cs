namespace Assign05
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelMonth = new System.Windows.Forms.Label();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCheckDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(35, 27);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 13);
            this.labelYear.TabIndex = 0;
            this.labelYear.Text = "&Year:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(38, 43);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(95, 20);
            this.textBoxYear.TabIndex = 1;
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(140, 27);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(40, 13);
            this.labelMonth.TabIndex = 2;
            this.labelMonth.Text = "&Month:";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(143, 43);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(95, 20);
            this.textBoxMonth.TabIndex = 3;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(245, 27);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(29, 13);
            this.labelDay.TabIndex = 4;
            this.labelDay.Text = "&Day:";
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(248, 43);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(95, 20);
            this.textBoxDay.TabIndex = 5;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(34, 110);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(66, 24);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "label1";
            // 
            // buttonCheckDate
            // 
            this.buttonCheckDate.Location = new System.Drawing.Point(232, 111);
            this.buttonCheckDate.Name = "buttonCheckDate";
            this.buttonCheckDate.Size = new System.Drawing.Size(111, 23);
            this.buttonCheckDate.TabIndex = 7;
            this.buttonCheckDate.Text = "Check Date";
            this.buttonCheckDate.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonCheckDate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 192);
            this.Controls.Add(this.buttonCheckDate);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCheckDate;
    }
}

