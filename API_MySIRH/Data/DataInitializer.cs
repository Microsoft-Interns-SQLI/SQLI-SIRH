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
        public static List<Collaborateur> SeedData()
        {
            List<Collaborateur> collaborateurs = new List<Collaborateur>();
            string collaborateursJsonString = System.IO.File.ReadAllText(@"Data/collaborateurs.json");
            var collaborateurDynamicJson = JsonConvert.DeserializeObject<dynamic>(collaborateursJsonString);
            int i = 1;
            foreach (var collaborateurJson in collaborateurDynamicJson)
            {
                collaborateurs.Add(new Collaborateur
                {
                    Id = i++,
                    Nom = collaborateurJson["Nom Complet"].ToString().Split(" ")[0],
                    Prenom = collaborateurJson["Nom Complet"].ToString().Split(" ")[1],
                    Diplomes = collaborateurJson["Diplômes"],
                    Matricule = collaborateurJson["Matricule"],
                    ModeRecrutement = collaborateurJson["Recrutement Mode"],
                    Civilite = collaborateurJson["Civilité"],
                    DateDebutStage = collaborateurJson["Date de début de stage"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date de début de stage"].ToString()) : null,
                    DateEntreeSqli = collaborateurJson["Date d'entrée"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date d'entrée"].ToString()) : null,
                    DateNaissance = collaborateurJson["Date Naissance"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date Naissance"].ToString()) : null,
                    DatePremiereExperience = collaborateurJson["Date 1ere expèrience"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date 1ere expèrience"].ToString()) : null,
                    DateSortieSqli = collaborateurJson["Date de sortie"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date de sortie"].ToString()) : null,
                });
            }
            return collaborateurs;
        }
    }
}