using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using PluginLib;
using System.Windows.Forms;
using System.Drawing;

namespace LoggingPlugin
{
    public class LoggingPlugin : BasePlugin
    {
		public LoggingPlugin()
		{
			base.Info.Name = "LoggingPlugin";
			base.Info.Author = "Max Mustermann";
			base.Info.Description = "Hanging out and do some logging sometimes.";
			base.Info.Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		}

		public override object DoWork(object parameter)
		{
			Console.WriteLine("Logging -> {0}", parameter);
			
			return null;
		}

		public override void Show(object parameter)
		{
			System.Windows.Forms.Form form = new System.Windows.Forms.Form();
			form.Text = base.Info.Name;

            Label label = new Label();

            label.Text = "Hello I am the " + base.Info.Name + "!"
                + Environment.NewLine
                + Environment.NewLine
                + "My author is:" + base.Info.Author + Environment.NewLine
                + "My task is:" + base.Info.Description + Environment.NewLine
                + "My version is:" + base.Info.Version + Environment.NewLine;

            label.Location = new Point(5, 5);
            label.Size = new Size(form.Width, form.Height);

            form.Controls.Add(label);

			form.Show();
		}
    }
}
