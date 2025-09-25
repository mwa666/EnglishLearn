using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace EngTeach
{
	/// <summary>
	/// Description of CrossWords.
	/// </summary>
	public partial class PrintWords : Form
	{
		
		public int[] numbers1;
		public Dictionary<int, string> words1;
		public int indexWord = 0;
		string[] needword;
		
		public PrintWords(Dictionary<int, string> words, int[] numbers)
		{
			words1 = words;
			numbers1 = numbers;
				
			Random random = new Random();
			
			indexWord = random.Next(0, 4);
			
//			numbers = GenerateUniqueRandomNumbers(0, (words1.Count - 1), 10);
			
			InitializeComponent();
			
			needword = words1.ElementAt(numbers[indexWord]).Value.Split(';');
			textBox1.Text = needword[1].ToUpper();
			
		}
		
		public void CheckWord(object sender, EventArgs e)
		{
			
			if (textBox2.Text.ToUpper() == needword[0].ToUpper()) {
			
				Random random = new Random();
			
				for (int i = numbers1.Length - 1; i > 0; i--) {
					int j = random.Next(0, i + 1);
					int temp = numbers1[i];
					numbers1[i] = numbers1[j];
					numbers1[j] = temp;
				}

				indexWord = random.Next(0, 4);
				needword = words1.ElementAt(numbers1[indexWord]).Value.Split(';');
				textBox1.Text = needword[1].ToUpper();
				textBox2.Text = "";
	
			}
			
		}
		
		void AnswerMouseDown(object sender, MouseEventArgs e)
		{
			textBox2.Text = needword[0].ToUpper();
		}
		
		void AnswerMouseUp(object sender, MouseEventArgs e)
		{
			textBox2.Text = "";
		}
		
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			
			if (e.KeyChar == (char)Keys.Enter) {
			
				if (textBox2.Text.ToUpper() == needword[0].ToUpper()) {
			
					Random random = new Random();
			
					for (int i = numbers1.Length - 1; i > 0; i--) {
						int j = random.Next(0, i + 1);
						int temp = numbers1[i];
						numbers1[i] = numbers1[j];
						numbers1[j] = temp;
					}

					indexWord = random.Next(0, 4);
					needword = words1.ElementAt(numbers1[indexWord]).Value.Split(';');
					textBox1.Text = needword[1].ToUpper();
					textBox2.Text = "";
	
				}
				
			}
			
		}
		
	}
}
