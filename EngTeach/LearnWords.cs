using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace EngTeach
{
	/// <summary>
	/// Description of LearnWords.
	/// </summary>
	public partial class LearnWords : Form
	{
		public int[] numbers;
		public Dictionary<int, string> words1;
		public int indexWord = 0;
		
		public LearnWords(Dictionary<int, string> words)
		{
			int i = 0;
			words1 = words;
			
			
			Random random = new Random();
			
			indexWord = random.Next(0, 4);
			
			numbers = GenerateUniqueRandomNumbers(0, (words1.Count - 1), 10);
			
			InitializeComponent();
			
			string[] needword = words1.ElementAt(numbers[indexWord]).Value.Split(';');
			textBox1.Text = needword[1].ToUpper();
			
			foreach (Control control in this.Controls) {
				Button button = control as Button;
				if ((button != null) & (i < 5)) {
					
					string[] temp = words1.ElementAt(numbers[button.TabIndex]).Value.Split(';');
					
					button.Text = temp[0].ToUpper();
					i++;
				}
			}			
			
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
		
		
		public void CheckWord(object sender, EventArgs e)
		{
			int a = 0;
			
			Button clickedButton = (Button)sender;
			
			if (clickedButton.TabIndex == indexWord) {
			
				Random random = new Random();
			
				for (int i = numbers.Length - 1; i > 0; i--) {
					int j = random.Next(0, i + 1);
					int temp = numbers[i];
					numbers[i] = numbers[j];
					numbers[j] = temp;
				}

				foreach (Control control in this.Controls) {
					Button button = control as Button;
					if ((button != null) & (a < 5)) {
					
						string[] temp = words1.ElementAt(numbers[button.TabIndex]).Value.Split(';');
					
						button.Text = temp[0].ToUpper();
						a++;
					}
				}			

				indexWord = random.Next(0, 4);
				string[] needword = words1.ElementAt(numbers[indexWord]).Value.Split(';');
				textBox1.Text = needword[1].ToUpper();
				
			}
	
		}
		
	}
}
