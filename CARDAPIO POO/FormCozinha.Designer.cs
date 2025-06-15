namespace CARDAPIO_POO
{
    partial class FormCozinha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCozinha));
            listViewPedidosCozinha = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnVerDetalhes = new Button();
            btnMarcarConcluido = new Button();
            pictureBox2 = new PictureBox();
            listViewFinalizadoCozinha = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listViewPedidosCozinha
            // 
            listViewPedidosCozinha.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewPedidosCozinha.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            listViewPedidosCozinha.FullRowSelect = true;
            listViewPedidosCozinha.GridLines = true;
            listViewPedidosCozinha.Location = new Point(1, 96);
            listViewPedidosCozinha.MultiSelect = false;
            listViewPedidosCozinha.Name = "listViewPedidosCozinha";
            listViewPedidosCozinha.Size = new Size(666, 493);
            listViewPedidosCozinha.TabIndex = 0;
            listViewPedidosCozinha.UseCompatibleStateImageBehavior = false;
            listViewPedidosCozinha.View = View.Details;
            listViewPedidosCozinha.SelectedIndexChanged += listViewPedidosCozinha_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cliente";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Status";
            columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Data e Hora";
            columnHeader3.Width = 280;
            // 
            // btnVerDetalhes
            // 
            btnVerDetalhes.BackColor = Color.White;
            btnVerDetalhes.BackgroundImage = (Image)resources.GetObject("btnVerDetalhes.BackgroundImage");
            btnVerDetalhes.BackgroundImageLayout = ImageLayout.Stretch;
            btnVerDetalhes.FlatAppearance.BorderSize = 0;
            btnVerDetalhes.FlatAppearance.MouseDownBackColor = Color.White;
            btnVerDetalhes.FlatAppearance.MouseOverBackColor = Color.White;
            btnVerDetalhes.FlatStyle = FlatStyle.Flat;
            btnVerDetalhes.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            btnVerDetalhes.ForeColor = Color.White;
            btnVerDetalhes.Location = new Point(353, 625);
            btnVerDetalhes.Name = "btnVerDetalhes";
            btnVerDetalhes.Size = new Size(194, 98);
            btnVerDetalhes.TabIndex = 32;
            btnVerDetalhes.Text = "Exibir detalhes";
            btnVerDetalhes.UseVisualStyleBackColor = false;
            btnVerDetalhes.Click += btnVerDetalhes_Click;
            // 
            // btnMarcarConcluido
            // 
            btnMarcarConcluido.BackColor = Color.White;
            btnMarcarConcluido.BackgroundImage = (Image)resources.GetObject("btnMarcarConcluido.BackgroundImage");
            btnMarcarConcluido.BackgroundImageLayout = ImageLayout.Stretch;
            btnMarcarConcluido.FlatAppearance.BorderSize = 0;
            btnMarcarConcluido.FlatAppearance.MouseDownBackColor = Color.White;
            btnMarcarConcluido.FlatAppearance.MouseOverBackColor = Color.White;
            btnMarcarConcluido.FlatStyle = FlatStyle.Flat;
            btnMarcarConcluido.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            btnMarcarConcluido.ForeColor = Color.White;
            btnMarcarConcluido.Location = new Point(153, 625);
            btnMarcarConcluido.Name = "btnMarcarConcluido";
            btnMarcarConcluido.Size = new Size(194, 98);
            btnMarcarConcluido.TabIndex = 31;
            btnMarcarConcluido.Text = "Marcar como concluido";
            btnMarcarConcluido.UseVisualStyleBackColor = false;
            btnMarcarConcluido.Click += btnMarcarConcluido_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(109, 595);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(467, 161);
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // listViewFinalizadoCozinha
            // 
            listViewFinalizadoCozinha.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listViewFinalizadoCozinha.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            listViewFinalizadoCozinha.FullRowSelect = true;
            listViewFinalizadoCozinha.GridLines = true;
            listViewFinalizadoCozinha.Location = new Point(744, 86);
            listViewFinalizadoCozinha.MultiSelect = false;
            listViewFinalizadoCozinha.Name = "listViewFinalizadoCozinha";
            listViewFinalizadoCozinha.Size = new Size(667, 493);
            listViewFinalizadoCozinha.TabIndex = 34;
            listViewFinalizadoCozinha.UseCompatibleStateImageBehavior = false;
            listViewFinalizadoCozinha.View = View.Details;
            listViewFinalizadoCozinha.SelectedIndexChanged += listViewFInalizadoCozinha_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cliente";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Status";
            columnHeader5.Width = 230;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Data e Hora";
            columnHeader6.Width = 280;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agrandir Narrow Bold", 20.25F, FontStyle.Bold);
            label2.Location = new Point(919, 34);
            label2.Name = "label2";
            label2.Size = new Size(243, 36);
            label2.TabIndex = 36;
            label2.Text = "Pedidos Entregues";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Narrow Bold", 20.25F, FontStyle.Bold);
            label1.Location = new Point(247, 34);
            label1.Name = "label1";
            label1.Size = new Size(264, 36);
            label1.TabIndex = 35;
            label1.Text = "HIstorico de pedidos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_05_20_223613_removebg_preview;
            pictureBox1.Location = new Point(1155, 662);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // FormCozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1433, 780);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listViewFinalizadoCozinha);
            Controls.Add(btnVerDetalhes);
            Controls.Add(btnMarcarConcluido);
            Controls.Add(pictureBox2);
            Controls.Add(listViewPedidosCozinha);
            Name = "FormCozinha";
            Text = "FormCozinha";
            Load += FormCozinha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewPedidosCozinha;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnVerDetalhes;
        private Button btnMarcarConcluido;
        private PictureBox pictureBox2;
        private ListView listViewFinalizadoCozinha;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}