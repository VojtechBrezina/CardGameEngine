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

	public partial class ProjectEditForm : Form {
		public Project Project { get; }
		public ProjectEditForm(Project project) {
			InitializeComponent();
			this.Project = project;
		}
	}
}
