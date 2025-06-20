
namespace CARDAPIO_POO
{
    partial class FormEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoque));
            listViewEstoque = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btnRemover = new Button();
            btnAdicionar = new Button();
            quantidadeTxt = new TextBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // listViewEstoque
            // 
            listViewEstoque.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewEstoque.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            listViewEstoque.FullRowSelect = true;
            listViewEstoque.GridLines = true;
            listViewEstoque.Location = new Point(22, 174);
            listViewEstoque.Name = "listViewEstoque";
            listViewEstoque.Size = new Size(976, 553);
            listViewEstoque.TabIndex = 0;
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
            // btnRemover
            // 
            btnRemover.BackColor = Color.White;
            btnRemover.BackgroundImage = (Image)resources.GetObject("btnRemover.BackgroundImage");
            btnRemover.BackgroundImageLayout = ImageLayout.Stretch;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatAppearance.MouseDownBackColor = Color.White;
            btnRemover.FlatAppearance.MouseOverBackColor = Color.White;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(1110, 413);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(185, 82);
            btnRemover.TabIndex = 35;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.White;
            btnAdicionar.BackgroundImage = (Image)resources.GetObject("btnAdicionar.BackgroundImage");
            btnAdicionar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatAppearance.MouseDownBackColor = Color.White;
            btnAdicionar.FlatAppearance.MouseOverBackColor = Color.White;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(1110, 325);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(185, 82);
            btnAdicionar.TabIndex = 34;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // quantidadeTxt
            // 
            quantidadeTxt.BackColor = Color.Gainsboro;
            quantidadeTxt.Location = new Point(1191, 282);
            quantidadeTxt.Name = "quantidadeTxt";
            quantidadeTxt.Size = new Size(166, 23);
            quantidadeTxt.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1052, 282);
            label2.Name = "label2";
            label2.Size = new Size(133, 24);
            label2.TabIndex = 37;
            label2.Text = "quantidade:";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(1017, 174);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(375, 375);
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Agrandir Narrow Bold", 20.25F, FontStyle.Bold);
            label1.Location = new Point(1089, 210);
            label1.Name = "label1";
            label1.Size = new Size(241, 36);
            label1.TabIndex = 40;
            label1.Text = "Modificar Estoque";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(22, 30);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(203, 70);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 43;
            pictureBox4.TabStop = false;
            // 
            // FormEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 822);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(quantidadeTxt);
            Controls.Add(label2);
            Controls.Add(listViewEstoque);
            Controls.Add(pictureBox3);
            Name = "FormEstoque";
            Text = "Form2";
            Load += FormEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void listViewEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private ListView listViewEstoque;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnRemover;
        private Button btnAdicionar;
        private TextBox quantidadeTxt;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox4;
    }
}