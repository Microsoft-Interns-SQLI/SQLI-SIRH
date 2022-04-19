using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_MySIRH.Entities;
using Newtonsoft.Json;

namespace API_MySIRH.Data
{
    public static class DataInitializer
    {
        public static Dictionary<string, object> SeedData()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("Niveaux", SeedNiveaux());
            data.Add("Collaborateurs", SeedCollaborateurs());
            return data;
        }

        public static List<Collaborateur> SeedCollaborateurs()
        {
            int id = 1;
            List<Collaborateur> collaborateurs = new List<Collaborateur>();
            string collaborateursJsonString = System.IO.File.ReadAllText(@"Data/collaborateurs.json");
            var collaborateurDynamicJson = JsonConvert.DeserializeObject<dynamic>(collaborateursJsonString);
            foreach (var collaborateurJson in collaborateurDynamicJson)
                collaborateurs.Add
                (
                    new Collaborateur
                    {
                        Id = id++,
                        Nom = collaborateurJson["Nom Complet"].ToString().Split(" ")[0],
                        Prenom = collaborateurJson["Nom Complet"].ToString().Split(" ")[1],
                        Email = collaborateurJson["Email"].ToString(),
                        Diplomes = collaborateurJson["Diplômes"],
                        Matricule = collaborateurJson["Matricule"],
                        ModeRecrutement = collaborateurJson["Recrutement Mode"],
                        Civilite = collaborateurJson["Civilité"],
                        DateDebutStage = collaborateurJson["Date de début de stage"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date de début de stage"].ToString()) : null,
                        DateEntreeSqli = collaborateurJson["Date d'entrée"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date d'entrée"].ToString()) : null,
                        DateNaissance = collaborateurJson["Date Naissance"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date Naissance"].ToString()) : null,
                        DatePremiereExperience = collaborateurJson["Date 1ere expèrience"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date 1ere expèrience"].ToString()) : null,
                        DateSortieSqli = collaborateurJson["Date de sortie"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date de sortie"].ToString()) : null,
                        PhonePersonnel = "+212 06 66 20 17 40",
                        PhoneProfesionnel = "+212 06 12 34 56 78",
                        AutreTechnos = "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL",
                        Adresse = "Hay Andalous, Rue les orangers, Nr 2",
                        Certifications = "Certified .Net Developper|Angular Certification|Français avancé C1",
                        EmailPersonnel = "email.personnel@gmail.com",
                        HadAlreadyWorkedAtSQLI = false,
                        Langues = "Français|Anglais",
                        LieuNaissance = "Rabat",
                        Nationnalite = "Marocaine",
                        NiveauId = (SeedNiveaux()).Where(n => n.Name == collaborateurJson["Niveau"].ToString()).First().Id,
                        NumCin = "F580877",
                        Poste = collaborateurJson["Poste"],
                        Site = collaborateurJson["Agence"],
                        SituationFamiliale = "Célibataire",
                        SkillCenter = collaborateurJson["Skills center"],
                        TypeContrat = collaborateurJson["Type de Contrat"],
                        Note = "ceci est une note et remarque concernant le collaborateur."
                    }
                );
            return collaborateurs;
        }

        public static List<Niveau> SeedNiveaux()
        {
            return new List<Niveau>
            {
                new Niveau{ Id= 1, Name="Junior"},
                new Niveau{ Id= 2, Name="Opérationnel"},
                new Niveau{ Id= 3, Name="Confirmé"},
                new Niveau{ Id= 4, Name="Sénior"}
            };
        }
    }
}