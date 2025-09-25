/*
 * Created by SharpDevelop.
 * User: mwa66
 * Date: 9/11/2025
 * Time: 10:51 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EngTeach
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button LearnWords;
		private System.Windows.Forms.Button CrossWords;
		private System.Windows.Forms.Button LearnVerbs;
		
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
			this.LearnWords = new System.Windows.Forms.Button();
			this.CrossWords = new System.Windows.Forms.Button();
			this.LearnVerbs = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LearnWords
			// 
			this.LearnWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LearnWords.Location = new System.Drawing.Point(12, 12);
			this.LearnWords.Name = "LearnWords";
			this.LearnWords.Size = new System.Drawing.Size(260, 87);
			this.LearnWords.TabIndex = 0;
			this.LearnWords.Text = "Учить слова";
			this.LearnWords.UseVisualStyleBackColor = true;
			this.LearnWords.Click += new System.EventHandler(this.LearnWordsClick);
			// 
			// CrossWords
			// 
			this.CrossWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CrossWords.Location = new System.Drawing.Point(12, 105);
			this.CrossWords.Name = "CrossWords";
			this.CrossWords.Size = new System.Drawing.Size(260, 87);
			this.CrossWords.TabIndex = 1;
			this.CrossWords.Text = "Печать слов";
			this.CrossWords.UseVisualStyleBackColor = true;
			this.CrossWords.Click += new System.EventHandler(this.CrossWordsClick);
			// 
			// LearnVerbs
			// 
			this.LearnVerbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LearnVerbs.Location = new System.Drawing.Point(12, 198);
			this.LearnVerbs.Name = "LearnVerbs";
			this.LearnVerbs.Size = new System.Drawing.Size(260, 87);
			this.LearnVerbs.TabIndex = 2;
			this.LearnVerbs.Text = "Учить глаголы";
			this.LearnVerbs.UseVisualStyleBackColor = true;
			this.LearnVerbs.Click += new System.EventHandler(this.LearnVerbsClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 296);
			this.Controls.Add(this.LearnVerbs);
			this.Controls.Add(this.CrossWords);
			this.Controls.Add(this.LearnWords);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "EngTeach";
			this.ResumeLayout(false);

		}
	}
}
