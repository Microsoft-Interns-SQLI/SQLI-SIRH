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
            this._dataContext
                .Diplomes.RemoveRange(this._dataContext.Diplomes.ToList());
            this._dataContext
                .Collaborateurs.RemoveRange(this._dataContext.Collaborateurs.ToList());
            this._dataContext
                .Niveaux.RemoveRange(this._dataContext.Niveaux.ToList());
            this._dataContext
                .Posts.RemoveRange(this._dataContext.Posts.ToList());
            this._dataContext
                .TypeContrats.RemoveRange(this._dataContext.TypeContrats.ToList());
            this._dataContext
                .SkillCenters.RemoveRange(this._dataContext.SkillCenters.ToList());
            this._dataContext
                .Sites.RemoveRange(this._dataContext.Sites.ToList());
            this._dataContext
                .ModesRecrutements.RemoveRange(this._dataContext.ModesRecrutements.ToList());
            this._dataContext
                .Certifications.RemoveRange(this._dataContext.Certifications.ToList());
            this._dataContext
                .CollaborateurCertifications.RemoveRange(this._dataContext.CollaborateurCertifications.ToList());
            this._dataContext
                .Formations.RemoveRange(this._dataContext.Formations.ToList());
            this._dataContext
                .CollaborateurFormations.RemoveRange(this._dataContext.CollaborateurFormations.ToList());
            this._dataContext
                .CollaborateurTypeContrats.RemoveRange(this._dataContext.CollaborateurTypeContrats.ToList());
            await this._dataContext.SaveChangesAsync();

            // filling tables
            await this._dataContext.Niveaux.AddRangeAsync(this.SeedNiveaux());
            await this._dataContext.Posts.AddRangeAsync(this.SeedPostes());
            await this._dataContext.TypeContrats.AddRangeAsync(this.SeedTypesContrat());
            await this._dataContext.SkillCenters.AddRangeAsync(this.SeedSkillCenters());
            await this._dataContext.Sites.AddRangeAsync(this.SeedSites());
            await this._dataContext.ModesRecrutements.AddRangeAsync(this.SeedModeRecrutement());
            await this._dataContext.Certifications.AddRangeAsync(this.SeedCertifications());
            await this._dataContext.Formations.AddRangeAsync(this.SeedFormations());
            await this._dataContext.ReasonDemissions.AddRangeAsync(this.SeedReasonsDemission());
            this._dataContext.SaveChanges();

            this._dataContext.Collaborateurs.AddRange(await this.SeedCollaborateurs());
            this._dataContext.SaveChanges();


            await this._dataContext.CollaborateurCertifications.AddRangeAsync(this.SeedCollabCertification());
            await this._dataContext.CollaborateurFormations.AddRangeAsync(this.SeedCollabFormation());
            this._dataContext.SaveChanges();

            // return count of each dbSet
            return Ok(
                new
                {
                    niveaux = this._dataContext.Niveaux.Count(),
                    posts = this._dataContext.Posts.Count(),
                    skillCenters = this._dataContext.SkillCenters.Count(),
                    sites = this._dataContext.Sites.Count(),
                    modesRecrutements = this._dataContext.ModesRecrutements.Count(),
                    collaborateurs = this._dataContext.Collaborateurs.Count(),
                    typesContrat = this._dataContext.TypeContrats.Count(),
                    collaborateurTypeContrat = this._dataContext.CollaborateurTypeContrats.Count(),
                    diplomes = this._dataContext.Diplomes.Count(),
                    certifications = _dataContext.Certifications.Count(),
                    formations = _dataContext.Formations.Count(),
                    certificationCollab = _dataContext.CollaborateurCertifications.Count(),
                    formationCollab = _dataContext.CollaborateurFormations.Count()
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
                
                string niveau = collaborateurJson["Niveau"].ToString();
                string post = collaborateurJson["Poste"].ToString();
                string skillCenter = collaborateurJson["Skills center"].ToString();
                string site = collaborateurJson["Agence"].ToString();
                string mode = collaborateurJson["Recrutement Mode"].ToString();

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
                    //DateSortieSqli = collaborateurJson["Date de sortie"].ToString() != String.Empty ? DateTime.Parse(collaborateurJson["Date de sortie"].ToString()) : null,

                    ModeRecrutement = this._dataContext.ModesRecrutements.Where(m => m.Name == mode).FirstOrDefault(),
                    Niveau = this._dataContext.Niveaux.Where(n => n.Name == niveau).FirstOrDefault(),
                    Poste = this._dataContext.Posts.Where(p => p.Name == post).FirstOrDefault(),
                    SkillCenter = this._dataContext.SkillCenters.Where(sc => sc.Name == skillCenter).FirstOrDefault(),
                    Site = this._dataContext.Sites.Where(s => s.Name == site).FirstOrDefault(),

                    // because of no data in the collaborateurs.json ...
                    PhonePersonnel = "+212 06 66 20 17 40",
                    PhoneProfesionnel = "+212 06 12 34 56 78",
                    AutreTechnos = "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL",
                    Adresse = "Oujda, Hay Andalous, Rue les orangers, Nr 2",
                    EmailPersonnel = "email.personnel@gmail.com",
                    Langues = "Français|Anglais",
                    LieuNaissance = "Rabat",
                    Nationnalite = "Marocaine",
                    NumCin = "F580877",
                    SituationFamiliale = "Célibataire",
                    Note = "ceci est une note et remarque concernant le collaborateur."
                };

                collaborateurs.Add(collaborateur);
                await DiplomesTraitement(collaborateur, collaborateurJson["Diplômes"].ToString());
                await ContratsTraitement(collaborateur, collaborateurJson["Type de Contrat"].ToString());
                DemissionTraitement(collaborateur, collaborateurJson["Date de sortie"].ToString());
            }
            return collaborateurs;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public List<Certification> SeedCertifications()
        {
            return new List<Certification>
            {
                new Certification{ Libelle="AZ-104"},
                new Certification{ Libelle="AZ-900"},
                new Certification{ Libelle="AZ-204"},
                new Certification{ Libelle="AZ-400"},
                new Certification{ Libelle="AZ-300"},
                new Certification{ Libelle="AZ-301"},
                new Certification{ Libelle="DA-100"},
                new Certification{ Libelle="DP-900"},
                new Certification{ Libelle="DP-100"},
                new Certification{ Libelle="DP-200"},
                new Certification{ Libelle="DP-201"},
                new Certification{ Libelle="AI-900"},
                new Certification{ Libelle="AI-900"},
                new Certification{ Libelle="MS-900"},
                new Certification{ Libelle="MS100"},
                new Certification{ Libelle="MS101"},
                new Certification{ Libelle="MS300"},
                new Certification{ Libelle="MS301"},
                new Certification{ Libelle="MS600"},
            };
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public List<Formation> SeedFormations()
        {
            return new List<Formation>
            {
                new Formation{ Libelle="Skills"},
                new Formation{ Libelle="Gestion Projet"},
                new Formation{ Libelle=".NetCore"},
                new Formation{ Libelle="Angular 8+"},
                new Formation{ Libelle="Test Auto "},
                new Formation{ Libelle="ReactJS"},
                new Formation{ Libelle="PowerApps"},
                new Formation{ Libelle="PowerBI"},
                new Formation{ Libelle="Power Automate"},
                new Formation{ Libelle="Blazor"},
                new Formation{ Libelle="ASP MVC"},
                new Formation{ Libelle="OutSystems"},
                new Formation{ Libelle="Micro Servicesa"},
                new Formation{ Libelle="Azure"},
                new Formation{ Libelle="Epi"},
                new Formation{ Libelle="InRiver"},
                new Formation{ Libelle="CRM generalités"},
                new Formation{ Libelle="Dynamics Cloud"},
                new Formation{ Libelle="Dynamics 365 Avancé"},
                new Formation{ Libelle="DevOPS"},
                new Formation{ Libelle="Front (html, css & JS)"},
                new Formation{ Libelle="PWA"},
                new Formation{ Libelle="Graph QL"},
            };
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public List<CollaborateurFormation> SeedCollabFormation()
        {
            return new List<CollaborateurFormation>
            {
                new CollaborateurFormation{ CollaborateurId=1, FormationId=1, Status = Status.AFAIRE, DateDebut = DateTime.Now, DateFin = DateTime.Now.AddDays(7)},
                new CollaborateurFormation{ CollaborateurId=1, FormationId=2, Status= Status.AFAIRE, DateDebut = DateTime.Now, DateFin = DateTime.Now.AddDays(7)},
                new CollaborateurFormation{ CollaborateurId=1, FormationId=3, Status= Status.AFAIRE, DateDebut = DateTime.Now, DateFin = DateTime.Now.AddDays(7)},
                new CollaborateurFormation{ CollaborateurId=24, FormationId=2, Status= Status.AFAIRE, DateDebut = DateTime.Now, DateFin = DateTime.Now.AddDays(7)},
                new CollaborateurFormation{ CollaborateurId=24, FormationId=5, Status= Status.AFAIRE, DateDebut = DateTime.Now, DateFin = DateTime.Now.AddDays(7)},
                new CollaborateurFormation{ CollaborateurId=60, FormationId=1, Status= Status.AFAIRE, DateDebut = DateTime.Now, DateFin = DateTime.Now.AddDays(7)},
            };
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public List<CollaborateurCertification> SeedCollabCertification()
        {
            return new List<CollaborateurCertification>
            {
                new CollaborateurCertification{ CollaborateurId=1, CertificationId=1, Status = Status.AFAIRE, DateDebut = DateTime.Now, DateFin = DateTime.Now.AddDays(7)},
                new CollaborateurCertification{ CollaborateurId=1, CertificationId=2, Status= Status.AFAIRE, DateDebut = DateTime.Now, DateFin = DateTime.Now.AddDays(7)},
                new CollaborateurCertification{ CollaborateurId=1, CertificationId=3, Status= Status.AFAIRE, DateDebut = DateTime.Now, DateFin = DateTime.Now.AddDays(7)},
                new CollaborateurCertification{ CollaborateurId=24, CertificationId=2, Status= Status.AFAIRE, DateDebut = DateTime.Now, DateFin = DateTime.Now.AddDays(7)},
                new CollaborateurCertification{ CollaborateurId=24, CertificationId=5, Status= Status.AFAIRE, DateDebut = DateTime.Now, DateFin = DateTime.Now.AddDays(7)},
                new CollaborateurCertification{ CollaborateurId=60, CertificationId=1, Status= Status.AFAIRE, DateDebut = DateTime.Now, DateFin = DateTime.Now.AddDays(7)}
            };
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
                new ModeRecrutement{ Name="E-Chalenge"},
                new ModeRecrutement{ Name="Recommandation"},
                new ModeRecrutement{ Name="Stage PFE"},
                new ModeRecrutement{ Name="Cooptation"},
                new ModeRecrutement{ Name="Autre"},
            };
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public List<ReasonDemission> SeedReasonsDemission()
        {
            return new List<ReasonDemission>
            {
                new ReasonDemission { Name = "Opportunité etranger" },
                new ReasonDemission { Name = "Salaire et avantages" },
                new ReasonDemission { Name = "Insatisfait des projets" },
                new ReasonDemission { Name = "carrière" },
                new ReasonDemission { Name = "conflit" }
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
                        collaborateur.Diplomes.Add(diplomeObj);
                        this._dataContext.Diplomes.Add(diplomeObj);
                    }
            }
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task ContratsTraitement(Collaborateur collaborateur, string typeContrat)
        {
            if (typeContrat != String.Empty)
            {
                this._dataContext.CollaborateurTypeContrats.Add(new CollaborateurTypeContrat
                {
                    Collaborateur = collaborateur,
                    TypeContrat = this._dataContext.TypeContrats.Where(tc => tc.Name == typeContrat).FirstOrDefault(),
                    IsInSQLI = true
                });
            }
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public void DemissionTraitement(Collaborateur collaborateur, string dateSortieSqli)
        {
            if (!string.IsNullOrEmpty(dateSortieSqli))
            {
                this._dataContext.Add(new Demission
                {
                    Collaborateur = collaborateur,
                    DateSortieSqli = DateTime.Parse(dateSortieSqli),
                    DateDemission = DateTime.Parse(dateSortieSqli),
                    IsCanceled = false
                }) ;
            }
        }
    }
}