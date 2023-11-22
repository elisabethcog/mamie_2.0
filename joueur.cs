using System;

public class joueur

{
	public joueur()
	{
        string nom;

        List<string> MotsTrouvés;

        int score;



        public Joueur (string nom, List<string> motsTrouvés, int score)

        {

            this.nom = nom;

            MotsTrouvés = motsTrouvés;

            this.score = score;

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

            return this.nom + "a trouver les mots " + listeMots + " pour un score final de " + this.score + " points";

        }





        public void Add_Score(int val)

        {

            this.score = this.score + val;

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
