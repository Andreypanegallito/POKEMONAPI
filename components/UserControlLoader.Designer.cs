namespace _7DAYSOFCODE.components
{
    partial class UserControlLoader
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            labelTextLoader = new Label();
            panelLoader = new Panel();
            panelLoader.SuspendLayout();
            SuspendLayout();
            // 
            // labelTextLoader
            // 
            labelTextLoader.Dock = DockStyle.Fill;
            labelTextLoader.Location = new Point(0, 0);
            labelTextLoader.Name = "labelTextLoader";
            labelTextLoader.Size = new Size(416, 291);
            labelTextLoader.TabIndex = 0;
            labelTextLoader.Text = "Carregando pokemons...";
            labelTextLoader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLoader
            // 
            panelLoader.Controls.Add(labelTextLoader);
            panelLoader.Dock = DockStyle.Fill;
            panelLoader.Location = new Point(0, 0);
            panelLoader.Name = "panelLoader";
            panelLoader.Size = new Size(416, 291);
            panelLoader.TabIndex = 1;
            // 
            // UserControlLoader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(panelLoader);
            Name = "UserControlLoader";
            Size = new Size(416, 291);
            panelLoader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label labelTextLoader;
        private Panel panelLoader;
    }
}
