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
            listViewFinalizados = new ListView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnMarcarConcluido
            // 
            btnMarcarConcluido.BackgroundImage = (Image)resources.GetObject("btnMarcarConcluido.BackgroundImage");
            btnMarcarConcluido.BackgroundImageLayout = ImageLayout.Stretch;
            btnMarcarConcluido.FlatAppearance.BorderSize = 0;
            btnMarcarConcluido.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 241, 238);
            btnMarcarConcluido.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 241, 238);
            btnMarcarConcluido.FlatStyle = FlatStyle.Flat;
            btnMarcarConcluido.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            btnMarcarConcluido.ForeColor = Color.White;
            btnMarcarConcluido.Location = new Point(132, 509);
            btnMarcarConcluido.Name = "btnMarcarConcluido";
            btnMarcarConcluido.Size = new Size(194, 98);
            btnMarcarConcluido.TabIndex = 2;
            btnMarcarConcluido.Text = "Marcar como concluido";
            btnMarcarConcluido.UseVisualStyleBackColor = true;
            btnMarcarConcluido.Click += btnMarcarConcluido_Click;
            // 
            // btnVerDetalhes
            // 
            btnVerDetalhes.BackgroundImage = (Image)resources.GetObject("btnVerDetalhes.BackgroundImage");
            btnVerDetalhes.BackgroundImageLayout = ImageLayout.Stretch;
            btnVerDetalhes.FlatAppearance.BorderSize = 0;
            btnVerDetalhes.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 241, 238);
            btnVerDetalhes.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 241, 238);
            btnVerDetalhes.FlatStyle = FlatStyle.Flat;
            btnVerDetalhes.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            btnVerDetalhes.ForeColor = Color.White;
            btnVerDetalhes.Location = new Point(332, 509);
            btnVerDetalhes.Name = "btnVerDetalhes";
            btnVerDetalhes.Size = new Size(194, 98);
            btnVerDetalhes.TabIndex = 3;
            btnVerDetalhes.Text = "Exibir detalhes";
            btnVerDetalhes.UseVisualStyleBackColor = true;
            btnVerDetalhes.Click += btnVerDetalhes_Click;
            // 
            // listViewPedidos
            // 
            listViewPedidos.BackColor = Color.FromArgb(202, 196, 183);
            listViewPedidos.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            listViewPedidos.ForeColor = SystemColors.WindowText;
            listViewPedidos.FullRowSelect = true;
            listViewPedidos.GridLines = true;
            listViewPedidos.Location = new Point(108, 102);
            listViewPedidos.Name = "listViewPedidos";
            listViewPedidos.Size = new Size(410, 391);
            listViewPedidos.TabIndex = 4;
            listViewPedidos.UseCompatibleStateImageBehavior = false;
            listViewPedidos.View = View.Details;
            listViewPedidos.SelectedIndexChanged += listViewPedidos_SelectedIndexChanged;
            // 
            // listViewFinalizados
            // 
            listViewFinalizados.BackColor = Color.FromArgb(202, 196, 183);
            listViewFinalizados.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            listViewFinalizados.FullRowSelect = true;
            listViewFinalizados.GridLines = true;
            listViewFinalizados.Location = new Point(625, 102);
            listViewFinalizados.Name = "listViewFinalizados";
            listViewFinalizados.Size = new Size(409, 391);
            listViewFinalizados.TabIndex = 5;
            listViewFinalizados.UseCompatibleStateImageBehavior = false;
            listViewFinalizados.View = View.Details;
            listViewFinalizados.SelectedIndexChanged += listViewFinalizados_SelectedIndexChanged;
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
            label1.Font = new Font("Agrandir Narrow", 20.25F, FontStyle.Bold);
            label1.Location = new Point(174, 52);
            label1.Name = "label1";
            label1.Size = new Size(271, 36);
            label1.TabIndex = 28;
            label1.Text = "HIstorico de pedidos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agrandir Narrow", 20.25F, FontStyle.Bold);
            label2.Location = new Point(722, 52);
            label2.Name = "label2";
            label2.Size = new Size(244, 36);
            label2.TabIndex = 29;
            label2.Text = "Pedidos Entregues";
            // 
            // FormBalcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1330, 663);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(listViewFinalizados);
            Controls.Add(listViewPedidos);
            Controls.Add(btnVerDetalhes);
            Controls.Add(btnMarcarConcluido);
            Name = "FormBalcao";
            Text = "FormBalcao";
            Load += FormBalcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}