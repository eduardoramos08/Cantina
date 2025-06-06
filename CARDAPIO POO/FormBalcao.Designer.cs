namespace CARDAPIO_POO
{
    partial class FormBalcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBalcao));
            btnMarcarConcluido = new Button();
            btnVerDetalhes = new Button();
            listViewPedidos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            listViewFinalizados = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnMarcarConcluido
            // 
            btnMarcarConcluido.BackColor = Color.FromArgb(120, 118, 100);
            btnMarcarConcluido.BackgroundImage = (Image)resources.GetObject("btnMarcarConcluido.BackgroundImage");
            btnMarcarConcluido.BackgroundImageLayout = ImageLayout.Stretch;
            btnMarcarConcluido.FlatAppearance.BorderSize = 0;
            btnMarcarConcluido.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 118, 100);
            btnMarcarConcluido.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 118, 100);
            btnMarcarConcluido.FlatStyle = FlatStyle.Flat;
            btnMarcarConcluido.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            btnMarcarConcluido.ForeColor = Color.White;
            btnMarcarConcluido.Location = new Point(72, 570);
            btnMarcarConcluido.Name = "btnMarcarConcluido";
            btnMarcarConcluido.Size = new Size(194, 98);
            btnMarcarConcluido.TabIndex = 2;
            btnMarcarConcluido.Text = "Marcar como concluido";
            btnMarcarConcluido.UseVisualStyleBackColor = false;
            btnMarcarConcluido.Click += btnMarcarConcluido_Click;
            // 
            // btnVerDetalhes
            // 
            btnVerDetalhes.BackColor = Color.FromArgb(120, 118, 100);
            btnVerDetalhes.BackgroundImage = (Image)resources.GetObject("btnVerDetalhes.BackgroundImage");
            btnVerDetalhes.BackgroundImageLayout = ImageLayout.Stretch;
            btnVerDetalhes.FlatAppearance.BorderSize = 0;
            btnVerDetalhes.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 118, 100);
            btnVerDetalhes.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 118, 100);
            btnVerDetalhes.FlatStyle = FlatStyle.Flat;
            btnVerDetalhes.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            btnVerDetalhes.ForeColor = Color.White;
            btnVerDetalhes.Location = new Point(272, 570);
            btnVerDetalhes.Name = "btnVerDetalhes";
            btnVerDetalhes.Size = new Size(194, 98);
            btnVerDetalhes.TabIndex = 3;
            btnVerDetalhes.Text = "Exibir detalhes";
            btnVerDetalhes.UseVisualStyleBackColor = false;
            btnVerDetalhes.Click += btnVerDetalhes_Click;
            // 
            // listViewPedidos
            // 
            listViewPedidos.BackColor = Color.FromArgb(202, 196, 183);
            listViewPedidos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewPedidos.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            listViewPedidos.ForeColor = SystemColors.WindowText;
            listViewPedidos.FullRowSelect = true;
            listViewPedidos.GridLines = true;
            listViewPedidos.Location = new Point(28, 125);
            listViewPedidos.Name = "listViewPedidos";
            listViewPedidos.Size = new Size(584, 391);
            listViewPedidos.TabIndex = 4;
            listViewPedidos.UseCompatibleStateImageBehavior = false;
            listViewPedidos.View = View.Details;
            listViewPedidos.SelectedIndexChanged += listViewPedidos_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cliente";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Status";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Data e Hora";
            columnHeader3.Width = 280;
            // 
            // listViewFinalizados
            // 
            listViewFinalizados.BackColor = Color.FromArgb(202, 196, 183);
            listViewFinalizados.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listViewFinalizados.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            listViewFinalizados.FullRowSelect = true;
            listViewFinalizados.GridLines = true;
            listViewFinalizados.Location = new Point(695, 125);
            listViewFinalizados.Name = "listViewFinalizados";
            listViewFinalizados.Size = new Size(585, 391);
            listViewFinalizados.TabIndex = 5;
            listViewFinalizados.UseCompatibleStateImageBehavior = false;
            listViewFinalizados.View = View.Details;
            listViewFinalizados.SelectedIndexChanged += listViewFinalizados_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cliente";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Status";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Data e Hora";
            columnHeader6.Width = 280;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_05_20_223613_removebg_preview;
            pictureBox1.Location = new Point(957, 551);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Narrow Bold", 20.25F, FontStyle.Bold);
            label1.Location = new Point(179, 69);
            label1.Name = "label1";
            label1.Size = new Size(264, 36);
            label1.TabIndex = 28;
            label1.Text = "HIstorico de pedidos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agrandir Narrow Bold", 20.25F, FontStyle.Bold);
            label2.Location = new Point(851, 69);
            label2.Name = "label2";
            label2.Size = new Size(243, 36);
            label2.TabIndex = 29;
            label2.Text = "Pedidos Entregues";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(120, 118, 100);
            pictureBox2.Location = new Point(28, 540);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(467, 161);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // FormBalcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1330, 724);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(listViewFinalizados);
            Controls.Add(listViewPedidos);
            Controls.Add(btnVerDetalhes);
            Controls.Add(btnMarcarConcluido);
            Controls.Add(pictureBox2);
            Name = "FormBalcao";
            Text = "FormBalcao";
            Load += FormBalcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnMarcarConcluido;
        private Button btnVerDetalhes;
        private ListView listViewPedidos;
        private ListView listViewFinalizados;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private PictureBox pictureBox2;
    }
}