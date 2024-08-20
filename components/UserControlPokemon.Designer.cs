namespace POKEMONAPI.components
{
    partial class UserControlPokemon
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
            lblBase = new Label();
            txtBase = new Label();
            lblWeight = new Label();
            txtWeight = new Label();
            lblHeight = new Label();
            txtHeight = new Label();
            btnToAllPokemon = new Button();
            btnToHome = new Button();
            imgPokemon = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPokemon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblBase);
            panel1.Controls.Add(txtBase);
            panel1.Controls.Add(lblWeight);
            panel1.Controls.Add(txtWeight);
            panel1.Controls.Add(lblHeight);
            panel1.Controls.Add(txtHeight);
            panel1.Controls.Add(btnToAllPokemon);
            panel1.Controls.Add(btnToHome);
            panel1.Controls.Add(imgPokemon);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1131, 567);
            panel1.TabIndex = 0;
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Location = new Point(148, 265);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(0, 15);
            lblBase.TabIndex = 9;
            lblBase.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBase
            // 
            txtBase.AutoSize = true;
            txtBase.Location = new Point(47, 265);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(97, 15);
            txtBase.TabIndex = 8;
            txtBase.Text = "Experiência base:";
            txtBase.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(186, 236);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(0, 15);
            lblWeight.TabIndex = 7;
            lblWeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtWeight
            // 
            txtWeight.AutoSize = true;
            txtWeight.Location = new Point(144, 236);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(35, 15);
            txtWeight.TabIndex = 6;
            txtWeight.Text = "Peso:";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(89, 236);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(0, 15);
            lblHeight.TabIndex = 5;
            // 
            // txtHeight
            // 
            txtHeight.AutoSize = true;
            txtHeight.Location = new Point(47, 236);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(42, 15);
            txtHeight.TabIndex = 4;
            txtHeight.Text = "Altura:";
            // 
            // btnToAllPokemon
            // 
            btnToAllPokemon.Location = new Point(144, 21);
            btnToAllPokemon.Name = "btnToAllPokemon";
            btnToAllPokemon.Size = new Size(123, 23);
            btnToAllPokemon.TabIndex = 3;
            btnToAllPokemon.Text = "Todos os Pokemons";
            btnToAllPokemon.UseVisualStyleBackColor = true;
            // 
            // btnToHome
            // 
            btnToHome.Location = new Point(47, 21);
            btnToHome.Name = "btnToHome";
            btnToHome.Size = new Size(75, 23);
            btnToHome.TabIndex = 2;
            btnToHome.Text = "Inicial";
            btnToHome.UseVisualStyleBackColor = true;
            // 
            // imgPokemon
            // 
            imgPokemon.Location = new Point(47, 91);
            imgPokemon.Name = "imgPokemon";
            imgPokemon.Size = new Size(220, 115);
            imgPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPokemon.TabIndex = 1;
            imgPokemon.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(398, 57);
            label1.Name = "label1";
            label1.Size = new Size(221, 32);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserControlPokemon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserControlPokemon";
            Size = new Size(1131, 567);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgPokemon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox imgPokemon;
        private Button btnToAllPokemon;
        private Button btnToHome;
        private Label txtHeight;
        private Label lblHeight;
        private Label lblWeight;
        private Label txtWeight;
        private Label txtBase;
        private Label lblBase;
    }
}
