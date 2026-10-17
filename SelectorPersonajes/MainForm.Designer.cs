#nullable disable
namespace SelectorPersonajes
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            tlpRaiz = new TableLayoutPanel();
            tlpBarra = new TableLayoutPanel();
            lblLista = new Label();
            cmbList = new ComboBox();
            btnBenchmark = new Button();
            lblSelected = new Label();
            lblPosition = new Label();
            tlpTarjeta = new TableLayoutPanel();
            btnAnterior = new Button();
            tlpCentro = new TableLayoutPanel();
            picImagen = new PictureBox();
            lblName = new Label();
            lblSpecies = new Label();
            lblDano = new Label();
            lblSpeed = new Label();
            lblLevel = new Label();
            btnNext = new Button();
            tlpAcciones = new TableLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            tlpOrden = new TableLayoutPanel();
            btnOrdenNivel = new Button();
            btnOrdenDano = new Button();
            btnOrdenVelocidad = new Button();
            btnSelect = new Button();
            tlpRaiz.SuspendLayout();
            tlpBarra.SuspendLayout();
            tlpTarjeta.SuspendLayout();
            tlpCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            tlpAcciones.SuspendLayout();
            tlpOrden.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRaiz
            // 
            tlpRaiz.ColumnCount = 1;
            tlpRaiz.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRaiz.Controls.Add(tlpBarra, 0, 0);
            tlpRaiz.Controls.Add(lblSelected, 0, 1);
            tlpRaiz.Controls.Add(lblPosition, 0, 2);
            tlpRaiz.Controls.Add(tlpTarjeta, 0, 3);
            tlpRaiz.Controls.Add(tlpAcciones, 0, 4);
            tlpRaiz.Controls.Add(tlpOrden, 0, 5);
            tlpRaiz.Controls.Add(btnSelect, 0, 6);
            tlpRaiz.Dock = DockStyle.Fill;
            tlpRaiz.Location = new Point(0, 0);
            tlpRaiz.Name = "tlpRaiz";
            tlpRaiz.Padding = new Padding(12);
            tlpRaiz.RowCount = 7;
            tlpRaiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpRaiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpRaiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpRaiz.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRaiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpRaiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpRaiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tlpRaiz.Size = new Size(500, 730);
            tlpRaiz.TabIndex = 0;
            // 
            // tlpBarra
            // 
            tlpBarra.ColumnCount = 3;
            tlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tlpBarra.Controls.Add(lblLista, 0, 0);
            tlpBarra.Controls.Add(cmbList, 1, 0);
            tlpBarra.Controls.Add(btnBenchmark, 2, 0);
            tlpBarra.Dock = DockStyle.Fill;
            tlpBarra.Location = new Point(15, 15);
            tlpBarra.Name = "tlpBarra";
            tlpBarra.RowCount = 1;
            tlpBarra.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBarra.Size = new Size(470, 38);
            tlpBarra.TabIndex = 0;
            // 
            // lblLista
            // 
            lblLista.Dock = DockStyle.Fill;
            lblLista.Location = new Point(3, 0);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(49, 38);
            lblLista.TabIndex = 0;
            lblLista.Text = "Lista:";
            lblLista.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbList
            // 
            cmbList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbList.FormattingEnabled = true;
            cmbList.Items.AddRange(new object[] { "Lista personalizada (nodos)", "LinkedList<T>", "List<T>" });
            cmbList.Location = new Point(58, 5);
            cmbList.Name = "cmbList";
            cmbList.Size = new Size(279, 31);
            cmbList.TabIndex = 1;
            cmbList.SelectedIndexChanged += cmbList_SelectedIndexChanged;
            // 
            // btnBenchmark
            // 
            btnBenchmark.Dock = DockStyle.Fill;
            btnBenchmark.Location = new Point(344, 4);
            btnBenchmark.Margin = new Padding(4);
            btnBenchmark.Name = "btnBenchmark";
            btnBenchmark.Size = new Size(122, 30);
            btnBenchmark.TabIndex = 2;
            btnBenchmark.Text = "Benchmark…";
            btnBenchmark.UseVisualStyleBackColor = true;
            btnBenchmark.Click += btnBenchmark_Click;
            // 
            // lblSelected
            // 
            lblSelected.Dock = DockStyle.Fill;
            lblSelected.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelected.Location = new Point(15, 56);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(470, 50);
            lblSelected.TabIndex = 1;
            lblSelected.Text = "Ningún personaje elegido";
            lblSelected.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPosition
            // 
            lblPosition.Dock = DockStyle.Fill;
            lblPosition.ForeColor = Color.Gray;
            lblPosition.Location = new Point(15, 106);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(470, 28);
            lblPosition.TabIndex = 2;
            lblPosition.Text = "1 / 6   ·   Lista personalizada (nodos)";
            lblPosition.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpTarjeta
            // 
            tlpTarjeta.ColumnCount = 3;
            tlpTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tlpTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tlpTarjeta.Controls.Add(btnAnterior, 0, 0);
            tlpTarjeta.Controls.Add(tlpCentro, 1, 0);
            tlpTarjeta.Controls.Add(btnNext, 2, 0);
            tlpTarjeta.Dock = DockStyle.Fill;
            tlpTarjeta.Location = new Point(15, 137);
            tlpTarjeta.Name = "tlpTarjeta";
            tlpTarjeta.RowCount = 1;
            tlpTarjeta.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTarjeta.Size = new Size(470, 426);
            tlpTarjeta.TabIndex = 3;
            // 
            // btnAnterior
            // 
            btnAnterior.Dock = DockStyle.Fill;
            btnAnterior.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.Location = new Point(4, 4);
            btnAnterior.Margin = new Padding(4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(48, 418);
            btnAnterior.TabIndex = 0;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnPrevious_Click;
            // 
            // tlpCentro
            // 
            tlpCentro.ColumnCount = 1;
            tlpCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCentro.Controls.Add(picImagen, 0, 0);
            tlpCentro.Controls.Add(lblName, 0, 1);
            tlpCentro.Controls.Add(lblSpecies, 0, 2);
            tlpCentro.Controls.Add(lblDano, 0, 3);
            tlpCentro.Controls.Add(lblSpeed, 0, 4);
            tlpCentro.Controls.Add(lblLevel, 0, 5);
            tlpCentro.Dock = DockStyle.Fill;
            tlpCentro.Location = new Point(59, 3);
            tlpCentro.Name = "tlpCentro";
            tlpCentro.RowCount = 6;
            tlpCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCentro.Size = new Size(352, 420);
            tlpCentro.TabIndex = 1;
            // 
            // picImagen
            // 
            picImagen.BackColor = Color.Gainsboro;
            picImagen.BorderStyle = BorderStyle.FixedSingle;
            picImagen.Dock = DockStyle.Fill;
            picImagen.Location = new Point(6, 6);
            picImagen.Margin = new Padding(6);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(340, 258);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(3, 270);
            lblName.Name = "lblName";
            lblName.Size = new Size(346, 30);
            lblName.TabIndex = 1;
            lblName.Text = "Arthur";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSpecies
            // 
            lblSpecies.Dock = DockStyle.Fill;
            lblSpecies.Location = new Point(3, 300);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(346, 30);
            lblSpecies.TabIndex = 2;
            lblSpecies.Text = "Species: Caballero";
            lblSpecies.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDano
            // 
            lblDano.Dock = DockStyle.Fill;
            lblDano.Location = new Point(3, 330);
            lblDano.Name = "lblDano";
            lblDano.Size = new Size(346, 30);
            lblDano.TabIndex = 3;
            lblDano.Text = "Attack: 45";
            lblDano.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSpeed
            // 
            lblSpeed.Dock = DockStyle.Fill;
            lblSpeed.Location = new Point(3, 360);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(346, 30);
            lblSpeed.TabIndex = 4;
            lblSpeed.Text = "Velocidad de ataque: 1.2";
            lblSpeed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLevel
            // 
            lblLevel.Dock = DockStyle.Fill;
            lblLevel.Location = new Point(3, 390);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(346, 30);
            lblLevel.TabIndex = 5;
            lblLevel.Text = "Level: 12";
            lblLevel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Dock = DockStyle.Fill;
            btnNext.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(418, 4);
            btnNext.Margin = new Padding(4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(48, 418);
            btnNext.TabIndex = 2;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // tlpAcciones
            // 
            tlpAcciones.ColumnCount = 3;
            tlpAcciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpAcciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpAcciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpAcciones.Controls.Add(btnAdd, 0, 0);
            tlpAcciones.Controls.Add(btnEdit, 1, 0);
            tlpAcciones.Controls.Add(btnDelete, 2, 0);
            tlpAcciones.Dock = DockStyle.Fill;
            tlpAcciones.Location = new Point(15, 569);
            tlpAcciones.Name = "tlpAcciones";
            tlpAcciones.RowCount = 1;
            tlpAcciones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAcciones.Size = new Size(470, 42);
            tlpAcciones.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(4, 4);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(148, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Location = new Point(160, 4);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(148, 34);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(316, 4);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tlpOrden
            // 
            tlpOrden.ColumnCount = 3;
            tlpOrden.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpOrden.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpOrden.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpOrden.Controls.Add(btnOrdenNivel, 0, 0);
            tlpOrden.Controls.Add(btnOrdenDano, 1, 0);
            tlpOrden.Controls.Add(btnOrdenVelocidad, 2, 0);
            tlpOrden.Dock = DockStyle.Fill;
            tlpOrden.Location = new Point(15, 617);
            tlpOrden.Name = "tlpOrden";
            tlpOrden.RowCount = 1;
            tlpOrden.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpOrden.Size = new Size(470, 42);
            tlpOrden.TabIndex = 5;
            // 
            // btnOrdenNivel
            // 
            btnOrdenNivel.Dock = DockStyle.Fill;
            btnOrdenNivel.Location = new Point(4, 4);
            btnOrdenNivel.Margin = new Padding(4);
            btnOrdenNivel.Name = "btnOrdenNivel";
            btnOrdenNivel.Size = new Size(148, 34);
            btnOrdenNivel.TabIndex = 0;
            btnOrdenNivel.Text = "Level ↓";
            btnOrdenNivel.UseVisualStyleBackColor = true;
            btnOrdenNivel.Click += btnLevelOrder_Click;
            // 
            // btnOrdenDano
            // 
            btnOrdenDano.Dock = DockStyle.Fill;
            btnOrdenDano.Location = new Point(160, 4);
            btnOrdenDano.Margin = new Padding(4);
            btnOrdenDano.Name = "btnOrdenDano";
            btnOrdenDano.Size = new Size(148, 34);
            btnOrdenDano.TabIndex = 1;
            btnOrdenDano.Text = "Attack ↓";
            btnOrdenDano.UseVisualStyleBackColor = true;
            btnOrdenDano.Click += btnAtackOrder_Click;
            // 
            // btnOrdenVelocidad
            // 
            btnOrdenVelocidad.Dock = DockStyle.Fill;
            btnOrdenVelocidad.Location = new Point(316, 4);
            btnOrdenVelocidad.Margin = new Padding(4);
            btnOrdenVelocidad.Name = "btnOrdenVelocidad";
            btnOrdenVelocidad.Size = new Size(150, 34);
            btnOrdenVelocidad.TabIndex = 2;
            btnOrdenVelocidad.Text = "Velocidad ↑";
            btnOrdenVelocidad.UseVisualStyleBackColor = true;
            btnOrdenVelocidad.Click += btnSpeedOrder_Click;
            // 
            // btnSelect
            // 
            btnSelect.Dock = DockStyle.Fill;
            btnSelect.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelect.Location = new Point(16, 666);
            btnSelect.Margin = new Padding(4);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(468, 48);
            btnSelect.TabIndex = 6;
            btnSelect.Text = "Elegir personaje";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 730);
            Controls.Add(tlpRaiz);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(480, 730);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selector de personajes";
            FormClosed += MainForm_FormClosed;
            tlpRaiz.ResumeLayout(false);
            tlpBarra.ResumeLayout(false);
            tlpTarjeta.ResumeLayout(false);
            tlpCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            tlpAcciones.ResumeLayout(false);
            tlpOrden.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpRaiz;
        private TableLayoutPanel tlpBarra;
        private Label lblLista;
        private ComboBox cmbList;
        private Button btnBenchmark;
        private Label lblSelected;
        private Label lblPosition;
        private TableLayoutPanel tlpTarjeta;
        private Button btnAnterior;
        private TableLayoutPanel tlpCentro;
        private PictureBox picImagen;
        private Label lblName;
        private Label lblSpecies;
        private Label lblDano;
        private Label lblSpeed;
        private Label lblLevel;
        private Button btnNext;
        private TableLayoutPanel tlpAcciones;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TableLayoutPanel tlpOrden;
        private Button btnOrdenNivel;
        private Button btnOrdenDano;
        private Button btnOrdenVelocidad;
        private Button btnSelect;
    }
}
