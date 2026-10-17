#nullable disable
namespace SelectorPersonajes
{
    partial class BenchmarkForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelSuperior = new Panel();
            lblCantidad = new Label();
            nudQuantity = new NumericUpDown();
            lblRepeticiones = new Label();
            nudRepetitions = new NumericUpDown();
            btnExecute = new Button();
            lblState = new Label();
            dgvResults = new DataGridView();
            colOperacion = new DataGridViewTextBoxColumn();
            colPersonalizada = new DataGridViewTextBoxColumn();
            colLinkedList = new DataGridViewTextBoxColumn();
            colList = new DataGridViewTextBoxColumn();
            colDetalle = new DataGridViewTextBoxColumn();
            lblVerification = new Label();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRepetitions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(btnExecute);
            panelSuperior.Controls.Add(nudRepetitions);
            panelSuperior.Controls.Add(lblRepeticiones);
            panelSuperior.Controls.Add(nudQuantity);
            panelSuperior.Controls.Add(lblCantidad);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(12, 12);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(976, 52);
            panelSuperior.TabIndex = 0;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(0, 14);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(172, 23);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Quantity de personajes:";
            // 
            // nudQuantity
            // 
            nudQuantity.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            nudQuantity.Location = new Point(180, 11);
            nudQuantity.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 30);
            nudQuantity.TabIndex = 1;
            nudQuantity.ThousandsSeparator = true;
            nudQuantity.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // lblRepeticiones
            // 
            lblRepeticiones.AutoSize = true;
            lblRepeticiones.Location = new Point(330, 14);
            lblRepeticiones.Name = "lblRepeticiones";
            lblRepeticiones.Size = new Size(107, 23);
            lblRepeticiones.TabIndex = 2;
            lblRepeticiones.Text = "Repetitions:";
            // 
            // nudRepetitions
            // 
            nudRepetitions.Location = new Point(445, 11);
            nudRepetitions.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudRepetitions.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRepetitions.Name = "nudRepetitions";
            nudRepetitions.Size = new Size(70, 30);
            nudRepetitions.TabIndex = 3;
            nudRepetitions.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(545, 8);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(180, 36);
            btnExecute.TabIndex = 4;
            btnExecute.Text = "Execute benchmark";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnEjecutar_Click;
            // 
            // lblState
            // 
            lblState.Dock = DockStyle.Top;
            lblState.Location = new Point(12, 64);
            lblState.Name = "lblState";
            lblState.Size = new Size(976, 30);
            lblState.TabIndex = 1;
            lblState.Text = "Estado";
            lblState.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AllowUserToResizeRows = false;
            dgvResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvResults.BackgroundColor = SystemColors.Window;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { colOperacion, colPersonalizada, colLinkedList, colList, colDetalle });
            dgvResults.Dock = DockStyle.Fill;
            dgvResults.Location = new Point(12, 94);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersVisible = false;
            dgvResults.Size = new Size(976, 418);
            dgvResults.TabIndex = 2;
            // 
            // colOperacion
            // 
            colOperacion.HeaderText = "Operación";
            colOperacion.Name = "colOperacion";
            colOperacion.ReadOnly = true;
            colOperacion.SortMode = DataGridViewColumnSortMode.NotSortable;
            colOperacion.Width = 230;
            // 
            // colPersonalizada
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPersonalizada.DefaultCellStyle = dataGridViewCellStyle1;
            colPersonalizada.HeaderText = "Custom (ms)";
            colPersonalizada.Name = "colPersonalizada";
            colPersonalizada.ReadOnly = true;
            colPersonalizada.SortMode = DataGridViewColumnSortMode.NotSortable;
            colPersonalizada.Width = 150;
            // 
            // colLinkedList
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            colLinkedList.DefaultCellStyle = dataGridViewCellStyle2;
            colLinkedList.HeaderText = "LinkedList<T> (ms)";
            colLinkedList.Name = "colLinkedList";
            colLinkedList.ReadOnly = true;
            colLinkedList.SortMode = DataGridViewColumnSortMode.NotSortable;
            colLinkedList.Width = 150;
            // 
            // colList
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colList.DefaultCellStyle = dataGridViewCellStyle3;
            colList.HeaderText = "List<T> (ms)";
            colList.Name = "colList";
            colList.ReadOnly = true;
            colList.SortMode = DataGridViewColumnSortMode.NotSortable;
            colList.Width = 150;
            // 
            // colDetalle
            // 
            colDetalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            colDetalle.DefaultCellStyle = dataGridViewCellStyle4;
            colDetalle.HeaderText = "Estadística calculada";
            colDetalle.Name = "colDetalle";
            colDetalle.ReadOnly = true;
            colDetalle.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // lblVerification
            // 
            lblVerification.Dock = DockStyle.Bottom;
            lblVerification.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVerification.Location = new Point(12, 512);
            lblVerification.Name = "lblVerification";
            lblVerification.Size = new Size(976, 36);
            lblVerification.TabIndex = 3;
            lblVerification.Text = "Verificación";
            lblVerification.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BenchmarkForm
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 560);
            Controls.Add(dgvResults);
            Controls.Add(lblVerification);
            Controls.Add(lblState);
            Controls.Add(panelSuperior);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(840, 500);
            Name = "BenchmarkForm";
            Padding = new Padding(12);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Benchmark de listas";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRepetitions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label lblCantidad;
        private NumericUpDown nudQuantity;
        private Label lblRepeticiones;
        private NumericUpDown nudRepetitions;
        private Button btnExecute;
        private Label lblState;
        private DataGridView dgvResults;
        private DataGridViewTextBoxColumn colOperacion;
        private DataGridViewTextBoxColumn colPersonalizada;
        private DataGridViewTextBoxColumn colLinkedList;
        private DataGridViewTextBoxColumn colList;
        private DataGridViewTextBoxColumn colDetalle;
        private Label lblVerification;
    }
}
