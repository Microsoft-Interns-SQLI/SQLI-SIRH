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
            data.Add("ModesRecrutement", SeedModeRecrutement());
            data.Add("Niveaux", SeedNiveaux());
            data.Add("Sites", SeedSites());
            data.Add("SkillCenters", SeedSkillCenters());
            data.Add("Postes", SeedPostes());
            data.Add("TypesContrat", SeedTypesContrat());
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
                        Civilite = collaborateurJson["Civilité"],
                        DateDebutStage = collaborateurJson["Date de début de stage"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date de début de stage"].ToString()) : null,
                        DateEntreeSqli = collaborateurJson["Date d'entrée"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date d'entrée"].ToString()) : null,
                        DateNaissance = collaborateurJson["Date Naissance"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date Naissance"].ToString()) : null,
                        DatePremiereExperience = collaborateurJson["Date 1ere expèrience"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date 1ere expèrience"].ToString()) : null,
                        DateSortieSqli = collaborateurJson["Date de sortie"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date de sortie"].ToString()) : null,

                        ModeRecrutementId = (SeedModeRecrutement()).Where(m => m.Mode == collaborateurJson["Recrutement Mode"].ToString()).FirstOrDefault()?.Id,
                        NiveauId = (SeedNiveaux()).Where(n => n.Name == collaborateurJson["Niveau"].ToString()).First().Id,
                        PosteId = (SeedPostes()).Where(p => p.Name == collaborateurJson["Poste"].ToString()).First().Id,
                        SkillCenterId = (SeedSkillCenters()).Where(sc => sc.Name == collaborateurJson["Skills center"].ToString()).First().Id,
                        TypeContratId = (SeedTypesContrat()).Where(tc => tc.Name == collaborateurJson["Type de Contrat"].ToString()).First().Id,
                        SiteId = (SeedSites()).Where(s => s.Name == collaborateurJson["Agence"].ToString()).First().Id,

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
                        NumCin = "F580877",
                        SituationFamiliale = "Célibataire",
                        Note = "ceci est une note et remarque concernant le collaborateur."
                    }
                );
            return collaborateurs;
        }

        public static List<Niveau> SeedNiveaux()
        {
            return new List<Niveau>
            {
                new Niveau{ Id = 1, Name="Junior"},
                new Niveau{ Id = 2, Name="Opérationnel"},
                new Niveau{ Id = 3, Name="Confirmé"},
                new Niveau{ Id = 4, Name="Sénior"}
            };
        }

        public static List<Post> SeedPostes()
        {
            return new List<Post>
            {
                new Post{ Id = 1, Name="Ingénieur Concepteur développeur"},
                new Post{ Id = 2, Name="Expert technique"},
                new Post{ Id = 3, Name="Chef de projet technique"},
                new Post{ Id = 4, Name="Manager"},
            };
        }

        public static List<TypeContrat> SeedTypesContrat()
        {
            return new List<TypeContrat>
            {
                new TypeContrat{ Id = 1, Name="CDI"},
                new TypeContrat{ Id = 2, Name="CDD"},
                new TypeContrat{ Id = 3, Name="Freelance"},
            };
        }

        public static List<SkillCenter> SeedSkillCenters()
        {
            return new List<SkillCenter>
            {
                new SkillCenter{ Id = 1, Name="Skill Microsoft"},
                new SkillCenter{ Id = 2, Name="Skill Java"},
                new SkillCenter{ Id = 3, Name="Skill PHP"},
                new SkillCenter{ Id = 4, Name="Skill Front & Mobile"},
                new SkillCenter{ Id = 5, Name="Skill DevOps"},
            };
        }

        public static List<Site> SeedSites()
        {
            return new List<Site>
            {
                new Site{ Id = 1, Name="Rabat"},
                new Site{ Id = 2, Name="Oujda"},
                new Site{ Id = 3, Name="CasaBlanca"},
            };
        }

        public static List<ModeRecrutement> SeedModeRecrutement()
        {
            return new List<ModeRecrutement>
            {
                new ModeRecrutement{ Id = 1, Mode="E-Chalenge"},
                new ModeRecrutement{ Id = 2, Mode="Recommandation"},
                new ModeRecrutement{ Id = 3, Mode="Stage PFE"},
                new ModeRecrutement{ Id = 4, Mode="Cooptation"},
                new ModeRecrutement{ Id = 5, Mode="Autre"},
            };
        }
    }
}