namespace DesignPatternsGofDotnet.Factory
{
    /// <summary>
    /// Resume: classe construtora/criadora 'ConcreteCreator' 
    /// </summary>
    class Resume : Document
    {
        // Implementação método Factory
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}