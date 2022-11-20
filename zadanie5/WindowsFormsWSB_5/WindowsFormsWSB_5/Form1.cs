using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;

namespace WindowsFormsWSB_5
{
    public partial class Form1 : Form
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nursa\source\repos\WinForms\zadanie5\WindowsFormsWSB_5\WindowsFormsWSB_5\company.mdf;Integrated Security=True;Connect Timeout=30";
        static DataContext bazaDanychFirma = new DataContext(connectionString);
        static Table<Pracownik> listaPracownikow = bazaDanychFirma.GetTable<Pracownik>();
        static Table<Kontrahent> listaKontrahentow = bazaDanychFirma.GetTable<Kontrahent>();
        static Table<FakturySprzedazy> listaFakturSprzedazy = bazaDanychFirma.GetTable<FakturySprzedazy>();

        public Form1()
        {
            InitializeComponent();
            gpEmployee.Visible = false;
            gpVentors.Visible = false;
            gpInvoices.Visible = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (gpVentors.Visible)
            {
                int wiersz = Convert.ToInt32(dataGridView1.CurrentRow.Index);
                string nazwa = dataGridView1.Rows[wiersz].Cells[1].Value.ToString();
                string nip = dataGridView1.Rows[wiersz].Cells[2].Value.ToString();
                string ulica = dataGridView1.Rows[wiersz].Cells[3].Value.ToString();
                string miasto = dataGridView1.Rows[wiersz].Cells[4].Value.ToString();
                int idKontrahent = Convert.ToInt32(dataGridView1.Rows[wiersz].Cells[0].Value.ToString());

                txtName.Text = nazwa;
                txtNip.Text = nip;
                txtStreet.Text = ulica;
                txtCity.Text = miasto;

                var ls = from FakturySprzedazy in listaFakturSprzedazy
                         where (FakturySprzedazy.KontrahentId == idKontrahent)
                         select new
                         {
                             FakturySprzedazy.Id,
                             FakturySprzedazy.Numer,
                             FakturySprzedazy.Netto,
                             FakturySprzedazy.Vat,
                             FakturySprzedazy.Data,
                             FakturySprzedazy.Zaplacono
                         };

                dataGridView2.DataSource = ls;
            }
            else if (gpEmployee.Visible)
            {
                int wiersz = Convert.ToInt32(dataGridView1.CurrentRow.Index);
                string imie = dataGridView1.Rows[wiersz].Cells[1].Value.ToString();
                string nazwisko = dataGridView1.Rows[wiersz].Cells[2].Value.ToString();
                string email = dataGridView1.Rows[wiersz].Cells[3].Value.ToString();
                string telefon = dataGridView1.Rows[wiersz].Cells[4].Value.ToString();
                int idPracownik = Convert.ToInt32(dataGridView1.Rows[wiersz].Cells[0].Value.ToString());

                txtFirstName.Text = imie;
                txtLastName.Text = nazwisko;
                txtEmail.Text = email;
                txtPhone.Text = telefon;

                var ls = from FakturySprzedazy in listaFakturSprzedazy
                         where (FakturySprzedazy.PracownikId == idPracownik)
                         select new
                         {
                             FakturySprzedazy.Id,
                             FakturySprzedazy.Numer,
                             FakturySprzedazy.Netto,
                             FakturySprzedazy.Vat,
                             FakturySprzedazy.Data,
                             FakturySprzedazy.Zaplacono
                         };

                dataGridView2.DataSource = ls;
            }
            else
            {
                int wiersz = Convert.ToInt32(dataGridView1.CurrentRow.Index);
                int idFaktury = Convert.ToInt32(dataGridView1.Rows[wiersz].Cells[0].Value.ToString());
                string number = dataGridView1.Rows[wiersz].Cells[1].Value.ToString();
                string netto = dataGridView1.Rows[wiersz].Cells[2].Value.ToString();
                string vat = dataGridView1.Rows[wiersz].Cells[3].Value.ToString();
                string date = dataGridView1.Rows[wiersz].Cells[4].Value.ToString();
                
                string paid;
                if (dataGridView1.Rows[wiersz].Cells[5].Value == null)
                {
                    paid = "0";
                }
                else
                {
                    paid = dataGridView1.Rows[wiersz].Cells[5].Value.ToString();
                };

                string kontrahentId = dataGridView1.Rows[wiersz].Cells[6].Value.ToString();
                string employeeId = dataGridView1.Rows[wiersz].Cells[7].Value.ToString();

                txtNumber.Text = number;
                txtNetto.Text = netto;
                txtVat.Text = vat;  
                dtpDate.Text = date;
                txtPaid.Text = paid;
                cbVendor.SelectedValue = Convert.ToInt32(kontrahentId);
                cbEmployee.SelectedValue = Convert.ToInt32(employeeId);
            }
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1_Click(this, null);
        }


