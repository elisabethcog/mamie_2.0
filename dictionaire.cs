using System;

public class dictionaire
{
	public dictionaire()
	{
        string filename;

        public dictionaire(string filename)
        {
            this.filename = filename;
        }

        public string toString(this.filename)
        {
            StreamReader flux = null;
            try
            {
                flux = new StreamReader(filename);
                string s;
                string DecritDictionaire="Langue: Français" + "\n";
                int TotalMots=0;

                for (int i = 0; (s = flux.ReadLine()) != null; i++)
                {
                    string[] line = s.Split(' ');
                    
                    for(int j=1, j<line.Length, j++)
                    {
                        int compteMemePremiereLettre = 1;
                        if (line[j][0] == ligne[j - 1][0])
                        {
                            compteMemePremiereLettre++;
                        }
                        else
                        {
                            DecritDictionaire=DecritDictionaire+ "\n" +line[j-1][0] +" = " +compteMemePremiereLettre;
                            TotalMots = TotalMots + compteMemePremiereLettre;
                        }
                    }


                    if (line[2] == "t")
                    {
                        b = true;
                    }
                    compte_bancaire.Add(new Compte_Bancaire(line[0], Convert.ToDouble(line[1]), b, 0));
                    i++;


                }


            }
            catch (FileNotFoundException) { Console.WriteLine("file not found"); }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { if (flux != null) flux.Close(); }


        }
}
