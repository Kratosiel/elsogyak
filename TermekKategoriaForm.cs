using elsogyak.Data;
using elsogyak.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elsogyak
{
    public partial class TermekKategoriaForm : Form
    {
        private RendelesDbContext _context;
        public TermekKategoriaForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadKategoriak();
        }
        private void LoadKategoriak()
        {
            // Az összes kategória lekérdezése az adatbázisból
            var kategoriak = (from k in _context.TermekKategoria
                              select k).ToList();

            // TreeView tartalmának törlése
            treeViewkategoria.Nodes.Clear();

            // Főkategóriák hozzáadása a TreeView-hoz
            var fokategoriak = from k in kategoriak
                               where k.SzuloKategoriaId == null
                               select k;

            foreach (var kategoria in fokategoriak)
            {
                var node = CreateTreeNode(kategoria, kategoriak);
                treeViewkategoria.Nodes.Add(node);
            }
        }
        private TreeNode CreateTreeNode(TermekKategoria kategoria, List<TermekKategoria> osszeKategoria)
        {
            // TreeNode létrehozása az aktuális kategóriához
            var node = new TreeNode(kategoria.Nev) { Tag = kategoria };

            // Alkategóriák keresése és hozzáadása
            var alkategoriak = from k in osszeKategoria
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;

            foreach (var gyerekKategoria in alkategoriak)
            {
                node.Nodes.Add(CreateTreeNode(gyerekKategoria, osszeKategoria));
            }

            return node;
        }
        private void treeViewKategoriak_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is TermekKategoria selectedKategoria)
            {
                textBoxKategoriaNev.Text = selectedKategoria.Nev;
                textBoxleiras.Text = selectedKategoria.Leiras;
            }
        }

        private void TermekKategoriaForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!(treeViewkategoria.SelectedNode?.Tag is TermekKategoria selectedKategoria))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxKategoriaNev.Text))
            {
                MessageBox.Show("A név mező nem lehet üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectedKategoria.Nev=textBoxKategoriaNev.Text;
            selectedKategoria.Leiras=textBoxleiras.Text;

            try
            {
                _context.SaveChanges();
                MessageBox.Show("A változások sikeresen mentve!","Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKategoriak();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hiba történt a mentés során: {ex.Message}","Hiba",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
