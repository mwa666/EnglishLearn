﻿/*
 * Created by SharpDevelop.
 * User: SlavaTLT
 * Date: 9/25/2025
 * Time: 10:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EngTeach
{
	partial class LearnVerbs
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			// 
			// LearnVerbs
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "LearnVerbs";
			this.Name = "LearnVerbs";
		}
	}
}
