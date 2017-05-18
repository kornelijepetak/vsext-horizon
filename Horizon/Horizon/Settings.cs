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

	public static class Settings
	{
		public static T GetValue<T>(string path, T defaultValue = default(T))
		{
			try
			{
				dynamic val = getProperty(path).Value;
				return (T)val;
			}
			catch
			{
				return defaultValue;
			}
		}

		public static bool SetValue<T>(string path, T value)
		{
			try
			{
				getProperty(path).Value = value;
				return true;
			}
			catch
			{
				return false;
			}
		}


		private static Property getProperty(string path)
		{
			string[] parts = path.Split('.');
			string category = parts[0];
			string page = parts[1];
			string property = parts[2];

			Properties props = VS.Instance.get_Properties(category, page);
			return props.Item(property);
		}

	}
}
