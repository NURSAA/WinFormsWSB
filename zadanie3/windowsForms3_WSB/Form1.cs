using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsForms3_WSB
{
    public partial class Form1 : Form
    {
        object dragDropSource = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lbSender = sender as ListBox;
            //int index = lbSender.IndexFromPoint(e.X, e.Y);
            dragDropSource = sender;

            if (e.Button == MouseButtons.Left && (lbSender.SelectedIndices.Count > 0))
            {
                //DragDropEffects operation = lbSender.DoDragDrop(lbSender.Items[index], DragDropEffects.Copy | DragDropEffects.Move);
                DragDropEffects operation = lbSender.DoDragDrop(lbSender.SelectedItems, DragDropEffects.Copy | DragDropEffects.Move);

                if (operation == DragDropEffects.Move)
                    //lbSender.Items.RemoveAt(index);
                    for (int i = lbSender.SelectedItems.Count - 1; i >= 0; i--)
                        lbSender.Items.Remove(lbSender.SelectedItems[i]);
            }
            dragDropSource = null;
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            if (sender == dragDropSource)
                e.Effect = DragDropEffects.None;
            else
            {
                if ((e.KeyState & 8) == 8) // check if ctrl is pressed
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            ListBox lbSender = sender as ListBox;
            ListBox lbSource = dragDropSource as ListBox;
            int index = lbSender.IndexFromPoint(lbSender.PointToClient(new Point(e.X, e.Y)));

            if (index == -1)
                index = lbSender.Items.Count;

            //lbSender.Items.Insert(index, e.Data.GetData(DataFormats.Text).ToString());
            for (int i = lbSource.SelectedItems.Count - 1; i >= 0; i--)
                lbSender.Items.Insert(index, lbSource.Items[lbSource.SelectedIndices[i]]);
        }
    }
}
