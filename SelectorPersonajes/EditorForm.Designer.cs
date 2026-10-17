#nullable disable
namespace SelectorPersonajes
{
    partial class EditorForm
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
            lblNombre = new Label();
            txtName = new TextBox();
            lblEspecie = new Label();
            cmbSpecies = new ComboBox();
            lblDano = new Label();
            nudAttack = new NumericUpDown();
            lblVelocidad = new Label();
            nudAttackSpeed = new NumericUpDown();
            lblNivel = new Label();
            nudLevel = new NumericUpDown();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAttack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAttackSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLevel).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(190, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 25);
            txtName.TabIndex = 1;
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Location = new Point(20, 68);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(56, 19);
            lblEspecie.TabIndex = 2;
            lblEspecie.Text = "Especie:";
            // 
            // cmbSpecies
            // 
            cmbSpecies.FormattingEnabled = true;
            cmbSpecies.Location = new Point(190, 64);
            cmbSpecies.Name = "cmbSpecies";
            cmbSpecies.Size = new Size(190, 25);
            cmbSpecies.TabIndex = 3;
            // 
            // lblDano
            // 
            lblDano.AutoSize = true;
            lblDano.Location = new Point(20, 112);
            lblDano.Name = "lblDano";
            lblDano.Size = new Size(110, 19);
            lblDano.TabIndex = 4;
            lblDano.Text = "Daño de ataque:";
            // 
            // nudAttack
            // 
            nudAttack.Location = new Point(190, 108);
            nudAttack.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudAttack.Name = "nudAttack";
            nudAttack.Size = new Size(190, 25);
            nudAttack.TabIndex = 5;
            nudAttack.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Location = new Point(20, 156);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(135, 19);
            lblVelocidad.TabIndex = 6;
            lblVelocidad.Text = "Velocidad de ataque:";
            // 
            // nudAttackSpeed
            // 
            nudAttackSpeed.DecimalPlaces = 2;
            nudAttackSpeed.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudAttackSpeed.Location = new Point(190, 152);
            nudAttackSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudAttackSpeed.Name = "nudAttackSpeed";
            nudAttackSpeed.Size = new Size(190, 25);
            nudAttackSpeed.TabIndex = 7;
            nudAttackSpeed.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Location = new Point(20, 200);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(42, 19);
            lblNivel.TabIndex = 8;
            lblNivel.Text = "Nivel:";
            // 
            // nudLevel
            // 
            nudLevel.Location = new Point(190, 196);
            nudLevel.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudLevel.Name = "nudLevel";
            nudLevel.Size = new Size(190, 25);
            nudLevel.TabIndex = 9;
            nudLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(150, 250);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 36);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnSave_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(270, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 36);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // EditorForm
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(400, 306);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(nudLevel);
            Controls.Add(lblNivel);
            Controls.Add(nudAttackSpeed);
            Controls.Add(lblVelocidad);
            Controls.Add(nudAttack);
            Controls.Add(lblDano);
            Controls.Add(cmbSpecies);
            Controls.Add(lblEspecie);
            Controls.Add(txtName);
            Controls.Add(lblNombre);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar personaje";
            ((System.ComponentModel.ISupportInitialize)nudAttack).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAttackSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtName;
        private Label lblEspecie;
        private ComboBox cmbSpecies;
        private Label lblDano;
        private NumericUpDown nudAttack;
        private Label lblVelocidad;
        private NumericUpDown nudAttackSpeed;
        private Label lblNivel;
        private NumericUpDown nudLevel;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
