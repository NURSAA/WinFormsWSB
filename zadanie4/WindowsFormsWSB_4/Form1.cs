using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsWSB_4
{
    public partial class Form1 : Form
    {
        private BindingList<ToDoEntry> entries = new BindingList<ToDoEntry>();

        public Form1()
        {
            InitializeComponent();
            txtTitle.DataBindings.Add("Text", entriesSource, "Title", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpDueDate.DataBindings.Add("Value", entriesSource, "Due", true, DataSourceUpdateMode.OnPropertyChanged);
            entriesSource.DataSource = entries;
            CreateNewItem();
        }

        private void CreateNewItem()
        {
            ToDoEntry entry = (ToDoEntry)entriesSource.AddNew();
            entry.Title = "New task";
            entry.Due = DateTime.Now;
            entriesSource.ResetCurrentItem();
        }

        private void MakeListViewNewEntry(int itemIndex)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add("");
            entriesListView.Items.Insert(itemIndex, item);
        }

        private void RemoveListViewItem(int intemIndex)
        {
            entriesListView.Items.RemoveAt(intemIndex);
        }

        private void UpdateListViewItem(int itemIndex)
        {
            ListViewItem item = entriesListView.Items[itemIndex];
            ToDoEntry entry = entries[itemIndex];
            item.SubItems[0].Text = entry.Title;
            item.SubItems[1].Text = entry.Due.ToString();
        }

        private void entriesSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    MakeListViewNewEntry(e.NewIndex);
                    break;

                case ListChangedType.ItemDeleted:
                    RemoveListViewItem(e.NewIndex);
                    break;

                case ListChangedType.ItemChanged:
                    UpdateListViewItem(e.NewIndex);
                    break;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateNewItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (entriesListView.SelectedIndices.Count != 0)
            {
                int entryIndex = entriesListView.SelectedIndices[0];
                entriesSource.RemoveAt(entryIndex);
            }
        }

        private void entriesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entriesListView.SelectedIndices.Count != 0)
            {
                int entryIndex = entriesListView.SelectedIndices[0];
                entriesSource.Position = entryIndex;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                saveToFile(fileName, entries);
                MessageBox.Show("List saved to file Sucessfully");

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            BindingList<ToDoEntry> list = new BindingList<ToDoEntry>();
            entriesListView.Items.Clear();

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader streamReader = new StreamReader(openFileDialog1.FileName);

                    string row;
                    while ((row = streamReader.ReadLine()) != null)
                    {
                        if (row.Count() > 4)
                        {
                            var tasks = row.Split(';');

                            ToDoEntry entry = new ToDoEntry
                            {
                                Title = tasks[0],
                                Description = tasks[1],
                                Due = Convert.ToDateTime(tasks[2])
                            };

                            //add new items to listView
                            string[] Listrow = { entry.Title, entry.Due.ToString(), entry.Description };
                            ListViewItem item = new ListViewItem(Listrow);
                            entriesListView.Items.Add(item);
                            
                            list.Add(entry);
                        }
                    }
                }

                entries = list;
                entriesSource.DataSource = list;

                MessageBox.Show("List Loaded Sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveToFile(string fileName, BindingList<ToDoEntry> rows)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var row in rows)
                {
                    sw.WriteLine($"{row.Title};{row.Description};{row.Due}\n");
                }
            }
        }
    }
}
