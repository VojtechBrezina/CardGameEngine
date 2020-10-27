using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGameEngine {
	/// <summary>
	/// Okno pro vběr projektu.
	/// </summary>
	public partial class StartForm : Form, INotifyPropertyChanged {
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Zjišťuje, jesti je ze seznamu vybrán nějaký projekt.
		/// </summary>
		public bool ProjectSelected {
			get {
				return projectsListBox.SelectedIndex != -1;
			}
		}
		
		public StartForm() {
			InitializeComponent();
			playButton.DataBindings.Add("Enabled", this, "ProjectSelected");
			editButton.DataBindings.Add("Enabled", this, "ProjectSelected");
		}

		private void projectsListBox_SelectedIndexChanged(object sender, EventArgs e) {
			PropertyChanged(this, new PropertyChangedEventArgs("ProjectSelected"));
		}
	}
}
