using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_FAZA_1
{
    public partial class Form1 : Form
    {
        public int general_id = 0;
        List<Imobil> lstImobile = new List<Imobil>();
        List<Oferta> lstOferte = new List<Oferta>();
        List<Cerere> lstCereri = new List<Cerere>();
       // List<Operatiune> lstOperatiuni = new List<Operatiune>(); //fiecare operatiune cu idul ei 
        //fiercare operatiune merge in cate 2 liste pentru a face raporarte ulterior mai repedfe

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imobil_Insert imbINS= new Imobil_Insert(this);
            imbINS.Show();
        }

        public void addImobil(string prop,int camere,string adresa,int pret)
        {
            Imobil tmp = new Imobil(general_id, prop, camere, pret, adresa);
            
            //lstView.Items.Add(CreateListViewItem(tmp));
            ListViewItem item = new ListViewItem(tmp.ID.ToString());
            item.SubItems.Add(tmp.Proprietar);
            item.SubItems.Add(tmp.NrCamere.ToString());
            item.SubItems.Add(tmp.Pret.ToString());
            item.SubItems.Add(tmp.adresa.ToString());
            // lstImobile.Items.Add(item);
            lstImobile.Add(tmp);
            listView2.Items.Add(item);


            tbMes.Text += "\n\r Imobil adaugat cu id "+general_id+", nr camere= "+camere+", pret= "+ pret;
            general_id++;
        }

        public void addOferta(string doritor,int ID_Imobil,int pret) 
        {
            Oferta tmp = new Oferta(general_id, doritor, ID_Imobil, pret);

            ListViewItem item = new ListViewItem(tmp.ID.ToString());
            switch (tmp.Stare)
            {
                case 0: item.SubItems.Add("Plasata"); break;
                case 1: item.SubItems.Add("Acceptata"); break;
                case 2: item.SubItems.Add("Respinsa"); break;
            }
            item.SubItems.Add(tmp.Stare.ToString());
            item.SubItems.Add(tmp.ID_Imobil.ToString());
            item.SubItems.Add(tmp.pret_oferit.ToString());
            item.SubItems.Add(tmp.Doritor);
           // item.SubItems.Add(tmp.adresa.ToString());
            // lstImobile.Items.Add(item);
            lstOferte.Add(tmp);
            lstView.Items.Add(item);

            tbMes.Text += "\n\r Oferta adaugata cu id " + general_id + ", nr camere= " + ID_Imobil + ", pret= " + pret;
            general_id++;

        }

        public void addCerere(string petant, string Subiect, string descriere)
        {
            Cerere tmp = new Cerere(general_id, petant, Subiect, descriere);

            ListViewItem item = new ListViewItem(tmp.ID.ToString());
            item.SubItems.Add(tmp.Petant);
            item.SubItems.Add(tmp.Subiect);
            item.SubItems.Add(tmp.Descriere);
            // item.SubItems.Add(tmp.adresa.ToString());
            // lstImobile.Items.Add(item);
            lstCereri.Add(tmp);
            listView1.Items.Add(item);

            tbMes.Text += "\n\r Oferta adaugata cu id " + general_id + ", petant= " + tmp.Petant + ", duebiect= " + tmp.Subiect;
            general_id++;
        }

        private void ofertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OfertaIntrod formm = new OfertaIntrod(this);
            formm.Show();
        }

        private void cerereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerereIntrod cereree = new CerereIntrod(this);
           cereree.Show();
        }

        /*private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = "data.txt";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    
                    line = reader.ReadLine();
                    int numImobile = int.Parse(line.Split(';')[0]);

                    
                    for (int i = 0; i < numImobile; i++)
                    {
                        line = reader.ReadLine();
                        string[] parts = line.Split(';');
                        Imobil imb = new Imobil
                        (
                            int.Parse(parts[0]),
                            parts[1],
                            int.Parse(parts[2]),
                            int.Parse(parts[3]),
                            parts[4]
                        );
                        lstImobile.Add(imb);
                    }

                    
                    line = reader.ReadLine();
                    int numOferte = int.Parse(line.Split(';')[0]);

                    
                    for (int i = 0; i < numOferte; i++)
                    {
                        line = reader.ReadLine();
                        string[] parts = line.Split(';');
                        Oferta oferta = new Oferta
                        (
                            int.Parse(parts[0]),
                            parts[1],
                            int.Parse(parts[2]),
                            int.Parse(parts[3]),
                            int.Parse(parts[4])
                        );
                        lstOferte.Add(oferta);
                    }

                    
                    line = reader.ReadLine();
                    int numCereri = int.Parse(line.Split(';')[0]);

                    
                    for (int i = 0; i < numCereri; i++)
                    {
                        line = reader.ReadLine();
                        string[] parts = line.Split(';');
                        Cerere cerere = new Cerere
                        (
                            int.Parse(parts[0]),
                             parts[1],
                             parts[2],
                             parts[3]
                        );
                        lstCereri.Add(cerere);
                    }

                    
                    line = reader.ReadLine();
                    general_id = int.Parse(line);
                }

                MessageBox.Show("Data was successfully loaded from the text file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading from the file: {ex.Message}");
            }
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = "data.txt";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    { 
                    // Citim numărul de imobile
                    line = reader.ReadLine();
                    int numImobile = int.Parse(line.Split(';')[0]);
                    Debug.WriteLine($"Numărul de imobile: {numImobile}");

                    // Parcurgem imobilele
                    for (int i = 0; i < numImobile; i++)
                    {
                        line = reader.ReadLine();
                        Debug.WriteLine($"Linia citită pentru imobil: {line}");
                        string[] parts = line.Split(';');
                        // Verificăm dacă numărul de părți este corect
                        if (parts.Length-1 != 5)
                        {
                            Debug.WriteLine($"Număr incorect de părți: {parts.Length}");
                            continue; // Trecem la următoarea linie din fișier
                        }
                        // Parcurgem părțile și le afișăm pentru depanare
                        for (int j = 0; j < parts.Length - 1; j++)
                        {
                            Debug.WriteLine($"Parte: {j}");
                        }
                        // Creăm obiectul Imobil și îl adăugăm în listă
                        Imobil imb = new Imobil
                        (
                            int.Parse(parts[0]),
                            parts[1],
                            int.Parse(parts[2]),
                            int.Parse(parts[4]),
                            parts[3]
                        );
                       
                        ListViewItem item = new ListViewItem(imb.ID.ToString());
                        item.SubItems.Add(imb.Proprietar);
                        item.SubItems.Add(imb.NrCamere.ToString());
                        item.SubItems.Add(imb.adresa);
                        item.SubItems.Add(imb.Pret.ToString());
                        
                      
                        lstImobile.Add(imb);
                       
                        listView2.Items.Add(item);

                    }
                    }
                    { 
                    // OERTEEEEEEE
                    line = reader.ReadLine();
                    int numOferte = int.Parse(line.Split(';')[0]);
                    Debug.WriteLine($"Numărul de oferte: {numOferte}");

                    // Parcurgem imobilele
                    for (int i = 0; i < numOferte; i++)
                    {
                        line = reader.ReadLine();
                        Debug.WriteLine($"Linia citită pentru oferta: {line}");
                        string[] parts = line.Split(';');
                        // Verificăm dacă numărul de părți este corect
                        if (parts.Length - 1 != 5)
                        {
                            Debug.WriteLine($"Număr incorect de părți: {parts.Length}");
                            continue; // Trecem la următoarea linie din fișier
                        }
                        // Parcurgem părțile și le afișăm pentru depanare
                        for (int j = 0; j < parts.Length - 1; j++)
                        {
                            Debug.WriteLine($"Parte: {j}");
                        }
                        // Creăm obiectul Imobil și îl adăugăm în listă
                        Oferta imbb = new Oferta
                        (
                            int.Parse(parts[0]),
                            parts[1],
                            int.Parse(parts[2]),
                            int.Parse(parts[3]),
                            int.Parse(parts[4])
                        );

                        ListViewItem itemm = new ListViewItem(imbb.ID.ToString());
                        
                        switch (imbb.Stare)
                        {
                            case 0: { itemm.SubItems.Add("Plasata"); break; }
                            case 1: { itemm.SubItems.Add("Acceptata"); break; }
                            case 2: { itemm.SubItems.Add("Respinsa"); break; }
                        };
                        
                        
                        itemm.SubItems.Add(imbb.Doritor);
                        itemm.SubItems.Add(imbb.ID_Imobil.ToString());
                        itemm.SubItems.Add(imbb.pret_oferit.ToString());
                            //se pun in ordine ciudata


                            lstOferte.Add(imbb);

                        lstView.Items.Add(itemm);

                    }
                    }
                    { 
                    //  CERERIIIII
                    line = reader.ReadLine();
                    int numCereri = int.Parse(line.Split(';')[0]);
                    Debug.WriteLine($"Numărul de cereri: {numCereri}");

                    // Parcurgem imobilele
                    for (int i = 0; i < numCereri; i++)
                    {
                        line = reader.ReadLine();
                        Debug.WriteLine($"Linia citită pentru cerere: {line}");
                        string[] parts = line.Split(';');
                        // Verificăm dacă numărul de părți este corect
                        if (parts.Length - 1 != 4)
                        {
                            Debug.WriteLine($"Număr incorect de părți: {parts.Length}");
                            continue; // Trecem la următoarea linie din fișier
                        }
                        // Parcurgem părțile și le afișăm pentru depanare
                        for (int j = 0; j < parts.Length - 1; j++)
                        {
                            Debug.WriteLine($"Parte: {j}");
                        }
                        // Creăm obiectul Imobil și îl adăugăm în listă
                        Cerere imbbbb = new Cerere
                        (
                            int.Parse(parts[0]),
                            parts[1],
                            parts[2],                   
                            parts[3]
                        );

                        ListViewItem item = new ListViewItem(imbbbb.ID.ToString());
                        item.SubItems.Add(imbbbb.Petant);
                        item.SubItems.Add(imbbbb.Subiect);
                        item.SubItems.Add(imbbbb.Descriere);
                       // item.SubItems.Add(imb.Pret.ToString());


                        lstCereri.Add(imbbbb);

                        listView1.Items.Add(item);

                    }
                    }
                    line = reader.ReadLine();
                    general_id = int.Parse(line.Split(';')[0]);

                    // Restul codului pentru oferte, cereri și general_id
                    // ...
                }
                MessageBox.Show("Datele au fost încărcate cu succes din fișierul text.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la citirea din fișier: {ex.Message}");
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = "data.txt";


            /* using (StreamWriter writer = new StreamWriter(filePath))
             {

                 writer.WriteLine($"{lstImobile.Count()};");
                 foreach (Imobil imb in lstImobile)
                 {
                     writer.WriteLine($"{imb.ID};{imb.Proprietar};{imb.NrCamere};{imb.adresa};{imb.Pret}");
                 }

                 writer.WriteLine($"{lstOferte.Count()};");
                 foreach (Oferta imb in lstOferte)
                 {
                     writer.WriteLine($"{imb.ID};{imb.Doritor};{imb.Stare};{imb.ID_Imobil};{imb.pret_oferit}");
                 }

                 writer.WriteLine($"{lstCereri.Count()};");
                 foreach (Cerere imb in lstCereri)
                 {
                     writer.WriteLine($"{imb.ID};{imb.Petant};{imb.Subiect};{imb.Descriere}");
                 }

                 writer.WriteLine(general_id);
                 writer.Close();

             }*/

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the number of Imobile objects
                    writer.WriteLine(lstImobile.Count());
                    // Write each Imobil object
                    foreach (Imobil imb in lstImobile)
                    {
                        writer.WriteLine(imb.ID+";"+imb.Proprietar+";"+imb.NrCamere + ";" + imb.adresa + ";" + imb.Pret+";");
                    }

                    // Write the number of Oferta objects
                    writer.WriteLine(lstOferte.Count());
                    // Write each Oferta object
                    foreach (Oferta imb in lstOferte)
                    {
                        writer.WriteLine(imb.ID + ";" + imb.Doritor + ";" + imb.Stare + ";" + imb.ID_Imobil + ";" + imb.pret_oferit + ";" );
                    }

                    // Write the number of Cerere objects
                    writer.WriteLine(lstCereri.Count());
                    // Write each Cerere object
                    foreach (Cerere imb in lstCereri)
                    {
                        writer.WriteLine(imb.ID + ";" + imb.Petant + ";" + imb.Subiect + ";" + imb.Descriere);
                    }

                    // Write the general_id
                    writer.WriteLine(general_id);

                    // Flush the writer to ensure data is written immediately
                    writer.Flush();
                }

                MessageBox.Show("Data was successfully written to the text file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to the file: {ex.Message}");
            }
        }
    }
}
