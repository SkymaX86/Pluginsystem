using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using PluginLib;
using System.Windows.Forms;
using System.Drawing;

namespace CalculationPlugin
{
    public class CalculationPlugin : BasePlugin
    {
		public CalculationPlugin()
		{
			base.Info.Name = "CalculationPlugin";
			base.Info.Author = "Max Mustermann";
			base.Info.Description = "Im dr. math and calculate all day long";
			base.Info.Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		}

		public override object DoWork(object parameter)
		{
			Console.WriteLine("Calculation -> {0}", parameter);

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
