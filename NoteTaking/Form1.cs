

using System.Data;


namespace NoteTaking
{


    public partial class Form1 : Form
    {
        
        private readonly DataTable NoteTable = new DataTable();
        
        private NoteManipulation? fileSave;




        public Form1()
        {
            InitializeComponent();

        }


        private void CreatePrompt() //funkce na vytvoreni nove formy kde se bude zadavat jmeno "Note"
        {
            Form2 prompt = new Form2();
            prompt.ShowDialog();
            NoteManipulation.TableAddNote(NoteTable, prompt.GetName());


        }


        private void rightClickContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e) //varianty rozkliknuti v context menu
        {
            switch (e.ClickedItem.ToString())
            {
                case "New Note":  //vytvori se novy note
                    CreatePrompt();
                    break;
            }

        }


        private void AllNotes_MouseDown(object sender, MouseEventArgs e) //ContextMenuStrip pri kliknuti praveho tlacitka
        {
            if (e.Button == MouseButtons.Right)
            {
                rightClickContextMenuStrip.Show(this, new Point(e.X + 10, e.Y + 50));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            NoteTable.Columns.Add("Note Name", typeof(string));
            NoteTable.Columns.Add("Creation Date", typeof(DateTime));
            NoteTable.Columns.Add("Note Text", typeof(string));


            AllNotes.DataSource = NoteTable;
            AllNotes.Columns["Note Text"].Visible = false;
            fileSave = new NoteManipulation();

        }


        private void btnSaveNote_Click(object sender, EventArgs e) //ulozeni textu notu 
        {
            NoteTable.Rows[AllNotes.CurrentCell.RowIndex]["Note Text"] = NoteText.Text;
        }

        private void AllNotes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) //prepinani mezi notami
        {
            try
            {
                if (NoteTable.Rows[AllNotes.CurrentCell.RowIndex]["Note Name"] != null)
                {
                    if (NoteTable.Rows[AllNotes.CurrentCell.RowIndex].ItemArray[2] == null)
                        NoteTable.Rows[AllNotes.CurrentCell.RowIndex].ItemArray[2] = "";


                    NoteText.Text = NoteTable.Rows[AllNotes.CurrentCell.RowIndex].ItemArray[2].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + " Click on a note"); }



        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e) //pomocka kdyz kliknout na tlacitko "help"
        {
            MessageBox.Show("Right Click - to create New Note", "Help", MessageBoxButtons.OK);
        }

        private void tsmSave_Click(object sender, EventArgs e) //dialog na ulozeni notu do souboru
        {
            folderBrowserDialog1.ShowDialog();
            fileSave.Save(NoteTable, folderBrowserDialog1.SelectedPath.ToString());

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) //otevreni uz existujicich notu
        {
            openFileDialog1.ShowDialog();
            fileSave.Open(NoteTable, openFileDialog1.FileName.ToString());
        }
    }

















}
