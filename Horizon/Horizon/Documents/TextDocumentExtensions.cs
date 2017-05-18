using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE;

namespace Horizon.Documents
{
	public static class TextDocumentExtensions
	{
		public static TextDocument AsTextDocument(this Document document)
			=> document.Object() as TextDocument;

		public static EditPoint StartOfLine(this TextDocument doc)
		{
			EditPoint editPoint = doc.Selection.ActivePoint.CreateEditPoint();
			editPoint.StartOfLine();

			return editPoint;
		}

		public static EditPoint EndOfLine(this TextDocument doc)
		{
			EditPoint editPoint = doc.Selection.ActivePoint.CreateEditPoint();
			editPoint.EndOfLine();

			return editPoint;
		}

		public static EditPointsSpan GetCurrentLineSpan(this TextDocument doc)
			=> new EditPointsSpan(doc.StartOfLine(), doc.EndOfLine());
	}
}
