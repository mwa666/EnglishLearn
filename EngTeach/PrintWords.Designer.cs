/*
 * Created by SharpDevelop.
 * User: mwa66
 * Date: 9/11/2025
 * Time: 11:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EngTeach
{
	partial class PrintWords
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button checkWord;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button answer;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkWord = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.answer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(557, 40);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// checkWord
			// 
			this.checkWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
			this.checkWord.Location = new System.Drawing.Point(4, 84);
			this.checkWord.Name = "checkWord";
			this.checkWord.Size = new System.Drawing.Size(549, 44);
			this.checkWord.TabIndex = 1;
			this.checkWord.Text = "Проверить";
			this.checkWord.UseVisualStyleBackColor = true;
			this.checkWord.Click += new System.EventHandler(this.CheckWord);
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
			this.textBox2.Location = new System.Drawing.Point(0, 40);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(557, 40);
			this.textBox2.TabIndex = 2;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// answer
			// 
			this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
			this.answer.Location = new System.Drawing.Point(4, 134);
			this.answer.Name = "answer";
			this.answer.Size = new System.Drawing.Size(549, 44);
			this.answer.TabIndex = 3;
			this.answer.Text = "Ответ";
			this.answer.UseVisualStyleBackColor = true;
			this.answer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnswerMouseDown);
			this.answer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AnswerMouseUp);
			// 
			// PrintWords
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 183);
			this.Controls.Add(this.answer);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.checkWord);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "PrintWords";
			this.Text = "PrintWords";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
