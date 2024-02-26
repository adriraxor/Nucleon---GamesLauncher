using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Reauto
{
    public partial class Form1 : Form
    {

        private String default_path = "E:\\Jeux";

        public Form1()
        {
            InitializeComponent();
            getGames();
        }

        private void getGames()
        {
            Console.WriteLine("DEBUT DU PROGRAMME");
            string[] games_dir = Directory.GetDirectories(default_path);

            // Boucle sur les répertoires de jeux //

            foreach (string gamedir in games_dir)
            {
                // Nom du jeu 

                Console.WriteLine(gamedir);

                string name = Path.GetFileName(gamedir);
                
                // On ajoute le jeu dans la list view (Répertoire + Nom) 

                ListViewItem gameItem = new ListViewItem(name);
                gameItem.SubItems.Add(gamedir);
                lvGames.Items.Add(gameItem);
            }


        }

        private void lvGames_MouseClick(object sender, MouseEventArgs e)
        {
            // On vide la listView avant de remplir avec les nouvelles données

            lvGameExe.Items.Clear();

            // ImageList pour les icones des exe 

            ImageList iconExeList = new ImageList();
            iconExeList.ImageSize = new Size(20, 20);

            lvGameExe.SmallImageList = iconExeList; //--- Important d'utiliser la propriété SmallImageList

            // On valorise la listView des EXE 

            if (lvGames.SelectedItems.Count > 0)
            {
                // Récupération du chemin du jeu 

                string game_dir_selected = lvGames.SelectedItems[0].SubItems[1].Text;

                // Récupération des EXE à partir du chemin

                string[] exeList = Directory.GetFiles(game_dir_selected, "*.exe");
                
                // Boucle sur tout les EXE Trouvés 

                foreach (string exePath in exeList) 
                {

                    // Icone de l'executable 

                    Icon icon = Icon.ExtractAssociatedIcon(exePath);
                
                    // Valorisation de la ListView 

                    ListViewItem exeItem = new ListViewItem();

                    // On ajoute l'icone à l'imageList

                    iconExeList.Images.Add(icon);

                    // On valorise les colonnes 

                    exeItem.ImageIndex = iconExeList.Images.Count - 1; // Première colonne (Icone de l'exe)
                    exeItem.SubItems.Add(Path.GetFileName(exePath)); // Seconde colonne (Nom de l'exe)
                    exeItem.SubItems.Add(exePath); // Troisième colonne (Répertoire)
                   
                    // On ajoute l'item à la listView

                    lvGameExe.Items.Add(exeItem);  
                   
                }

            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {            
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe", 
                WorkingDirectory = lvGames.SelectedItems[0].SubItems[1].Text,
                Arguments = $"/C cd /d \"{lvGames.SelectedItems[0].SubItems[1].Text}\" && \"{lvGameExe.SelectedItems[0].SubItems[2].Text}\"", 
                UseShellExecute = false,
                RedirectStandardOutput = true, 
                CreateNoWindow = true 
            };

            Console.WriteLine(psi.Arguments);

            Process.Start(psi).WaitForExit();

        }

    }
}
