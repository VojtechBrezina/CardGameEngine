using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameEngine {
	/// <summary>
	/// Obsahuje základní informace o projektu a umožňuje správu všech projektů.
	/// </summary>
	class Project {
		private string name;
		/// <summary>
		/// Jméno projektu.
		/// _Změnou se projekt zároveň přesune do nové složky.
		/// </summary>
		public string Name {
			get {
				return name;
			}
			set {
				MoveProject(value);
				name = value;
			}
		}

		/// <summary>
		/// Cesta ke složce s projekty.
		/// </summary>
		static readonly string projectsFolderPath;

		static Project() {
			projectsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Card Game Engine";
			Console.WriteLine("Project folder: \"" + projectsFolderPath + "\"");
		}

		/// <summary>
		/// Změní jméno složky projektu, nic jiného.
		/// </summary>
		/// <param name="name">Nové jméno.</param>
		private void MoveProject(string name) {
		}
	}
}
