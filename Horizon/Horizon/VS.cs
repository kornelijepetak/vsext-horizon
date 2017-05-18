using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;

namespace Horizon
{
	public static class VS
	{
		public static DTE2 Instance
			=> ServiceProvider.GlobalProvider.GetService(typeof(DTE)) as DTE2;
	}
}
