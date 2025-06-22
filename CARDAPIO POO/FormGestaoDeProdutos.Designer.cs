namespace CARDAPIO_POO
{
    partial class FormGestaoDeProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestaoDeProdutos));
            listViewEstoque = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            listViewCardapio = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            pictureBox4 = new PictureBox();
            cardapioTxt = new Label();
            pictureBox1 = new PictureBox();
            AdicionarcardapioBtn = new Button();
            label1 = new Label();
            editarBtn = new Button();
            adicionarEstoqueBtn = new Button();
            CodigoTxt = new TextBox();
            DescricaoTxt = new TextBox();
            DataValidadeTxt = new TextBox();
            CustoTxt = new TextBox();
            PrecoTxt = new TextBox();
            QuantidadeTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            salvarBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listViewEstoque
            // 
            listViewEstoque.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewEstoque.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            listViewEstoque.FullRowSelect = true;
            listViewEstoque.GridLines = true;
            listViewEstoque.Location = new Point(751, 172);
            listViewEstoque.Name = "listViewEstoque";
            listViewEstoque.Size = new Size(976, 501);
            listViewEstoque.TabIndex = 1;
            listViewEstoque.UseCompatibleStateImageBehavior = false;
            listViewEstoque.View = View.Details;
            listViewEstoque.SelectedIndexChanged += listViewEstoque_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Descrição ";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Data de Validade";
            columnHeader3.Width = 190;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Quantidade";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Preço";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Custo";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 120;
            // 
            // listViewCardapio
            // 
            listViewCardapio.BackColor = Color.White;
            listViewCardapio.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            listViewCardapio.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            listViewCardapio.ForeColor = Color.Black;
            listViewCardapio.FullRowSelect = true;
            listViewCardapio.GridLines = true;
            listViewCardapio.ImeMode = ImeMode.Off;
            listViewCardapio.Location = new Point(25, 172);
            listViewCardapio.MultiSelect = false;
            listViewCardapio.Name = "listViewCardapio";
            listViewCardapio.Size = new Size(607, 501);
            listViewCardapio.TabIndex = 23;
            listViewCardapio.UseCompatibleStateImageBehavior = false;
            listViewCardapio.View = View.Details;
            listViewCardapio.SelectedIndexChanged += listViewCardapio_SelectedIndexChanged;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Codigo";
            columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Descrição";
            columnHeader8.Width = 280;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Estoque";
            columnHeader9.TextAlign = HorizontalAlignment.Right;
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Preço (R$)";
            columnHeader10.TextAlign = HorizontalAlignment.Right;
            columnHeader10.Width = 130;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(25, 23);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(203, 70);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            // 
            // cardapioTxt
            // 
            cardapioTxt.AutoSize = true;
            cardapioTxt.Font = new Font("Agrandir Narrow Bold", 20.25F, FontStyle.Bold);
            cardapioTxt.Location = new Point(214, 118);
            cardapioTxt.Name = "cardapioTxt";
            cardapioTxt.Size = new Size(129, 36);
            cardapioTxt.TabIndex = 43;
            cardapioTxt.Text = "Cardápio";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-696, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // AdicionarcardapioBtn
            // 
            AdicionarcardapioBtn.BackgroundImage = (Image)resources.GetObject("AdicionarcardapioBtn.BackgroundImage");
            AdicionarcardapioBtn.BackgroundImageLayout = ImageLayout.Stretch;
            AdicionarcardapioBtn.FlatAppearance.BorderSize = 0;
            AdicionarcardapioBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 241, 238);
            AdicionarcardapioBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 241, 238);
            AdicionarcardapioBtn.FlatStyle = FlatStyle.Flat;
            AdicionarcardapioBtn.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            AdicionarcardapioBtn.ForeColor = Color.White;
            AdicionarcardapioBtn.Location = new Point(216, 692);
            AdicionarcardapioBtn.Name = "AdicionarcardapioBtn";
            AdicionarcardapioBtn.Size = new Size(185, 82);
            AdicionarcardapioBtn.TabIndex = 48;
            AdicionarcardapioBtn.Text = "Adicionar No Cardapio";
            AdicionarcardapioBtn.UseVisualStyleBackColor = true;
            AdicionarcardapioBtn.Click += AdicionarcardapioBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Narrow Bold", 20.25F, FontStyle.Bold);
            label1.Location = new Point(-507, 106);
            label1.Name = "label1";
            label1.Size = new Size(129, 36);
            label1.TabIndex = 45;
            label1.Text = "Cardápio";
            // 
            // editarBtn
            // 
            editarBtn.BackgroundImage = (Image)resources.GetObject("editarBtn.BackgroundImage");
            editarBtn.BackgroundImageLayout = ImageLayout.Stretch;
            editarBtn.FlatAppearance.BorderSize = 0;
            editarBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 241, 238);
            editarBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 241, 238);
            editarBtn.FlatStyle = FlatStyle.Flat;
            editarBtn.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            editarBtn.ForeColor = Color.White;
            editarBtn.Location = new Point(25, 690);
            editarBtn.Name = "editarBtn";
            editarBtn.Size = new Size(185, 82);
            editarBtn.TabIndex = 46;
            editarBtn.Text = "Editar";
            editarBtn.UseVisualStyleBackColor = true;
            editarBtn.Click += editarBtn_Click;
            // 
            // adicionarEstoqueBtn
            // 
            adicionarEstoqueBtn.BackgroundImage = (Image)resources.GetObject("adicionarEstoqueBtn.BackgroundImage");
            adicionarEstoqueBtn.BackgroundImageLayout = ImageLayout.Stretch;
            adicionarEstoqueBtn.FlatAppearance.BorderSize = 0;
            adicionarEstoqueBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 241, 238);
            adicionarEstoqueBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 241, 238);
            adicionarEstoqueBtn.FlatStyle = FlatStyle.Flat;
            adicionarEstoqueBtn.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            adicionarEstoqueBtn.ForeColor = Color.White;
            adicionarEstoqueBtn.Location = new Point(407, 692);
            adicionarEstoqueBtn.Name = "adicionarEstoqueBtn";
            adicionarEstoqueBtn.Size = new Size(185, 82);
            adicionarEstoqueBtn.TabIndex = 47;
            adicionarEstoqueBtn.Text = "Adicionar No Estoque";
            adicionarEstoqueBtn.UseVisualStyleBackColor = true;
            adicionarEstoqueBtn.Click += adicionarEstoqueBtn_Click;
            // 
            // CodigoTxt
            // 
            CodigoTxt.Location = new Point(837, 692);
            CodigoTxt.Name = "CodigoTxt";
            CodigoTxt.Size = new Size(100, 23);
            CodigoTxt.TabIndex = 50;
            // 
            // DescricaoTxt
            // 
            DescricaoTxt.Location = new Point(837, 725);
            DescricaoTxt.Name = "DescricaoTxt";
            DescricaoTxt.Size = new Size(100, 23);
            DescricaoTxt.TabIndex = 51;
            // 
            // DataValidadeTxt
            // 
            DataValidadeTxt.Location = new Point(837, 754);
            DataValidadeTxt.Name = "DataValidadeTxt";
            DataValidadeTxt.Size = new Size(100, 23);
            DataValidadeTxt.TabIndex = 52;
            // 
            // CustoTxt
            // 
            CustoTxt.Location = new Point(1025, 750);
            CustoTxt.Name = "CustoTxt";
            CustoTxt.Size = new Size(100, 23);
            CustoTxt.TabIndex = 55;
            // 
            // PrecoTxt
            // 
            PrecoTxt.Location = new Point(1025, 721);
            PrecoTxt.Name = "PrecoTxt";
            PrecoTxt.Size = new Size(100, 23);
            PrecoTxt.TabIndex = 54;
            // 
            // QuantidadeTxt
            // 
            QuantidadeTxt.Location = new Point(1025, 692);
            QuantidadeTxt.Name = "QuantidadeTxt";
            QuantidadeTxt.Size = new Size(100, 23);
            QuantidadeTxt.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(773, 725);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 56;
            label2.Text = "Descricao";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(737, 762);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 57;
            label3.Text = "Data de Validade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(982, 726);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 59;
            label4.Text = "Preco";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(982, 757);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 58;
            label5.Text = "Custo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(950, 690);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 61;
            label6.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(785, 692);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 60;
            label7.Text = "Codigo";
            // 
            // salvarBtn
            // 
            salvarBtn.BackgroundImage = (Image)resources.GetObject("salvarBtn.BackgroundImage");
            salvarBtn.BackgroundImageLayout = ImageLayout.Stretch;
            salvarBtn.FlatAppearance.BorderSize = 0;
            salvarBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 241, 238);
            salvarBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 241, 238);
            salvarBtn.FlatStyle = FlatStyle.Flat;
            salvarBtn.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            salvarBtn.ForeColor = Color.White;
            salvarBtn.Location = new Point(1557, 717);
            salvarBtn.Name = "salvarBtn";
            salvarBtn.Size = new Size(185, 82);
            salvarBtn.TabIndex = 62;
            salvarBtn.Text = "Salvar Tudo";
            salvarBtn.UseVisualStyleBackColor = true;
            salvarBtn.Click += salvarBtn_Click;
            // 
            // FormGestaoDeProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1852, 963);
            Controls.Add(salvarBtn);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CustoTxt);
            Controls.Add(PrecoTxt);
            Controls.Add(QuantidadeTxt);
            Controls.Add(DataValidadeTxt);
            Controls.Add(DescricaoTxt);
            Controls.Add(CodigoTxt);
            Controls.Add(pictureBox1);
            Controls.Add(AdicionarcardapioBtn);
            Controls.Add(label1);
            Controls.Add(editarBtn);
            Controls.Add(adicionarEstoqueBtn);
            Controls.Add(pictureBox4);
            Controls.Add(cardapioTxt);
            Controls.Add(listViewCardapio);
            Controls.Add(listViewEstoque);
            Name = "FormGestaoDeProdutos";
            Text = "FormGestaoDePedidos";
            Load += FormGestaoDeProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewEstoque;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView listViewCardapio;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private PictureBox pictureBox4;
        private Label cardapioTxt;
        private PictureBox pictureBox1;
        private Button AdicionarcardapioBtn;
        private Label label1;
        private Button editarBtn;
        private Button adicionarEstoqueBtn;
        private TextBox CodigoTxt;
        private TextBox DescricaoTxt;
        private TextBox DataValidadeTxt;
        private TextBox CustoTxt;
        private TextBox PrecoTxt;
        private TextBox QuantidadeTxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button salvarBtn;
    }
}