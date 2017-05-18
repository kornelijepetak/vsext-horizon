using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;

namespace Horizon.Settings
{
	public class Setting<T>
	{
		private string path;

		public Setting(string path)
		{
			this.path = path;
		}

		public T Value
		{
			get
			{
				return Settings.GetValue<T>(path);
			}
			set
			{
				Settings.SetValue(path, value);
			}
		}

	}
}
