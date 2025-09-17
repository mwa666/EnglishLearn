/*
 * Created by SharpDevelop.
 * User: mwa66
 * Date: 9/11/2025
 * Time: 10:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EngTeach
{
	partial class LearnWords
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button var1;
		private System.Windows.Forms.Button var2;
		private System.Windows.Forms.Button var3;
		private System.Windows.Forms.Button var4;
		private System.Windows.Forms.Button var5;
		private System.Windows.Forms.TextBox textBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.var1 = new System.Windows.Forms.Button();
			this.var2 = new System.Windows.Forms.Button();
			this.var3 = new System.Windows.Forms.Button();
			this.var4 = new System.Windows.Forms.Button();
			this.var5 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// var1
			// 
			this.var1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.var1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.var1.Location = new System.Drawing.Point(12, 47);
			this.var1.Name = "var1";
			this.var1.Size = new System.Drawing.Size(623, 85);
			this.var1.TabIndex = 0;
			this.var1.Text = "button1";
			this.var1.UseVisualStyleBackColor = true;
			this.var1.Click += new System.EventHandler(this.CheckWord);
			// 
			// var2
			// 
			this.var2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.var2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
			this.var2.Location = new System.Drawing.Point(12, 138);
			this.var2.Name = "var2";
			this.var2.Size = new System.Drawing.Size(623, 85);
			this.var2.TabIndex = 1;
			this.var2.Text = "button2";
			this.var2.UseVisualStyleBackColor = true;
			this.var2.Click += new System.EventHandler(this.CheckWord);
			// 
			// var3
			// 
			this.var3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.var3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
			this.var3.Location = new System.Drawing.Point(12, 229);
			this.var3.Name = "var3";
			this.var3.Size = new System.Drawing.Size(623, 85);
			this.var3.TabIndex = 2;
			this.var3.Text = "button3";
			this.var3.UseVisualStyleBackColor = true;
			this.var3.Click += new System.EventHandler(this.CheckWord);
			// 
			// var4
			// 
			this.var4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.var4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
			this.var4.Location = new System.Drawing.Point(12, 320);
			this.var4.Name = "var4";
			this.var4.Size = new System.Drawing.Size(623, 85);
			this.var4.TabIndex = 3;
			this.var4.Text = "button4";
			this.var4.UseVisualStyleBackColor = true;
			this.var4.Click += new System.EventHandler(this.CheckWord);
			// 
			// var5
			// 
			this.var5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.var5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
			this.var5.Location = new System.Drawing.Point(12, 411);
			this.var5.Name = "var5";
			this.var5.Size = new System.Drawing.Size(623, 85);
			this.var5.TabIndex = 4;
			this.var5.Text = "button5";
			this.var5.UseVisualStyleBackColor = true;
			this.var5.Click += new System.EventHandler(this.CheckWord);
			// 
			// textBox1
			// 
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(647, 40);
			this.textBox1.TabIndex = 5;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// LearnWords
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 508);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.var5);
			this.Controls.Add(this.var4);
			this.Controls.Add(this.var3);
			this.Controls.Add(this.var2);
			this.Controls.Add(this.var1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(315, 228);
			this.Name = "LearnWords";
			this.Text = "LearnWords";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
