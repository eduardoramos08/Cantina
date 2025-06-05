namespace CARDAPIO_POO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            totalTxt = new Label();
            cardapioTxt = new Label();
            adicionarBtn = new Button();
            removerBtn = new Button();
            finalizarBtn = new Button();
            pedidoTxt = new Label();
            quantidadeTxt = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dinheiroRecebidoTxt = new TextBox();
            label1 = new Label();
            label3 = new Label();
            Troco = new Label();
            label4 = new Label();
            nomeTxt = new TextBox();
            listViewCardapio = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listViewCarrinho = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            comboBoxFormaPagamento = new ComboBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btnViagem = new CheckBox();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // totalTxt
            // 
            totalTxt.AutoSize = true;
            totalTxt.Font = new Font("Segoe UI", 12F);
            totalTxt.Location = new Point(1119, 500);
            totalTxt.Name = "totalTxt";
            totalTxt.Size = new Size(0, 21);
            totalTxt.TabIndex = 0;
            // 
            // cardapioTxt
            // 
            cardapioTxt.AutoSize = true;
            cardapioTxt.Font = new Font("Agrandir Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardapioTxt.Location = new Point(202, 38);
            cardapioTxt.Name = "cardapioTxt";
            cardapioTxt.Size = new Size(131, 36);
            cardapioTxt.TabIndex = 1;
            cardapioTxt.Text = "Cardápio";
            cardapioTxt.Click += cardapioTxt_Click;
            // 
            // adicionarBtn
            // 
            adicionarBtn.BackColor = Color.FromArgb(120, 118, 100);
            adicionarBtn.BackgroundImage = (Image)resources.GetObject("adicionarBtn.BackgroundImage");
            adicionarBtn.BackgroundImageLayout = ImageLayout.Stretch;
            adicionarBtn.FlatAppearance.BorderSize = 0;
            adicionarBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 118, 100);
            adicionarBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 118, 100);
            adicionarBtn.FlatStyle = FlatStyle.Flat;
            adicionarBtn.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            adicionarBtn.ForeColor = Color.White;
            adicionarBtn.Location = new Point(96, 686);
            adicionarBtn.Name = "adicionarBtn";
            adicionarBtn.Size = new Size(185, 82);
            adicionarBtn.TabIndex = 2;
            adicionarBtn.Text = "Adicionar";
            adicionarBtn.UseVisualStyleBackColor = false;
            adicionarBtn.Click += adicionarBtn_Click;
            // 
            // removerBtn
            // 
            removerBtn.BackColor = Color.FromArgb(120, 118, 100);
            removerBtn.BackgroundImage = (Image)resources.GetObject("removerBtn.BackgroundImage");
            removerBtn.BackgroundImageLayout = ImageLayout.Stretch;
            removerBtn.FlatAppearance.BorderSize = 0;
            removerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 118, 100);
            removerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 118, 100);
            removerBtn.FlatStyle = FlatStyle.Flat;
            removerBtn.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            removerBtn.ForeColor = Color.White;
            removerBtn.Location = new Point(287, 686);
            removerBtn.Name = "removerBtn";
            removerBtn.Size = new Size(185, 82);
            removerBtn.TabIndex = 3;
            removerBtn.Text = "Remover";
            removerBtn.UseVisualStyleBackColor = false;
            removerBtn.Click += removerBtn_Click;
            // 
            // finalizarBtn
            // 
            finalizarBtn.BackColor = Color.FromArgb(120, 118, 100);
            finalizarBtn.BackgroundImage = (Image)resources.GetObject("finalizarBtn.BackgroundImage");
            finalizarBtn.BackgroundImageLayout = ImageLayout.Stretch;
            finalizarBtn.FlatAppearance.BorderSize = 0;
            finalizarBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 118, 100);
            finalizarBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 118, 100);
            finalizarBtn.FlatStyle = FlatStyle.Flat;
            finalizarBtn.Font = new Font("Inter Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finalizarBtn.ForeColor = Color.White;
            finalizarBtn.Location = new Point(756, 479);
            finalizarBtn.Name = "finalizarBtn";
            finalizarBtn.Size = new Size(185, 81);
            finalizarBtn.TabIndex = 4;
            finalizarBtn.Text = "Finalizar";
            finalizarBtn.UseVisualStyleBackColor = false;
            finalizarBtn.Click += finalizarBtn_Click;
            // 
            // pedidoTxt
            // 
            pedidoTxt.AutoSize = true;
            pedidoTxt.Font = new Font("Agrandir Narrow", 20.25F, FontStyle.Bold);
            pedidoTxt.Location = new Point(1379, 38);
            pedidoTxt.Name = "pedidoTxt";
            pedidoTxt.Size = new Size(99, 36);
            pedidoTxt.TabIndex = 7;
            pedidoTxt.Text = "Pedido";
            // 
            // quantidadeTxt
            // 
            quantidadeTxt.Location = new Point(271, 636);
            quantidadeTxt.Name = "quantidadeTxt";
            quantidadeTxt.Size = new Size(166, 23);
            quantidadeTxt.TabIndex = 9;
            quantidadeTxt.TextChanged += quantidadeTxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(120, 118, 100);
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(109, 634);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 11;
            label2.Text = "quantidade:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1528, 774);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(149, 32);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.Value = new DateTime(2025, 5, 16, 8, 31, 20, 0);
            dateTimePicker1.Visible = false;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dinheiroRecebidoTxt
            // 
            dinheiroRecebidoTxt.ForeColor = Color.White;
            dinheiroRecebidoTxt.Location = new Point(877, 306);
            dinheiroRecebidoTxt.Name = "dinheiroRecebidoTxt";
            dinheiroRecebidoTxt.Size = new Size(134, 23);
            dinheiroRecebidoTxt.TabIndex = 15;
            dinheiroRecebidoTxt.TextChanged += dinheiroRecebido_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(120, 118, 100);
            label1.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(704, 302);
            label1.Name = "label1";
            label1.Size = new Size(167, 24);
            label1.TabIndex = 16;
            label1.Text = "Total recebido:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(120, 118, 100);
            label3.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(793, 371);
            label3.Name = "label3";
            label3.Size = new Size(78, 24);
            label3.TabIndex = 17;
            label3.Text = "Troco:";
            label3.Click += label3_Click;
            // 
            // Troco
            // 
            Troco.AutoSize = true;
            Troco.BackColor = Color.White;
            Troco.Font = new Font("Segoe UI", 13F);
            Troco.ForeColor = Color.White;
            Troco.Location = new Point(877, 370);
            Troco.Name = "Troco";
            Troco.Size = new Size(131, 25);
            Troco.TabIndex = 19;
            Troco.Text = "_________________";
            Troco.Click += Troco_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(120, 118, 100);
            label4.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(793, 194);
            label4.Name = "label4";
            label4.Size = new Size(78, 24);
            label4.TabIndex = 20;
            label4.Text = "Nome:";
            // 
            // nomeTxt
            // 
            nomeTxt.Location = new Point(877, 194);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(134, 23);
            nomeTxt.TabIndex = 21;
            nomeTxt.TextChanged += nomeTxt_TextChanged;
            // 
            // listViewCardapio
            // 
            listViewCardapio.BackColor = Color.FromArgb(202, 196, 183);
            listViewCardapio.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewCardapio.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            listViewCardapio.ForeColor = Color.Black;
            listViewCardapio.FullRowSelect = true;
            listViewCardapio.GridLines = true;
            listViewCardapio.ImeMode = ImeMode.Off;
            listViewCardapio.Location = new Point(26, 77);
            listViewCardapio.MultiSelect = false;
            listViewCardapio.Name = "listViewCardapio";
            listViewCardapio.Size = new Size(533, 501);
            listViewCardapio.TabIndex = 22;
            listViewCardapio.UseCompatibleStateImageBehavior = false;
            listViewCardapio.View = View.Details;
            listViewCardapio.SelectedIndexChanged += listViewCardapio_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Codigo";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Descrição";
            columnHeader2.Width = 208;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estoque";
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Preço (R$)";
            columnHeader4.TextAlign = HorizontalAlignment.Right;
            columnHeader4.Width = 130;
            // 
            // listViewCarrinho
            // 
            listViewCarrinho.BackColor = Color.FromArgb(202, 196, 183);
            listViewCarrinho.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listViewCarrinho.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            listViewCarrinho.ForeColor = Color.Black;
            listViewCarrinho.FullRowSelect = true;
            listViewCarrinho.GridLines = true;
            listViewCarrinho.Location = new Point(1144, 77);
            listViewCarrinho.MultiSelect = false;
            listViewCarrinho.Name = "listViewCarrinho";
            listViewCarrinho.Size = new Size(533, 501);
            listViewCarrinho.TabIndex = 23;
            listViewCarrinho.UseCompatibleStateImageBehavior = false;
            listViewCarrinho.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Produto";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Qtd";
            columnHeader6.TextAlign = HorizontalAlignment.Right;
            columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Preço Unit. (R$)";
            columnHeader7.TextAlign = HorizontalAlignment.Right;
            columnHeader7.Width = 180;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Subtotal (R$)";
            columnHeader8.TextAlign = HorizontalAlignment.Right;
            columnHeader8.Width = 150;
            // 
            // comboBoxFormaPagamento
            // 
            comboBoxFormaPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFormaPagamento.FormattingEnabled = true;
            comboBoxFormaPagamento.Location = new Point(877, 245);
            comboBoxFormaPagamento.Name = "comboBoxFormaPagamento";
            comboBoxFormaPagamento.Size = new Size(134, 23);
            comboBoxFormaPagamento.TabIndex = 24;
            comboBoxFormaPagamento.SelectedIndexChanged += comboBoxFormaPagamento_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(120, 118, 100);
            label5.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(621, 245);
            label5.Name = "label5";
            label5.Size = new Size(250, 24);
            label5.TabIndex = 25;
            label5.Text = "Método de pagamento:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_05_20_223613_removebg_preview;
            pictureBox1.Location = new Point(1503, 674);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 241, 238);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 241, 238);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(756, 646);
            button1.Name = "button1";
            button1.Size = new Size(185, 82);
            button1.TabIndex = 28;
            button1.Text = "Tela de Pedidos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnViagem
            // 
            btnViagem.AutoSize = true;
            btnViagem.BackColor = Color.FromArgb(120, 118, 100);
            btnViagem.Font = new Font("Inter Medium", 20F, FontStyle.Bold);
            btnViagem.ForeColor = Color.White;
            btnViagem.Location = new Point(745, 418);
            btnViagem.Name = "btnViagem";
            btnViagem.Size = new Size(207, 37);
            btnViagem.TabIndex = 29;
            btnViagem.Text = "Para Viagem";
            btnViagem.UseVisualStyleBackColor = false;
            btnViagem.CheckedChanged += btnViagem_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(120, 118, 100);
            label6.Font = new Font("Inter Medium", 20F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(734, 140);
            label6.Name = "label6";
            label6.Size = new Size(251, 33);
            label6.TabIndex = 31;
            label6.Text = "Dados do Cliente";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(580, 77);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(548, 501);
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(120, 118, 100);
            pictureBox2.Location = new Point(51, 609);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(459, 197);
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1703, 816);
            Controls.Add(label6);
            Controls.Add(btnViagem);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(comboBoxFormaPagamento);
            Controls.Add(listViewCarrinho);
            Controls.Add(listViewCardapio);
            Controls.Add(nomeTxt);
            Controls.Add(label4);
            Controls.Add(Troco);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dinheiroRecebidoTxt);
            Controls.Add(dateTimePicker1);
            Controls.Add(pedidoTxt);
            Controls.Add(cardapioTxt);
            Controls.Add(totalTxt);
            Controls.Add(button1);
            Controls.Add(finalizarBtn);
            Controls.Add(pictureBox3);
            Controls.Add(removerBtn);
            Controls.Add(adicionarBtn);
            Controls.Add(quantidadeTxt);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalTxt;
        private Label cardapioTxt;
        private Button adicionarBtn;
        private Button removerBtn;
        private Button finalizarBtn;
        private Label pedidoTxt;
        private TextBox quantidadeTxt;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox dinheiroRecebidoTxt;
        private Label label1;
        private Label label3;
        private Label Troco;
        private Label label4;
        private TextBox nomeTxt;
        private ListView listViewCardapio;
        private ListView listViewCarrinho;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ComboBox comboBoxFormaPagamento;
        private Label label5;
        private PictureBox pictureBox1;
        private Button button1;
        private CheckBox btnViagem;
        private Label label6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}
