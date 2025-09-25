using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace EngTeach
{
	/// <summary>
	/// Description of LearnVerbs.
	/// </summary>
	public partial class LearnVerbs : Form
	{
		public int[] numbers1;
		
		public LearnVerbs(Dictionary<int, string> words, int[] numbers)
		{
			InitializeComponent();

		}
	}
}
