using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> siren = new List<string>();
            string city;
            char activite;
            int typOrga = 0;

            do
            {
                typOrga = ChoixOrganisation();
                switch (typOrga)
                {
                    case 1:
                        {
                            for (int c = 0; c < 3; c++)
                            {
                                siren.Add(new Random().Next(999).ToString("000"));
                            }
                            city = Ville().Substring(0, 5);
                            activite = Activite();
                            Console.WriteLine("RCS " + city + " " + activite + " " + siren.ElementAt(0) + " " + siren.ElementAt(1) + " " + siren.ElementAt(2));
                            break;
                        }
                    case 2:
                        {
                            for (int c = 0; c < 4; c++)
                            {
                                siren.Add(new Random().Next(999).ToString("000"));
                            }
                            int metier = 0;
                            do
                            {
                                metier = Metier();
                            } while (metier == 0);
                            Console.WriteLine(siren.ElementAt(0) + " " + siren.ElementAt(1) + " " + siren.ElementAt(2) + " RM " + metier.ToString("000"));
                            break;
                        }
                    case 3:
                        {
                            for (int c = 0; c < 4; c++)
                            {
                                siren.Add(new Random().Next(999).ToString("000"));
                            }
                            Console.WriteLine(siren.ElementAt(0) + " " + siren.ElementAt(1) + " " + siren.ElementAt(2));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Au revoir...");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Choix incorrect");
                            break;
                        }
                }
            } while (typOrga != 4);
        }



        static int ChoixOrganisation()
        {
            try
            {
                Console.WriteLine("Quel est le type d'organisation dont dépend votre activité (1, 2 ou 3) :");
                Console.WriteLine("1/ Commerçants et sociétés");
                Console.WriteLine("2/ Immatriculé à la chanbre des métiers et de l'artisanat");
                Console.WriteLine("3/ Professions libéralles");
                Console.WriteLine("4/ Quitter");
                var typeOrganisation = Convert.ToInt32(Console.ReadLine());
                return typeOrganisation;
            }
            catch (Exception)
            {
                Console.WriteLine("erreur");
                int erreur = 0;
                return erreur;
            }
        }

        static string Ville()
        {
            Console.WriteLine("Saisissez votre ville : ");
            string _city = Console.ReadLine().ToUpper();
            return _city;
        }

        static char Activite()
        {
            Console.WriteLine("Etes-vous un commerçant (A) ou une société (B): ");
            char _activite = Convert.ToChar(Console.ReadLine().ToUpper());
            return _activite;
        }

        static int Metier()
        {
            try
            {
                Console.WriteLine("Saisissez le groupe de chiffres désignant la chambre des métier et de l'artisanat : ");
                int _metier = Convert.ToInt32(Console.ReadLine());
                return _metier;
            }
            catch
            {
                Console.WriteLine("Vous ne pouvez pas saisier des lettres ou caractère spéciaux");
                int erreur = 0;
                return erreur;
            }
        }
    }
}
