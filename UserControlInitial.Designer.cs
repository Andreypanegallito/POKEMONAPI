namespace POKEMONAPI
{
    partial class UserControlInitial
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
            panel1 = new Panel();
            btnAllPokemon = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAllPokemon);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 609);
            panel1.TabIndex = 0;
            // 
            // btnAllPokemon
            // 
            btnAllPokemon.Location = new Point(50, 50);
            btnAllPokemon.Name = "btnAllPokemon";
            btnAllPokemon.Size = new Size(100, 100);
            btnAllPokemon.TabIndex = 2;
            btnAllPokemon.Text = "Todos os Pokemons";
            btnAllPokemon.UseVisualStyleBackColor = true;
            // 
            // UserControlInitial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserControlInitial";
            Size = new Size(970, 609);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAllPokemon;
    }
}
