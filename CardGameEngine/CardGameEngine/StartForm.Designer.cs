namespace CardGameEngine {
	partial class StartForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.projectsListBox = new System.Windows.Forms.ListBox();
			this.playButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// projectsListBox
			// 
			this.projectsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.projectsListBox.FormattingEnabled = true;
			this.projectsListBox.IntegralHeight = false;
			this.projectsListBox.ItemHeight = 16;
			this.projectsListBox.Location = new System.Drawing.Point(12, 111);
			this.projectsListBox.Name = "projectsListBox";
			this.projectsListBox.Size = new System.Drawing.Size(378, 330);
			this.projectsListBox.Sorted = true;
			this.projectsListBox.TabIndex = 0;
			this.projectsListBox.SelectedIndexChanged += new System.EventHandler(this.projectsListBox_SelectedIndexChanged);
			// 
			// playButton
			// 
			this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.playButton.Location = new System.Drawing.Point(12, 82);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(378, 23);
			this.playButton.TabIndex = 1;
			this.playButton.Text = "Hrát";
			this.playButton.UseVisualStyleBackColor = true;
			// 
			// editButton
			// 
			this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.editButton.Location = new System.Drawing.Point(12, 53);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(378, 23);
			this.editButton.TabIndex = 2;
			this.editButton.Text = "Upravit";
			this.editButton.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Location = new System.Drawing.Point(12, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(378, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Nový projekt";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 453);
			this.Controls.Add(this.playButton);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.projectsListBox);
			this.Controls.Add(this.button3);
			this.MinimumSize = new System.Drawing.Size(420, 500);
			this.Name = "StartForm";
			this.Text = "Card game engine";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox projectsListBox;
		private System.Windows.Forms.Button playButton;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button button3;
	}
}

