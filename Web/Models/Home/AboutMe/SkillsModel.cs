using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models.Home.AboutMe
{
    public class SkillsModel
    {
        public List<Skill> FluentLanguages { get; set; }
        public List<Skill> MinorLanguages { get; set; }
        public List<Skill> Practices { get; set; }
        public List<Skill> Tools { get; set; }
        public List<Skill> Others { get; set; }
    }
}