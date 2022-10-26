namespace Exec2_Star
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.ButtonMiddle = new System.Windows.Forms.Button();
			this.ButtonRight = new System.Windows.Forms.Button();
			this.ButtonLeft = new System.Windows.Forms.Button();
			this.TextBoxInput = new System.Windows.Forms.TextBox();
			this.TextBoxOutput = new System.Windows.Forms.TextBox();
			this.LabelGuide = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ButtonMiddle
			// 
			this.ButtonMiddle.Location = new System.Drawing.Point(152, 23);
			this.ButtonMiddle.Name = "ButtonMiddle";
			this.ButtonMiddle.Size = new System.Drawing.Size(75, 23);
			this.ButtonMiddle.TabIndex = 0;
			this.ButtonMiddle.Text = "等腰三角形";
			this.ButtonMiddle.UseVisualStyleBackColor = true;
			this.ButtonMiddle.Click += new System.EventHandler(this.ButtonMiddle_Click);
			// 
			// ButtonRight
			// 
			this.ButtonRight.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ButtonRight.Location = new System.Drawing.Point(287, 23);
			this.ButtonRight.Name = "ButtonRight";
			this.ButtonRight.Size = new System.Drawing.Size(75, 23);
			this.ButtonRight.TabIndex = 1;
			this.ButtonRight.Text = "右邊三角形";
			this.ButtonRight.UseVisualStyleBackColor = true;
			this.ButtonRight.Click += new System.EventHandler(this.ButtonRight_Click);
			// 
			// ButtonLeft
			// 
			this.ButtonLeft.Location = new System.Drawing.Point(12, 23);
			this.ButtonLeft.Name = "ButtonLeft";
			this.ButtonLeft.Size = new System.Drawing.Size(75, 23);
			this.ButtonLeft.TabIndex = 2;
			this.ButtonLeft.Text = "左邊三角形";
			this.ButtonLeft.UseVisualStyleBackColor = true;
			this.ButtonLeft.Click += new System.EventHandler(this.ButtonLeft_Click);
			// 
			// TextBoxInput
			// 
			this.TextBoxInput.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.TextBoxInput.Location = new System.Drawing.Point(188, 56);
			this.TextBoxInput.MaxLength = 3;
			this.TextBoxInput.Name = "TextBoxInput";
			this.TextBoxInput.Size = new System.Drawing.Size(160, 43);
			this.TextBoxInput.TabIndex = 3;
			// 
			// TextBoxOutput
			// 
			this.TextBoxOutput.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxOutput.Location = new System.Drawing.Point(12, 105);
			this.TextBoxOutput.Multiline = true;
			this.TextBoxOutput.Name = "TextBoxOutput";
			this.TextBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextBoxOutput.Size = new System.Drawing.Size(350, 236);
			this.TextBoxOutput.TabIndex = 4;
			// 
			// LabelGuide
			// 
			this.LabelGuide.AutoSize = true;
			this.LabelGuide.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.LabelGuide.Location = new System.Drawing.Point(22, 63);
			this.LabelGuide.Name = "LabelGuide";
			this.LabelGuide.Size = new System.Drawing.Size(150, 35);
			this.LabelGuide.TabIndex = 5;
			this.LabelGuide.Text = "請輸入行數";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 353);
			this.Controls.Add(this.LabelGuide);
			this.Controls.Add(this.TextBoxOutput);
			this.Controls.Add(this.TextBoxInput);
			this.Controls.Add(this.ButtonLeft);
			this.Controls.Add(this.ButtonRight);
			this.Controls.Add(this.ButtonMiddle);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonMiddle;
		private System.Windows.Forms.Button ButtonRight;
		private System.Windows.Forms.Button ButtonLeft;
		private System.Windows.Forms.TextBox TextBoxInput;
		private System.Windows.Forms.TextBox TextBoxOutput;
		private System.Windows.Forms.Label LabelGuide;
	}
}

