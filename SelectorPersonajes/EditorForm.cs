namespace SelectorPersonajes;

public partial class EditorForm : Form
{
    private readonly bool IsNew;
    private readonly string? imagePath;
    public Persona? Result { get; private set; }
    public EditorForm() : this(null) { }
    public EditorForm(Persona? original)
    {
        InitializeComponent();

        IsNew = original == null;
        imagePath = original?.ImagePath;
        Text = IsNew ? "Nuevo personaje" : "Editar personaje";

        cmbSpecies.Items.Clear();
        cmbSpecies.Items.AddRange(Persona.EspeciesBase);

        if (original != null)
        {
            txtName.Text = original.Name;
            cmbSpecies.Text = original.Species;
            nudAttack.Value = Math.Clamp(original.Attack, (int)nudAttack.Minimum, (int)nudAttack.Maximum);
            nudAttackSpeed.Value = Math.Clamp((decimal)original.AtackSpeed, nudAttackSpeed.Minimum, nudAttackSpeed.Maximum);
            nudLevel.Value = Math.Clamp(original.Level, (int)nudLevel.Minimum, (int)nudLevel.Maximum);
        }
        else
        {
            cmbSpecies.SelectedIndex = 0;
            nudAttack.Value = 10;
            nudAttackSpeed.Value = 1M;
            nudLevel.Value = 1;
        }
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        string species = cmbSpecies.Text.Trim();

        if (name == "")
        {
            MessageBox.Show(this, "El name no puede estar vacío.", "Dato requerido",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtName.Focus();
            return;
        }

        if (species == "")
        {
            MessageBox.Show(this, "La species no puede estar vacía.", "Dato requerido",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cmbSpecies.Focus();
            return;
        }

        var response = MessageBox.Show(this,
            IsNew ? "¿Guardar el nuevo personaje?" : "¿Guardar los cambios de este personaje?",
            "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (response != DialogResult.Yes) return;

        Result = new Persona(name, species, (int)nudAttack.Value, (double)nudAttackSpeed.Value, (int)nudLevel.Value)
        {
            ImagePath = imagePath
        };

        DialogResult = DialogResult.OK;   
    }
}
