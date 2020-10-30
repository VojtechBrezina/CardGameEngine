using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameEngine {
	/// <summary>
	/// Obsahuje základní informace o projektu a umožňuje správu všech projektů.
	/// </summary>
	public class Project {
		#region static

		/// <summary>
		/// Cesta ke složce s projekty.
		/// </summary>
		static readonly string projectsFolderPath;

		static Project() {
			projectsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Card Game Engine\";
			Console.WriteLine($"Project folder: '{projectsFolderPath}'");
		}

		/// <summary>
		/// Vytvoří nový projekt se zadaným jménem.
		/// </summary>
		/// <param name="name">Jméno nového projektu.</param>
		/// <returns></returns>
		public static Project CreateProject(string name) {
			if(Directory.Exists(projectsFolderPath + name)) {
				throw new ArgumentException("Projekt s tímto názvem již existuje.", "name");
			}

			Directory.CreateDirectory(projectsFolderPath + name);
			return new Project(name);
		}
		#endregion

		private string name;
		/// <summary>
		/// Jméno projektu.
		/// Změnou se projekt zároveň přesune do nové složky.
		/// Projekt je pořát nutno uložit.
		/// </summary>
		public string Name {
			get {
				return name;
			}
			set {
				Directory.Move(projectsFolderPath + name, projectsFolderPath + value);
				name = value;
			}
		}

		/// <summary>
		/// Určuje, zda je aktuální podoba projektu uložena do souboru.
		/// </summary>
		public bool Saved { get; private set; }

		private Project(string name) {
			this.name = name;
			Saved = false;
		}
	}
}
