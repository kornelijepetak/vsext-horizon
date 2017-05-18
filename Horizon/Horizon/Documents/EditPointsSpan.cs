using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE;

namespace Horizon.Documents
{
	public struct EditPointsSpan
	{
		public EditPointsSpan(EditPoint start, EditPoint end)
		{
			this.start = start;
			this.end = end;
			text = null;
		}

		private EditPoint start;
		private EditPoint end;

		private string text;

		public string Text
		{
			get => text ?? (text = start.GetText(end));
			set => start.ReplaceText(end, value, replaceSettings);
		}

		private const int replaceSettings =
			(int)(vsEPReplaceTextOptions.vsEPReplaceTextAutoformat | vsEPReplaceTextOptions.vsEPReplaceTextNormalizeNewlines);
	}
}
