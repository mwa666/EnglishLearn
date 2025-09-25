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
		public Dictionary<int, string> verbs = new Dictionary<int, string>();
		
		public int[] numbersWords;
		public int[] numbersVerbs;
		
		public MainForm()
		{

			InitializeComponent();

			words = ReadMultipleLines("dictionary.csv");
			verbs = ReadMultipleLines("dictionary.csv");
			
			numbersWords = GenerateUniqueRandomNumbers(0, (words.Count - 1), 10);
			numbersVerbs = GenerateUniqueRandomNumbers(0, (verbs.Count - 1), 10);

			
		}
		
		void LearnWordsClick(object sender, EventArgs e)
		{
			OpenFormLW(new LearnWords(words, numbersWords));
		}
		
		void CrossWordsClick(object sender, EventArgs e)
		{
			OpenFormPW(new PrintWords(words, numbersWords));
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
		
		private void OpenFormLV(Form form)
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
		
		public int[] GenerateUniqueRandomNumbers(int min, int max, int count = 10)
		{
			if (max - min + 1 < count)
				throw new ArgumentException("Диапазон слишком мал для генерации уникальных чисел");
    
			Random random = new Random();
			HashSet<int> numbers = new HashSet<int>();
    
			while (numbers.Count < count) {
				numbers.Add(random.Next(min, max + 1));
			}
    
			return numbers.ToArray();
		}
		
		void LearnVerbsClick(object sender, EventArgs e)
		{
			OpenFormLV(new LearnVerbs(verbs, numbersVerbs));
		}
		
		
		
	}
}
