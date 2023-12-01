using System;

public class joueur

{
	public joueur()
	{
        string nom;

        List<string> MotsTrouvés;

        List<int> score;
        int nbPartie;



        public Joueur (string nom, List<string> motsTrouvés, List<int> score, int nbPartie)

        {

            this.nom = nom;

            MotsTrouvés = motsTrouvés;

            this.score = score;
            nbPartie = nbPartie;

        }



        public void Add_Mot(string mot)

        {

            MotsTrouvés.Add(mot);

        }



        public string toString()

        {

            string listeMots = "";

            foreach (string Mot in MotsTrouvés)

            {

                listeMots = listeMots + Mot + "\n";

            }

            return this.nom + "a trouver les mots " + listeMots + " pour un score final de " + this.score[nbPartie] + " points";

        }





        public  void Add_Score(int val, string filename, string MotTrouvé)

        {

            StreamReader flux = null;

            try
            {
                flux = new StreamReader(filename);
                string s;
                int score=0;

                for (int i = 0; i < MotTrouvé.Length; i++)
                {
                    while ((s = flux.ReadLine()) != null)
                    {
                        string[] line = s.Split(',');
                        if (line[0] == Convert.ToString(MotTrouvé[i]))
                        {
                            score = score + Convert.ToInt32(line[2]);
                        }


                    }
                }
                score = score * MotTrouvé.Length;
                val = score + val;


            }
            catch (FileNotFoundException) { Console.WriteLine("file not found"); }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { if (flux != null) flux.Close(); }

        }





        public bool Contient(string MotProposé)

        {

            bool Present = false;

            foreach (string Mot in MotsTrouvés)

            {

                if (MotProposé == Mot)

                {

                    Present = true;

                }

            }

            return Present;
        }
}
