namespace CARDAPIO_POO
{
    partial class FormTelaChamada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaChamada));
            label1 = new Label();
            label2 = new Label();
            listViewPedidosProntos = new ListView();
            columnHeader4 = new ColumnHeader();
            listViewPedidoPreparando = new ListView();
            columnHeader1 = new ColumnHeader();
            btnMarcarConcluido = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Narrow Bold", 20.25F, FontStyle.Bold);
            label1.Location = new Point(253, 79);
            label1.Name = "label1";
            label1.Size = new Size(166, 36);
            label1.TabIndex = 2;
            label1.Text = "Preparando ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agrandir Narrow Bold", 20.25F, FontStyle.Bold);
            label2.Location = new Point(575, 79);
            label2.Name = "label2";
            label2.Size = new Size(263, 36);
            label2.TabIndex = 3;
            label2.Text = "Pronto para Coletar";
            // 
            // listViewPedidosProntos
            // 
            listViewPedidosProntos.BackColor = Color.White;
            listViewPedidosProntos.Columns.AddRange(new ColumnHeader[] { columnHeader4 });
            listViewPedidosProntos.Font = new Font("Inter Medium", 25F, FontStyle.Bold);
            listViewPedidosProntos.ForeColor = Color.Black;
            listViewPedidosProntos.FullRowSelect = true;
            listViewPedidosProntos.GridLines = true;
            listViewPedidosProntos.Location = new Point(575, 131);
            listViewPedidosProntos.MultiSelect = false;
            listViewPedidosProntos.Name = "listViewPedidosProntos";
            listViewPedidosProntos.Size = new Size(355, 412);
            listViewPedidosProntos.TabIndex = 7;
            listViewPedidosProntos.UseCompatibleStateImageBehavior = false;
            listViewPedidosProntos.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cliente";
            columnHeader4.Width = 350;
            // 
            // listViewPedidoPreparando
            // 
            listViewPedidoPreparando.BackColor = Color.White;
            listViewPedidoPreparando.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listViewPedidoPreparando.Font = new Font("Inter Medium", 20F, FontStyle.Bold);
            listViewPedidoPreparando.ForeColor = SystemColors.WindowText;
            listViewPedidoPreparando.FullRowSelect = true;
            listViewPedidoPreparando.GridLines = true;
            listViewPedidoPreparando.Location = new Point(253, 131);
            listViewPedidoPreparando.MultiSelect = false;
            listViewPedidoPreparando.Name = "listViewPedidoPreparando";
            listViewPedidoPreparando.Size = new Size(257, 412);
            listViewPedidoPreparando.TabIndex = 6;
            listViewPedidoPreparando.UseCompatibleStateImageBehavior = false;
            listViewPedidoPreparando.View = View.Details;
            listViewPedidoPreparando.SelectedIndexChanged += listViewPedidosPreparando_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cliente";
            columnHeader1.Width = 250;
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
            btnMarcarConcluido.Location = new Point(170, 664);
            btnMarcarConcluido.Name = "btnMarcarConcluido";
            btnMarcarConcluido.Size = new Size(163, 79);
            btnMarcarConcluido.TabIndex = 8;
            btnMarcarConcluido.Text = "Marcar como concluido";
            btnMarcarConcluido.UseVisualStyleBackColor = false;
            btnMarcarConcluido.Click += btnMarcarConcluido_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(141, 631);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 154);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FormTelaChamada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 797);
            Controls.Add(btnMarcarConcluido);
            Controls.Add(listViewPedidosProntos);
            Controls.Add(listViewPedidoPreparando);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormTelaChamada";
            Text = "FormTelaChamada";
            Load += FormTelaChamada_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ListView listViewPedidosProntos;
        private ColumnHeader columnHeader4;
        private ListView listViewPedidoPreparando;
        private ColumnHeader columnHeader1;
        private Button btnMarcarConcluido;
        private PictureBox pictureBox1;
    }
}