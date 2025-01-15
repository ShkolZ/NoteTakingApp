using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaking
{
    internal class NoteManipulation
    {
        
        public static void TableAddNote(DataTable NoteTable, string note_Name) //pridavani notu do dataTablu
        {
            if (NoteTable != null)
            {
                NoteTable.Rows.Add(note_Name, DateTime.Now.ToString());
                
            }


        }
        public static void TableAddNote(DataTable NoteTable, string note_Name, string? date, string noteText) //overload pro otevreni svych notu
        {
            if (NoteTable != null && date != null)
            {
                NoteTable.Rows.Add(note_Name, date, noteText);
            }
        }
        private string FindNoteName(string path) //funkce aby najit nazev z cesta do souboru
        {
            string noteName;
            noteName = path.Remove(path.LastIndexOf("."));
            noteName = noteName.Substring(path.LastIndexOf("\\") + 1);

            return noteName; 
        }
       
        public void Save(DataTable NoteTable, string path) //funkce ktera ulozi notu do souboru
        {
            for (int i = 0; i < NoteTable.Rows.Count; i++) { 
                string? noteName = NoteTable.Rows[i]["Note Name"].ToString() + ".txt";
                
                //File.Create(path + "\\" + noteName);
                using (StreamWriter sw = new StreamWriter(path + "\\" + noteName))
                {
                    sw.WriteLine(NoteTable.Rows[i]["Creation Date"].ToString());
                    sw.WriteLine(NoteTable.Rows[i]["Note Text"].ToString());
                }
            
                
            }
        }
        public void Open(DataTable NoteTable, string path) // funkce ktera otevri note zvoleny uzivatelem
        {
            string noteName = FindNoteName(path);
            
            try 
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string? dateLine = sr.ReadLine(); 
                    string noteText = sr.ReadToEnd();
                    TableAddNote(NoteTable, noteName, dateLine, noteText);
                } 
            }
            catch (Exception e) 
            { 
                MessageBox.Show(e.Message + " Something Went Wrong"); 
            }
            
        }
    }
}