        #region Employees
        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            gpVentors.Visible = false;
            gpInvoices.Visible = false;
            gpEmployee.Visible = true;

            var lp = from Pracownik in listaPracownikow
                     orderby Pracownik.Nazwisko
                     select new
                     {
                         Pracownik.Id,
                         Pracownik.Imie,
                         Pracownik.Nazwisko,
                         Pracownik.Telefon,
                         Pracownik.Email
                     };
            dataGridView1.DataSource = lp;
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int noweId = listaPracownikow.Max(Pracownik => Pracownik.Id) + 1;
            Pracownik nowyPracownik = new Pracownik
            {
                Id = noweId,
                Imie = txtFirstName.Text,
                Nazwisko = txtLastName.Text,
                Email = txtEmail.Text,
                Telefon = txtPhone.Text,
            };

            listaPracownikow.InsertOnSubmit(nowyPracownik);
            bazaDanychFirma.SubmitChanges();
            listaToolStripMenuItem_Click(this, null);
        }

        private void usunięcieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wiersz = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            int idPracownik = Convert.ToInt32(dataGridView1.Rows[wiersz].Cells[0].Value.ToString());

            IEnumerable<Pracownik> doSkasowania = from pracownik in listaPracownikow
                                                  where pracownik.Id == idPracownik
                                                  select pracownik;

            listaPracownikow.DeleteAllOnSubmit(doSkasowania);
            bazaDanychFirma.SubmitChanges();
            listaToolStripMenuItem_Click(this, null);
        }

        private void edycjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wiersz = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            int idPracownik = Convert.ToInt32(dataGridView1.Rows[wiersz].Cells[0].Value.ToString());

            foreach(Pracownik pracownik in listaPracownikow)
            {
                if (pracownik.Id == idPracownik)
                {
                    pracownik.Imie = txtFirstName.Text;
                    pracownik.Nazwisko = txtLastName.Text;
                    pracownik.Email = txtEmail.Text;
                    pracownik.Telefon = txtPhone.Text;
                }
            }

            bazaDanychFirma.SubmitChanges();
            listaToolStripMenuItem_Click(this, null);
        }
        #endregion

     
        #region Vendors

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            gpVentors.Visible = true;
            gpEmployee.Visible = false;
            gpInvoices.Visible = false;

            var lp = from Kontrahent in listaKontrahentow
                     orderby Kontrahent.Nazwa
                     select new
                     {
                         Kontrahent.Id,
                         Kontrahent.Nazwa,
                         Kontrahent.Nip,
                         Kontrahent.Ulica,
                         Kontrahent.Miasto
                     };

            dataGridView1.DataSource = lp;
        }

        private void nowyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int noweId = listaKontrahentow.Max(Kontrahent => Kontrahent.Id) + 1;
            Kontrahent nowyKontrahent = new Kontrahent
            {
                Nazwa = txtName.Text,
                Nip = txtNip.Text,
                Ulica = txtStreet.Text,
                Miasto = txtCity.Text,
            };

            listaKontrahentow.InsertOnSubmit(nowyKontrahent);
            bazaDanychFirma.SubmitChanges();
            listaToolStripMenuItem1_Click(this, null);
        }

        private void edycjaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int wiersz = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            int idKontrahent = Convert.ToInt32(dataGridView1.Rows[wiersz].Cells[0].Value.ToString());

            foreach (Kontrahent kontrahent in listaKontrahentow)
            {
                if (kontrahent.Id == idKontrahent)
                {
                    kontrahent.Nazwa = txtName.Text;
                    kontrahent.Nip = txtNip.Text;
                    kontrahent.Ulica = txtStreet.Text;
                    kontrahent.Miasto = txtCity.Text;
                }
            }

            bazaDanychFirma.SubmitChanges();
            listaToolStripMenuItem1_Click(this, null);
        }

        private void usunięcieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int wiersz = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            int idKontrahent = Convert.ToInt32(dataGridView1.Rows[wiersz].Cells[0].Value.ToString());

            IEnumerable<Kontrahent> doSkasowania = from kontrahent in listaKontrahentow
                                                  where kontrahent.Id == idKontrahent
                                                  select kontrahent;

            listaKontrahentow.DeleteAllOnSubmit(doSkasowania);
            bazaDanychFirma.SubmitChanges();
            listaToolStripMenuItem1_Click(this, null);
        }
        #endregion


        #region Invoices
        private void listaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            cbVendor.DataSource = null;
            cbEmployee.DataSource = null;
            gpVentors.Visible = false;
            gpEmployee.Visible = false;
            gpInvoices.Visible = true;

            var lp = from FakturaSprzedazy in listaFakturSprzedazy
                     orderby FakturaSprzedazy.Numer
                     select new
                     {
                         FakturaSprzedazy.Id,
                         FakturaSprzedazy.Numer,
                         FakturaSprzedazy.Netto,
                         FakturaSprzedazy.Vat,
                         FakturaSprzedazy.Data,
                         FakturaSprzedazy.Zaplacono,
                         FakturaSprzedazy.KontrahentId,
                         FakturaSprzedazy.PracownikId,
                     };


            var emp = from Pracownik in listaPracownikow
                      orderby Pracownik.Nazwisko
                      select new
                      {
                          Pracownik.Id,
                          Name = $"{Pracownik.Imie}_{Pracownik.Nazwisko}",
                      };

            var vendor = from Kontrahent in listaKontrahentow
                         orderby Kontrahent.Nazwa
                         select new
                         {
                             Kontrahent.Id,
                             Name = Kontrahent.Nazwa,
                         };

            cbEmployee.DataSource = emp;
            cbVendor.DataSource = vendor;
            dataGridView1.DataSource = lp;
        }
       

        private void nowaFakturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int noweId = listaFakturSprzedazy.Max(FakturySprzedazy => FakturySprzedazy.Id) + 1;
            FakturySprzedazy nowaFakturaSprzedazy = new FakturySprzedazy
            {
                Numer = txtNumber.Text,
                Netto = Convert.ToDouble(txtNetto.Text),
                Vat = Convert.ToDouble(txtVat.Text),
                Data = Convert.ToDateTime(dtpDate.Value.ToString()),
                Zaplacono = Convert.ToDouble(txtPaid.Text),
                KontrahentId = (int)cbVendor.SelectedValue,
                PracownikId = (int)cbEmployee.SelectedValue,
            };

            listaFakturSprzedazy.InsertOnSubmit(nowaFakturaSprzedazy);
            bazaDanychFirma.SubmitChanges();
            listaToolStripMenuItem2_Click(this, null);
        }

        private void edycjaFakturyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wiersz = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            int idFakturaSprzedazy = Convert.ToInt32(dataGridView1.Rows[wiersz].Cells[0].Value.ToString());

            foreach (FakturySprzedazy FakturaSprzedazy in listaFakturSprzedazy)
            {
                if (FakturaSprzedazy.Id == idFakturaSprzedazy)
                {
                    FakturaSprzedazy.Numer = txtNumber.Text;
                    FakturaSprzedazy.Netto = Convert.ToDouble(txtNetto.Text);
                    FakturaSprzedazy.Vat = Convert.ToDouble(txtVat.Text);
                    FakturaSprzedazy.Data = Convert.ToDateTime(dtpDate.Value.ToString());
                    FakturaSprzedazy.Zaplacono = Convert.ToDouble(txtPaid.Text);
                    FakturaSprzedazy.KontrahentId = (int)cbVendor.SelectedValue;
                    FakturaSprzedazy.PracownikId = (int)cbEmployee.SelectedValue;
                }
            }

            bazaDanychFirma.SubmitChanges();
            listaToolStripMenuItem2_Click(this, null);
        }

        private void usunięcieFakturyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wiersz = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            int idFakturaSprzedazy = Convert.ToInt32(dataGridView1.Rows[wiersz].Cells[0].Value.ToString());

            IEnumerable<FakturySprzedazy> doSkasowania = from fakturaSprzedazy in listaFakturSprzedazy
                                                   where fakturaSprzedazy.Id == idFakturaSprzedazy
                                                   select fakturaSprzedazy;

            listaFakturSprzedazy.DeleteAllOnSubmit(doSkasowania);
            bazaDanychFirma.SubmitChanges();
            listaToolStripMenuItem2_Click(this, null);
        }
        #endregion

        private void nieuregolowanafakturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = null;
            gpVentors.Visible = false;
            gpEmployee.Visible = false;
            gpInvoices.Visible = false;

            var lp = from FakturaSprzedazy in listaFakturSprzedazy
                     where FakturaSprzedazy.Netto + FakturaSprzedazy.Vat > FakturaSprzedazy.Zaplacono || FakturaSprzedazy.Zaplacono == null
                     orderby FakturaSprzedazy.Numer
                     select new
                     {
                         FakturaSprzedazy.Id,
                         FakturaSprzedazy.Numer,
                         FakturaSprzedazy.Netto,
                         FakturaSprzedazy.Vat,
                         FakturaSprzedazy.Data,
                         FakturaSprzedazy.Zaplacono,
                         FakturaSprzedazy.KontrahentId,
                         FakturaSprzedazy.PracownikId,
                     };

            dataGridView2.DataSource = lp;
        }
    }
}
