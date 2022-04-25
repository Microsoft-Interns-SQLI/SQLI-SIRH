using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Mvc;
using API_MySIRH.Helpers;
using API_MySIRH.Extentions;
using Syncfusion.XlsIO;
using System.Collections;
using AutoMapper;
using API_MySIRH.Entities;
using Microsoft.AspNetCore.JsonPatch;
using API_MySIRH.Data;
using Newtonsoft.Json;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedsController : ControllerBase
    {
        DataContext _dataContext;
        public SeedsController(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        [HttpGet("Data-And-Collaborateurs")]
        public async Task<IActionResult> Collaborateurs()
        {
            // clearing tables
            this._dataContext.Diplomes.RemoveRange(this._dataContext.Diplomes.ToList());
            this._dataContext.Collaborateurs.RemoveRange(this._dataContext.Collaborateurs.ToList());
            this._dataContext.Niveaux.RemoveRange(this._dataContext.Niveaux.ToList());
            this._dataContext.Posts.RemoveRange(this._dataContext.Posts.ToList());
            this._dataContext.TypeContrats.RemoveRange(this._dataContext.TypeContrats.ToList());
            this._dataContext.SkillCenters.RemoveRange(this._dataContext.SkillCenters.ToList());
            this._dataContext.Sites.RemoveRange(this._dataContext.Sites.ToList());
            this._dataContext.ModesRecrutements.RemoveRange(this._dataContext.ModesRecrutements.ToList());
            await this._dataContext.SaveChangesAsync();

            // filling tables
            await this._dataContext.Niveaux.AddRangeAsync(this.SeedNiveaux());
            await this._dataContext.Posts.AddRangeAsync(this.SeedPostes());
            await this._dataContext.TypeContrats.AddRangeAsync(this.SeedTypesContrat());
            await this._dataContext.SkillCenters.AddRangeAsync(this.SeedSkillCenters());
            await this._dataContext.Sites.AddRangeAsync(this.SeedSites());
            await this._dataContext.ModesRecrutements.AddRangeAsync(this.SeedModeRecrutement());
            this._dataContext.SaveChanges();

            this._dataContext.Collaborateurs.AddRange(await this.SeedCollaborateurs());
            this._dataContext.SaveChanges();

            // return count of each dbSet
            return Ok(
                new
                {
                    niveaux = this._dataContext.Niveaux.Count(),
                    posts = this._dataContext.Posts.Count(),
                    typesContrat = this._dataContext.TypeContrats.Count(),
                    skillCenters = this._dataContext.SkillCenters.Count(),
                    sites = this._dataContext.Sites.Count(),
                    modesRecrutements = this._dataContext.ModesRecrutements.Count(),
                    collaborateurs = this._dataContext.Collaborateurs.Count(),
                    diplomes = this._dataContext.Diplomes.Count(),
                }
            );
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<List<Collaborateur>> SeedCollaborateurs()
        {
            List<Collaborateur> collaborateurs = new List<Collaborateur>();
            string collaborateursJsonString = System.IO.File.ReadAllText(@"Data/collaborateurs.json");
            var collaborateurDynamicJson = JsonConvert.DeserializeObject<dynamic>(collaborateursJsonString);
            foreach (var collaborateurJson in collaborateurDynamicJson)
            {
                string mode = collaborateurJson["Recrutement Mode"].ToString();
                string niveau = collaborateurJson["Niveau"].ToString();
                string post = collaborateurJson["Poste"].ToString();
                string skillCenter = collaborateurJson["Skills center"].ToString();
                string typeContrat = collaborateurJson["Type de Contrat"].ToString();
                string site = collaborateurJson["Agence"].ToString();

                Collaborateur collaborateur = new Collaborateur
                {
                    // available data on collaborateurs.json
                    Nom = collaborateurJson["Nom Complet"].ToString().Split(" ")[0],
                    Prenom = collaborateurJson["Nom Complet"].ToString().Split(" ")[1],
                    Email = collaborateurJson["Email"].ToString(),
                    Matricule = collaborateurJson["Matricule"],
                    Civilite = collaborateurJson["Civilité"],
                    DateDebutStage = collaborateurJson["Date de début de stage"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date de début de stage"].ToString()) : null,
                    DateEntreeSqli = collaborateurJson["Date d'entrée"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date d'entrée"].ToString()) : null,
                    DateNaissance = collaborateurJson["Date Naissance"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date Naissance"].ToString()) : null,
                    DatePremiereExperience = collaborateurJson["Date 1ere expèrience"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date 1ere expèrience"].ToString()) : null,
                    DateSortieSqli = collaborateurJson["Date de sortie"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date de sortie"].ToString()) : null,

                    ModeRecrutement = this._dataContext.ModesRecrutements.Where(m => m.Mode == mode).FirstOrDefault(),
                    Niveau = this._dataContext.Niveaux.Where(n => n.Name == niveau).FirstOrDefault(),
                    Poste = this._dataContext.Posts.Where(p => p.Name == post).FirstOrDefault(),
                    SkillCenter = this._dataContext.SkillCenters.Where(sc => sc.Name == skillCenter).FirstOrDefault(),
                    TypeContrat = this._dataContext.TypeContrats.Where(tc => tc.Name == typeContrat).FirstOrDefault(),
                    Site = this._dataContext.Sites.Where(s => s.Name == site).FirstOrDefault(),

                    // because of no data in the collaborateurs.json ...
                        PhonePersonnel = "+212 06 66 20 17 40",
                        PhoneProfesionnel = "+212 06 12 34 56 78",
                        AutreTechnos = "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL",
                        Adresse = "Oujda, Hay Andalous, Rue les orangers, Nr 2",
                        Certifications = "Certified .Net Developper|Angular Certification|Français avancé C1",
                        EmailPersonnel = "email.personnel@gmail.com",
                        HadAlreadyWorkedAtSQLI = false,
                        Langues = "Français|Anglais",
                        LieuNaissance = "Rabat",
                        Nationnalite = "Marocaine",
                        NumCin = "F580877",
                        SituationFamiliale = "Célibataire",
                        Note = "ceci est une note et remarque concernant le collaborateur."
                };

                collaborateurs.Add(collaborateur);
                await DiplomesTraitement(collaborateur, collaborateurJson["Diplômes"].ToString());
            }
            return collaborateurs;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public List<Niveau> SeedNiveaux()
        {
            return new List<Niveau>
            {
                new Niveau{ Name="Junior"},
                new Niveau{ Name="Opérationnel"},
                new Niveau{ Name="Confirmé"},
                new Niveau{ Name="Sénior"}
            };
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public List<Post> SeedPostes()
        {
            return new List<Post>
            {
                new Post{ Name="Ingénieur Concepteur développeur"},
                new Post{ Name="Expert technique"},
                new Post{ Name="Chef de projet technique"},
                new Post{ Name="Manager"},
            };
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public List<TypeContrat> SeedTypesContrat()
        {
            return new List<TypeContrat>
            {
                new TypeContrat{ Name="CDI"},
                new TypeContrat{ Name="CDD"},
                new TypeContrat{ Name="Freelance"},
            };
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public List<SkillCenter> SeedSkillCenters()
        {
            return new List<SkillCenter>
            {
                new SkillCenter{ Name="Skill Microsoft"},
                new SkillCenter{ Name="Skill Java"},
                new SkillCenter{ Name="Skill PHP"},
                new SkillCenter{ Name="Skill Front & Mobile"},
                new SkillCenter{ Name="Skill DevOps"},
            };
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public List<Site> SeedSites()
        {
            return new List<Site>
            {
                new Site{ Name="Rabat"},
                new Site{ Name="Oujda"},
                new Site{ Name="CasaBlanca"},
            };
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public List<ModeRecrutement> SeedModeRecrutement()
        {
            return new List<ModeRecrutement>
            {
                new ModeRecrutement{ Mode="E-Chalenge"},
                new ModeRecrutement{ Mode="Recommandation"},
                new ModeRecrutement{ Mode="Stage PFE"},
                new ModeRecrutement{ Mode="Cooptation"},
                new ModeRecrutement{ Mode="Autre"},
            };
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task DiplomesTraitement(Collaborateur collaborateur, string diplomes)
        {
            if (diplomes.Length != 0)
            {
                foreach (var diplome in diplomes.Split('|'))
                    if (diplome != String.Empty)
                    {
                        var diplomeObj = new Diplome
                        {
                            Annee = int.Parse(diplome.Split(':')[0]),
                            Detail = diplome.Split(':')[1]
                        };
                        collaborateur.DiplomesList.Add(diplomeObj);
                        this._dataContext.Diplomes.Add(diplomeObj);
                    }
                await this._dataContext.SaveChangesAsync();
            }
        }
    }
}