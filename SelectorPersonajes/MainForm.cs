namespace SelectorPersonajes;

public partial class MainForm : Form
{
    private IPersonasList list = ListFactory.Create(ListType.Custom);
    private int index;               
    private Persona? selected;      

    private readonly Bitmap placeholder = CreatePlaceholder();

    public MainForm()
    {
        InitializeComponent();

        cmbList.SelectedIndex = 0;

        foreach (var p in Persona.Default()) list.Add(p);
        Refresh();
    }

    private void MainForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        if (picImagen.Image != null && picImagen.Image != placeholder) picImagen.Image.Dispose();
        placeholder.Dispose();
    }

    private static Bitmap CreatePlaceholder()
    {
        var bmp = new Bitmap(300, 300);
        using var g = Graphics.FromImage(bmp);
        g.Clear(Color.Gainsboro);
        using var pen = new Pen(Color.Silver, 4);
        g.DrawRectangle(pen, 2, 2, 296, 296);
        using var fuente = new Font("Segoe UI", 20F, FontStyle.Bold);
        using var formato = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };
        g.DrawString("IMAGEN\n(placeholder)", fuente, Brushes.Gray, new RectangleF(0, 0, 300, 300), formato);
        return bmp;
    }

    // EVENTOS
    // Tambien se usan las flechas ← → para navegar 
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (ActiveControl is not ComboBox)
        {
            if (keyData == Keys.Left) { Move(-1); return true; }
            if (keyData == Keys.Right) { Move(1); return true; }
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }

    private void cmbList_SelectedIndexChanged(object? sender, EventArgs e)
    {
        var type = (ListType)cmbList.SelectedIndex;
        if (type == list.Type) return;

        list = ListFactory.Convert(list, type);   
        ActiveControl = btnNext;                   
        Refresh();
    }

    private void btnBenchmark_Click(object? sender, EventArgs e)
    {
        using var dlg = new BenchmarkForm(list.Iterate().ToList());
        dlg.ShowDialog(this);
    }

    private void btnPrevious_Click(object? sender, EventArgs e) => Move(-1);

    private void btnNext_Click(object? sender, EventArgs e) => Move(1);

    private void btnSelect_Click(object? sender, EventArgs e)
    {
        if (index == list.Count) return;
        selected = list[index];
        Refresh();
    }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        if (index != list.Count) return;

        using var dlg = new EditorForm(null);
        if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Result != null)
        {
            list.Add(dlg.Result);
            index = list.Count - 1;
            Refresh();
        }
    }

    private void btnEdit_Click(object? sender, EventArgs e)
    {
        if (index == list.Count) return;

        var persona = list[index];
        using var dlg = new EditorForm(persona);
        if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Result != null)
        {
            persona.CopyFrom(dlg.Result);   
            Refresh();
        }
    }

    private void btnDelete_Click(object? sender, EventArgs e)
    {
        if (index == list.Count) return;

        var persona = list[index];
        var response = MessageBox.Show(this,
            $"¿Seguro que quieres eliminar a '{persona.Name}'?",
            "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (response != DialogResult.Yes) return;

        list.DeleteIn(index);   
        if (selected == persona) selected = null;
        Refresh();
    }

    private void btnLevelOrder_Click(object? sender, EventArgs e) => Order(Criteria.NivelDesc);

    private void btnAtackOrder_Click(object? sender, EventArgs e) => Order(Criteria.DanoDesc);

    private void btnSpeedOrder_Click(object? sender, EventArgs e) => Order(Criteria.VelocidadAsc);

    // ───────────────────────── Lógica ─────────────────────────

    private void Move(int direction)
    {
        int total = list.Count + 1;
        index = (index + direction + total) % total; 
        Refresh();
    }

    private void Order(Comparison<Persona> criteria)
    {
        var selected = index < list.Count ? list[index] : null;
        list.Order(criteria);

       
        if (selected != null) index = list.Index(selected);

        Refresh();
    }

    // ───────────────────────── Vista ─────────────────────────

    private void Refresh() 
    {
        bool IsAdd = index == list.Count;
        var p = IsAdd ? null : list[index];

        lblSelected.Text = selected == null
            ? "Ningún persona elegido"
            : $"Persona elegido: {selected.Name}";

        lblPosition.Text = $"{index + 1} / {list.Count + 1}   ·   {list.Name}";

        if (p == null)
        {
            lblName.Text = "★ Añadir nuevo persona";
            lblSpecies.Text = lblDano.Text = lblSpeed.Text = lblLevel.Text = "";
        }
        else
        {
            lblName.Text = p.Name;
            lblSpecies.Text = $"Especie: {p.Species}";
            lblDano.Text = $"Ataque: {p.Attack}";
            lblSpeed.Text = $"Velocidad de ataque: {p.AtackSpeed:0.##}";
            lblLevel.Text = $"Nivel: {p.Level}";
        }

        btnAdd.Enabled = IsAdd;
        btnEdit.Enabled = !IsAdd;
        btnDelete.Enabled = !IsAdd;
        btnSelect.Enabled = !IsAdd;

        ShowImage(p);
    }

    private void ShowImage(Persona? p)
    {
        var previous = picImagen.Image;
        Image @new = placeholder;

        if (p?.ImagePath is { } path && File.Exists(path))
        {
            try
            {
                using var temporal = Image.FromFile(path);
                @new = new Bitmap(temporal);   
            }
            catch
            {
                @new = placeholder;
            }
        }

        picImagen.Image = @new;
        if (previous != null && previous != placeholder && previous != @new)
            previous.Dispose();
    }
}
