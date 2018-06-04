using KhaiJobs.DataAccess;
using KhaiJobs.Entities;
using KhaiJobs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhaiJobs.Services
{
    public class StudentService
    {
        MainContext _context = new MainContext();


        public void AddProfessionalCompetence(AddProfessionalCompetenceViewModel model)
        {
            var profile = _context.student_profiles.FirstOrDefault(x => x.id == model.ProfileId);
            var professionalCompetence = new proffessional_competences
            {
                name = model.Name
            };
            professionalCompetence.abilities = new List<ability>();
            foreach (var ability in model.Abilities)
            {
                professionalCompetence.abilities.Add(new Entities.ability
                {
                    name = ability
                });
            }
            professionalCompetence.skills = new List<skill>();
            foreach (var skill in model.Skills)
            {
                professionalCompetence.skills.Add(new Entities.skill
                {
                    name = skill
                });
            }
            professionalCompetence.knowlege = new List<knowlege>();
            foreach (var knowlege in model.Knowlege)
            {
                professionalCompetence.knowlege.Add(new Entities.knowlege
                {
                    name = knowlege
                });
            }

            profile.students_proffessional_competences.Add(new students_proffessional_competences
            {
                id_student_profiles = model.ProfileId,
                proffessional_competence = professionalCompetence
            });
            _context.SaveChanges();
        }

        public void AddPersonalCompetence(AddPersonalCompetenceViewModel model)
        {
            var profile = _context.student_profiles.FirstOrDefault(x => x.id == model.ProfileId);
            var personalCompetence = new personal_competences
            {
                name = model.Name
            };
            profile.students_personal_competences.Add(new students_personal_competences
            {
                id_student_profiles = model.ProfileId,
                personal_competence = personalCompetence
            });
            _context.SaveChanges();
        }
    }
}