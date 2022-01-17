
namespace ListaUI
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.lbDados = new System.Windows.Forms.ListBox();
            this.label_total = new MonoFlat.MonoFlat_Label();
            this.label_detalhes = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label3 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label4 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label5 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label6 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label7 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label8 = new MonoFlat.MonoFlat_Label();
            this.btnFechar = new MonoFlat.MonoFlat_Button();
            this.btnAdicionar = new MonoFlat.MonoFlat_Button();
            this.btnRemover = new MonoFlat.MonoFlat_Button();
            this.btnLimpar = new MonoFlat.MonoFlat_Button();
            this.txt_tipo = new MonoFlat.MonoFlat_TextBox();
            this.txt_unidade = new MonoFlat.MonoFlat_TextBox();
            this.txt_calorias = new MonoFlat.MonoFlat_TextBox();
            this.txt_preco = new MonoFlat.MonoFlat_TextBox();
            this.txt_custototal = new MonoFlat.MonoFlat_TextBox();
            this.txt_quantidade = new MonoFlat.MonoFlat_TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.monoFlat_ThemeContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.txt_quantidade);
            this.monoFlat_ThemeContainer1.Controls.Add(this.txt_custototal);
            this.monoFlat_ThemeContainer1.Controls.Add(this.txt_preco);
            this.monoFlat_ThemeContainer1.Controls.Add(this.txt_calorias);
            this.monoFlat_ThemeContainer1.Controls.Add(this.txt_unidade);
            this.monoFlat_ThemeContainer1.Controls.Add(this.txt_tipo);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnLimpar);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnRemover);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnAdicionar);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnFechar);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label8);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label7);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label6);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label5);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label4);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label3);
            this.monoFlat_ThemeContainer1.Controls.Add(this.label_detalhes);
            this.monoFlat_ThemeContainer1.Controls.Add(this.label_total);
            this.monoFlat_ThemeContainer1.Controls.Add(this.lbDados);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = false;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(853, 584);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            this.monoFlat_ThemeContainer1.Text = "ListaUI";
            // 
            // lbDados
            // 
            this.lbDados.BackColor = System.Drawing.Color.Black;
            this.lbDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDados.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDados.ForeColor = System.Drawing.Color.White;
            this.lbDados.FormattingEnabled = true;
            this.lbDados.ItemHeight = 19;
            this.lbDados.Location = new System.Drawing.Point(13, 73);
            this.lbDados.Name = "lbDados";
            this.lbDados.Size = new System.Drawing.Size(310, 401);
            this.lbDados.TabIndex = 0;
            this.lbDados.SelectedIndexChanged += new System.EventHandler(this.lbDados_SelectedIndexChanged);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.BackColor = System.Drawing.Color.Transparent;
            this.label_total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.ForeColor = System.Drawing.Color.White;
            this.label_total.Location = new System.Drawing.Point(128, 485);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(58, 21);
            this.label_total.TabIndex = 1;
            this.label_total.Text = "Total: 0";
            // 
            // label_detalhes
            // 
            this.label_detalhes.AutoSize = true;
            this.label_detalhes.BackColor = System.Drawing.Color.Transparent;
            this.label_detalhes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_detalhes.ForeColor = System.Drawing.Color.White;
            this.label_detalhes.Location = new System.Drawing.Point(380, 69);
            this.label_detalhes.Name = "label_detalhes";
            this.label_detalhes.Size = new System.Drawing.Size(130, 21);
            this.label_detalhes.TabIndex = 2;
            this.label_detalhes.Text = "Detalhes do item:";
            // 
            // monoFlat_Label3
            // 
            this.monoFlat_Label3.AutoSize = true;
            this.monoFlat_Label3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label3.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label3.Location = new System.Drawing.Point(402, 107);
            this.monoFlat_Label3.Name = "monoFlat_Label3";
            this.monoFlat_Label3.Size = new System.Drawing.Size(43, 21);
            this.monoFlat_Label3.TabIndex = 3;
            this.monoFlat_Label3.Text = "Tipo:";
            // 
            // monoFlat_Label4
            // 
            this.monoFlat_Label4.AutoSize = true;
            this.monoFlat_Label4.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label4.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label4.Location = new System.Drawing.Point(402, 169);
            this.monoFlat_Label4.Name = "monoFlat_Label4";
            this.monoFlat_Label4.Size = new System.Drawing.Size(71, 21);
            this.monoFlat_Label4.TabIndex = 4;
            this.monoFlat_Label4.Text = "Unidade:";
            // 
            // monoFlat_Label5
            // 
            this.monoFlat_Label5.AutoSize = true;
            this.monoFlat_Label5.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label5.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label5.Location = new System.Drawing.Point(402, 231);
            this.monoFlat_Label5.Name = "monoFlat_Label5";
            this.monoFlat_Label5.Size = new System.Drawing.Size(69, 21);
            this.monoFlat_Label5.TabIndex = 5;
            this.monoFlat_Label5.Text = "Calorias:";
            // 
            // monoFlat_Label6
            // 
            this.monoFlat_Label6.AutoSize = true;
            this.monoFlat_Label6.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label6.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label6.Location = new System.Drawing.Point(402, 293);
            this.monoFlat_Label6.Name = "monoFlat_Label6";
            this.monoFlat_Label6.Size = new System.Drawing.Size(52, 21);
            this.monoFlat_Label6.TabIndex = 6;
            this.monoFlat_Label6.Text = "Preço:";
            // 
            // monoFlat_Label7
            // 
            this.monoFlat_Label7.AutoSize = true;
            this.monoFlat_Label7.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label7.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label7.Location = new System.Drawing.Point(402, 355);
            this.monoFlat_Label7.Name = "monoFlat_Label7";
            this.monoFlat_Label7.Size = new System.Drawing.Size(89, 21);
            this.monoFlat_Label7.TabIndex = 7;
            this.monoFlat_Label7.Text = "Custo Total:";
            // 
            // monoFlat_Label8
            // 
            this.monoFlat_Label8.AutoSize = true;
            this.monoFlat_Label8.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label8.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label8.Location = new System.Drawing.Point(402, 417);
            this.monoFlat_Label8.Name = "monoFlat_Label8";
            this.monoFlat_Label8.Size = new System.Drawing.Size(94, 21);
            this.monoFlat_Label8.TabIndex = 8;
            this.monoFlat_Label8.Text = "Quantidade:";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFechar.Image = null;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(794, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(47, 41);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "X";
            this.btnFechar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdicionar.Image = null;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(384, 531);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(146, 41);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Transparent;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemover.Image = null;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(536, 531);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(146, 41);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLimpar.Image = null;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(688, 531);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(146, 41);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txt_tipo
            // 
            this.txt_tipo.BackColor = System.Drawing.Color.Transparent;
            this.txt_tipo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_tipo.Image = null;
            this.txt_tipo.Location = new System.Drawing.Point(406, 129);
            this.txt_tipo.MaxLength = 32767;
            this.txt_tipo.Multiline = false;
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.ReadOnly = false;
            this.txt_tipo.Size = new System.Drawing.Size(413, 41);
            this.txt_tipo.TabIndex = 13;
            this.txt_tipo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_tipo.UseSystemPasswordChar = false;
            // 
            // txt_unidade
            // 
            this.txt_unidade.BackColor = System.Drawing.Color.Transparent;
            this.txt_unidade.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_unidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_unidade.Image = null;
            this.txt_unidade.Location = new System.Drawing.Point(406, 191);
            this.txt_unidade.MaxLength = 32767;
            this.txt_unidade.Multiline = false;
            this.txt_unidade.Name = "txt_unidade";
            this.txt_unidade.ReadOnly = false;
            this.txt_unidade.Size = new System.Drawing.Size(413, 41);
            this.txt_unidade.TabIndex = 14;
            this.txt_unidade.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_unidade.UseSystemPasswordChar = false;
            // 
            // txt_calorias
            // 
            this.txt_calorias.BackColor = System.Drawing.Color.Transparent;
            this.txt_calorias.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_calorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_calorias.Image = null;
            this.txt_calorias.Location = new System.Drawing.Point(406, 253);
            this.txt_calorias.MaxLength = 32767;
            this.txt_calorias.Multiline = false;
            this.txt_calorias.Name = "txt_calorias";
            this.txt_calorias.ReadOnly = false;
            this.txt_calorias.Size = new System.Drawing.Size(413, 41);
            this.txt_calorias.TabIndex = 15;
            this.txt_calorias.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_calorias.UseSystemPasswordChar = false;
            // 
            // txt_preco
            // 
            this.txt_preco.BackColor = System.Drawing.Color.Transparent;
            this.txt_preco.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_preco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_preco.Image = null;
            this.txt_preco.Location = new System.Drawing.Point(406, 315);
            this.txt_preco.MaxLength = 32767;
            this.txt_preco.Multiline = false;
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.ReadOnly = false;
            this.txt_preco.Size = new System.Drawing.Size(413, 41);
            this.txt_preco.TabIndex = 16;
            this.txt_preco.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_preco.UseSystemPasswordChar = false;
            // 
            // txt_custototal
            // 
            this.txt_custototal.BackColor = System.Drawing.Color.Transparent;
            this.txt_custototal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_custototal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_custototal.Image = null;
            this.txt_custototal.Location = new System.Drawing.Point(406, 377);
            this.txt_custototal.MaxLength = 32767;
            this.txt_custototal.Multiline = false;
            this.txt_custototal.Name = "txt_custototal";
            this.txt_custototal.ReadOnly = false;
            this.txt_custototal.Size = new System.Drawing.Size(413, 41);
            this.txt_custototal.TabIndex = 17;
            this.txt_custototal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_custototal.UseSystemPasswordChar = false;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.BackColor = System.Drawing.Color.Transparent;
            this.txt_quantidade.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_quantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_quantidade.Image = null;
            this.txt_quantidade.Location = new System.Drawing.Point(406, 441);
            this.txt_quantidade.MaxLength = 32767;
            this.txt_quantidade.Multiline = false;
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.ReadOnly = false;
            this.txt_quantidade.Size = new System.Drawing.Size(413, 41);
            this.txt_quantidade.TabIndex = 18;
            this.txt_quantidade.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_quantidade.UseSystemPasswordChar = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 584);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ListaUI";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_TextBox txt_quantidade;
        private MonoFlat.MonoFlat_TextBox txt_custototal;
        private MonoFlat.MonoFlat_TextBox txt_preco;
        private MonoFlat.MonoFlat_TextBox txt_calorias;
        private MonoFlat.MonoFlat_TextBox txt_unidade;
        private MonoFlat.MonoFlat_TextBox txt_tipo;
        private MonoFlat.MonoFlat_Button btnLimpar;
        private MonoFlat.MonoFlat_Button btnRemover;
        private MonoFlat.MonoFlat_Button btnAdicionar;
        private MonoFlat.MonoFlat_Button btnFechar;
        private MonoFlat.MonoFlat_Label monoFlat_Label8;
        private MonoFlat.MonoFlat_Label monoFlat_Label7;
        private MonoFlat.MonoFlat_Label monoFlat_Label6;
        private MonoFlat.MonoFlat_Label monoFlat_Label5;
        private MonoFlat.MonoFlat_Label monoFlat_Label4;
        private MonoFlat.MonoFlat_Label monoFlat_Label3;
        private MonoFlat.MonoFlat_Label label_detalhes;
        private MonoFlat.MonoFlat_Label label_total;
        private System.Windows.Forms.ListBox lbDados;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

