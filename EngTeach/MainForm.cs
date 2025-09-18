using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace EngTeach
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public Dictionary<int, string> words = new Dictionary<int, string>();
		
		public MainForm()
		{

			InitializeComponent();
			// Dictionary<int, string>
//			var lines = ReadMultipleLines("test.txt", 1, 3, 5, 10);
			words = ReadMultipleLines("Coraline(1).csv");
			
		}
		
		void LearnWordsClick(object sender, EventArgs e)
		{
			OpenFormLW(new LearnWords(words));
		}
		
		void CrossWordsClick(object sender, EventArgs e)
		{
			OpenFormPW(new PrintWords(words));
		}
		
		private void OpenFormLW(Form form)
		{
			// Подписываемся на событие закрытия формы
			form.FormClosed += (s, args) => this.Show();
            
			this.Hide(); // Скрываем главное окно
			form.Show(); // Показываем новое окно
		}
		
		private void OpenFormPW(Form form)
		{
			// Подписываемся на событие закрытия формы
			form.FormClosed += (s, args) => this.Show();
            
			this.Hide(); // Скрываем главное окно
			form.Show(); // Показываем новое окно
		}
		
		public Dictionary<int, string> ReadMultipleLines(string filePath)
		{
			Dictionary<int, string> result = new Dictionary<int, string>();
			int i = 0;
    
			try {
				string[] lines = File.ReadAllLines(filePath);
				int totalLines = lines.Length;
				
				foreach (string line in lines) {
					
					result[i] = line;
					i++;
				}
				
			} catch (Exception ex) {
				result[-1] = "Error: " + ex.Message.ToString();
			}
    
			return result;
		}
		
	}
}
