
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
            listViewEstoque = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btnAdicionar = new Button();
            btnRemover = new Button();
            quantidadeTxt = new TextBox();
            SuspendLayout();
            // 
            // listViewEstoque
            // 
            listViewEstoque.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewEstoque.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            listViewEstoque.FullRowSelect = true;
            listViewEstoque.GridLines = true;
            listViewEstoque.Location = new Point(44, 38);
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
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(1047, 38);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(143, 112);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(1047, 183);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(143, 126);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // quantidadeTxt
            // 
            quantidadeTxt.Location = new Point(1213, 38);
            quantidadeTxt.Name = "quantidadeTxt";
            quantidadeTxt.Size = new Size(191, 23);
            quantidadeTxt.TabIndex = 3;
            // 
            // FormEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1564, 822);
            Controls.Add(quantidadeTxt);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(listViewEstoque);
            Name = "FormEstoque";
            Text = "Form2";
            Load += FormEstoque_Load;
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
        private Button btnAdicionar;
        private Button btnRemover;
        private TextBox quantidadeTxt;
    }
}